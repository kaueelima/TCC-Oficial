using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiveFaceDetection
{
    public partial class Facebook : Form
    {
        public Facebook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(ComputerBeacon.Facebook.Models.Event.GetFeed("me", "CAACEdEose0cBANats19MiRG0IELIcLHWoxwUfgllpkZB0oEOmMhPudueKi98SDQAZB2ZC2LpBDhCoZCCie11ffAfZBC8gUt4d1sv0cA0s628Lo5EmnOtxPrDYdUnkwgBlgMg8l4xZBUdlynv0QjYZBXrWEJZBUBZCvrQkUVyExtN1GK8a3HQPZCgXzsaLnV0OENbJ9mWLIH8as3bZAnzvVyJRAf").First());
            //textBox3.Text = ComputerBeacon.Facebook.Authentication.AccessTokenManager.GetAppAccessToken("100000858786622", "Kaue$123456");
            //new ComputerBeacon.Facebook.Publish.CreatePostRequest("me", "Olá", "CAACEdEose0cBANats19MiRG0IELIcLHWoxwUfgllpkZB0oEOmMhPudueKi98SDQAZB2ZC2LpBDhCoZCCie11ffAfZBC8gUt4d1sv0cA0s628Lo5EmnOtxPrDYdUnkwgBlgMg8l4xZBUdlynv0QjYZBXrWEJZBUBZCvrQkUVyExtN1GK8a3HQPZCgXzsaLnV0OENbJ9mWLIH8as3bZAnzvVyJRAf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
        }
    }
}
