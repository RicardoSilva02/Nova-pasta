using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariadoRicardo
{
    public partial class Inicio : Form
    {
    
        public Inicio()
        {
            InitializeComponent();
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                if (lb_ajuda.Text == "Ajuda" || lb_ajuda.Text == "" || lb_ajuda.Text == "A minha Biblioteca" || lb_ajuda.Text == "EBOOKS")
                {
                    lb_ajuda.Text = "Cliente";
                }


                if (this.panel_receive.Controls.Count > 0)
                {
                    this.panel_receive.Controls.RemoveAt(0);
                }

                conta log = new conta();
                log.TopLevel = false;
                log.Tag = this;
                this.panel_receive.Controls.Add(log);
                log.Show();







            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            {
                if (lb_ajuda.Text == "Ajuda" || lb_ajuda.Text == "" || lb_ajuda.Text == "Cliente" || lb_ajuda.Text == "EBOOKS")
                {
                    lb_ajuda.Text = "A minha Biblioteca";
                }


                if (this.panel_receive.Controls.Count > 0)
                {
                    this.panel_receive.Controls.RemoveAt(0);
                }

                Bibli log = new Bibli();
                log.TopLevel = false;
                log.Tag = this;
                this.panel_receive.Controls.Add(log);
                log.Show();










            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if(lb_ajuda.Text == "" || lb_ajuda.Text == "Cliente" || lb_ajuda.Text == "A minha Bilioteca" || lb_ajuda.Text == "EBOOKS")
            {
                lb_ajuda.Text = "Ajuda";
            }



            if (this.panel_receive.Controls.Count > 0)
            {
                this.panel_receive.Controls.RemoveAt(0);
            }

            ajuda log = new ajuda();
            log.TopLevel = false;
            log.Tag = this;
            this.panel_receive.Controls.Add(log);
            log.Show();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            {
                if (lb_ajuda.Text == "Ajuda" || lb_ajuda.Text == "" || lb_ajuda.Text == "Cliente" || lb_ajuda.Text == "A minha Biblioteca")
                {
                    lb_ajuda.Text = "EBOOKS";
                }
                if (this.panel_receive.Controls.Count > 0)
                {
                    this.panel_receive.Controls.RemoveAt(0);
                }

                ebo log = new ebo();
                log.TopLevel = false;
                log.Tag = this;
                this.panel_receive.Controls.Add(log);
                log.Show();

            }
        }

        private void Panel_receive_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Owner = this;
            this.Hide();
            f1.ShowDialog();
            this.Dispose();
        }

        private void Panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
