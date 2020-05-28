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
            this.knappSpelaAI = new System.Windows.Forms.Button();
            this.KnappSpelaAnnanSpelare = new System.Windows.Forms.Button();
            this.stängAvKnapp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // välkommenText
            // 
            this.välkommenText.AutoSize = true;
            this.välkommenText.BackColor = System.Drawing.Color.Transparent;
            this.välkommenText.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.välkommenText.ForeColor = System.Drawing.Color.Black;
            this.välkommenText.Location = new System.Drawing.Point(90, 71);
            this.välkommenText.Name = "välkommenText";
            this.välkommenText.Size = new System.Drawing.Size(398, 41);
            this.välkommenText.TabIndex = 0;
            this.välkommenText.Text = "Välkommen till tre i rad";
            // 
            // knappSpelaAI
            // 
            this.knappSpelaAI.BackColor = System.Drawing.Color.Transparent;
            this.knappSpelaAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knappSpelaAI.Location = new System.Drawing.Point(97, 126);
            this.knappSpelaAI.Margin = new System.Windows.Forms.Padding(0);
            this.knappSpelaAI.Name = "knappSpelaAI";
            this.knappSpelaAI.Size = new System.Drawing.Size(184, 170);
            this.knappSpelaAI.TabIndex = 3;
            this.knappSpelaAI.Text = "Spela mot AI";
            this.knappSpelaAI.UseVisualStyleBackColor = false;
            this.knappSpelaAI.Click += new System.EventHandler(this.Knapp3x3_Click);
            // 
            // KnappSpelaAnnanSpelare
            // 
            this.KnappSpelaAnnanSpelare.BackColor = System.Drawing.Color.Transparent;
            this.KnappSpelaAnnanSpelare.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnappSpelaAnnanSpelare.Location = new System.Drawing.Point(304, 126);
            this.KnappSpelaAnnanSpelare.Margin = new System.Windows.Forms.Padding(0);
            this.KnappSpelaAnnanSpelare.Name = "KnappSpelaAnnanSpelare";
            this.KnappSpelaAnnanSpelare.Size = new System.Drawing.Size(184, 170);
            this.KnappSpelaAnnanSpelare.TabIndex = 4;
            this.KnappSpelaAnnanSpelare.Text = "Spela mot annan spelare";
            this.KnappSpelaAnnanSpelare.UseVisualStyleBackColor = false;
            this.KnappSpelaAnnanSpelare.Click += new System.EventHandler(this.KnappSpelaAnnanSpelare_Click);
            // 
            // stängAvKnapp
            // 
            this.stängAvKnapp.Location = new System.Drawing.Point(497, 526);
            this.stängAvKnapp.Name = "stängAvKnapp";
            this.stängAvKnapp.Size = new System.Drawing.Size(75, 23);
            this.stängAvKnapp.TabIndex = 5;
            this.stängAvKnapp.Text = "Stäng av";
            this.stängAvKnapp.UseVisualStyleBackColor = true;
            this.stängAvKnapp.Click += new System.EventHandler(this.stängAvKnapp_Click);
            // 
            // Meny
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.stängAvKnapp);
            this.Controls.Add(this.KnappSpelaAnnanSpelare);
            this.Controls.Add(this.knappSpelaAI);
            this.Controls.Add(this.välkommenText);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Meny";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

        private void KnappSpelaAnnanSpelare_Click(object sender, EventArgs e)
        {
            Spelplan3x3 myForm = new Spelplan3x3();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void stängAvKnapp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        
    }
}
