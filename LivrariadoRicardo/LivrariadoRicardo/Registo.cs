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
    public partial class Registo : Form
    {
        public Registo()
        {
            InitializeComponent();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Owner = this;
            this.Hide();
            f1.ShowDialog();
            this.Dispose();


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (username, Password,emailuser) VALUES (@usn, @pass,@email);", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = userNameBox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailbox.Text;

            
            db.openConnection();

            
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Criaste a tua conta");
                Login f1 = new Login();
                this.Hide();
                f1.ShowDialog();
                this.Dispose();
            }
            else if (command.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("Tenta de Novo");
            }

            
            db.closeConnection();
        }

        private void TextBox4_Enter(object sender, EventArgs e)
        {
            if (userNameBox.Text == "User name")
            {
                userNameBox.Text = "";
                userNameBox.ForeColor = Color.Black;
                userNameBox.UseSystemPasswordChar = false;
            }
        }

        private void TextBox4_Leave(object sender, EventArgs e)
        {
            if (userNameBox.Text == "")
            {
                userNameBox.Text = "User name";
                userNameBox.ForeColor = Color.Black;
                userNameBox.UseSystemPasswordChar = false;
            }
        }

        private void TextBox3_Enter(object sender, EventArgs e)
        {
            if (emailbox.Text == "Email")
            {
                emailbox.Text = "";
                emailbox.ForeColor = Color.Black;
                emailbox.UseSystemPasswordChar = false;
            }
        }

        private void TextBox3_Leave(object sender, EventArgs e)  
        {
            if (emailbox.Text == "")
            {
                emailbox.Text = "Email";
                emailbox.ForeColor = Color.Black;
                emailbox.UseSystemPasswordChar = false;
            }
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Password")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Password";
                textBox1.ForeColor = Color.Black;
                textBox1.UseSystemPasswordChar = false;
            }
        }

        private void Emailbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registo_Load(object sender, EventArgs e)
        {

        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
