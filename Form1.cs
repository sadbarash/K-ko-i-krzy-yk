﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kółko_i_krzyżyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool gracz1 = true;
        int ruch = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Restart();
            wynikO.Text = "0";
            wynikX.Text = "0";
            Kto.Text = "O";
            gracz1 = true;
        }

        private void Restart()
        {
            ruch = 0;
            Button[] all = new Button[9];
            all[0] = button1;
            all[1] = button2;
            all[2] = button3;
            all[3] = button4;
            all[4] = button5;
            all[5] = button6;
            all[6] = button7;
            all[7] = button8;
            all[8] = button9;
            foreach(Button b in all)
            {
                b.Enabled = true;
                b.Text = "";
            }
        }
        private void Sprawdz()
        {
            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
            {
                Wygrana();
            }
            else if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
            {
                Wygrana();
            }
            else if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text) 
            {
                Wygrana();
            }
            else if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text) 
            {
                Wygrana();
            }
            else if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text) 
            {
                Wygrana();
            }
            else if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text) 
            {
                Wygrana();
            }
            else if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text) 
            {
                Wygrana();
            }
            else if (button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text) 
            {
                Wygrana();
            }
            else if(ruch == 9)
            {
                MessageBox.Show("Remis", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restart();
            }
        }

        private void Wygrana()
        {
            MessageBox.Show("Wygrywa gracz: " + (gracz1 ? "O" : "X"), "Wygrana", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (gracz1)
                wynikO.Text = ((int.Parse(wynikO.Text)) + 1).ToString();
            else
                wynikX.Text = ((int.Parse(wynikX.Text)) + 1).ToString();
            Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if(ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            Kto.Text = gracz1 ? "O" : "X";
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            Kto.Text = gracz1 ? "O" : "X";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            Kto.Text = gracz1 ? "O" : "X";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            Kto.Text = gracz1 ? "O" : "X";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            Kto.Text = gracz1 ? "O" : "X";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            Kto.Text = gracz1 ? "O" : "X";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            Kto.Text = gracz1 ? "O" : "X";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            Kto.Text = gracz1 ? "O" : "X";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            Kto.Text = gracz1 ? "O" : "X";
        }
    }
}
