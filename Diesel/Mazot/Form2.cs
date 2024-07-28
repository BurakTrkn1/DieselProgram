using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Mazot
{
    //Admin giriş ve admin işlemleri  işlemi kaldı 
    public partial class Logın : Form
    {
        public Logın()
        {
            InitializeComponent();
        }
        string Connectserver = "Data Source =DESKTOP-AGB1JSQ; Initial Catalog=Mazot; Persist Security Info=True;User ID = sa; Password=***********;Integrated Security = True;";
        private SqlConnection connection;
        private SqlCommand command; 
        private SqlDataReader rdr;
        private Form1 form1;
        private string type;

        private void Logın_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox2.UseSystemPasswordChar = true;
            textBox5.UseSystemPasswordChar = true;

            try
            {
                connection = new SqlConnection(Connectserver);
                connection.Open();
            }
            catch (Exception ex) {
            
              MessageBox.Show("bağlantı Kurulamadı" + ex,"Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
              connection.Close();
              rdr.Close();
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sHA256Hash= SHA256.Create())
            {
                byte[] bytes= sHA256Hash.ComputeHash(Encoding.UTF8.GetBytes(password)); 
                StringBuilder stringBuilder= new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    stringBuilder.Append(bytes[i]);
                }
                return stringBuilder.ToString();    

            }

        }
  

        private void Login_Click(object sender, EventArgs e)
        {
            
            string Username = textBox1.Text;
            string enteredPassword = textBox2.Text;
            string storedhash=null;
            bool isPasswordValid = false;

            if (Username =="" || enteredPassword == "")
            {
                MessageBox.Show("Kullancı Adı Veya Şifre Boş Geçilmemeli", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
           
            string query = "SELECT * FROM Logın Where Username = @Username ";
            command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@Username",Username);
            rdr = command.ExecuteReader();
                try
                {
                    if (rdr.Read())
                    {
                        storedhash = rdr["Password"].ToString();
                        MessageBox.Show(storedhash);
                        rdr.Close();

                    }
                    if (string.IsNullOrEmpty(storedhash))
                    {
                        MessageBox.Show("Şifre hash değeri boş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rdr.Close();
                    }
                    else
                    {
                        try
                        {
                            isPasswordValid = BCrypt.Net.BCrypt.Verify(enteredPassword, storedhash);
                            MessageBox.Show(isPasswordValid.ToString());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Doğrulama sırasında hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (isPasswordValid)
                        {
                            MessageBox.Show("Giriş Başarılı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            form1 = new Form1(Username);
                            form1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Adı Ve Şifre Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rdr.Close();
                        }
                        return;
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata:" + ex, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

           



        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
        }

        private void Regıster_Click(object sender, EventArgs e)
        {
            string Name=textBox3.Text;
            string Username=textBox4.Text;
            string hasedpassword = BCrypt.Net.BCrypt.HashPassword(textBox5.Text);
            if (Name == "" || Username == "" || hasedpassword == "")
            {
                MessageBox.Show("Kullancı Adı Veya Şifre Boş geçilmemeli", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                command = new SqlCommand("SELECT COUNT(*) FROM Regıster Where Name_Surname = @Name_Surname AND Username = @Username AND Password=@Password", connection);
                command.Parameters.AddWithValue("@Name_Surname", Name);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", hasedpassword);


                int count = (int)command.ExecuteScalar();
                if (count == 0)
                {
                    string query = "INSERT INTO Regıster(Name_Surname,Username,Password) VALUES ('" + Name + "','" + Username + "','" + hasedpassword + "')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(hasedpassword);
                    if (rows != 0)
                    {
                        MessageBox.Show("Kayıt Başarılıyla Gerçekleşmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AddLogın(Name,Username, hasedpassword);
                        Name = "";
                        Username = "";
                        hasedpassword = "";



                    }
                    else
                    {
                        MessageBox.Show("Kayıt Olunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                else
                {

                    MessageBox.Show("Bu kullanıcı Zaten Kayıtlı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
           
        }
            private void AddLogın(string Name_Surname,string Username , string Password)
            {
                string query = "INSERT INTO Logın(Username,Password) Values ('" + Username + "', '" + Password + "')";
                command = new SqlCommand(query,connection);
                int rows = command.ExecuteNonQuery();

            if (rows > 0)
            {
                
            }
            else
            {
                MessageBox.Show("Kayıt Olunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            }
       
    }
}
