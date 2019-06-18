namespace LivrariadoRicardo
{
    partial class ajuda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajuda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menudrop = new System.Windows.Forms.Button();
            this.paneldowndrop = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.paneldowndrop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.menudrop);
            this.panel1.Controls.Add(this.paneldowndrop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 310);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // menudrop
            // 
            this.menudrop.FlatAppearance.BorderSize = 0;
            this.menudrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menudrop.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menudrop.Image = global::LivrariadoRicardo.Properties.Resources.icons8_mais_241;
            this.menudrop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menudrop.Location = new System.Drawing.Point(29, 13);
            this.menudrop.Name = "menudrop";
            this.menudrop.Size = new System.Drawing.Size(557, 41);
            this.menudrop.TabIndex = 0;
            this.menudrop.Text = "Ebooks";
            this.menudrop.UseVisualStyleBackColor = true;
            this.menudrop.Click += new System.EventHandler(this.Button1_Click);
            // 
            // paneldowndrop
            // 
            this.paneldowndrop.Controls.Add(this.button4);
            this.paneldowndrop.Controls.Add(this.button3);
            this.paneldowndrop.Controls.Add(this.button2);
            this.paneldowndrop.Location = new System.Drawing.Point(29, 13);
            this.paneldowndrop.MaximumSize = new System.Drawing.Size(557, 126);
            this.paneldowndrop.MinimumSize = new System.Drawing.Size(557, 41);
            this.paneldowndrop.Name = "paneldowndrop";
            this.paneldowndrop.Size = new System.Drawing.Size(557, 41);
            this.paneldowndrop.TabIndex = 1;
            this.paneldowndrop.Paint += new System.Windows.Forms.PaintEventHandler(this.Paneldowndrop_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(557, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "Como leio um EBOOK";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(557, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Como comprar?";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(557, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "O que são?";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ajuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 310);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ajuda";
            this.Text = "Biblioteca";
            this.panel1.ResumeLayout(false);
            this.paneldowndrop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menudrop;
        private System.Windows.Forms.Panel paneldowndrop;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}