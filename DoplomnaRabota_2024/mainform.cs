using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Data.SqlClient;

namespace DoplomnaRabota_2024
{
    public partial class mainform : Form
    {
        string query = "SELECT COUNT(*) FROM Cart";
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=|DataDirectory|\LoginData.mdf;
Integrated Security=True;Connect Timeout=30;";
        public mainform()
        {
            InitializeComponent();
            UpdateContent();
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


        //Покривни системи и материали
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            pokrivnisistemiimateriali menu2 =new pokrivnisistemiimateriali();
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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            zanas zanas = new zanas();
            zanas.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            zanas zanas = new zanas();
            zanas.Show();
            this.Hide();
        }



        //Дървен материал
        private void toolStripMenuItem20_Click_1(object sender, EventArgs e)
        {
            durvenmaterial menu5 = new durvenmaterial();
            menu5.Show();
            this.Hide();
        }

        private void toolStripMenuItem21_Click_1(object sender, EventArgs e)
        {
            durvenmaterial menu5 = new durvenmaterial();
            menu5.Show();
            this.Hide();
        }

        private void toolStripMenuItem22_Click_1(object sender, EventArgs e)
        {
            durvenmaterial menu5 = new durvenmaterial();
            menu5.Show();
            this.Hide();
        }


        //Метали
        private void toolStripMenuItem29_Click_1(object sender, EventArgs e)
        {
            metali menu7 = new metali();
            menu7.Show();
            this.Hide();
        }

        private void toolStripMenuItem30_Click_1(object sender, EventArgs e)
        {
            metali menu7 = new metali();
            menu7.Show();
            this.Hide();
        }

        private void toolStripMenuItem31_Click_1(object sender, EventArgs e)
        {
            metali menu7 = new metali();
            menu7.Show();
            this.Hide();
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
        private int CheckCartTableRecords()
        {
            int rowCount = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Отваряне на връзката с базата данни
                connection.Open();

                // Дефиниране на SQL заявката за извличане на броя записи в таблицата "Cart"
                string query = "SELECT COUNT(*) FROM Cart";

                // Създаване на SQL команда за изпълнение на заявката
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Изпълнение на SQL командата и връщане на броя записи
                    rowCount = (int)command.ExecuteScalar();
                }
            }
            return rowCount;
        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }
        private int currentIndex = 0;
        private List<string> images = new List<string> {  Path.Combine(Application.StartupPath, "images", "materializazidariqmain.jpeg"),
    Path.Combine(Application.StartupPath, "images", "prokrivnimaterialimain.jpeg"),
    Path.Combine(Application.StartupPath, "images", "suhistroitelnimain.jpeg"),
    Path.Combine(Application.StartupPath, "images", "uplatnitelimain.jpeg"),
    Path.Combine(Application.StartupPath, "images", "durven materialmain.jpeg"),
    Path.Combine(Application.StartupPath, "images", "ploskostimain.jpeg"),
    Path.Combine(Application.StartupPath, "images", "metalimain.jpeg")};
        private List<string> captions = new List<string> { "Материали за зидария", "Покривни системи и" + Environment.NewLine + "материали", "Сухи строителни смеси", "Уплатнители и фуги", "Дървен материал", "Плоскости","Метали" };
        private List<string> secondCaptions = new List<string> { "-Тухли" + Environment.NewLine + "-Коминни тела и системи" + Environment.NewLine+"-Щурцове", 
            "-Керемиди" + Environment.NewLine + "-Подкеремидни материали" + Environment.NewLine+"-Покривни прозорци",
           "-Цимент" + Environment.NewLine + "-Гипс" + Environment.NewLine+"-Подови замаски и" + Environment.NewLine + " невилиращи смеси"  + Environment.NewLine + "-Бетон" + Environment.NewLine+"-Лепила и шпакловки" + Environment.NewLine + "-Лепила за плочки и камъни",
        "-Фуги" + Environment.NewLine + "-Уплатнители и пяни" ,
         "-Дъски" + Environment.NewLine + "-Греди" + Environment.NewLine+"-Летви",
        "-OSB плоскости" + Environment.NewLine + "-Шперплат" + Environment.NewLine+"-Фазер"+ Environment.NewLine+"-Кофражни елементи",
        "-Арматури" + Environment.NewLine + "-Телове" + Environment.NewLine+"-Ламарини"};

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= images.Count)
            {
                currentIndex = 0;
            }
            UpdateContent();
        }
        private void UpdateContent()
        {
            pictureBox5.Image = Image.FromFile(images[currentIndex]);
            label11.Text = captions[currentIndex];
            label12.Text = secondCaptions[currentIndex];
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вече сте в тази страница! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вече сте в тази страница! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
