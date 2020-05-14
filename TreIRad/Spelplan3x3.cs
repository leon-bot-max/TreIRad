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
    public partial class Spelplan3x3 : Form
    {
        public Spelplan3x3()
        {
            InitializeComponent();
            görKnappar();
        }
        bool spelKlart = false;
        TreIRadSpel spel = new TreIRadSpel(3,3);
        Button[] knappar;

        public void Button_Click(object sender, EventArgs e)
        {
            Button knapp = (Button)sender;
            int knappIndex = Array.IndexOf(knappar, knapp);//int.Parse(knapp.Name[knapp.Name.Length - 1].ToString());//fix??
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
