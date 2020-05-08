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
        TreIRadSpel spel = new TreIRadSpel(3,3);


        public void Button_Click(object sender, EventArgs e)
        {
             Button knapp = (Button)sender;
            int knappIndex = int.Parse(knapp.Name[knapp.Name.Length - 1].ToString());//fix??
            int[] kordinater = spel.fåKordinater(knappIndex);//{x, y}

            if (spel.ärTom(kordinater[0], kordinater[1]))
            {
                spel.görDrag(kordinater[0], kordinater[1]);
                knapp.Text = spel.bräda[kordinater[1], kordinater[0]].ToString();
                if (spel.ärVinst())
                {
                    Console.WriteLine("vinst");
                }
                else if (spel.ärOavgjort())
                {
                    Console.WriteLine("Oavgjort");
                }
            }
            


        }
        

        public void spela()
        {
            while(spelKlart == false)
            {
               


                //om tre i rad spelaklart = true
            }
        }

        
       
    }
}
