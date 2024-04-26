 
using System;
using System.Windows.Forms;

namespace Green_house_chikale
{
    public partial class AuthnFrom : Form
    {
        public AuthnFrom()
        {
            InitializeComponent();
            Signin sgn = new Signin();
            UserControl(sgn);

        }
       
        private void UserControl(UserControl usercontrol)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Min_btn_Click(object sender, EventArgs e)
        {
            // Assuming this is the form you want to minimize
            this.WindowState = FormWindowState.Minimized;
        }

        private void Authn_Load(object sender, EventArgs e)
        {

        }

        private void ReadyAcc_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            Signup sgnup = new Signup();
            sgnup.Hide();

            Signin sgnn = new Signin();
            sgnn.Show();
            UserControl(sgnn);


        }

        private void NoAcc_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Signin signin = new Signin();
            signin.Hide();

            Signup sgnup = new Signup();
            UserControl(sgnup);

        }

       

        private void Authn_Load_1(object sender, EventArgs e)
        {

        }
    }
}
