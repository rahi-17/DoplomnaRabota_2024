using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoplomnaRabota_2024
{
    public partial class suhistroitelnismesi : Form
    {
        string query = "SELECT COUNT(*) FROM Cart";
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=|DataDirectory|\LoginData.mdf;
Integrated Security=True;Connect Timeout=30;";
        public suhistroitelnismesi()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вече сте в тази страница! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вече сте в тази страница! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вече сте в тази страница! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вече сте в тази страница! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вече сте в тази страница! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вече сте в тази страница! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        ////Покривни системи и материали
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
        //21
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 21);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //22
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 22);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //23
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 23);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //24
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 24);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //25
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 25);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //26
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 26);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //27
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 27);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //28
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 28);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //29
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 29);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //30
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 30);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //31
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 31);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //32
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 32);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //33
        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 33);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //34
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 34);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //35
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 35);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //36
        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 36);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //37
        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, produkti, cena, kolichestvo FROM produkti WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Id", 37);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int availableQuantity = reader.GetInt32(3);

                        reader.Close(); // Затваряме първия DataReader, тъй като вече сме го използвали

                        // Проверка дали продуктът вече е добавен в кошницата
                        string checkCartQuery = "SELECT COUNT(*) FROM Cart WHERE [Сериен номер] = @SerialNumber";
                        SqlCommand checkCartCommand = new SqlCommand(checkCartQuery, connection);
                        checkCartCommand.Parameters.AddWithValue("@SerialNumber", id);
                        int cartItemCount = (int)checkCartCommand.ExecuteScalar();

                        if (cartItemCount > 0)
                        {
                            MessageBox.Show("Продуктът вече е добавен в кошницата.", "Вече добавен продукт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Излизаме от метода, тъй като продуктът вече е добавен в кошницата
                        }

                        int quantity = 0;
                        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Въведете количество за " + productName + ":", "Въвеждане на количество"), out quantity))
                        {
                            if (quantity > availableQuantity)
                            {
                                MessageBox.Show("Няма достатъчно количество от продукта " + productName + " в наличност.", "Грешка при добавяне на продукта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO Cart ([Сериен номер], [Име на продукта], [Единична цена], [Количество], [Обща цена]) VALUES (@SerialNumber, @Name, @Price, @Quantity, @TotalValue)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@SerialNumber", id);
                                insertCommand.Parameters.AddWithValue("@Name", productName);
                                insertCommand.Parameters.AddWithValue("@Price", price);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@TotalValue", price * quantity);
                                insertCommand.ExecuteNonQuery();

                                // Изваждане на избраното количество от наличното количество в таблицата produkti
                                string updateQuery = "UPDATE produkti SET kolichestvo = kolichestvo - @Quantity WHERE Id = @Id";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Продуктът е успешно добавен в кошницата.", "Добавен продукт към кошницата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продуктът не е намерен.", "Грешка при намирането на продукта.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
