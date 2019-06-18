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
    public partial class conta : Form
    {
        public conta()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void Conta_Load(object sender, EventArgs e)
        {
            MySqlConnection db = new MySqlConnection(Properties.Settings.Default.ConnectionString);
            db.Open();

            string query = "SELECT username, password FROM users WHERE idusers = " + Program.IDUser;

            MySqlCommand comando = new MySqlCommand(query, db);
            comando.CommandText = query;
           

            MySqlDataReader mydb = comando.ExecuteReader(CommandBehavior.CloseConnection);
            while (mydb.Read())
            {
                label3.Text = mydb["username"].ToString();
                label4.Text = mydb["password"].ToString();
            }

            db.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
