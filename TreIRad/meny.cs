using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreIRad
{
    public partial class Meny : Form
    {
        public Meny()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meny));
            this.välkommenText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.knapp3x3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // välkommenText
            // 
            this.välkommenText.AutoSize = true;
            this.välkommenText.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.välkommenText.ForeColor = System.Drawing.Color.Yellow;
            this.välkommenText.Location = new System.Drawing.Point(78, 79);
            this.välkommenText.Name = "välkommenText";
            this.välkommenText.Size = new System.Drawing.Size(398, 41);
            this.välkommenText.TabIndex = 0;
            this.välkommenText.Text = "Välkommen till tre i rad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(228, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // knapp3x3
            // 
            this.knapp3x3.BackColor = System.Drawing.Color.White;
            this.knapp3x3.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knapp3x3.Location = new System.Drawing.Point(336, 140);
            this.knapp3x3.Name = "knapp3x3";
            this.knapp3x3.Size = new System.Drawing.Size(200, 200);
            this.knapp3x3.TabIndex = 3;
            this.knapp3x3.Text = "3x3";
            this.knapp3x3.UseVisualStyleBackColor = false;
            // 
            // Meny
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.knapp3x3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.välkommenText);
            this.Name = "Meny";
            this.Text = "tre i rad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
    }
}
