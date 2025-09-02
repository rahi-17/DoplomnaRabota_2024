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
    public partial class loginform : Form
    {
        SqlConnection conect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=|DataDirectory|\LoginData.mdf;
Integrated Security=True;Connect Timeout=30;");
        registerform f2 = new registerform();
        public loginform()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f2.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
            }
            else if (textBox2.PasswordChar == '\0')
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Моля попълнете всички полета!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if(conect.State != ConnectionState.Open)
            {
                
                    try
                    {
                        conect.Open();

                        String selectData = "SELECT * FROM admin WHERE username = @username AND pssword = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, conect))
                        {
                            cmd.Parameters.AddWithValue("@username", textBox1.Text);
                            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {

                            if (table.Rows[0]["role"].ToString() == "admin")
                            {
                                MessageBox.Show("Влизането като администратор е успешно!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Показване на формата за администратор
                                adminform adminForm = new adminform();
                                adminForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Влизането е успешно!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Показване на другата форма
                                mainform otherForm = new mainform();
                                otherForm.Show();
                                this.Hide();
                            }

                        }
                           
                            else
                            {

                                DialogResult result = MessageBox.Show("Грешна парола/потребителско име!" + Environment.NewLine + "Желаете ли да създадете нов акунт?", "Error Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                if (result == DialogResult.Yes)
                                {
                                    f2.Show();
                                    this.Hide();
                                }
                            }
                          
                        }
                        }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conect.Close();
                    }
            }
            
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f2.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
            }
            else if (textBox2.PasswordChar == '\0')
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
