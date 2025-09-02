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
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Text.RegularExpressions;

namespace DoplomnaRabota_2024
{
    public partial class cart : Form
    {

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=|DataDirectory|\LoginData.mdf;
Integrated Security=True;Connect Timeout=30;";
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable table;
        string query = "SELECT SUM([Обща цена]) FROM cart";

      
        public cart()
        {
            InitializeComponent();
           
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

        private void cart_Load(object sender, EventArgs e)
        {
            // Инициализирайте връзката и адаптера
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter("SELECT * FROM Cart", connection);

            // Създайте и попълнете DataTable с данните от базата данни
            table = new DataTable();
            dataAdapter.Fill(table);

            // Заредете DataTable в DataGridView
            dataGridView1.DataSource = table;

            // Позволете на потребителя да редактира данните
            dataGridView1.ReadOnly = true;





            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                // Изпълнение на заявката и вземане на сумата
                object result = command.ExecuteScalar();

                // Проверка дали има резултат и дали той не е DBNull
                if (result != DBNull.Value && result != null)
                {
                    // Преобразуване на резултата в подходящ тип данни
                    decimal totalPrice = Convert.ToDecimal(result);

                    // Изведете сумата във вашия label
                    label14.Text = $" {totalPrice}";
                }
                else
                {
                    // Ако резултатът е DBNull или null, задайте label на 0 или покажете съобщение за липса на данни
                    label14.Text = "0"; // или "Няма данни."
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                decimal additionalCost = 5.99m; // Допълнителната цена, която да добавим

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();

                    // Изпълнение на заявката и вземане на сумата
                    object result = command.ExecuteScalar();

                    // Проверка дали има резултат
                    if (result != null)
                    {
                        // Преобразуване на резултата в подходящ тип данни
                        decimal totalPrice = Convert.ToDecimal(result);

                        // Изчисляване на новата обща цена
                        decimal newTotalPrice = totalPrice + additionalCost;

                        // Изведете новата обща цена в друг label
                        label13.Text = $"{newTotalPrice}";
                    }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                decimal additionalCost = 5.99m; // Допълнителната цена, която да добавим

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();

                    // Изпълнение на заявката и вземане на сумата
                    object result = command.ExecuteScalar();

                    // Проверка дали има резултат
                    if (result != null)
                    {
                        // Преобразуване на резултата в подходящ тип данни
                        decimal totalPrice = Convert.ToDecimal(result);

                        // Изчисляване на новата обща цена
                        decimal newTotalPrice = totalPrice + additionalCost;

                        // Изведете новата обща цена в друг label
                        label13.Text = $"{newTotalPrice}";
                    }
                }
            }
        }




       
        private int invoiceCount = 1; // Брояч на фактурите


    


        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Моля, изберете доставчик за вашата поръчка, за да продължите.", "Необходим е избор на доставчик", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""||textBox8.Text=="")
            {
                MessageBox.Show("Моля попълнете всички полета с вашите данни!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Проверява дали поне един от радио бутоните е избран
            
            else if (!Regex.IsMatch(textBox2.Text, @"^08[7-9]\d{7}$"))
            {
                MessageBox.Show("Невалиден телефонен номер.", "Невалиден вход", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Пътя към целевата папка за съхранение на фактурите
                string customFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "фактури");

                string fileName = GetUniqueInvoiceFileName(customFolderPath);
                string filePath = Path.Combine(customFolderPath, fileName);


                // Генериране на документа и останалата логика за генериране и записване на фактурата
                using (WordprocessingDocument doc = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = doc.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());

                    // Добавяне на стил за центриране на текста
                    ParagraphProperties titleParagraphProperties = new ParagraphProperties();
                    titleParagraphProperties.Append(new Justification() { Val = JustificationValues.Center });

                    // Добавяне на стил за центриране на текста
                    ParagraphProperties titleParagraphProperties1 = new ParagraphProperties();
                    titleParagraphProperties1.Append(new Justification() { Val = JustificationValues.Left });

                    // Добавяне на заглавието
                    Paragraph titleParagraph = body.AppendChild(new Paragraph(titleParagraphProperties));
                    Run titleRun = titleParagraph.AppendChild(new Run());
                    titleRun.AppendChild(new Text("Фактура"));
                    titleRun.RunProperties = new RunProperties(new Bold(), new FontSize() { Val = "70" });

                    // Добавяне на полета за дата и час на поръчката
                    Paragraph orderDateParagraph = body.AppendChild(new Paragraph());
                    orderDateParagraph.AppendChild(new Run(new Text($"Дата на поръчката: {DateTime.Now.ToShortDateString()}")));

                    Paragraph orderTimeParagraph = body.AppendChild(new Paragraph());
                    orderTimeParagraph.AppendChild(new Run(new Text($"Час на поръчката: {DateTime.Now.ToShortTimeString()}")));

                    Paragraph invoiceNumberParagraph = body.AppendChild(new Paragraph());
                    invoiceNumberParagraph.AppendChild(new Run(new Text($"Номер на фактурата: {invoiceCount}")));



                    // Добавяне на данните от формата
                    Paragraph dataParagraph = body.AppendChild(new Paragraph());
                    dataParagraph.AppendChild(new Run(new Text($"Име: {textBox8.Text}\n")));

                    Paragraph lastNameParagraph = body.AppendChild(new Paragraph());
                    lastNameParagraph.AppendChild(new Run(new Text($"Фамилия: {textBox1.Text}\n")));

                    Paragraph phoneNumberParagraph = body.AppendChild(new Paragraph());
                    phoneNumberParagraph.AppendChild(new Run(new Text($"Телефонен номер: {textBox2.Text}\n")));

                    Paragraph addressParagraph = body.AppendChild(new Paragraph());
                    addressParagraph.AppendChild(new Run(new Text($"Адрес на доставката: {textBox3.Text}\n")));

                    // Добавяне на текст "Закупени продукти" над таблицата
                    Paragraph productsTitleParagraph1 = body.AppendChild(new Paragraph(titleParagraphProperties1));
                    Run productsTitleRun = productsTitleParagraph1.AppendChild(new Run());
                    productsTitleRun.AppendChild(new Text("Закупени продукти"));
                    productsTitleRun.RunProperties = new RunProperties(new Bold(), new FontSize() { Val = "30" });



                    // Изчисляване на общата стойност на продуктите
                    decimal totalValue = CalculateTotalValue();

                    // Добавяне на таблицата
                    Table table = new Table();

                    // Добавяне на заглавния ред, включващ заглавията на колоните
                    TableRow headerRow = new TableRow();
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        TableCell tableCell = CreateTableCell(column.HeaderText, true);
                        // Добавяне на граници към клетките в заглавния ред
                        TableCellBorders borders = new TableCellBorders(
                            new BottomBorder { Val = BorderValues.Single, Size = 12 },
                            new LeftBorder { Val = BorderValues.Single, Size = 12 },
                            new RightBorder { Val = BorderValues.Single, Size = 12 });
                        tableCell.AppendChild(new TableCellProperties(borders));
                        headerRow.AppendChild(tableCell);
                    }
                    table.AppendChild(headerRow);

                    // Добавяне на данните от DataGridView
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        TableRow dataRow = new TableRow();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            TableCell tableCell = CreateTableCell(cell.Value?.ToString() ?? "");
                            // Добавяне на граници към клетките в данни редове
                            TableCellBorders borders = new TableCellBorders(
                                new BottomBorder { Val = BorderValues.Single, Size = 12 },
                                new LeftBorder { Val = BorderValues.Single, Size = 12 },
                                new RightBorder { Val = BorderValues.Single, Size = 12 });
                            tableCell.AppendChild(new TableCellProperties(borders));
                            dataRow.AppendChild(tableCell);
                        }
                        table.AppendChild(dataRow);
                    }

