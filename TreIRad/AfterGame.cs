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
        public afterGame()
        {
            InitializeComponent();
        }

        private void tillMenyKnapp_Click(object sender, EventArgs e)
        {
            Meny myForm = new Meny();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
