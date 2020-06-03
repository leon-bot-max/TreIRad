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
    public partial class afterGame : Form
    {

        bool spelarMotBot;
        int storlek;
        int mål;
        public afterGame(char resultat, bool spelarMotBot, int storlek, int mål, char[,] bräda)
        {
            InitializeComponent();
            if (resultat == 'T')// skriver ut vem som vunnit eller om det blir oavgjort
            {
                harVunnitBox.Text = "Ingen vann, oavgjort";
            }
            else
                harVunnitBox.Text = "Spelare " + resultat.ToString() + " har vunnit ";
            

            this.spelarMotBot = spelarMotBot;
            this.storlek = storlek;
            this.mål = mål;

            ritaBräda(bräda);

        }

        private void tillMenyKnapp_Click(object sender, EventArgs e)//går tillbaka till menyn
        {
            Meny myForm = new Meny();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void startaOmKnapp_Click(object sender, EventArgs e)//startar om spelet
        {
            Spelplan3x3 myForm = new Spelplan3x3(spelarMotBot, storlek, mål);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
        private void ritaBräda(char[,] bräda)//gör en kopia av brädan som man ser i aftergame
        {

            int sidLängd = 96 / storlek;
            for (int y = 0; y < bräda.GetLength(0); y++)
            {
                for (int x = 0; x < bräda.GetLength(1); x++)
                {
                    Label label = new Label();
                    label.Text = bräda[y, x].ToString();
                    label.AutoSize = false;
                    label.BackColor = SystemColors.ControlDark;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.Size = new Size(sidLängd, sidLängd);
                    label.Font = new Font("Arial", 60/storlek);
                    label.Location = new Point((Width / 2 - sidLängd*(storlek/2)) + sidLängd * x, 100 + y * sidLängd);
                    label.BringToFront();
                    Controls.Add(label);
                }
            }
        }
    }
}