                    body.AppendChild(table);

                    // Добавяне на параграф с общата сума под таблицата
                    Paragraph totalSumParagraph = body.AppendChild(new Paragraph());
                    Run totalSumRun = totalSumParagraph.AppendChild(new Run());
                    totalSumRun.AppendChild(new Text($"Обща стойност на продуктите: {totalValue}"));
                    // Добавяне на доставчика
                    Paragraph deliveryProviderParagraph = body.AppendChild(new Paragraph());
                    string deliveryProviderText = "";
                    if (radioButton1.Checked)
                    {
                        deliveryProviderText = "Доставчик: Еконт (+5.99лв. за доставката)";
                    }
                    else if (radioButton2.Checked)
                    {
                        deliveryProviderText = "Доставчик: Speedy (+5.99лв. за доставката)";
                    }
                    deliveryProviderParagraph.AppendChild(new Run(new Text(deliveryProviderText)));


                    // Добавяне на общата стойност на продуктите
                    Paragraph totalValueParagraph = body.AppendChild(new Paragraph());
                    totalValueParagraph.AppendChild(new Run(new Text($"Обща стойност на поръчката: {totalValue + 5.99m}\n" + " лв.")));
                }


                // Увеличаване на брояча на фактурите за следващата фактура
                invoiceCount++;

                // Извеждане на номера на фактурата в самата фактура
                WriteInvoiceNumberToDocument(filePath);
                AddEmptyParagraphsToDocument(filePath);


                // Изтриване на записите от таблицата "cart"
                DeleteRecordsFromCartTable();

