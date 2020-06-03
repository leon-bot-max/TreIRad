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
    public partial class AfterGame : Form
    {

        bool spelarMotBot;
        int storlek;
        int mål;
        public AfterGame(char resultat, bool spelarMotBot, int storlek, int mål, char[,] bräda)
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
            Spelplan myForm = new Spelplan(spelarMotBot, storlek, mål);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
        private void ritaBräda(char[,] bräda)//gör en kopia av brädan som man ser i aftergame
        {

            int sidLängd = 96 / storlek;
            int mittenPosX = Width / 2;
            int toppPosY = 100;

            for (int y = 0; y < bräda.GetLength(0); y++)
            {
                for (int x = 0; x < bräda.GetLength(1); x++)
                {

                    int posX = (mittenPosX - sidLängd * (storlek / 2)) + sidLängd * x; //Får position X
                    int posY = toppPosY + y * sidLängd; //Position Y

                    Label label = new Label();
                    label.Text = bräda[y, x].ToString();
                    label.AutoSize = false;
                    label.BackColor = SystemColors.ControlDark;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Size = new Size(sidLängd, sidLängd);
                    label.Font = new Font("Arial", 60/storlek);
                    label.Location = new Point(posX +x, posY+y);//+x och +y för att få mellanrum
                    label.BringToFront();
                    Controls.Add(label);
                }
            }
        }
    }
}



