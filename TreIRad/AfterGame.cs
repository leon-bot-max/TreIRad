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
        public afterGame(char resultat)
        {
            InitializeComponent();
            if( resultat == 'T')
            {
                harVunnitBox.Text = "Ingen vann, oavgjort";
            }
            else
            harVunnitBox.Text = "Spelare " + resultat.ToString() + " har vunnit ";

        }

        private void tillMenyKnapp_Click(object sender, EventArgs e)
        {
            Meny myForm = new Meny();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void startaOmKnapp_Click(object sender, EventArgs e)
        {
            Spelplan3x3 myForm = new Spelplan3x3(true);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

      
    }
}
