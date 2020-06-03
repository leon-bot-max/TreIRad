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
            this.knapp3x3 = new System.Windows.Forms.Button();
            this.knapp5x5 = new System.Windows.Forms.Button();
            this.labelMål3x3 = new System.Windows.Forms.Label();
            this.labelMål5x5 = new System.Windows.Forms.Label();
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
            this.knappSpelaAI.Location = new System.Drawing.Point(97, 247);
            this.knappSpelaAI.Margin = new System.Windows.Forms.Padding(0);
            this.knappSpelaAI.Name = "knappSpelaAI";
            this.knappSpelaAI.Size = new System.Drawing.Size(184, 170);
            this.knappSpelaAI.TabIndex = 3;
            this.knappSpelaAI.Text = "Spela mot AI";
            this.knappSpelaAI.UseVisualStyleBackColor = false;
            this.knappSpelaAI.Click += new System.EventHandler(this.KnappSpelaBot_Click);
            // 
            // KnappSpelaAnnanSpelare
            // 
            this.KnappSpelaAnnanSpelare.BackColor = System.Drawing.Color.Transparent;
            this.KnappSpelaAnnanSpelare.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnappSpelaAnnanSpelare.Location = new System.Drawing.Point(304, 247);
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
            // knapp3x3
            // 
            this.knapp3x3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.knapp3x3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knapp3x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knapp3x3.Location = new System.Drawing.Point(97, 157);
            this.knapp3x3.Name = "knapp3x3";
            this.knapp3x3.Size = new System.Drawing.Size(87, 57);
            this.knapp3x3.TabIndex = 6;
            this.knapp3x3.Text = "3x3";
            this.knapp3x3.UseVisualStyleBackColor = false;
            this.knapp3x3.Click += new System.EventHandler(this.knapp3x3_Click);
            // 
            // knapp5x5
            // 
            this.knapp5x5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.knapp5x5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knapp5x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knapp5x5.Location = new System.Drawing.Point(401, 157);
            this.knapp5x5.Name = "knapp5x5";
            this.knapp5x5.Size = new System.Drawing.Size(87, 57);
            this.knapp5x5.TabIndex = 7;
            this.knapp5x5.Text = "5x5";
            this.knapp5x5.UseVisualStyleBackColor = false;
            this.knapp5x5.Click += new System.EventHandler(this.knapp5x5_Click);
            // 
            // labelMål3x3
            // 
            this.labelMål3x3.AutoSize = true;
            this.labelMål3x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMål3x3.Location = new System.Drawing.Point(74, 129);
            this.labelMål3x3.Name = "labelMål3x3";
            this.labelMål3x3.Size = new System.Drawing.Size(150, 25);
            this.labelMål3x3.TabIndex = 8;
            this.labelMål3x3.Text = "Mål: Få 3 i rad";
            // 
            // labelMål5x5
            // 
            this.labelMål5x5.AutoSize = true;
            this.labelMål5x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMål5x5.Location = new System.Drawing.Point(369, 129);
            this.labelMål5x5.Name = "labelMål5x5";
            this.labelMål5x5.Size = new System.Drawing.Size(150, 25);
            this.labelMål5x5.TabIndex = 9;
            this.labelMål5x5.Text = "Mål: Få 4 i rad";
            this.labelMål5x5.Visible = false;
            // 
            // Meny
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.labelMål5x5);
            this.Controls.Add(this.labelMål3x3);
            this.Controls.Add(this.knapp5x5);
            this.Controls.Add(this.knapp3x3);
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

        int storlek = 3;
        int mål = 3;

        private void KnappSpelaBot_Click(object sender, EventArgs e)//gör att man spelar på en 3x3 plan
        {

            Spelplan myForm = new Spelplan(true, storlek, mål);
            this.Hide();
            myForm.ShowDialog();
            this.Close();

        }

        private void KnappSpelaAnnanSpelare_Click(object sender, EventArgs e)// spela 1v1
        {
            Spelplan myForm = new Spelplan(false, storlek, mål);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void stängAvKnapp_Click(object sender, EventArgs e)//avslutar applikationen
        {
            System.Windows.Forms.Application.Exit();
        }

        private void knapp3x3_Click(object sender, EventArgs e)// gör att man spelar på en 3x3 plan
        {
            storlek = 3;
            mål = 3;

            knapp3x3.BackColor = SystemColors.ActiveCaption;
            knapp5x5.BackColor = SystemColors.ControlDarkDark;
            labelMål3x3.Visible = true;
            labelMål5x5.Visible = false;
        }

        private void knapp5x5_Click(object sender, EventArgs e)//gör att man spelar på en 5x5 plan
        {
            storlek = 5;
            mål = 4;

            knapp5x5.BackColor = SystemColors.ActiveCaption;
            knapp3x3.BackColor = SystemColors.ControlDarkDark;
            labelMål5x5.Visible = true;
            labelMål3x3.Visible = false;
        }
    }
}
