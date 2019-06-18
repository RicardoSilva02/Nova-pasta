using LivrariadoRicardo.Properties;
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
    public partial class ajuda : Form
    {



        private bool isCollapsed; 

        public ajuda()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {

                menudrop.Image = Resources.icons8_menos_241;
                paneldowndrop.Height += 10;
                if (paneldowndrop.Size == paneldowndrop.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }

            }
             else
            {
                menudrop.Image = Resources.icons8_mais_241;
                paneldowndrop.Height -= 10;
                if (paneldowndrop.Size == paneldowndrop.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Paneldowndrop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
