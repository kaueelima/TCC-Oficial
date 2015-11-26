/*=================================================
 * This code is brought to you by Mahvish
 * visit http://fewtutorials.bravesites.com/ for more
 * tutorials on EmguCV and C#
 * **************************************************
 *        PLEASE DO NOT REMOVE THIS NOTE!
 * **************************************************
 * ================================================== */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.AudioFormat;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;
using System.Data.SqlClient;
using Microsoft.VisualBasic;


namespace LiveFaceDetection
{


    public partial class TrainingSetEditor : Form
    {
        //declaring global variables

        //.............FOR LIVE CAMERA CAPTURE.............
        //-----------------------------------------------------------------------------------
        private Capture capture;        //takes images from camera as image frames
        Image<Bgr, Byte> TestImage;    //EmguCV type color image
        public static Image FotoC;


        //.............FOR FACE DETECTION.............
        //-----------------------------------------------------------------------------------
        private HaarCascade haar;            //the viola-jones classifier (detector)       
        //Lets set the Default values of the parameters, to be used as a variable in call to DetectHaarCascase()
        private int WindowsSize = 25;
        private Double ScaleIncreaseRate = 1.1;
        private int MinNeighbors = 3;
        public String URL;

        //.............For Face "EXTRACTION".............
        //-----------------------------------------------------------------------------------
        //string[] FaceCollection = Directory.GetFiles(@"Face Collection\", "*.bmp");  // the folder where we want to save extracted faces
        int faceNo = 0;             //Total no. of faces detected in an image
        Bitmap[] EXfaces;           //an array to hold the extracted faces


        public TrainingSetEditor()
        {
            //esse Funciona! MessageBox.Show("Olá");
            InitializeComponent();
        }

        private void TrainingSetEditor_Load(object sender, EventArgs e)
        {
            // adjust path to find your xml at loading
            haar = new HaarCascade("haarcascade_frontalface_alt_tree.xml");
        }

        //----------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTIONS USED TO GET INPUT IMAGE----------------------->>>>>>>>
        //----------------------------------------------------------------------------//
        /// <summary>
        /// Loads an image from Hard disk and detects faces from it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image InputImg = Image.FromFile(openFileDialog.FileName);
                TestImage = new Image<Bgr, byte>(new Bitmap(InputImg));
         
