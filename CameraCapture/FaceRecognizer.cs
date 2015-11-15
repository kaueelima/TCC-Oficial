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
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;


namespace LiveFaceDetection
{
    public partial class FaceRecognizer : Form
    {
        //declaring global variables

        //.............FOR LIVE CAMERA CAPTURE.............
        //-----------------------------------------------------------------------------------
        private Capture capture;        //takes images from camera as image frames
        Image<Bgr, Byte> TestImage;    //EmguCV type color image

        //.............FOR FACE DETECTION.............
        //-----------------------------------------------------------------------------------
        private HaarCascade haar;            //the viola-jones classifier (detector)       
        //Lets set the Default values of the parameters, to be used as a variable in call to DetectHaarCascase()
        private int WindowsSize = 25;
        private Double ScaleIncreaseRate = 1.1;
        private int MinNeighbors = 3;

        public FaceRecognizer()
        {
            InitializeComponent();
        }

        private void FaceRecognizer_Load(object sender, EventArgs e)
        {
            // adjust path to find your xml at loading
            haar = new HaarCascade("haarcascade_frontalface_alt_tree.xml");
          
        }

        //----------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTIONS USED TO GET INPUT IMAGE----------------------->>>>>>>>
        //----------------------------------------------------------------------------//
        /// <summary>
        /// Loads an input image from Hard disk and detects faces from it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image InputImg = Image.FromFile(openFileDialog.FileName);
                TestImage = new Image<Bgr, byte>(new Bitmap(InputImg));
                CamImageBox.Image = TestImage;
                DetectAndRecognizeFaces();
            }
        }

        //------------------------------------------------------------------------------//
        //Process Frame() below is our user defined function in which we will create an EmguCv 
        //type image called ImageFrame. capture a frame from camera and allocate it to our 
        //ImageFrame. then show this image in ourEmguCV imageBox
        //------------------------------------------------------------------------------//
        private void ProcessFrame(object sender, EventArgs arg)
        {
            //fetch the frame captured by web camera
            TestImage = capture.QueryFrame();

            //show the image in the EmguCV ImageBox
            CamImageBox.Image = TestImage;
        }

        /// <summary>
        /// Starts live video streaming, Pauses it to detect faces, Resumes it 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Kauê");

            if (capture != null)
            {
                if (btnStart.Text == "Detect Face")
                {  //if camera is getting frames then pause the capture and set button Text to
                    // "Resume" for resuming capture
                    MessageBox.Show("Oi kaue");
                    btnStart.Text = "Resume Live Video"; //

                    //Pause the live streaming video
                    Application.Idle -= ProcessFrame;

                    //Call face detection & recognition
                    DetectAndRecognizeFaces();
                }
                else
                {
                    //if camera is NOT getting frames then start the capture and set button
                    // Text to "Pause" for pausing capture
                    MessageBox.Show("Oi kaue");
                    btnStart.Text = "Detect Face";
                    Application.Idle += ProcessFrame;
                }
            }
        }

        /// <summary>
        /// This function is the Selected Index changed event of the comboBox
        /// It allows the user to select a desired camera and starts it for him/her
        /// </summary>
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
        /// stops and terminates the camera capture
        /// </summary>
        private void ReleaseCamera()
        {
            if (capture != null)
                capture.Dispose();
        }

        //----------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTION USED TO CONNECT TO DB---------------->>>>>>>>>>>>>>
        //----------------------------------------------------------------------------//
        private void ConnectToDatabase()
        {

        }

        private void RefreshDBConnection()
        {

        }
        private Image ReadImageFromDB(int index)
        {
            return null;

        }

        //----------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTION USED TO DETECT AND RECOGNIZE FACES---------->>>>>>>>
        //----------------------------------------------------------------------------//
        private void DetectAndRecognizeFaces()
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
            MessageBox.Show("Total Faces Detected: " + faces.Length.ToString());

            Bitmap BmpInput = grayframe.ToBitmap();
            Bitmap ExtractedFace;  // an empty "box"/"image" to hold the extracted face.
            Graphics g;
            MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);

            //draw a green rectangle on each detected face in image
            foreach (var face in faces)
            {
                //locate the detected face & mark with a rectangle
                TestImage.Draw(face.rect, new Bgr(Color.Green), 3);
                CamImageBox.Image = TestImage;
                //set the size of the empty box(ExtractedFace) which will later contain the detected face
                ExtractedFace = new Bitmap(face.rect.Width, face.rect.Height);

                //assign the empty box to graphics for painting
                g = Graphics.FromImage(ExtractedFace);
                //graphics fills the empty box with exact pixels of the face to be extracted from input image
                g.DrawImage(BmpInput, 0, 0, face.rect, GraphicsUnit.Pixel);


            }

            //Display the detected faces in imagebox
            CamImageBox.Image = TestImage;

            //MessageBox.Show(faces.Length.ToString()+ " Face(s) Extracted sucessfully!");
        }

        //-------------------------------------------------------------------------------------//
        //<<<<<----------------FUNCTIONS USED TO TRAIN RECOGNIZER ON TRAINING SET----------->>>>
        //-------------------------------------------------------------------------------------//
        /// <summary>
        /// Fetches (Reads) Face-Label pairs from MS Access Database for recognizer
        /// </summary>
        private void LoadTrainingSet()
        {

        }

        /// <summary>
        /// Trains recognizer on fetched face-label pairs and saves the trained data to recognition variables
        /// </summary>
        public void TrainRecognizer()
        {

        }

        /// <summary>
        /// button used call TrainRecognizer()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrainRecog_Click(object sender, EventArgs e)
        {


        }

        //-------------------------------------------------------------------------------------//
        //<<<<<-----FUNCTIONS USED TO LOAD & DISPLAY TRAINED DATA (eigen faces + Avg Face)--->>>>
        //---------------------------------------------------------------------------------------//
        /// <summary>
        /// Reads the trained data from recognition variables
        /// </summary>
        public void LoadTrainedData()
        {

        }
        /// <summary>
        /// Shows the calculated eigenfaces(i.e trained data)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewEigen_Click(object sender, EventArgs e)
        {


        }
        /// <summary>
        /// displays the average image of the eigenfaces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAvgFace_Click(object sender, EventArgs e)
        {

        }
                  
        //===================================================================================
        /// <summary>
        /// Loads the Training Set Editor Winform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpnTSeditor_Click(object sender, EventArgs e)
        {
           
        }
      }
}
