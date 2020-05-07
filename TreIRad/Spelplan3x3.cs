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
    public partial class Spelplan3x3 : Form
    {
        public Spelplan3x3()
        {
            InitializeComponent();
        }
        bool spelKlart = false;
        int vemsTur = 0;
        

        public void spela()
        {
            while(spelKlart == false)
            {
                if(vemsTur % 2 == 0)//spelarens tur
                {

                }
                else//AI tur
                {
                    
                }


                //om tre i rad spelaklart = true
            }
        }

      
    }
}
