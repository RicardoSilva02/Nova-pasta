using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;   

namespace LivrariadoRicardo
{
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection();

        private static string _connectionString = "Server=127.0.0.1;Database=livraria_db;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);





        public Login()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {

            string nome = textBoxUserName.Text;
            string pass = textBoxPassWord.Text;
            string query;


            MySqlConnection db = new MySqlConnection(Properties.Settings.Default.ConnectionString);
            db.Open();

            try
            {

                query = "SELECT idusers, username, password FROM users WHERE username = @nome AND password = @pass";

                MySqlCommand comando = new MySqlCommand(query, db);
                comando.CommandText = query;
                MySqlParameter uusername = new MySqlParameter("@nome", MySqlDbType.String);
                MySqlParameter upassword = new MySqlParameter("@pass", MySqlDbType.String);
                uusername.Value = textBoxUserName.Text;
                upassword.Value = textBoxPassWord.Text;

                comando.Parameters.Add(uusername);
                comando.Parameters.Add(upassword);

                MySqlDataReader mydb = comando.ExecuteReader(CommandBehavior.CloseConnection);
                if (mydb.Read() == true)
                {
                    Program.IDUser = Convert.ToInt32(mydb["idusers"].ToString());

                    Inicio f4 = new Inicio();
                    f4.Owner = this;
                    this.Hide();
                    f4.ShowDialog();
                    this.Dispose();

                 

                }
                else
                {
                    textBoxUserName.Clear();
                    MessageBox.Show("Falhaste a pass ou o user!");
                }






            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {


            Registo f2 = new Registo();
            f2.Owner = this;
            this.Hide();
            f2.ShowDialog();
            this.Dispose();
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "User name")
            {
                textBoxUserName.Text = "";
                textBoxUserName.ForeColor = Color.Black;
                textBoxUserName.UseSystemPasswordChar = false;
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "")
            {
                textBoxUserName.Text = "User name";
                textBoxUserName.ForeColor = Color.Black;
                textBoxUserName.UseSystemPasswordChar = false;
            }
        }



        private void TextBox4_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_Leave(object sender, EventArgs e)
        {

        }

        private void TextBox3_Enter(object sender, EventArgs e)
        {
            if (textBoxPassWord.Text == "Password")
            {
                textBoxPassWord.Text = "";
                textBoxPassWord.ForeColor = Color.Black;
                textBoxPassWord.UseSystemPasswordChar = true;
            }
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            if (textBoxPassWord.Text == "")
            {
                textBoxPassWord.Text = "Password";
                textBoxPassWord.ForeColor = Color.Black;
                textBoxPassWord.UseSystemPasswordChar = false;
            }
        }

        private void TextBoxPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
