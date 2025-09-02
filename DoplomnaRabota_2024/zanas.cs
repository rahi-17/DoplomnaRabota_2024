using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoplomnaRabota_2024
{
    public partial class zanas : Form
    {
        string query = "SELECT COUNT(*) FROM Cart";
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=|DataDirectory|\LoginData.mdf;
Integrated Security=True;Connect Timeout=30;";
        public zanas()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате" + Environment.NewLine + "да се върнете към началната страница", "Връщане към начална страница", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                main.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате" + Environment.NewLine + "да се върнете към началната страница", "Връщане към начална страница", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                main.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || richTextBox1.Text == "")
            {
                MessageBox.Show("Моля попълнете всички полета!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
                
                else if (!textBox2.Text.Contains("@"))
                {
                    MessageBox.Show("Невалиден имейл адрес!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!textBox2.Text.EndsWith(".bg") && !textBox2.Text.EndsWith(".com"))
                {
                    MessageBox.Show("Невалиден имейл адрес!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "съобщения.docx");


                // Проверка дали документът съществува
                if (!File.Exists(filePath))
                    {
                        // Ако документът не съществува, създаваме нов документ
                        Word.Application wordApp = new Word.Application();
                        Word.Document doc = wordApp.Documents.Add();

                        // Запазваме документа на посочената пътека
                        doc.SaveAs(filePath);
                        doc.Close();
                        wordApp.Quit();
                    }

                    // Отваряме съществуващ документ
                    Word.Application wordAppExisting = new Word.Application();
                    Word.Document existingDoc = wordAppExisting.Documents.Open(filePath);

                    // Добавяме нов текст в края на документа
                    existingDoc.Content.InsertAfter(Environment.NewLine + "Име: " + textBox1.Text + Environment.NewLine);
                    existingDoc.Content.InsertAfter("Email: " + textBox2.Text + Environment.NewLine);
                    existingDoc.Content.InsertAfter("Съобщение: " + richTextBox1.Text + Environment.NewLine);
                    existingDoc.Save();
                    existingDoc.Close();
                    wordAppExisting.Quit();

                    MessageBox.Show("Информацията бeше изпратена успешно!" + Environment.NewLine + "Благодарим ви!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сигурни ли сте че искате да напуснтете профила си?", "Изход от профил!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                loginform login = new loginform();
                login.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Сигурни ли сте че искате да напуснтете профила си?", "Изход от профил!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                loginform login = new loginform();
                login.Show();
                this.Hide();
            }
        }

        //Материали за зидария 
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            materializazidariq menu1 = new materializazidariq();
            menu1.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            materializazidariq menu1 = new materializazidariq();
            menu1.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            materializazidariq menu1 = new materializazidariq();
            menu1.Show();
            this.Hide();
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            pokrivnisistemiimateriali menu2 = new pokrivnisistemiimateriali();
            menu2.Show();
            this.Hide();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            pokrivnisistemiimateriali menu2 = new pokrivnisistemiimateriali();
            menu2.Show();
            this.Hide();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            pokrivnisistemiimateriali menu2 = new pokrivnisistemiimateriali();
            menu2.Show();
            this.Hide();
        }

        //Сухи строителни материали
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            suhistroitelnismesi menu3 = new suhistroitelnismesi();
            menu3.Show();
            this.Hide();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            suhistroitelnismesi menu3 = new suhistroitelnismesi();
            menu3.Show();
            this.Hide();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            suhistroitelnismesi menu3 = new suhistroitelnismesi();
            menu3.Show();
            this.Hide();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            suhistroitelnismesi menu3 = new suhistroitelnismesi();
            menu3.Show();
            this.Hide();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            suhistroitelnismesi menu3 = new suhistroitelnismesi();
            menu3.Show();
            this.Hide();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            suhistroitelnismesi menu3 = new suhistroitelnismesi();
            menu3.Show();
            this.Hide();
        }


        //Уплатнители и фуги
        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            uplatniteliifugi menu4 = new uplatniteliifugi();
            menu4.Show();
            this.Hide();

        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            uplatniteliifugi menu4 = new uplatniteliifugi();
            menu4.Show();
            this.Hide();
        }


        //Дървен материал
        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            durvenmaterial menu5 = new durvenmaterial();
            menu5.Show();
            this.Hide();
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            durvenmaterial menu5 = new durvenmaterial();
            menu5.Show();
            this.Hide();
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            durvenmaterial menu5 = new durvenmaterial();
            menu5.Show();
            this.Hide();
        }


        //Плоскости
        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            ploskosti menu6 = new ploskosti();
            menu6.Show();
            this.Hide();
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            ploskosti menu6 = new ploskosti();
            menu6.Show();
            this.Hide();
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            ploskosti menu6 = new ploskosti();
            menu6.Show();
            this.Hide();
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            ploskosti menu6 = new ploskosti();
            menu6.Show();
            this.Hide();
        }


        //Метали
        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
            metali menu7 = new metali();
            menu7.Show();
            this.Hide();
        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
            metali menu7 = new metali();
            menu7.Show();
            this.Hide();
        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            metali menu7 = new metali();
            menu7.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вече сте в тази страница! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Вече сте в тази страница! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Все още нямате добавени продукти към кошницата!" + Environment.NewLine + "Моля първо добавете продукти в кошницата, за да преминете към тази страница.", "Празна количка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cart cart = new cart();
                        cart.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Възникна грешка: {ex.Message}", "Грешка");
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Все още нямате добавени продукти към кошницата!" + Environment.NewLine + "Моля първо добавете продукти в кошницата, за да преминете към тази страница.", "Празна количка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cart cart = new cart();
                        cart.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Възникна грешка: {ex.Message}", "Грешка");
                }
            }
        }

        private void zanas_Load(object sender, EventArgs e)
        {

        }
    }
}
