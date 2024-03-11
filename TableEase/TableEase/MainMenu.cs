using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;

namespace TableEase
{
    public partial class MainMenu : Form
    {
        private String clockFormat = "HH:mm:ss";
        public MainMenu()
        {
            InitializeComponent();
        }

        private void RefreshGrid()
        {
            String date = dateTimePicker1.Value.ToShortDateString();
            using (SqlConnection conn = Connector.GetConnection())
            {
                //Create query
                string query = "SELECT tId AS [Table], cName AS Name, noOfPeople AS People, rDate AS Date, rTime AS Time, cPhone AS Phone, comments AS Comments, rId AS RID FROM Reservation WHERE rDate = @Date";


                //Run query
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Date", date);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                dataGridView1.DataSource = dataTable;
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString(clockFormat);
        }

        public void SetBackgroundColor(Color color)
        {
            this.BackColor = color; 
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            switch (languageComboBox.SelectedIndex)
            {
                case 0:
                    changeLanguage.UpdateConfig("language", "en");
                    System.Windows.Forms.Application.Restart();
                    break;

                case 1:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    System.Windows.Forms.Application.Restart();
                    break;

                case 2:
                    changeLanguage.UpdateConfig("language", "es");
                    System.Windows.Forms.Application.Restart();
                    break;

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.ShowDialog();
            this.Hide();
        }

        private void billingButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the value in the first column
                int rId = int.Parse(selectedRow.Cells[7].Value.ToString());
                Bill billForm = new Bill(rId);
                billForm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a row to bill.");
            }
        }

        private void lightModeRaidoButton_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SelectedColor = Color.White;
            Properties.Settings.Default.Save();
            this.BackColor = Properties.Settings.Default.SelectedColor;
        }

        private void darkModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SelectedColor = Color.DarkGray;
            Properties.Settings.Default.Save();
            this.BackColor = Properties.Settings.Default.SelectedColor;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void clockLabel_Click(object sender, EventArgs e)
        {
            if (clockFormat == "HH:mm:ss")
            {
                clockFormat = "hh:mm:ss tt";
            }
            else if (clockFormat == "hh:mm:ss tt")
            {
                clockFormat = "HH:mm:ss";
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the value in the first column
                int rId = int.Parse(selectedRow.Cells[7].Value.ToString());
                Reservation reservation = new Reservation(rId);
                reservation.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a row to modify.");
            }
        }

        private void viewCommentButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the value in the first column
                int rId = int.Parse(selectedRow.Cells[7].Value.ToString());
                try
                {
                    using (SqlConnection connection = Connector.GetConnection())
                    {
                        SqlCommand command = new SqlCommand("SELECT comments FROM Reservation WHERE rid = @rid", connection);
                        command.Parameters.AddWithValue("@rid", rId);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            string comment = result.ToString();
                            MessageBox.Show(comment, "Comment for Reservation #" + rId);
                        }
                        else
                        {
                            MessageBox.Show("No comment found for Reservation #" + rId);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to view comment.");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
