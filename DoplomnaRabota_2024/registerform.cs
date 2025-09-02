using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoplomnaRabota_2024
{
    public partial class registerform : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=|DataDirectory|\LoginData.mdf;
Integrated Security=True;Connect Timeout=30;");
        
        public registerform()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loginform f1 = new loginform();
            f1.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '*')
            {
                textBox3.PasswordChar = '\0';
            }
            else if (textBox3.PasswordChar == '\0')
            {
                textBox3.PasswordChar = '*';
            }


            if (textBox4.PasswordChar == '*')
            {
                textBox4.PasswordChar = '\0';
            }
            else if (textBox4.PasswordChar == '\0')
            {
                textBox4.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == ""
                 || textBox3.Text == "")
            {
                MessageBox.Show("Моля попълнете празните полета!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Моля повторете паролата!");
            }
            else if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Паролите не съвпадат!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!textBox1.Text.Contains("@"))
            {
                MessageBox.Show("Невалиден имейл адрес!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!textBox1.Text.EndsWith(".bg") && !textBox1.Text.EndsWith(".com"))
            {
                MessageBox.Show("Невалиден имейл адрес!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string checkusername = "SELECT * FROM admin WHERE username = '" + textBox2.Text.Trim() + "'";

                        using (SqlCommand checkuser = new SqlCommand(checkusername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkuser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Акаунт с това име вече съществува!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertdata = "INSERT INTO admin (email, username, pssword, date, role)VALUES(@email, @username, @pass, @date, @role)";
                                DateTime date = DateTime.Today;
                                string role = "user"; // Дефиниране на стойността за role


                                using (SqlCommand cmd = new SqlCommand(insertdata, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", textBox1.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", textBox2.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", textBox3.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);
                                    cmd.Parameters.AddWithValue("@role", role); // Подаване на стойността за role

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Регистрацията е направена успешно!" + Environment.NewLine + "Моля влезте в акаунта си.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                    loginform f1 = new loginform();
                                    f1.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            loginform f1 = new loginform();
            f1.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '*')
            {
                textBox3.PasswordChar = '\0';
            }
            else if (textBox3.PasswordChar == '\0')
            {
                textBox3.PasswordChar = '*';
            }


            if (textBox4.PasswordChar == '*')
            {
                textBox4.PasswordChar = '\0';
            }
            else if (textBox4.PasswordChar == '\0')
            {
                textBox4.PasswordChar = '*';
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