                DetectFaces();
            }
        }     
        
        /// <summary>
        /// Starts live video streaming, Pauses it to detect faces, Resumes it 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Welcome to the magic mirror");
            synth.Dispose();

            //MessageBox.Show("Câmera selecionada");
            if (capture != null)
            {
                if (btnStart.Text == "Extrair Rosto")
                {  //if camera is getting frames then pause the capture and set button Text to
                    // "Resume" for resuming capture
                    btnStart.Text = "Resumir Imagem"; //
              
                    //Pause the live streaming video
                    Application.Idle -= ProcessFrame;

                    //Call face detection 
                    DetectFaces(); 
                }
                else
                {
                    //if camera is NOT getting frames then start the capture and set button
                    // Text to "Pause" for pausing capture
                    btnStart.Text = "Extrair Rosto";
                    Application.Idle += ProcessFrame;
                }
            }
        }
      
        /// <summary>
        /// Captures a picture from the connected camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void ProcessFrame(object sender, EventArgs arg)
        {
            //------------------------------------------------------------------------------//
            //Process Frame() below is our user defined function in which we will create an EmguCv 
            //type image called TestImage. capture a frame from camera and allocate it to our 
            //TestImage. then show this image in ourEmguCV imageBox
            //------------------------------------------------------------------------------//
            //fetch the frame captured by web camera
            TestImage = capture.QueryFrame();

            //show the image in the EmguCV ImageBox
            CamImageBox.Image = TestImage;
            
        }

        /// <summary>
        /// Connects to the selected camera attached to the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCamIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set the camera number to the one selected via combo box
            int CamNumber = -1;
            CamNumber = int.Parse(cbCamIndex.Text);

            //Start the selected camera
            #region if capture is not created, create it now
            if (capture == null)
            {
                try
                {
                    capture = new Capture(CamNumber);
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            #endregion

            //Start showing the stream from camera
            btnStart_Click(sender, e);
            btnStart.Enabled = true;
        }
        
        /// <summary>
        /// Disconnects from the camera
        /// </summary>
        private void ReleaseCamera()
        {
            if (capture != null)
            {
                //Pause the live streaming video
                Application.Idle -= ProcessFrame;
                capture.Dispose();
                
            }
        }


        
        //----------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTION USED TO DETECT AND EXTRACT FACES--------------->>>>>>>>
        //----------------------------------------------------------------------------//
        private void DetectFaces()
        {
            Image<Gray, byte> grayframe = TestImage.Convert<Gray, byte>();
            
            //Assign user-defined Values to parameter variables:
            MinNeighbors = int.Parse(comboBoxMinNeigh.Text);  // the 3rd parameter
            WindowsSize = int.Parse(textBoxWinSiz.Text);   // the 5th parameter
            ScaleIncreaseRate = Double.Parse(comboBoxScIncRte.Text); //the 2nd parameter

           
            //detect faces from the gray-scale image and store into an array of type 'var',i.e 'MCvAvgComp[]'
            var faces = grayframe.DetectHaarCascade(haar, ScaleIncreaseRate, MinNeighbors,
                                    HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                    new Size(WindowsSize, WindowsSize))[0];
            if (faces.Length > 0)
            {
                //MessageBox.Show("Total Faces Detected: " + faces.Length.ToString());

                Bitmap BmpInput = grayframe.ToBitmap();
                Bitmap ExtractedFace;  // an empty "box"/"image" to hold the extracted face.

                Graphics FaceCanvas;

                //Set The Face Number
                //FaceCollection = Directory.GetFiles(@"Face Collection\", "*.bmp");
                //int FaceNo = FaceCollection.Length;

                //A Bitmap Array to hold the extracted faces
                EXfaces = new Bitmap[faces.Length];
                int i = 0;
                
                //draw a green rectangle on each detected face in image
                foreach (var face in faces)
                {
                    //locate the detected face & mark with a rectangle
                    TestImage.Draw(face.rect, new Bgr(Color.Green), 3);

                    //set the size of the empty box(ExtractedFace) which will later contain the detected face
                    ExtractedFace = new Bitmap(face.rect.Width, face.rect.Height);
                    


                    //ExtractedFace = new Bitmap(300, 300);

                    //set empty image as FaceCanvas, for painting
                    FaceCanvas = Graphics.FromImage(ExtractedFace);
                    
                    //graphics draws the located face on the faceCancas, thus filling the empty ExtractedFace 
                    //image with exact pixels of the face to be extracted from input image
                    FaceCanvas.DrawImage(BmpInput, 0, 0, face.rect, GraphicsUnit.Pixel);
                    
                    //save this extracted face to hard disk
                    //Modificar para salvar essa imagem na PASTA!!! <<<<<<<<<<<<

                    //FaceCollection = Directory.GetFiles(@"C:/Users/KaueexD/Desktop/Level 4d Face Recognition System - half UNCODED/CameraCapture/bin/Debug/Face", "*.bmp");
                    //int FaceNo = FaceCollection.Length;

                    //ExtractedFace.SetResolution(300, 300);

                    Bitmap ExtractedFace2 = new Bitmap(ExtractedFace, 300, 300);
                    
                    ExtractedFace2.Save(@nometxt.Text + ".bmp");//save images in folder
                    URL = "C:\\Users\\KaueexD\\Desktop\\TccAtual\\Level 4d Face Recognition System - half UNCODED\\CameraCapture\\bin\\Debug\\" + nometxt.Text + ".bmp";

                    Conexao minhaConexao = new Conexao(); //criando comando de conexao
                    minhaConexao.Open();  //abrir conexao

                    string comando;  //variavel para colocar o codigo em slq
                    comando = "select * from UsuarioTCC";

                    SqlCommand comSQLSelect = new SqlCommand(comando, minhaConexao.CONEXAO);  //cria comando sql
                    minhaConexao.DR = comSQLSelect.ExecuteReader();  //pega o resultado

                    if (minhaConexao.DR.HasRows)
                    {
                        float menorDif = 20;
                        float aux = 0;
                        String nomeDif = "";

                        while (minhaConexao.DR.Read())
                        {
                            aux = Diferenca(URL, minhaConexao.DR.GetString(2));
                            //MessageBox.Show("Comparando com o do banco");

                            if (aux < menorDif) 
                            {
                                menorDif = aux;
                                nomeDif = minhaConexao.DR.GetString(1);
                                //MessageBox.Show("Comparado com alguem, sendo a diferença de " + menorDif + "com o " + nomeDif);
                            }
                        }

                        if (menorDif > 7)
                        {
                            if (MessageBox.Show("Você quer se cadastrar no banco?", "Diferença muito alta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Conexao minhaConexao2 = new Conexao(); //criando comando de conexao
                                minhaConexao2.Open();  //abrir conexao

                                string comando2;  //variavel para colocar o codigo em slq
                                comando2 = "insert into UsuarioTCC values('" + nometxt.Text + "', '" + URL + "')";

                                SqlCommand comSQLSelect2 = new SqlCommand(comando2, minhaConexao2.CONEXAO);  //cria comando sql
                                minhaConexao2.DR = comSQLSelect2.ExecuteReader();
                            }
                        }
                        else
                        {

                            //MessageBox.Show("Você tem mais semelhança com o " + nomeDif + ". Com a diferença de " + menorDif + "%");
                            MessageBox.Show("Logou com sucesso como " + nomeDif);
                            nometxt.Text = nomeDif;
                        }
                    }

                    //MessageBox.Show("Acabou de salvar");
                    //Modificar para salvar essa imagem na PASTA!!! <<<<<<<<<<<<

                    //Save this extracted face to array
                    EXfaces[i] = ExtractedFace;
                    i++;

                }
                //Display the detected faces in imagebox
                CamImageBox.Image = TestImage;

                //MessageBox.Show(faces.Length.ToString() + " Face(s) Extraída com sucesso!");
              
                pbCollectedFaces.Image = EXfaces[0];
                //Passa a imagem para a variavel
                //FotoC = EXfaces[0];

                FotoC = pbCollectedFaces.Image;

                if (faces.Length > 1)
                {
                    btnNext.Enabled = true;
                    btnPrev.Enabled = true;
                }
                else
                {
                    btnNext.Enabled = false;
                    btnPrev.Enabled = false;
                }

                //CamImageBox.Image = TestImage;
                Inicio formDestino = new Inicio(nometxt.Text);
                formDestino.Show();
                this.Visible = false;
            }
            else
                MessageBox.Show("NO faces Detected!");
        }
        //----------------------------------------------------------------------------//
        //<<<<<<<<------BUTTONS USED TO NAVIGATE THROUGH EXTRACTED FACES----------->>>>>
        //----------------------------------------------------------------------------//
        /// <summary>
        /// Navigates to the NEXT image in the Extracted Faces 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (faceNo < EXfaces.Length - 1)
            {

                faceNo++;
                //pbCollectedFaces.Image = Image.FromFile(FaceCollection[faceNo]);
                pbCollectedFaces.Image = EXfaces[faceNo];

            }
            else
                MessageBox.Show("this is the LAST image!");
        }

        /// <summary>
        /// Navigates to the Previous image in the Extracted Faces 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (faceNo > 0)
            {
                faceNo--;
                pbCollectedFaces.Image = EXfaces[faceNo];
                //pbCollectedFaces.Image = Image.FromFile(FaceCollection[faceNo]);
            }
            else
                MessageBox.Show("this is the 1st image!");
        }
        
        private float Diferenca(String URL1, String URL2)
        {
            Bitmap img1 = new Bitmap(URL1);
            Bitmap img2 = new Bitmap(URL2);

            if (img1.Size != img2.Size)
            {
                Console.Error.WriteLine("Images are of different sizes");
                return -1;
            }

            float diff = 0;

            //img1.Height
               //img1.Width

            for (int y = 0; y < 260; y++)
            {
                for (int x = 0; x < 270; x++)
                {
                    diff += (float)Math.Abs(img1.GetPixel(x, y).R - img2.GetPixel(x, y).R) / 255;
                    diff += (float)Math.Abs(img1.GetPixel(x, y).G - img2.GetPixel(x, y).G) / 255;
                    diff += (float)Math.Abs(img1.GetPixel(x, y).B - img2.GetPixel(x, y).B) / 255;
                }
            }

            //MessageBox.Show("diff: {0} %"+  100 * diff / (img1.Width * img1.Height * 3));
            float dif = 100 * diff / (img1.Width * img1.Height * 3);

            return dif;
        }

        //----------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTIONS USED TO CONNECT TO DB---------------->>>>>>>>>>>>>>
        //----------------------------------------------------------------------------//
        /// <summary>
        /// Connects to an MS Access database using Oledb connection
        /// </summary>
        private void ConnectToDatabase()
        {
            
        }
        
        /// <summary>
        /// Refreshes connection to MS Access Database to load Latest data
        /// </summary>
        private void RefreshDBConnection()
        {
            
        }


        //---------------------------------------------------------------------------------------------//
        //<<<------BUTTONS & FUNCTIONS USED TO NAVIGATE & ADD FACE-LABEL PAIRS TO DATABASE--------->>>>>>
        //---------------------------------------------------------------------------------------------//

        /// <summary>
        /// Adds the extracted face and its label to the Training Set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        /// Converts an Image to a byte array format
        /// </summary>
        /// <param name="InputImage"></param> the image to be coverted is a Drawing.Image
        /// <returns></returns> byte array for input image
        private byte[] ConvertToDBFormat(Image InputImage)
        {
            return null;
        }
        /// <summary>
        /// Stores a Face image and its Name in the Training Set, in MS Access Database 
        /// </summary>
        /// <param name="ImageAsBytes"></param> Face image converted to bytes 
        /// <param name="FaceName"></param>the name of face set in the textbox
        private void AddFaceToDB(Image InputFace, string FaceName)
        {
         
        }
        
        
        //-------------------------------------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTIONS USED TO READ & NAVIGATE DATAFACE-LABEL PAIRS FROM DATABASE--------->>>>>>>>>>>>>>
        //-------------------------------------------------------------------------------------------------------//       
        /// <summary>
        /// Reads the Face stored in MS Access Database at the specified row & converts it to Image
        /// </summary>
        /// <returns></returns>
        private Image GetFaceFromDB()
        {
            
                return null;
           
        }

        /// <summary>
        /// Loads the stored 1ST face-label pair from Training Set to windows form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTSFirst_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Loads the Previous face label from Training Set to windows form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTSPrev_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Loads the Next face label from Training Set to windows form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTSNxt_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Loads the LAST face label from Training Set to windows form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadTSLast_Click(object sender, EventArgs e)
        {
            
        }


        //-----------------------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTIONS USED TO EDIT CURRENT FACE-LABEL PAIRS in DATABASE--------->>>>>>>>>>>>>>
        //------------------------------------------------------------------------------------------//
        /// <summary>
        /// Updates any change to a Face Name/Label in the Training Set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateFace_Click(object sender, EventArgs e)
        {
                               
        }
 
        /// <summary>
        /// Deletes a face from the Training Set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelFace_Click(object sender, EventArgs e)
        {
            
        }


        private void btnLoadRecog_Click(object sender, EventArgs e)
        {
            FaceRecognizer fcrec = new FaceRecognizer();
            fcrec.Show();
        }

        private void gBFaceAdder_Enter(object sender, EventArgs e)
        {

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine recognitionEngine = new SpeechRecognitionEngine(); 
            recognitionEngine.SetInputToDefaultAudioDevice(); 
            recognitionEngine.LoadGrammar(new DictationGrammar()); 
            RecognitionResult result = recognitionEngine.Recognize(new TimeSpan(0, 0, 20)); 
            foreach (RecognizedWordUnit word in result.Words) 
            { 
                 MessageBox.Show(word.Text); 
            }
        }



        
        
      }

}
