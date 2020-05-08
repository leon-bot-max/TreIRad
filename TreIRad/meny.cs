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
            this.välkommenText = new System.Windows.Forms.Label();
            this.knappTryckStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // välkommenText
            // 
            this.välkommenText.AutoSize = true;
            this.välkommenText.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.välkommenText.ForeColor = System.Drawing.Color.Black;
            this.välkommenText.Location = new System.Drawing.Point(79, 67);
            this.välkommenText.Name = "välkommenText";
            this.välkommenText.Size = new System.Drawing.Size(398, 41);
            this.välkommenText.TabIndex = 0;
            this.välkommenText.Text = "Välkommen till tre i rad";
            // 
            // knappTryckStart
            // 
            this.knappTryckStart.BackColor = System.Drawing.Color.Transparent;
            this.knappTryckStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knappTryckStart.Location = new System.Drawing.Point(143, 200);
            this.knappTryckStart.Margin = new System.Windows.Forms.Padding(0);
            this.knappTryckStart.Name = "knappTryckStart";
            this.knappTryckStart.Size = new System.Drawing.Size(301, 123);
            this.knappTryckStart.TabIndex = 3;
            this.knappTryckStart.Text = "Tryck för att starta";
            this.knappTryckStart.UseVisualStyleBackColor = false;
            this.knappTryckStart.Click += new System.EventHandler(this.Knapp3x3_Click);
            // 
            // Meny
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.knappTryckStart);
            this.Controls.Add(this.välkommenText);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Meny";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Knapp3x3_Click(object sender, EventArgs e)
        {

            Spelplan3x3 myForm = new Spelplan3x3();
            this.Hide();
            myForm.ShowDialog();
            this.Close();

        }

       
    }
}