                MessageBox.Show("Благодарим за вашата поръчка!" + Environment.NewLine + $"Фактурата с име \"{fileName}\" беше генерирана успешно." + Environment.NewLine + "Ще бъдете прехвърлени в началната страница", "Успешна поръчка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GetInvoiceNumberFromFileName(string fileName)
        {
            string[] parts = fileName.Split('_');
            if (parts.Length > 1)
            {
                string lastPart = parts[parts.Length - 1];
                int invoiceNumber;
                if (int.TryParse(lastPart.Replace(".docx", ""), out invoiceNumber))
                {
                    return invoiceNumber;
                }
            }
            return -1; // Ако не можем да намерим номер на фактурата в името на файла
        }
        private void WriteInvoiceNumberToDocument(string filePath)
        {
            using (WordprocessingDocument doc = WordprocessingDocument.Open(filePath, true))
            {
                // Извличане на номера на фактурата от името на файла
                int invoiceNumber = GetInvoiceNumberFromFileName(Path.GetFileName(filePath));

                // Търсене на параграфа, където да се изведе номерът на фактурата (може да се промени според структурата на документа)
                var body = doc.MainDocumentPart.Document.Body;
                Paragraph invoiceNumberParagraph = body.Elements<Paragraph>().FirstOrDefault(p => p.InnerText.Contains("Номер на фактурата:"));
                if (invoiceNumberParagraph != null)
                {
                    invoiceNumberParagraph.Append(new Run(new Text($" {invoiceNumber}")));
                }
            }
        }
        private string GetUniqueInvoiceFileName(string folderPath)
        {
            int invoiceNumber = 1;
            string fileName;
            do
            {
                fileName = $"Фактура{invoiceNumber}.docx";
                invoiceNumber++;
            } while (File.Exists(Path.Combine(folderPath, fileName)));

            return fileName;
        }
        private decimal CalculateTotalValue()
        {
            decimal totalValue = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                decimal productValue;
                if (decimal.TryParse(row.Cells["Обща цена"].Value?.ToString(), out productValue))
                {
                    totalValue += productValue;
                }
            }
            return totalValue;
        }

        private TableCell CreateTableCell(string text, bool isHeader = false)
        {
            TableCell cell = new TableCell(new Paragraph(new Run(new Text(text))));

            // Проверка дали клетката е заглавна
            if (isHeader)
            {
                // Ако е заглавна, добавяме стил за подчертаване и други стилове, според вашите изисквания
                TableCellProperties cellProperties = new TableCellProperties();
                TableCellBorders borders = new TableCellBorders(
                    new TopBorder { Val = BorderValues.Single, Size = 12 },
                    new BottomBorder { Val = BorderValues.Single, Size = 12 },
                    new LeftBorder { Val = BorderValues.Single, Size = 12 },
                    new RightBorder { Val = BorderValues.Single, Size = 12 });
                Shading shading = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "D9D9D9" };

                cellProperties.AppendChild(borders);
                cellProperties.AppendChild(shading);

                cell.AppendChild(cellProperties);
            }
            else
            {
                // Ако не е заглавна, добавяме горна и долна граница
                cell.TableCellProperties = new TableCellProperties(new TableCellBorders(new TopBorder { Val = BorderValues.Single, Size = 12 },
                                                                                        new BottomBorder { Val = BorderValues.Single, Size = 12 },
                                                                                        new LeftBorder { Val = BorderValues.Single, Size = 12 },
                                                                                        new RightBorder { Val = BorderValues.Single, Size = 12 }));
            }
            return cell;
        }
        private void AddEmptyParagraphsToDocument(string filePath)
        {
            using (WordprocessingDocument doc = WordprocessingDocument.Open(filePath, true))
            {
                var body = doc.MainDocumentPart.Document.Body;

                // Търсене на параграфа с номера на фактурата
                Paragraph invoiceNumberParagraph = body.Elements<Paragraph>().FirstOrDefault(p => p.InnerText.Contains("Номер на фактурата:"));
                if (invoiceNumberParagraph != null)
                {
                    // Добавяне на параграф между номера на фактурата и името
                    body.InsertAfter(new Paragraph(), invoiceNumberParagraph);
                }

                // Търсене на параграфа с текст "Фактура"
                Paragraph invoiceParagraph = body.Elements<Paragraph>().FirstOrDefault(p => p.InnerText.Contains("Фактура"));
                if (invoiceParagraph != null)
                {
                    // Добавяне на параграф след параграфа с текст "Фактура"
                    body.InsertAfter(new Paragraph(), invoiceParagraph);
                }

                // Търсене на параграфа с текст "Адрес на доставката"
                Paragraph addressParagraph = body.Elements<Paragraph>().FirstOrDefault(p => p.InnerText.Contains("Адрес на доставката"));
                if (addressParagraph != null)
                {
                    // Добавяне на параграф след параграфа с текст "Адрес на доставката"
                    body.InsertAfter(new Paragraph(), addressParagraph);
                }
            }
        }
        private void DeleteRecordsFromCartTable()
        {
            // Дефиниране на връзката с базата данни
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Отваряне на връзката с базата данни
                    connection.Open();

                    // Дефиниране на SQL заявката за изтриване на записи от таблицата "cart"
                    string query = "DELETE FROM Cart";

                    // Създаване на SQL команда за изпълнение на заявката
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Изпълнение на SQL командата за изтриване на записи
                        command.ExecuteNonQuery();
                    }

                    // Скриване на текущата форма
                    this.Hide();

                    // Показване на главната форма, като създадете нова инстанция или ако вече е създадена - просто я покажете
                    mainform mainForm = new mainform();
                    mainForm.Show();
                }
                catch (Exception ex)
                {
                    // Показване на грешка в случай на проблем при изпълнението на заявката за изтриване на записи
                    MessageBox.Show("Грешка при изтриване на записи: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вече сте в тази страница! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Вече сте в тази страница! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}



