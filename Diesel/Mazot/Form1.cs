using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mazot
{
    public partial class Form1 : Form
    {
        string Connectserver = "Data Source =DESKTOP-AGB1JSQ; Initial Catalog=Mazot; Persist Security Info=True;User ID = sa; Password=***********;Integrated Security = True;";
        public SqlConnection connection;
        private SqlDataAdapter dataadapter;
        private DataTable tbl;
        private SqlDataReader rdr;
        private DialogResult res;
        private Form form;
        private Logın logın;
        private string User;
        public Form1(string Username)
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            User = Username;    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            



            this.carsTableAdapter.Fill(this.mazotDataSet.Cars);
            connection = new SqlConnection(Connectserver);
            try
            {
                connection.Open();
                comboBox1.Items.Clear();
                GetData();
                GetUser(User);

            }
            catch (Exception ex)
            {
                MessageBox.Show("bağlantı başarısız" + ex.Message);


            }
        }
        void GetData()
        {

            SqlCommand getdata = new SqlCommand("Select NewPlate From Cars", connection);
            rdr = getdata.ExecuteReader();

            while (rdr.Read())
            {
                comboBox1.Items.Add(rdr["NewPlate"].ToString());
            }
            rdr.Close();

        }
        void getDatagridview()
        {
            string query = "SELECT * FROM Cars";
            SqlCommand cmd = new SqlCommand(query, connection);
            dataadapter = new SqlDataAdapter(cmd);
            tbl = new DataTable();
            dataadapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }
        void UpdateCombobox()
        {
            comboBox1.Items.Clear();
            string query = "SELECT NewPlate From Cars";

            SqlCommand cmd = new SqlCommand(query, connection);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                comboBox1.Items.Add(rdr["NewPlate"].ToString());
            }
            rdr.Close();
        }

        private void GetUser(string Username)
        {

            string query = "SELECT * FROM Logın Where Username = @Username";
            SqlCommand cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@Username", Username);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

                label2.Text= "Kullanıcı :" + rdr["Username"].ToString();
                if (User == "Admin")
                {
                    dataGridView1.Visible = true;
                    label1.Visible = true;
                    button3.Visible= true;
                    newplate.Visible= true;
                    

                }
                else
                {
                    dataGridView1.Visible = false;
                    textBox1.Visible = false;
                    label1.Visible = false;
                    button3.Visible = false;
                    newplate.Visible = false;


                }
            }
            rdr.Close();
       
        }
        private void newplate_Click(object sender, EventArgs e)
        {
            string plaka = textBox1.Text.Trim();
            string pattern = "^(0[1-9]|[1-7][0-9]|8[01])\\s([A-Z]{1,3})\\s(\\d{2,4})$";

            if (Regex.IsMatch(plaka, pattern))
            {
                label1.Text += " Geçerli Plaka";
                label2.Text = textBox1.Text;
             

                SqlCommand checkcmd = new SqlCommand("SELECT COUNT(*) FROM Cars WHERE NewPlate = @NewPlate", connection);
                checkcmd.Parameters.AddWithValue("@NewPlate", textBox1.Text);
                int count = (int)checkcmd.ExecuteScalar();
                if (count == 0)
                {
                    SqlCommand cmd = new SqlCommand("Insert Into Cars(NewPlate) Values ('" + textBox1.Text + "')", connection);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows != 0)
                    {
                        MessageBox.Show("Başarıyla kayıt edildi: " + plaka.ToString() ,"Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        UpdateCombobox();
                        getDatagridview();
                        textBox1.Text = "";
                        label1.Text += "";
                        rdr.Close();
                    }
                    else
                    {
                        MessageBox.Show("başarısız Kayıt","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Bu plaka zaten kayıtlı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }


            }
            else
            {
                label1.Text += " Geçersiz plaka.";
                label1.Text += "";
                return;
            }
         
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        private void UpdatePlate()
        {

            string plaka = comboBox1.SelectedItem.ToString();
            float Onceki_Km = float.Parse(textBox2.Text);
            float Sonraki_Km = float.Parse(textBox3.Text);
            float litre = float.Parse(textBox5.Text);   
            DateTime selectedDate = dateTimePicker1.Value;
            // Seçilen tarihi bir mesaj kutusunda göster

            float trip = Onceki_Km - Sonraki_Km;

            float Yüzde = litre / trip;
            




            string query = "UPDATE Cars Set  Trip=@Trip ,Onceki_Km=@Onceki_Km,Sonraki_Km=@Sonraki_Km, litre=@litre , Yuzde=@Yüzde, EntryDate=@EntryDate  Where NewPlate=@NewPlate ";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Litre", litre);
            cmd.Parameters.AddWithValue("@Yüzde", Yüzde);
            cmd.Parameters.AddWithValue("@Trip", trip);
            cmd.Parameters.AddWithValue("@Onceki_Km", Onceki_Km);
            cmd.Parameters.AddWithValue("@Sonraki_km", Sonraki_Km);
            cmd.Parameters.AddWithValue("@EntryDate", selectedDate);
            cmd.Parameters.AddWithValue("@NewPlate", plaka);
            int Rows = cmd.ExecuteNonQuery();
            if (Rows > 0)
            {
                
                MessageBox.Show("başarıyla ile eklendi","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                rdr.Close();
            }
            else
            {
                MessageBox.Show("Bilgiler Eklenemedi", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Gerekli yerleri doldurunuz");
            }
            else
            {
                string plaka=comboBox1.SelectedItem.ToString();
                MessageBox.Show(plaka);
                UpdatePlate();
                DaliyMovement(plaka);
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                comboBox1.Text = "";
                rdr.Close();

            }
        }
        void DaliyMovement(string UpdataPlate)
        {
            string query = @"INSERT INTO CarHar (NewPlate, Trip, Onceki_Km, Sonraki_Km, Litre , Yuzde , EntryDate)
                     SELECT c.NewPlate, c.Trip, c.Onceki_Km, c.Sonraki_Km,c.Litre ,c.Yuzde, GETDATE()
                     FROM Cars c
                      Where NewPlate = @NewPlate";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NewPlate", UpdataPlate);
            int rows = command.ExecuteNonQuery();
            MessageBox.Show(UpdataPlate);
            if (rows > 0)
            {
                MessageBox.Show("Günlük Hareketler Eklendi");
                rdr.Close();
            }
            else
            {
                MessageBox.Show("Günlük Hareketler Eklenemedi");
            }
        }

        void SendExcel()
        {
            string query = "SELECT NewPlate, Trip, Onceki_Km, Sonraki_Km, Litre, Yuzde, EntryDate FROM Cars WHERE EntryDate >= @FilterDate";
            dataadapter = new SqlDataAdapter(query, connection);
            dataadapter.SelectCommand.Parameters.AddWithValue("@FilterDate", dateTimePicker1.Value.Date);
            tbl = new DataTable();
            dataadapter.Fill(tbl);

            IXLWorkbook wb = new XLWorkbook();
            IXLWorksheet ws = wb.Worksheets.Add("Sheet1");

            ws.Cell(1, 1).Value = "Tarih";
            ws.Cell(1, 2).Value = "Plaka";
            ws.Cell(1, 3).Value = "Litre";
            ws.Cell(1, 4).Value = "Önceki Km";
            ws.Cell(1, 5).Value = "Sonraki Km";
            ws.Cell(1, 6).Value = "Trip";
            ws.Cell(1, 7).Value = "Yüzde";



            int row = 2;

            foreach (DataRow dr in tbl.Rows)
            {
                ws.Cell(row, 1).Value = ((DateTime)dr["EntryDate"]).ToString("dd-MM-yy", CultureInfo.InvariantCulture);
                ws.Cell(row, 2).Value = dr["NewPlate"].ToString();
                ws.Cell(row, 3).Value = dr["Litre"].ToString();
                ws.Cell(row, 4).Value = dr["Onceki_Km"].ToString();
                ws.Cell(row, 5).Value = dr["Sonraki_Km"].ToString();
                ws.Cell(row, 6).Value = dr["Trip"].ToString();
                ws.Cell(row, 7).Value= dr["Yuzde"].ToString();
                string yuzdeStr =Convert.ToDecimal(dr["Yuzde"]).ToString("F19");
                string yuzdeFormat = yuzdeStr.Length > 5 ? yuzdeStr.Substring(6, 2) :"00";
                MessageBox.Show(yuzdeFormat);

                row++;


            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel Files|*.xlsx";
            saveFile.Title = "Excel Dosyası Kaydet";
            saveFile.FileName = "CarsData.xlsx";

            res = MessageBox.Show("Bugün Girmiş Olduğunuz Kayıtlar Excele Aktarılcaktır Eminmisiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(saveFile.FileName);
                    MessageBox.Show("veriler başarıyla aktarıldı");
                    rdr.Close();
                }
            }
            else
            {
                MessageBox.Show("veriler Aktarılamadı");

            }

        }

        private void GoExcel_Click(object sender, EventArgs e)
        {
            SendExcel();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            PlateDelete();
            getDatagridview();
        }
        void PlateDelete()
        {

            string Platedelete = comboBox1.Text;


            if (string.IsNullOrEmpty(Platedelete))
            {
                MessageBox.Show("Silmek İstediğiniz Plakayı Seçiniz");

            }
            else
            {

            }
            res = MessageBox.Show("Seçmiş olduğunuz Plaka Silinecektir Eminmisiniz", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string query = "Delete  From Cars Where NewPlate=@NewPlate";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NewPlate", Platedelete);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Plaka Başarıyla Silindi");
                    comboBox1.Text = "";
                    UpdateCombobox();
                    rdr.Close();
                }
            }
            else
            {
                MessageBox.Show("Plaka Silinemedi");

            }


        }
     
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            differentdate();

        }
        void differentdate()
        {

            string Plate = textBox4.Text;
            if (string.IsNullOrEmpty(Plate))
            {
                MessageBox.Show("Lütfen Kayıtlı bir Plaka Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                string Newdate = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
                string query = "Select NewPlate,Trip,Onceki_Km, Sonraki_Km, Litre , Yuzde , EntryDate From CarHar Where CAST(EntryDate AS DATE)=@EntryDate AND NewPlate = @NewPlate";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NewPlate", Plate);
                cmd.Parameters.AddWithValue("@EntryDate", Newdate);
                rdr = cmd.ExecuteReader();

                listView1.Items.Clear();
                listView1.View = View.Details;
                listView1.Columns.Clear();
                listView1.Columns.Add("NewPlate", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Trip", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Onceki_Km", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Sonraki_Km", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Litre", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Yuzde", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("EntryDate", 100, HorizontalAlignment.Left);

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        ListViewItem item = new ListViewItem(rdr["NewPlate"].ToString());
                        item.SubItems.Add(rdr["Trip"].ToString());
                        item.SubItems.Add(rdr["Onceki_Km"].ToString());
                        item.SubItems.Add(rdr["Sonraki_Km"].ToString());
                        item.SubItems.Add(rdr["Litre"].ToString());
                        item.SubItems.Add(rdr["Yuzde"].ToString());
                        item.SubItems.Add(((DateTime)rdr["EntryDate"]).ToString("dd-MM-yyyy"));
                        listView1.Items.Add(item);
                    }
                    rdr.Close();
                }

                else
                {
                    MessageBox.Show("Seçilen Tarihe Ait Bilgi Bulunamdı");
                    rdr.Close();
                }


            }
          


        }
       
        void MazotHar(ListView listView)
        {
            IXLWorkbook wb = new XLWorkbook();
            IXLWorksheet ws = wb.Worksheets.Add("Sheet1");

          

            // ListView sütun başlıklarını Excel'e ekle
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                ws.Cell(1, i + 1).Value = listView.Columns[i].Text;
            }

            // ListView satırlarını Excel'e ekle
            for (int i = 0; i < listView.Items.Count; i++)
            {
                for (int j = 0; j < listView.Items[i].SubItems.Count; j++)
                {
                    ws.Cell(i + 2, j + 1).Value = listView.Items[i].SubItems[j].Text;
                }
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel Files|*.xlsx";
            saveFile.Title = "Excel Dosyası Kaydet";
            saveFile.FileName = "MazotHarData.xlsx";

            MessageBox.Show("Bu Bilgileri Excele Aktarılacak Aktarılsınmı","Onay",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res==DialogResult.Yes) {

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(saveFile.FileName);
                    MessageBox.Show("Bilgiler Başarıyla Excel Dosyasına aktarıldı.","Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);  
                }
            }
            else
            {
                MessageBox.Show("Bilgiler Aktarılamadı");
            }
            
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            MazotHar(listView1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize Eminmisiniz ?" ,"Çıkış", MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                e.Cancel = false;
                connection.Close();
                rdr.Close();
                
            }
            else
            {
                e.Cancel= true;
                
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
           res= MessageBox.Show("Hesaptan Çıkış yapmak istediğinize emin misiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
             logın=new Logın();
                logın.Show();
                this.Hide();
            }
           
        }
    }
}
