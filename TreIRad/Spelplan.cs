﻿using System;
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
    public partial class Spelplan : Form
    {


        
        TreIRadSpel spel;
        TreIRadBot bot; //new TreIRadBot(spel);
        Button[] knappar;
        bool spelarMotBot;
        int antalTillgängligaDrag;

        public Spelplan(bool spelarMotBot, int storlek, int mål)
        {
            InitializeComponent();
            bool botBörjar = false; //Kan användas fall man vill bot ska börja 
            spel = new TreIRadSpel(storlek, mål);
            bot = new TreIRadBot(spel);
            this.spelarMotBot = spelarMotBot;
            antalTillgängligaDrag = storlek * storlek;
            görKnappar();

            if (spelarMotBot && botBörjar)
            {
                görBotDrag();
            }

        }


        public void Button_Click(object sender, EventArgs e)
        {
            Button knapp = (Button)sender;
            int knappIndex = Array.IndexOf(knappar, knapp);//får index
            int[] kordinater = spel.fåKordinater(knappIndex);//{x, y}

            if (spel.ärTom(kordinater[0], kordinater[1]))
            {
                spel.görDrag(kordinater[0], kordinater[1]);
                knapp.Text = spel.bräda[kordinater[1], kordinater[0]].ToString();
                kollaEfterVinst();

                antalTillgängligaDrag -= 1; //Ett mindre tillgängligt drag
                
                if (spelarMotBot)
                {
                    görBotDrag();
                }
            }
            
        }
        
  

        public void kollaEfterVinst()//vinst eller oavgjort
        {
            if (spel.ärVinst())
            {
                Console.WriteLine("vinst");
                AfterGame myForm = new AfterGame(spel.väntandeSpelare, spelarMotBot, spel.storlek, spel.antalFörVinst, spel.bräda);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
            else if (spel.ärOavgjort())
            {
                Console.WriteLine("Oavgjort");
                AfterGame myForm = new AfterGame('T', spelarMotBot, spel.storlek, spel.antalFörVinst, spel.bräda);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
        }

        public void görBotDrag()
        {
            //Djupet ändras beroende på antal drag. Funkar från 3x3 till 5x5
            int djup = (int)(15 * Math.Exp(-0.046 * antalTillgängligaDrag));//13-antalTillgängligaDrag/3;//Kan ändras
            int[] drag = bot.fåDragMinimax(djup);
            spel.görDrag(drag[0], drag[1]);

            int index = drag[1] * spel.storlek + drag[0]; //Hittar knapp index som ska ändras
            
            knappar[index].Text = spel.bräda[drag[1], drag[0]].ToString();
            
            antalTillgängligaDrag -= 1; //Ett mindre tillgängligt drag
            kollaEfterVinst();

        }



        public void görKnappar()
        {

            int knappStorlek = Width/spel.storlek;
            knappar = new Button[spel.storlek * spel.storlek];//1D Array med knappar
            for (int i = 0;  i < knappar.Length; i++)
            {
                int x = (i % spel.storlek)*knappStorlek;
                int y = (i / spel.storlek)*knappStorlek;

                Button knapp = new Button();
                knapp.Location = new Point(x, y);
                knapp.Size = new Size(knappStorlek, knappStorlek);
                knapp.Text = "";
                knapp.Name = "knapp" + i;
                knapp.Font = new Font("Trebuchet MS", knappStorlek/2);
                knapp.Click += new EventHandler(Button_Click); //Funktion som ska köras när en knapp trycks
                knapp.BringToFront();               
                Controls.Add(knapp);
                knappar[i] = knapp;
            }
        }
       
    }
}
