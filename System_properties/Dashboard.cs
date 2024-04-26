using Green_house_chikale.System_properties;
using System;
using System.Windows.Forms;

namespace Green_house_chikale.Authn
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Overview ovw = new Overview();
            UserControl(ovw);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }
        private void UserControl(UserControl usercontrol)
        {
          panel4.Controls.Clear();
          panel4.Controls.Add(usercontrol);
          usercontrol.BringToFront();
        }
        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Overview ovw = new Overview();
            UserControl(ovw);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task tsk = new Task();
            UserControl(tsk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Soil soils = new Soil();
            UserControl(soils);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                AuthnFrom logout = new AuthnFrom();
                logout.Show();
            }
            else
            {
                return;
            }
        }

    }
}
