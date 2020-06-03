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


        bool spelKlart = false;
        TreIRadSpel spel;
        TreIRadBot bot; //new TreIRadBot(spel);
        Button[] knappar;
        bool spelarMotBot;
        int antalTillgängligaDrag;

        public Spelplan3x3(bool spelarMotBot, int storlek, int mål)
        {
            InitializeComponent();
            spel = new TreIRadSpel(storlek, mål);
            bot = new TreIRadBot(spel);
            this.spelarMotBot = spelarMotBot;
            antalTillgängligaDrag = storlek * storlek;
            görKnappar();



        }


        public void Button_Click(object sender, EventArgs e)
        {
            Button knapp = (Button)sender;
            int knappIndex = Array.IndexOf(knappar, knapp);//int.Parse(knapp.Name[knapp.Name.Length - 1].ToString());//fix??
            int[] kordinater = spel.fåKordinater(knappIndex);//{x, y}

            if (spel.ärTom(kordinater[0], kordinater[1]))
            {
                spel.görDrag(kordinater[0], kordinater[1]);
                knapp.Text = spel.bräda[kordinater[1], kordinater[0]].ToString();
                kollaEfterVinst();

                antalTillgängligaDrag -= 1;
                
                if (spelarMotBot)
                {
                    görBotDrag();
                    kollaEfterVinst();
                }
            }
            
        }
        
  

        public void kollaEfterVinst()//vinst eller oavgjort
        {
            if (spel.ärVinst())
            {
                Console.WriteLine("vinst");
                afterGame myForm = new afterGame(spel.väntandeSpelare, spelarMotBot, spel.storlek, spel.antalFörVinst, spel.bräda);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
            else if (spel.ärOavgjort())
            {
                Console.WriteLine("Oavgjort");
                afterGame myForm = new afterGame('T', spelarMotBot, spel.storlek, spel.antalFörVinst, spel.bräda);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
        }

        public void görBotDrag()
        {
            int djup = 13-antalTillgängligaDrag/3;//Kan ändras
            int[] drag = bot.fåDragMinimax(djup);
            spel.görDrag(drag[0], drag[1]);

            int index = drag[1] * spel.storlek + drag[0];
            
            knappar[index].Text = spel.bräda[drag[1], drag[0]].ToString();
            
            antalTillgängligaDrag -= 1;

        }

       

        public void görKnappar()
        {

            int knappStorlek = Width/spel.storlek;//Width / spel.storlek-3;
            knappar = new Button[spel.storlek * spel.storlek];
            for (int i = 0;  i < knappar.Length; i++)
            {
                int x = (i % spel.storlek)*knappStorlek;
                int y = (i / spel.storlek)*knappStorlek;

                Button knapp = new Button();
                knapp.Location = new Point(x, y);
                knapp.Size = new Size(knappStorlek, knappStorlek);
                knapp.Text = "";
                knapp.Name = "knapp" + i;
                knapp.Font = new Font("Trebuchet MS", 72);
                knapp.Click += new EventHandler(Button_Click);
                knapp.BringToFront();               
                Controls.Add(knapp);
                knappar[i] = knapp;
            }
        }
       
    }
}
