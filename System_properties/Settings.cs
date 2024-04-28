using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Green_house_chikale.Authn;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;

namespace Green_house_chikale.System_properties
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            // Create a MySqlDataAdapter to execute the query and fill the DataTable
           


        }
        Database db = new Database();
        private void Settings_Load(object sender, EventArgs e)
        {

            db.OpenConnection();
            // Create a MySqlCommand to execute the query
            string query = "SELECT location FROM settings";
            MySqlCommand command = new MySqlCommand(query, db.GetConnection);
            // Execute the query and get the result
            string location = command.ExecuteScalar()?.ToString();
            // Close the database connection
            db.CloseConnection();
            // Assign the retrieved location value to the text property of the label
            CurrentLocation.Text = location ?? "Location not found";

            try
            {
                MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM Plants", db.GetConnection);
                DataTable dTable = new DataTable();
                My.Fill(dTable);
                dataGridView1.DataSource = dTable;
                dataGridView1.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Location_btn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {
                db.OpenConnection();
                command.Connection = db.GetConnection;
                command.CommandText = "UPDATE settings SET Location='" +  Location_recom.Text + "';";
                command.ExecuteNonQuery();

                MessageBox.Show("Loction updated successfully!");

              
                // Create a MySqlCommand to execute the query
                string query = "SELECT location FROM settings";
                MySqlCommand command2 = new MySqlCommand(query, db.GetConnection);
                // Execute the query and get the result
                string location = command2.ExecuteScalar()?.ToString();
                // Close the database connection
                db.CloseConnection();
                // Assign the retrieved location value to the text property of the label
                CurrentLocation.Text = location ?? "Location not found";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Password_update_Click(object sender, EventArgs e)
        {
           
            if(password.Text == ConfirmPassword.Text)
            {
                MySqlCommand command = new MySqlCommand();
                try
                {
                    db.OpenConnection();
                    command.Connection = db.GetConnection;
                    command.CommandText = "UPDATE Users SET password='" + password.Text + "' WHERE Username='" + Signin.Sessions + "';";
                    command.ExecuteNonQuery();

                    MessageBox.Show("Password updated successfully! your new password is:", password.Text);
                    password.Clear();
                    ConfirmPassword.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Password does not much check and try again");
            }
           
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {
                if (PlantsGrown.Text == "" )
                {
                    MessageBox.Show("Unable to Submit.. Text fields cannot be left empty", "Error on Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    db.OpenConnection();
                    command.Connection = db.GetConnection;
                    command.CommandText = "INSERT INTO Plants VALUES ('" + "" + "','" + PlantsGrown.Text + "', '" + DateGrown.Text + "')";
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data added successfully");
                        PlantsGrown.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Data not added");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM Plants", db.GetConnection);
                DataTable dTable = new DataTable();
                My.Fill(dTable);
                dataGridView1.DataSource = dTable;
                dataGridView1.Columns["ID"].Visible = false;
            }

        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                label10.Text = row.Cells["id"].Value.ToString();
            }
        } 
        private void Plants_btn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {
                db.OpenConnection();
                command.Connection = db.GetConnection;
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                command.CommandText = "DELETE FROM Plants WHERE id= '" + label10.Text + "'";
                command.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully!");
                //Re-loading gridview

                MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM Plants", db.GetConnection);
                DataTable dTable = new DataTable();
                My.Fill(dTable);
                dataGridView1.DataSource = dTable;
                dataGridView1.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting the record: " + ex.Message);
            }
        }
    }
}
