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
using System.Data.SqlClient;

namespace TableEase
{
    public partial class Reservation : Form
    {
        private int rId = 0;
        private int noOfPeople;
        private DateTime rDate;
        private TimeSpan rTime;
        private String cName;
        private string cPhone;
        private String comments;
        private int tId;

        public Reservation()
        {
            InitializeComponent();

        }

        public Reservation(int rId)
        {
            InitializeComponent();
            this.rId = rId;
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.SelectedColor;

            if (rId != 0)
            {
                reserveButton.Visible = false;
                saveButton.Visible = true;
                try
                {
                    using (SqlConnection connection = Connector.GetConnection())
                    {
                        SqlCommand command = new SqlCommand("SELECT * FROM Reservation WHERE rId = @rId", connection);
                        command.Parameters.AddWithValue("@rId", rId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                rId = (int)reader["rId"];
                                noOfPeople = (int)reader["noOfPeople"];
                                rDate = (DateTime)reader["rDate"];
                                rTime = (TimeSpan)reader["rTime"];
                                cName = reader["cName"].ToString();
                                cPhone = reader["cPhone"].ToString();
                                comments = reader["comments"].ToString();
                                tId = (int)reader["tId"];

                                peopleNumberNumericUpDown.Value = noOfPeople;
                                reservationDateTimePicker.Value = rDate;
                                //to populate currently selected time out of time options
                                string t = rTime.ToString().Substring(0, rTime.ToString().Length - 3);
                                for (int i = 0; i < timeComboBox.Items.Count; i++)
                                {
                                    if (timeComboBox.Items[i].ToString() == t)
                                    {
                                        timeComboBox.SelectedIndex = i;
                                        break;  // Exit the loop once the item is found
                                    }
                                }
                                nameTextBox.Text = cName;
                                phoneTextBox.Text = cPhone.ToString();
                                commentsRichTextBox.Text = comments;
                            }
                            reader.Close();
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
                reserveButton.Visible = true;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Color selectedColor = GetSelectedColor();
            var newForm = new MainMenu();
            newForm.SetBackgroundColor(selectedColor);
            newForm.Show();
            this.Hide();
        }

        private Color GetSelectedColor()
        {
            Color selectedColor = Color.LightGray;

            if (Properties.Settings.Default.SelectedColor != null)
            {
                try
                {
                    selectedColor = (Color)Properties.Settings.Default.SelectedColor;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e}");
                }
            }

            string colorName = ConfigurationManager.AppSettings["SelectedColor"];
            if (!string.IsNullOrEmpty(colorName))
            {
                try
                {
                    selectedColor = Color.FromName(colorName);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e}");
                }
            }

            return selectedColor;
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Connector.GetConnection())
                {
                    string query = "INSERT INTO Reservation (noOfPeople, rDate, rTime, cName, cPhone, comments, tId) VALUES ( @People, @Date, @Time, @Name, @Phone, @Comment, @tId)";

                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@People", peopleNumberNumericUpDown.Value);
                    command.Parameters.AddWithValue("@Date", reservationDateTimePicker.Value);
                    command.Parameters.AddWithValue("@Time", timeComboBox.Items[timeComboBox.SelectedIndex]);
                    command.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    command.Parameters.AddWithValue("@Phone", phoneTextBox.Text);
                    command.Parameters.AddWithValue("@Comment", commentsRichTextBox.Text);
                    command.Parameters.AddWithValue("@tId", tableNumberComboBox.SelectedItem.ToString());

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservation successful!");
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Reservation failed.");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Connector.GetConnection())
                {
                    string query = "UPDATE Reservation SET noOfPeople = @People, rDate = @Date, rTime = @Time, cName = @Name, cPhone = @Phone, comments = @Comment, tId = @tId WHERE rId = @Id";

                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("Id", rId);
                    command.Parameters.AddWithValue("@People", peopleNumberNumericUpDown.Value);
                    command.Parameters.AddWithValue("@Date", reservationDateTimePicker.Value);
                    command.Parameters.AddWithValue("@Time", timeComboBox.ValueMember.ToString());
                    command.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    command.Parameters.AddWithValue("@Phone", phoneTextBox.Text);
                    command.Parameters.AddWithValue("@Comment", commentsRichTextBox.Text);
                    command.Parameters.AddWithValue("@tId", tableNumberComboBox.SelectedIndex.ToString());

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservation modified successfully!");

                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Reservation modification failed.");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void reservationDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            tableNumberComboBox.Items.Clear();
            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand getTable = new SqlCommand("SELECT tId FROM [Table] WHERE tId NOT IN (SELECT tId FROM Reservation WHERE rDate = @Date AND rTime = @Time) AND capacity = @Capacity", connection);
                    getTable.Parameters.AddWithValue("@Date", reservationDateTimePicker.Value);
                    getTable.Parameters.AddWithValue("@Time", timeComboBox.ValueMember.ToString());
                    getTable.Parameters.AddWithValue("@Capacity", peopleNumberNumericUpDown.Value);

                    using (SqlDataReader reader = getTable.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int tableId = reader.GetInt32(0);
                            tableNumberComboBox.Items.Add(tableId);
                        }
                    }
                    for (int i = 0; i < timeComboBox.Items.Count; i++)
                    {
                        if (timeComboBox.Items[i].ToString() == tId.ToString())
                        {
                            tableNumberComboBox.SelectedIndex = i;
                            break;  // Exit the loop once the item is found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
