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

using Xceed.Words.NET;

namespace DoplomnaRabota_2024
{
    public partial class adminform : Form
    {
        
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=|DataDirectory|\LoginData.mdf;
Integrated Security=True;Connect Timeout=30;";
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable table;


        public adminform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void adminform_Load(object sender, EventArgs e)
        {
            // Инициализирайте връзката и адаптера
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter("SELECT * FROM admin", connection);

            // Създайте и попълнете DataTable с данните от базата данни
            table = new DataTable();
            dataAdapter.Fill(table);

            // Заредете DataTable в DataGridView
            dataGridView1.DataSource = table;

            // Позволете на потребителя да редактира данните
            dataGridView1.ReadOnly = true;



            // Инициализирайте връзката и адаптера
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter("SELECT * FROM produkti", connection);

            // Създайте и попълнете DataTable с данните от базата данни
            table = new DataTable();
            dataAdapter.Fill(table);

            // Заредете DataTable в DataGridView
            dataGridView2.DataSource = table;

            // Позволете на потребителя да редактира данните
            dataGridView2.ReadOnly = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сигурни ли сте че искате да напуснтете профила си?" , "Изход от профил!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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


        //За Нас
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            zanas zanas = new zanas();
            zanas.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            zanas zanas = new zanas();
            zanas.Show();
            this.Hide();
        }


        //adminform
        private void label3_Click(object sender, EventArgs e)
        {
            adminform adminform = new adminform();
            adminform.Show();
            this.Hide();
        }




        public void RefreshDataGridView()
        {
            // Изпълнение на заявка, за да заредите новите данни от базата данни и да ги покажете в Data Grid View
            string query = "SELECT * FROM admin";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            dataGridView1.DataSource = dataTable; // Уверете се, че dataGridView1 е правилното име на вашия DataGridView контрол
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == ""|| textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Моля попълнете всички полета!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!textBox1.Text.EndsWith(".bg") && !textBox1.Text.EndsWith(".com"))
            {
                MessageBox.Show("Невалиден имейл адрес!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!textBox1.Text.Contains("@"))
            {
                MessageBox.Show("Невалиден имейл адрес!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //(email, username, pssword, date_create, role)VALUES(@email, @username, @pass, @date, @role)
                // Изпълнение на SQL заявка за добавяне на нов запис
                string query = "INSERT INTO admin (email, username, pssword, date, role) VALUES (@Email, @Username, @Password, @DateCreated, @Role)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", textBox1.Text);
                command.Parameters.AddWithValue("@Username", textBox2.Text);
                command.Parameters.AddWithValue("@Password", textBox3.Text);
                command.Parameters.AddWithValue("@DateCreated", DateTime.Now); // Допълнително, ако искате да зададете конкретна дата, заменете DateTime.Now със съответната дата
                command.Parameters.AddWithValue("@Role", textBox4.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                RefreshDataGridView();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" )
            {
                MessageBox.Show("Моля попълнете всички полета!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textBox6.Text=="email")
            {
                if (!textBox7.Text.EndsWith(".bg") && !textBox7.Text.EndsWith(".com"))
                {
                    MessageBox.Show("Невалиден имейл адрес!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!textBox7.Text.Contains("@"))
                {
                    MessageBox.Show("Невалиден имейл адрес!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Изпълнение на SQL заявка за промяна на съществуващ запис
                string columnName = textBox6.Text; // Име на колоната, която ще бъде обновена
                string newValue = textBox7.Text; // Нова стойност, която ще се въведе в съответната колона

                string query = $"UPDATE admin SET {columnName} = @NewValue WHERE id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewValue", newValue);
                command.Parameters.AddWithValue("@Id", textBox5.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                RefreshDataGridView();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "" )
            {
                MessageBox.Show("Моля попълнете полето!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "DELETE FROM admin WHERE id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", textBox8.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                RefreshDataGridView();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int rowCount = CheckCartTableRecords();

            // Проверка дали има записи в таблицата "Cart"
            if (rowCount == 0)
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int rowCount = CheckCartTableRecords();

            // Проверка дали има записи в таблицата "Cart"
            if (rowCount == 0)
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
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Валидация на входа
            if (!int.TryParse(textBox9.Text, out int productId))
            {
                MessageBox.Show("Моля, въведете валидно ID.");
                return;
            }

            if (!int.TryParse(textBox10.Text, out int quantityToAdd))
            {
                MessageBox.Show("Моля, въведете валидно количество.");
                return;
            }

            // Търсене на реда със съответното ID
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["ID"].Value != null && row.Cells["ID"].Value.ToString() == textBox9.Text)
                {
                    // Намерен е редът, добавяне на количеството
                    int currentQuantity = int.Parse(row.Cells["kolichestvo"].Value.ToString());
                    row.Cells["kolichestvo"].Value = currentQuantity + quantityToAdd;
                    return;
                }
            }

            // Ако ID не е намерено в таблицата
            MessageBox.Show($"Продукт с ID {productId} не е намерен.");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mainform mainform = new mainform();
            mainform.Show();
            this.Hide();
        }
       
    }
}
