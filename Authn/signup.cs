
using Green_house_chikale.Authn;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Green_house_chikale
{
    public partial class Signup : UserControl
    {
        public Signup()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void BackToLogin_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signin sgnin = new Signin();
            sgnin.BringToFront();
            sgnin.Visible = true;

        }
      
        private void Signup_btn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select username from Users where username='" + Email.Text + "'", db.GetConnection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("User already exists in the server.\nPlease add a different username");
                }
                else
                {
                    db.OpenConnection();
                    command.Connection = db.GetConnection;
                    command.CommandText = "INSERT INTO users VALUES ('" + "" + "', '" + Firstname.Text + "','" + Surname.Text + "','" + Email.Text + "','" + Password.Text + "')";
                    command.ExecuteNonQuery();

                    MessageBox.Show("The account has been created successfully.\nThe user can now log in to the account.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Firstname.Clear();
                    Surname.Clear();
                    Email.Clear();
                    Password.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


    }
}
