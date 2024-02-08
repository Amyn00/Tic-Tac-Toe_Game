using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 f2 = new Form2();
        Random randomNum = new Random();
        Button btn = new Button();
        string p1, p2;
        int player1 = 0, player2 = 0, turn = 1, rndNum = 0, timeLeft = 0;
//-------------------------------------------------------------------------------------------------------------------
        //METHODE SMART CLICK
        public void checkClick() 
        {
            if (!button1.Enabled && !button2.Enabled && button3.Enabled && button1.Text == "O" && button2.Text == "O") { rndNum = 3; }
            else if (!button1.Enabled && !button3.Enabled && button2.Enabled && button1.Text == "O" && button3.Text == "O") { rndNum = 2; }
            else if (!button2.Enabled && !button3.Enabled && button1.Enabled && button2.Text == "O" && button3.Text == "O") { rndNum = 1; }

            else if (!button4.Enabled && !button5.Enabled && button6.Enabled && button4.Text == "O" && button5.Text == "O") { rndNum = 6; }
            else if (!button4.Enabled && !button6.Enabled && button5.Enabled && button4.Text == "O" && button6.Text == "O") { rndNum = 5; }
            else if (!button5.Enabled && !button6.Enabled && button4.Enabled && button5.Text == "O" && button6.Text == "O") { rndNum = 4; }

            else if (!button7.Enabled && !button8.Enabled && button9.Enabled && button7.Text == "O" && button8.Text == "O") { rndNum = 9; }
            else if (!button7.Enabled && !button9.Enabled && button8.Enabled && button7.Text == "O" && button9.Text == "O") { rndNum = 8; }
            else if (!button8.Enabled && !button9.Enabled && button7.Enabled && button8.Text == "O" && button9.Text == "O") { rndNum = 7; }

            else if (!button1.Enabled && !button4.Enabled && button7.Enabled && button1.Text == "O" && button4.Text == "O") { rndNum = 7; }
            else if (!button1.Enabled && !button7.Enabled && button4.Enabled && button1.Text == "O" && button7.Text == "O") { rndNum = 4; }
            else if (!button4.Enabled && !button7.Enabled && button1.Enabled && button4.Text == "O" && button7.Text == "O") { rndNum = 1; }

            else if (!button2.Enabled && !button5.Enabled && button8.Enabled && button2.Text == "O" && button5.Text == "O") { rndNum = 8; }
            else if (!button2.Enabled && !button8.Enabled && button5.Enabled && button2.Text == "O" && button8.Text == "O") { rndNum = 5; }
            else if (!button5.Enabled && !button8.Enabled && button2.Enabled && button5.Text == "O" && button8.Text == "O") { rndNum = 2; }

            else if (!button3.Enabled && !button6.Enabled && button9.Enabled && button3.Text == "O" && button6.Text == "O") { rndNum = 9; }
            else if (!button3.Enabled && !button9.Enabled && button6.Enabled && button3.Text == "O" && button9.Text == "O") { rndNum = 6; }
            else if (!button6.Enabled && !button9.Enabled && button3.Enabled && button6.Text == "O" && button9.Text == "O") { rndNum = 3; }

            else if (!button1.Enabled && !button5.Enabled && button9.Enabled && button1.Text == "O" && button5.Text == "O") { rndNum = 9; }
            else if (!button1.Enabled && !button9.Enabled && button5.Enabled && button1.Text == "O" && button9.Text == "O") { rndNum = 5; }
            else if (!button5.Enabled && !button9.Enabled && button1.Enabled && button5.Text == "O" && button9.Text == "O") { rndNum = 1; }

            else if (!button3.Enabled && !button5.Enabled && button7.Enabled && button3.Text == "O" && button5.Text == "O") { rndNum = 7; }
            else if (!button3.Enabled && !button7.Enabled && button5.Enabled && button3.Text == "O" && button7.Text == "O") { rndNum = 5; }
            else if (!button5.Enabled && !button7.Enabled && button3.Enabled && button5.Text == "O" && button7.Text == "O") { rndNum = 3; }

            else if (!button1.Enabled && !button2.Enabled && button3.Enabled && button1.Text == "X" && button2.Text == "X") { rndNum = 3; }
            else if (!button1.Enabled && !button3.Enabled && button2.Enabled && button1.Text == "X" && button3.Text == "X") { rndNum = 2; }
            else if (!button2.Enabled && !button3.Enabled && button1.Enabled && button2.Text == "X" && button3.Text == "X") { rndNum = 1; }

            else if (!button4.Enabled && !button5.Enabled && button6.Enabled && button4.Text == "X" && button5.Text == "X") { rndNum = 6; }
            else if (!button4.Enabled && !button6.Enabled && button5.Enabled && button4.Text == "X" && button6.Text == "X") { rndNum = 5; }
            else if (!button5.Enabled && !button6.Enabled && button4.Enabled && button5.Text == "X" && button6.Text == "X") { rndNum = 4; }

            else if (!button7.Enabled && !button8.Enabled && button9.Enabled && button7.Text == "X" && button8.Text == "X") { rndNum = 9; }
            else if (!button7.Enabled && !button9.Enabled && button8.Enabled && button7.Text == "X" && button9.Text == "X") { rndNum = 8; }
            else if (!button8.Enabled && !button9.Enabled && button7.Enabled && button8.Text == "X" && button9.Text == "X") { rndNum = 7; }

            else if (!button1.Enabled && !button4.Enabled && button7.Enabled && button1.Text == "X" && button4.Text == "X") { rndNum = 7; }
            else if (!button1.Enabled && !button7.Enabled && button4.Enabled && button1.Text == "X" && button7.Text == "X") { rndNum = 4; }
            else if (!button4.Enabled && !button7.Enabled && button1.Enabled && button4.Text == "X" && button7.Text == "X") { rndNum = 1; }

            else if (!button2.Enabled && !button5.Enabled && button8.Enabled && button2.Text == "X" && button5.Text == "X") { rndNum = 8; }
            else if (!button2.Enabled && !button8.Enabled && button5.Enabled && button2.Text == "X" && button8.Text == "X") { rndNum = 5; }
            else if (!button5.Enabled && !button8.Enabled && button2.Enabled && button5.Text == "X" && button8.Text == "X") { rndNum = 2; }

            else if (!button3.Enabled && !button6.Enabled && button9.Enabled && button3.Text == "X" && button6.Text == "X") { rndNum = 9; }
            else if (!button3.Enabled && !button9.Enabled && button6.Enabled && button3.Text == "X" && button9.Text == "X") { rndNum = 6; }
            else if (!button6.Enabled && !button9.Enabled && button3.Enabled && button6.Text == "X" && button9.Text == "X") { rndNum = 3; }

            else if (!button1.Enabled && !button5.Enabled && button9.Enabled && button1.Text == "X" && button5.Text == "X") { rndNum = 9; }
            else if (!button1.Enabled && !button9.Enabled && button5.Enabled && button1.Text == "X" && button9.Text == "X") { rndNum = 5; }
            else if (!button5.Enabled && !button9.Enabled && button1.Enabled && button5.Text == "X" && button9.Text == "X") { rndNum = 1; }

            else if (!button3.Enabled && !button5.Enabled && button7.Enabled && button3.Text == "X" && button5.Text == "X") { rndNum = 7; }
            else if (!button3.Enabled && !button7.Enabled && button5.Enabled && button3.Text == "X" && button7.Text == "X") { rndNum = 5; }
            else if (!button5.Enabled && !button7.Enabled && button3.Enabled && button5.Text == "X" && button7.Text == "X") { rndNum = 3; }

            else if (button1.Text == "X" && button3.Enabled && button7.Enabled && button9.Enabled && button2.Enabled && button4.Enabled && button5.Enabled && button6.Enabled && button8.Enabled) { rndNum = 5; }
            else if (button1.Enabled && button3.Text == "X" && button7.Enabled && button9.Enabled && button2.Enabled && button4.Enabled && button5.Enabled && button6.Enabled && button8.Enabled) { rndNum = 5; }
            else if (button1.Enabled && button3.Enabled && button7.Text == "X" && button9.Enabled && button2.Enabled && button4.Enabled && button5.Enabled && button6.Enabled && button8.Enabled) { rndNum = 5; }
            else if (button1.Enabled && button3.Enabled && button7.Enabled && button9.Text == "X" && button2.Enabled && button4.Enabled && button5.Enabled && button6.Enabled && button8.Enabled) { rndNum = 5; }
            else if (button5.Text == "X" && button1.Enabled && button2.Enabled && button3.Enabled && button4.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 1; }
            else if (button1.Text == "O" && button2.Enabled && button3.Enabled && button4.Enabled && button5.Text == "X" && button6.Enabled && button7.Enabled && button8.Enabled && button9.Text == "X") { rndNum = 3; }
            else if (button4.Text == "X" && button1.Enabled && button2.Enabled && button3.Enabled && button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 1; }
            else if (button4.Enabled && button1.Enabled && button2.Text == "X" && button3.Enabled && button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 3; }
            else if (button4.Enabled && button1.Enabled && button2.Enabled && button3.Enabled && button5.Enabled && button6.Text == "X" && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 9; }
            else if (button4.Enabled && button1.Enabled && button2.Enabled && button3.Enabled && button5.Enabled && button6.Enabled && button7.Enabled && button8.Text == "X" && button9.Enabled) { rndNum = 7; }
            else if (button1.Text == "X" && button2.Enabled && button3.Enabled && button4.Enabled && button5.Text == "O" && button6.Enabled && button7.Enabled && button8.Text == "X" && button9.Enabled) { rndNum = 7; }
            else if (button1.Text == "X" && button5.Text == "O" && button9.Text == "X" && button3.Enabled && button7.Enabled && button2.Enabled && button4.Enabled && button6.Enabled && button8.Enabled) { rndNum = 6; }
            else if (button1.Enabled && button2.Text == "X" && button3.Enabled && button4.Enabled && button5.Text == "O" && button6.Enabled && button7.Enabled && button8.Enabled && button9.Text == "X") { rndNum = 6; }
            else if (button1.Enabled && button2.Text == "X" && button3.Enabled && button4.Text == "X" && button5.Text == "O" && button6.Text == "O" && button7.Enabled && button8.Enabled && button9.Text == "X") { rndNum = 7; }
            else if (button1.Enabled && button2.Text == "X" && button3.Enabled && button4.Enabled && button5.Text == "O" && button6.Enabled && button7.Text == "X" && button8.Enabled && button9.Enabled) { rndNum = 4; }
            else if (button1.Enabled && button2.Enabled && button3.Text == "X" && button4.Enabled && button5.Text == "O" && button6.Enabled && button7.Enabled && button8.Text == "X" && button9.Enabled) { rndNum = 6; }
            else if (button3.Text == "X" && button5.Text == "O" && button7.Text == "X" && button1.Enabled && button9.Enabled && button2.Enabled && button4.Enabled && button6.Enabled && button8.Enabled) { rndNum = 4; }
            else if (button1.Enabled && button2.Enabled && button3.Enabled && button4.Enabled && button5.Text == "O" && button6.Text == "X" && button7.Text == "X" && button8.Enabled && button9.Enabled) { rndNum = 9; }
            else if (button1.Text == "X" && button2.Enabled && button3.Enabled && button4.Enabled && button5.Text == "O" && button6.Text == "X" && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 3; }
            else if (button1.Enabled && button2.Enabled && button3.Enabled && button4.Text == "X" && button5.Text == "O" && button6.Enabled && button7.Enabled && button8.Enabled && button9.Text == "X") { rndNum = 7; }
            else if (button1.Enabled && button2.Enabled && button3.Text == "X" && button4.Text == "X" && button5.Text == "O" && button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 1; }
            else if (button1.Text == "O" && button2.Text == "X" && button3.Enabled && button4.Text == "X" && button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 5; }
            else if (button1.Text == "O" && button2.Enabled && button3.Enabled && button4.Text == "X" && button5.Enabled && button6.Enabled && button7.Enabled && button8.Text == "X" && button9.Enabled) { rndNum = 5; }
            else if (button1.Text == "O" && button2.Enabled && button3.Enabled && button4.Text == "X" && button5.Enabled && button6.Enabled && button7.Text == "X" && button8.Enabled && button9.Enabled) { rndNum = 5; }
            else if (button1.Text == "O" && button2.Enabled && button3.Enabled && button4.Text == "X" && button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Text == "X") { rndNum = 5; }
            else if (button1.Text == "O" && button2.Enabled && button3.Text == "X" && button4.Text == "X" && button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 5; }

            else if (button1.Enabled && button2.Text == "X" && button3.Text == "O" && button4.Enabled && button5.Enabled && button6.Text == "X" && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 5; }
            else if (button1.Enabled && button2.Text == "X" && button3.Text == "O" && button4.Text == "X" && button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 5; }
            else if (button1.Text == "X" && button2.Text == "X" && button3.Text == "O" && button4.Enabled && button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 5; }
            else if (button1.Enabled && button2.Text == "X" && button3.Text == "O" && button4.Enabled && button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Text == "X") { rndNum = 5; }
            else if (button1.Enabled && button2.Text == "X" && button3.Text == "O" && button4.Enabled && button5.Enabled && button6.Enabled && button7.Text == "X" && button8.Enabled && button9.Enabled) { rndNum = 5; }

            else if (button1.Enabled && button2.Enabled && button3.Enabled && button4.Enabled && button5.Enabled && button6.Text == "X" && button7.Enabled && button8.Text == "X" && button9.Text == "O") { rndNum = 5; }
            else if (button1.Enabled && button2.Text == "X" && button3.Enabled && button4.Enabled && button5.Enabled && button6.Text == "X" && button7.Enabled && button8.Enabled && button9.Text == "O") { rndNum = 5; }
            else if (button1.Enabled && button2.Enabled && button3.Text == "X" && button4.Enabled && button5.Enabled && button6.Text == "X" && button7.Enabled && button8.Enabled && button9.Text == "O") { rndNum = 5; }
            else if (button1.Text == "X" && button2.Enabled && button3.Enabled && button4.Enabled && button5.Enabled && button6.Text == "X" && button7.Enabled && button8.Enabled && button9.Text == "O") { rndNum = 5; }
            else if (button1.Enabled && button2.Enabled && button3.Enabled && button4.Enabled && button5.Enabled && button6.Text == "X" && button7.Text == "X" && button8.Enabled && button9.Text == "O") { rndNum = 5; }

            else if (button1.Enabled && button2.Enabled && button3.Enabled && button4.Text == "X" && button5.Enabled && button6.Enabled && button7.Text == "O" && button8.Text == "X" && button9.Enabled) { rndNum = 5; }
            else if (button1.Enabled && button2.Enabled && button3.Enabled && button4.Enabled && button5.Enabled && button6.Text == "X" && button7.Text == "O" && button8.Text == "X" && button9.Enabled) { rndNum = 5; }
            else if (button1.Enabled && button2.Enabled && button3.Enabled && button4.Enabled && button5.Enabled && button6.Enabled && button7.Text == "O" && button8.Text == "X" && button9.Text == "X") { rndNum = 5; }
            else if (button1.Enabled && button2.Enabled && button3.Text == "X" && button4.Enabled && button5.Enabled && button6.Enabled && button7.Text == "O" && button8.Text == "X" && button9.Enabled) { rndNum = 5; }
            else if (button1.Text == "X" && button2.Enabled && button3.Enabled && button4.Enabled && button5.Enabled && button6.Enabled && button7.Text == "O" && button8.Text == "X" && button9.Enabled) { rndNum = 5; }

            else if (!button1.Enabled && button3.Enabled && button7.Enabled && button9.Enabled && button2.Enabled && button4.Enabled && button5.Enabled && button6.Enabled && button8.Enabled) { rndNum = 5; }
            else if (button1.Enabled && !button3.Enabled && button7.Enabled && button9.Enabled && button2.Enabled && button4.Enabled && button5.Enabled && button6.Enabled && button8.Enabled) { rndNum = 5; }
            else if (button1.Enabled && button3.Enabled && !button7.Enabled && button9.Enabled && button2.Enabled && button4.Enabled && button5.Enabled && button6.Enabled && button8.Enabled) { rndNum = 5; }
            else if (button1.Enabled && button3.Enabled && button7.Enabled && !button9.Enabled && button2.Enabled && button4.Enabled && button5.Enabled && button6.Enabled && button8.Enabled) { rndNum = 5; }
            else if (!button5.Enabled && button1.Enabled && button2.Enabled && button3.Enabled && button4.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 1; }
            else if (!button4.Enabled && button1.Enabled && button2.Enabled && button3.Enabled && button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 1; }
            else if (button4.Enabled && button1.Enabled && !button2.Enabled && button3.Enabled && button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 3; }
            else if (button4.Enabled && button1.Enabled && button2.Enabled && button3.Enabled && button5.Enabled && !button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 9; }
            else if (button4.Enabled && button1.Enabled && button2.Enabled && button3.Enabled && button5.Enabled && button6.Enabled && button7.Enabled && !button8.Enabled && button9.Enabled) { rndNum = 7; }
            else if (!button1.Enabled && button2.Enabled && button3.Enabled && button4.Enabled && !button5.Enabled && button6.Enabled && button7.Enabled && !button8.Enabled && button9.Enabled) { rndNum = 7; }
            else if (!button1.Enabled && !button5.Enabled && !button9.Enabled && button3.Enabled && button7.Enabled && button2.Enabled && button4.Enabled && button6.Enabled && button8.Enabled) { rndNum = 6; }
            else if (button1.Enabled && !button2.Enabled && button3.Enabled && button4.Enabled && !button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && !button9.Enabled) { rndNum = 6; }
            else if (button1.Enabled && !button2.Enabled && button3.Enabled && button4.Enabled && !button5.Enabled && button6.Enabled && !button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 4; }
            else if (button1.Enabled && button2.Enabled && !button3.Enabled && button4.Enabled && !button5.Enabled && button6.Enabled && button7.Enabled && !button8.Enabled && button9.Enabled) { rndNum = 6; }
            else if (!button3.Enabled && !button5.Enabled && !button7.Enabled && button1.Enabled && button9.Enabled && button2.Enabled && button4.Enabled && button6.Enabled && button8.Enabled) { rndNum = 4; }
            else if (button1.Enabled && button2.Enabled && button3.Enabled && button4.Enabled && !button5.Enabled && !button6.Enabled && !button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 9; }
            else if (!button1.Enabled && button2.Enabled && button3.Enabled && button4.Enabled && !button5.Enabled && !button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 3; }
            else if (button1.Enabled && button2.Enabled && button3.Enabled && !button4.Enabled && !button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && !button9.Enabled) { rndNum = 7; }
            else if (button1.Enabled && button2.Enabled && !button3.Enabled && !button4.Enabled && !button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 1; }
            else if (!button1.Enabled && !button2.Enabled && button3.Enabled && !button4.Enabled && button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 5; }
            else if (!button1.Enabled && button2.Enabled && button3.Enabled && !button4.Enabled && button5.Enabled && button6.Enabled && button7.Enabled && !button8.Enabled && button9.Enabled) { rndNum = 5; }
            else if (!button1.Enabled && button2.Enabled && button3.Enabled && !button4.Enabled && button5.Enabled && button6.Enabled && !button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 5; }
            else if (button1.Enabled && !button2.Enabled && !button3.Enabled && button4.Enabled && button5.Enabled && !button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 5; }
            else if (button1.Enabled && !button2.Enabled && !button3.Enabled && !button4.Enabled && button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 5; }
            else if (!button1.Enabled && !button2.Enabled && !button3.Enabled && button4.Enabled && button5.Enabled && button6.Enabled && button7.Enabled && button8.Enabled && button9.Enabled) { rndNum = 5; }
            else if (button1.Enabled && button2.Enabled && button3.Enabled && button4.Enabled && button5.Enabled && !button6.Enabled && button7.Enabled && !button8.Enabled && !button9.Enabled) { rndNum = 5; }
            else if (button1.Enabled && !button2.Enabled && button3.Enabled && button4.Enabled && button5.Enabled && !button6.Enabled && button7.Enabled && button8.Enabled && !button9.Enabled) { rndNum = 5; }
            else if (button1.Enabled && button2.Enabled && !button3.Enabled && button4.Enabled && button5.Enabled && !button6.Enabled && button7.Enabled && button8.Enabled && !button9.Enabled) { rndNum = 5; }
            else if (button1.Enabled && button2.Enabled && button3.Enabled && !button4.Enabled && button5.Enabled && button6.Enabled && !button7.Enabled && !button8.Enabled && button9.Enabled) { rndNum = 5; }
            else if (button1.Enabled && button2.Enabled && button3.Enabled && button4.Enabled && button5.Enabled && !button6.Enabled && !button7.Enabled && !button8.Enabled && button9.Enabled) { rndNum = 5; }
            else if (button1.Enabled && button2.Enabled && button3.Enabled && button4.Enabled && button5.Enabled && button6.Enabled && !button7.Enabled && !button8.Enabled && !button9.Enabled) { rndNum = 5; }

            else { rndNum = randomNum.Next(1, 10); }
        }
//-------------------------------------------------------------------------------------------------------------------
        //METHODE RANDOM CLICK
        public void RandomClick() 
        {
                checkClick(); 
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button && ctrl.Name == "button" + rndNum.ToString())
                    {
                        btn = (Button)(ctrl); 
                        break;
                    }
                }
                while (btn.Enabled==false) 
                {
                    checkClick();
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is Button && ctrl.Name == "button" + rndNum.ToString())
                        {
                            btn = (Button)(ctrl);
                            break;
                        }
                    }
                }
            
            btn.PerformClick();
        }
//-------------------------------------------------------------------------------------------------------------------     
        //METHODE CLEAR GAME
        public void cleargame()
        {
            timer2.Stop();
            timer3.Stop();
            i = 1;
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.Text = "";
            button1.Enabled = true;
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button2.Text = "";
            button2.Enabled = true;
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Black;
            button3.Text = "";
            button3.Enabled = true;
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Black;
            button4.Text = "";
            button4.Enabled = true;
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Black;
            button5.Text = "";
            button5.Enabled = true;
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Black;
            button6.Text = "";
            button6.Enabled = true;
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Black;
            button7.Text = "";
            button7.Enabled = true;
            button8.BackColor = Color.White;
            button8.ForeColor = Color.Black;
            button8.Text = "";
            button8.Enabled = true;
            button9.BackColor = Color.White;
            button9.ForeColor = Color.Black;
            button9.Text = "";
            button9.Enabled = true;
            the_turn_of();   
        }
//-------------------------------------------------------------------------------------------------------------------
        //METHODE TURN
        public void the_turn_of()
        {
            if (turn % 2 != 0)
            {
                textBox2.Text = p1;
            }
            else
            {
                textBox2.Text = p2;
                if (f2.checkBox1.Checked && (button1.Text == "" || button2.Text == "" || button3.Text == "" || button4.Text == "" || button5.Text == "" || button6.Text == "" || button7.Text == "" || button8.Text == "" || button9.Text == ""))
                {
                    RandomClick();
                }
            }
            if (!button1.Enabled && !button2.Enabled && !button3.Enabled && !button4.Enabled && !button5.Enabled && !button6.Enabled && !button7.Enabled && !button8.Enabled && !button9.Enabled)
            {
                timer1.Stop();
                timer3.Start();
            }
        }
//-------------------------------------------------------------------------------------------------------------------
        //METHODE CHECK THE WINNER

        //HORIZENTAL-----------------------------------------------------------
        //1st horizontal Line 1-2-3
        public void checkhorizontalLigne1()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                if (button1.Text == button2.Text && button1.Text == button3.Text)
                {
                    timer1.Stop();
                    timer2.Start();
                    /*button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button2.BackColor = Color.Green;
                    button2.ForeColor = Color.White;
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;*/
                    
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("CONGRATULATION " + p1 + "\n YOU WON !");
                        player1++;
                        textBox4.Text = player1.ToString();
                        turn = 1;
                    }
                    else
                    {
                        MessageBox.Show("CONGRATULATION " + p2 + "\n YOU WON !");
                        player2++;
                        textBox3.Text = player2.ToString();
                        turn = 0;
                        if (f2.checkBox1.Checked)
                        {
                            countdown();
                        }
                    }
                    cleargame();
                }
            }
        }

        //2nd horizontal Line 4-5-6
            public void checkhorizontalLigne2()
            {
                if (button4.Text != "" && button5.Text != "" && button6.Text != "")
                {
                    if (button4.Text == button5.Text && button4.Text == button6.Text)
                    {
                        timer1.Stop();
                        timer2.Start();
                        /*button4.BackColor = Color.Green;
                        button4.ForeColor = Color.White;
                        button5.BackColor = Color.Green;
                        button5.ForeColor = Color.White;
                        button6.BackColor = Color.Green;
                        button6.ForeColor = Color.White;*/
                        if (button4.Text == "X")
                        {
                            MessageBox.Show("CONGRATULATION " + p1 + "\n YOU WON !");
                            player1++;
                            textBox4.Text = player1.ToString();
                            turn = 1;
                        }
                        else
                        {
                            MessageBox.Show("CONGRATULATION " + p2 + "\n YOU WON !");
                            player2++;
                            textBox3.Text = player2.ToString();
                            turn = 0;
                            if (f2.checkBox1.Checked)
                            {
                                countdown();
                            }
                        }
                        cleargame();
                    }
                }
            }

            //3rd horizontal Line 7-8-9
            public void checkhorizontalLigne3()
            {
                if (button7.Text != "" && button8.Text != "" && button9.Text != "")
                {
                    if (button7.Text == button8.Text && button7.Text == button9.Text)
                    {
                        timer1.Stop();
                        timer2.Start();
                        /*button7.BackColor = Color.Green;
                        button7.ForeColor = Color.White;
                        button8.BackColor = Color.Green;
                        button8.ForeColor = Color.White;
                        button9.BackColor = Color.Green;
                        button9.ForeColor = Color.White;*/
                        if (button7.Text == "X")
                        {
                            MessageBox.Show("CONGRATULATION " + p1 + "\n YOU WON !");
                            player1++;
                            textBox4.Text = player1.ToString();
                            turn = 1;
                        }
                        else
                        {
                            MessageBox.Show("CONGRATULATION " + p2 + "\n YOU WON !");
                            player2++;
                            textBox3.Text = player2.ToString();
                            turn = 0;
                            if (f2.checkBox1.Checked)
                            {
                                countdown();
                            }
                        }
                        cleargame();
                    }
                }
            }
            //VERTICAL-----------------------------------------------------------
            //1st vertical line 1-4-7
            public void checkverticalLigne1()
            {
                if (button1.Text != "" && button4.Text != "" && button7.Text != "")
                {
                    if (button1.Text == button4.Text && button1.Text == button7.Text)
                    {
                        timer1.Stop();
                        timer2.Start();
                        /*button1.BackColor = Color.Green;
                        button1.ForeColor = Color.White;
                        button4.BackColor = Color.Green;
                        button4.ForeColor = Color.White;
                        button7.BackColor = Color.Green;
                        button7.ForeColor = Color.White;*/
                        if (button1.Text == "X")
                        {
                            MessageBox.Show("CONGRATULATION " + p1 + "\n YOU WON !");
                            player1++;
                            textBox4.Text = player1.ToString();
                            turn = 1;
                        }
                        else
                        {
                            MessageBox.Show("CONGRATULATION " + p2 + "\n YOU WON !");
                            player2++;
                            textBox3.Text = player2.ToString();
                            turn = 0;
                            if (f2.checkBox1.Checked)
                            {
                                countdown();
                            }
                        }
                        cleargame();
                    }
                }
            }

            //2nd vertical line 2-5-8
            public void checkverticalLigne2()
            {
                if (button2.Text != "" && button5.Text != "" && button8.Text != "")
                {
                    if (button2.Text == button5.Text && button2.Text == button8.Text)
                    {
                        timer1.Stop();
                        timer2.Start();
                        /*button2.BackColor = Color.Green;
                        button2.ForeColor = Color.White;
                        button5.BackColor = Color.Green;
                        button5.ForeColor = Color.White;
                        button8.BackColor = Color.Green;
                        button8.ForeColor = Color.White;*/
                        if (button2.Text == "X")
                        {
                            MessageBox.Show("CONGRATULATION " + p1 + "\n YOU WON !");
                            player1++;
                            textBox4.Text = player1.ToString();
                            turn = 1;
                        }
                        else
                        {
                            MessageBox.Show("CONGRATULATION " + p2 + "\n YOU WON !");
                            player2++;
                            textBox3.Text = player2.ToString();
                            turn = 0;
                            if (f2.checkBox1.Checked)
                            {
                                countdown();
                            }
                        }
                        cleargame();
                    }
                }
            }

            //3rd vertical line
            public void checkverticalLigne3()
            {
                if (button3.Text != "" && button6.Text != "" && button9.Text != "")
                {
                    if (button3.Text == button6.Text && button3.Text == button9.Text)
                    {
                        timer1.Stop();
                        timer2.Start();
                        /*button3.BackColor = Color.Green;
                        button3.ForeColor = Color.White;
                        button6.BackColor = Color.Green;
                        button6.ForeColor = Color.White;
                        button9.BackColor = Color.Green;
                        button9.ForeColor = Color.White;*/
                        if (button3.Text == "X")
                        {
                            MessageBox.Show("CONGRATULATION " + p1 + "\n YOU WON !");
                            player1++;
                            textBox4.Text = player1.ToString();
                            turn = 1;
                        }
                        else
                        {
                            MessageBox.Show("CONGRATULATION " + p2 + "\n YOU WON !");
                            player2++;
                            textBox3.Text = player2.ToString();
                            turn = 0;
                            if (f2.checkBox1.Checked)
                            {
                                countdown();
                            }
                        }
                        cleargame();
                    }
                }
            }
            //DIAGONAL-----------------------------------------------------------
            //1st line Diagonal 1-5-9
             public void checkDiagonalLigne1()
            {
                if (button1.Text != "" && button5.Text != "" && button9.Text != "")
                {
                    if (button1.Text == button5.Text && button1.Text == button9.Text)
                    {
                        timer1.Stop();
                        timer2.Start();
                        /*button1.BackColor = Color.Green;
                        button1.ForeColor = Color.White;
                        button5.BackColor = Color.Green;
                        button5.ForeColor = Color.White;
                        button9.BackColor = Color.Green;
                        button9.ForeColor = Color.White;*/
                        if (button1.Text == "X")
                        {
                            MessageBox.Show("CONGRATULATION " + p1 + "\n YOU WON !");
                            player1++;
                            textBox4.Text = player1.ToString();
                            turn = 1;
                        }
                        else
                        {
                            MessageBox.Show("CONGRATULATION " + p2 + "\n YOU WON !");
                            player2++;
                            textBox3.Text = player2.ToString();
                            turn = 0;
                            if (f2.checkBox1.Checked)
                            {
                                countdown();
                            }
                        }
                        cleargame();
                    }
                }
             }

             //2nd line Diagonal 3-5-7
            public void checkDiagonalLigne2()
            {
                if (button3.Text != "" && button5.Text != "" && button7.Text != "")
                {
                    if (button3.Text == button5.Text && button3.Text == button7.Text)
                    {
                        timer1.Stop();
                        timer2.Start();
                       /* button3.BackColor = Color.Green;
                        button3.ForeColor = Color.White;
                        button5.BackColor = Color.Green;
                        button5.ForeColor = Color.White;
                        button7.BackColor = Color.Green;
                        button7.ForeColor = Color.White;*/
                        if (button3.Text == "X")
                        {
                            MessageBox.Show("CONGRATULATION " + p1 + "\n YOU WON !");
                            player1++;
                            textBox4.Text = player1.ToString();
                            turn = 1;
                        }
                        else
                        {
                            MessageBox.Show("CONGRATULATION " + p2 + "\n YOU WON !");
                            player2++;
                            textBox3.Text = player2.ToString();
                            turn = 0;
                            if (f2.checkBox1.Checked)
                            {
                                countdown();
                            }
                        }
                        cleargame();
                      }
                   }
                }
//-------------------------------------------------------------------------------------------------------------------
        //BUTTON 1
        private void button1_Click(object sender, EventArgs e)
        {
                if (turn % 2 != 0)
                {
                    button1.Text = "X";
                }
                else
                {
                    button1.Text = "O";
                }
                turn++;
                button1.Enabled = false;
                countdown();
            checkhorizontalLigne1();
            checkhorizontalLigne2();
            checkhorizontalLigne3();
            checkverticalLigne1();
            checkverticalLigne2();
            checkverticalLigne3();
            checkDiagonalLigne1();
            checkDiagonalLigne2();
            the_turn_of();
        }
        //BUTTON 2
        private void button2_Click(object sender, EventArgs e)
        {
            if (turn % 2 != 0)
                {
                    button2.Text = "X";
                }
                else
                {
                    button2.Text = "O";
                }
                turn++;
                button2.Enabled = false;
                countdown();
            checkhorizontalLigne1();
            checkhorizontalLigne2();
            checkhorizontalLigne3();
            checkverticalLigne1();
            checkverticalLigne2();
            checkverticalLigne3();
            checkDiagonalLigne1();
            checkDiagonalLigne2();
            the_turn_of();
        }
        //BUTTON 3
        private void button3_Click(object sender, EventArgs e)
        {
            if (turn % 2 != 0)
                {
                    button3.Text = "X";
                }
                else
                {
                    button3.Text = "O";
                }
            turn++;
            button3.Enabled = false;
            countdown();
            checkhorizontalLigne1();
            checkhorizontalLigne2();
            checkhorizontalLigne3();
            checkverticalLigne1();
            checkverticalLigne2();
            checkverticalLigne3();
            checkDiagonalLigne1();
            checkDiagonalLigne2();
            the_turn_of();
        }
        //BUTTON 4
        private void button4_Click(object sender, EventArgs e)
        {
            if (turn % 2 != 0)
                {
                    button4.Text = "X";
                }
                else
                {
                    button4.Text = "O";
                }
            turn++;
            button4.Enabled = false;
            countdown();
            checkhorizontalLigne1();
            checkhorizontalLigne2();
            checkhorizontalLigne3();
            checkverticalLigne1();
            checkverticalLigne2();
            checkverticalLigne3();
            checkDiagonalLigne1();
            checkDiagonalLigne2();
            the_turn_of();
        }
        //BUTTON 5
        private void button5_Click(object sender, EventArgs e)
        {
                if (turn % 2 != 0)
                {
                    button5.Text = "X";
                }
                else
                {
                    button5.Text = "O";
                }
                turn++;
                button5.Enabled = false;
                countdown();
                checkhorizontalLigne1();
                checkhorizontalLigne2();
                checkhorizontalLigne3();
                checkverticalLigne1();
                checkverticalLigne2();
                checkverticalLigne3();
                checkDiagonalLigne1();
                checkDiagonalLigne2();
                the_turn_of();
        }
        //BUTTON 6
        private void button6_Click(object sender, EventArgs e)
        {
                if (turn % 2 != 0)
                {
                    button6.Text = "X";
                }
                else
                {
                    button6.Text = "O";
                }
                turn++;
                button6.Enabled = false;
                countdown();
                checkhorizontalLigne1();
                checkhorizontalLigne2();
                checkhorizontalLigne3();
                checkverticalLigne1();
                checkverticalLigne2();
                checkverticalLigne3();
                checkDiagonalLigne1();
                checkDiagonalLigne2();
                the_turn_of();
        }
        //BUTTON 7
        private void button7_Click(object sender, EventArgs e)
        {
                if (turn % 2 != 0)
                {
                    button7.Text = "X";
                }
                else
                {
                    button7.Text = "O";
                }
                turn++;
                button7.Enabled = false;
                countdown();
                checkhorizontalLigne1();
                checkhorizontalLigne2();
                checkhorizontalLigne3();
                checkverticalLigne1();
                checkverticalLigne2();
                checkverticalLigne3();
                checkDiagonalLigne1();
                checkDiagonalLigne2();
                the_turn_of();
        }
        //BUTTON 8
        private void button8_Click(object sender, EventArgs e)
        {
                if (turn % 2 != 0)
                {
                    button8.Text = "X";
                }
                else
                {
                    button8.Text = "O";
                }
                turn++;
                button8.Enabled = false;
                countdown();
                checkhorizontalLigne1();
                checkhorizontalLigne2();
                checkhorizontalLigne3();
                checkverticalLigne1();
                checkverticalLigne2();
                checkverticalLigne3();
                checkDiagonalLigne1();
                checkDiagonalLigne2();
                the_turn_of();
        }
        //BUTTON 9
        private void button9_Click(object sender, EventArgs e)
        {
                if (turn % 2 != 0)
                {
                    button9.Text = "X";
                }
                else
                {
                    button9.Text = "O";
                }
                turn++;
                button9.Enabled = false;
                countdown();
                checkhorizontalLigne1();
                checkhorizontalLigne2();
                checkhorizontalLigne3();
                checkverticalLigne1();
                checkverticalLigne2();
                checkverticalLigne3();
                checkDiagonalLigne1();
                checkDiagonalLigne2();
                the_turn_of();
        }
//-------------------------------------------------------------------------------------------------------------------
        //RESET GAME
        private void button10_Click(object sender, EventArgs e)
        {
            cleargame();
            turn = 1;
            player1 = 0;
            player2 = 0;
            textBox2.Text = p1;
            textBox3.Text = "0";
            textBox4.Text = "0";
            resetcountdown();
            timer1.Stop();
        }
//-------------------------------------------------------------------------------------------------------------------
        //PLAY AGAIN
        private void button11_Click(object sender, EventArgs e)
        {
            cleargame();
            textBox2.Text = p1;
            resetcountdown();
            if(f2.checkBox1.Checked)
            countdown();
        }
//-------------------------------------------------------------------------------------------------------------------
        //FORM LOADING
        private void Form1_Load(object sender, EventArgs e)
        {
            f2.ShowDialog();
            p1 = f2.textBox1.Text.ToUpper();
            if (f2.checkBox1.Checked) { p2 = "Computer".ToUpper(); } else p2 = f2.textBox2.Text.ToUpper();
            textBox2.Text = p1;
            textBox5.Text = p1;
            textBox6.Text = p2;
            timeLeft = (int)f2.numericUpDown1.Value;
            if (timeLeft < 10)
                label1.Text = "0" + timeLeft + " s";
            else label1.Text = timeLeft + " s";
            cleargame();
        }
        //EXIT
        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!f2.checkBox2.Checked)
            {
                if (timeLeft > 0)
                {
                    timeLeft -= 1;
                    if (timeLeft < 10)
                        label1.Text = "0" + timeLeft + " s";
                    else label1.Text = timeLeft + " s";
                    if (timeLeft == 3) { label2.Text = "TIME OUT :"; label2.ForeColor = Color.Red; label1.ForeColor = Color.Red; }
                }
                else
                {
                    timer1.Stop();
                    if (textBox2.Text == p1)
                    {
                        MessageBox.Show("YOU LOST !");
                        player2++;
                        textBox3.Text = player2.ToString();
                        turn = 0;
                    }
                    else
                    {
                        MessageBox.Show("YOU LOST !");
                        player1++;
                        textBox4.Text = player1.ToString();
                        turn = 1;
                    }
                    cleargame();
                    resetcountdown();
                }
            }
            else 
            {
                timer1.Stop();
            }
        }
        //COUNT DOWN
        public void countdown() 
        {
            timer1.Stop();
            timeLeft = (int)f2.numericUpDown1.Value;
            label1.Text = timeLeft.ToString() + " s";
            label1.ForeColor = Color.Green;
            label2.Text = "Time :";
            label2.ForeColor = Color.Green;
            timer1.Start();
        }
        //RESET COUNT DOWN
        public void resetcountdown() 
        {
            timer1.Stop();
            timeLeft = (int)f2.numericUpDown1.Value;
            label1.Text = timeLeft.ToString() + " s";
            label1.ForeColor = Color.Green;
            label2.Text = "Time :";
            label2.ForeColor = Color.Green;
        }
        //ANIMATION
        int i = 1;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                if (button1.Text == button2.Text && button1.Text == button3.Text)
                {
                    if (i == 1)
                        button1.BackColor = Color.Red;
                    if (i == 2)
                        button2.BackColor = Color.Red;
                    if (i == 3)
                        button3.BackColor = Color.Red;
                    if (i == 6)
                        button1.BackColor = Color.Blue;
                    if (i == 5)
                        button2.BackColor = Color.Blue;
                    if (i == 4)
                        button3.BackColor = Color.Blue;
                    if (i == 7)
                        button1.BackColor = Color.Green;
                    if (i == 8)
                        button2.BackColor = Color.Green;
                    if (i == 9)
                        button3.BackColor = Color.Green;
                }
            }

            if (button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                if (button4.Text == button5.Text && button4.Text == button6.Text)
                {
                    if (i == 1)
                        button4.BackColor = Color.Red;
                    if (i == 2)
                        button5.BackColor = Color.Red;
                    if (i == 3)
                        button6.BackColor = Color.Red;
                    if (i == 6)
                        button4.BackColor = Color.Blue;
                    if (i == 5)
                        button5.BackColor = Color.Blue;
                    if (i == 4)
                        button6.BackColor = Color.Blue;
                    if (i == 7)
                        button4.BackColor = Color.Green;
                    if (i == 8)
                        button5.BackColor = Color.Green;
                    if (i == 9)
                        button6.BackColor = Color.Green;
                }
            }

            if (button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if (button7.Text == button8.Text && button7.Text == button9.Text)
                {
                    if (i == 1)
                        button7.BackColor = Color.Red;
                    if (i == 2)
                        button8.BackColor = Color.Red;
                    if (i == 3)
                        button9.BackColor = Color.Red;
                    if (i == 6)
                        button7.BackColor = Color.Blue;
                    if (i == 5)
                        button8.BackColor = Color.Blue;
                    if (i == 4)
                        button9.BackColor = Color.Blue;
                    if (i == 7)
                        button7.BackColor = Color.Green;
                    if (i == 8)
                        button8.BackColor = Color.Green;
                    if (i == 9)
                        button9.BackColor = Color.Green;
                }
            }

            if (button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                if (button1.Text == button4.Text && button1.Text == button7.Text)
                {
                    if (i == 1)
                        button1.BackColor = Color.Red;
                    if (i == 2)
                        button4.BackColor = Color.Red;
                    if (i == 3)
                        button7.BackColor = Color.Red;
                    if (i == 6)
                        button1.BackColor = Color.Blue;
                    if (i == 5)
                        button4.BackColor = Color.Blue;
                    if (i == 4)
                        button7.BackColor = Color.Blue;
                    if (i == 7)
                        button1.BackColor = Color.Green;
                    if (i == 8)
                        button4.BackColor = Color.Green;
                    if (i == 9)
                        button7.BackColor = Color.Green;
                }
            }

            if (button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                if (button2.Text == button5.Text && button2.Text == button8.Text)
                {
                    if (i == 1)
                        button2.BackColor = Color.Red;
                    if (i == 2)
                        button5.BackColor = Color.Red;
                    if (i == 3)
                        button8.BackColor = Color.Red;
                    if (i == 6)
                        button2.BackColor = Color.Blue;
                    if (i == 5)
                        button5.BackColor = Color.Blue;
                    if (i == 4)
                        button8.BackColor = Color.Blue;
                    if (i == 7)
                        button2.BackColor = Color.Green;
                    if (i == 8)
                        button5.BackColor = Color.Green;
                    if (i == 9)
                        button8.BackColor = Color.Green;
                }
            }

            if (button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                if (button3.Text == button6.Text && button3.Text == button9.Text)
                {
                    if (i == 1)
                        button3.BackColor = Color.Red;
                    if (i == 2)
                        button6.BackColor = Color.Red;
                    if (i == 3)
                        button9.BackColor = Color.Red;
                    if (i == 6)
                        button3.BackColor = Color.Blue;
                    if (i == 5)
                        button6.BackColor = Color.Blue;
                    if (i == 4)
                        button9.BackColor = Color.Blue;
                    if (i == 7)
                        button3.BackColor = Color.Green;
                    if (i == 8)
                        button6.BackColor = Color.Green;
                    if (i == 9)
                        button9.BackColor = Color.Green;
                }
            }

            if (button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                if (button1.Text == button5.Text && button1.Text == button9.Text)
                {
                    if (i == 1)
                        button1.BackColor = Color.Red;
                    if (i == 2)
                        button5.BackColor = Color.Red;
                    if (i == 3)
                        button9.BackColor = Color.Red;
                    if (i == 6)
                        button1.BackColor = Color.Blue;
                    if (i == 5)
                        button5.BackColor = Color.Blue;
                    if (i == 4)
                        button9.BackColor = Color.Blue;
                    if (i == 7)
                        button1.BackColor = Color.Green;
                    if (i == 8)
                        button5.BackColor = Color.Green;
                    if (i == 9)
                        button9.BackColor = Color.Green;
                }
            }

            if (button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                if (button3.Text == button5.Text && button3.Text == button7.Text)
                {
                    if (i == 1)
                        button3.BackColor = Color.Red;
                    if (i == 2)
                        button5.BackColor = Color.Red;
                    if (i == 3)
                        button7.BackColor = Color.Red;
                    if (i == 6)
                        button3.BackColor = Color.Blue;
                    if (i == 5)
                        button5.BackColor = Color.Blue;
                    if (i == 4)
                        button7.BackColor = Color.Blue;
                    if (i == 7)
                        button3.BackColor = Color.Green;
                    if (i == 8)
                        button5.BackColor = Color.Green;
                    if (i == 9)
                        button7.BackColor = Color.Green;
                }
            }
            
            i++;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (!button1.Enabled && !button2.Enabled && !button3.Enabled && !button4.Enabled && !button5.Enabled && !button6.Enabled && !button7.Enabled && !button8.Enabled && !button9.Enabled)
            {
                if (i == 1)
                {
                    button1.Text = "";
                    button1.BackColor = Color.White;
                }
                if (i == 2)
                {
                    button2.Text = "";
                    button2.BackColor = Color.Yellow;
                }
                if (i == 3)
                {
                    button3.Text = "";
                    button3.BackColor = Color.Orange;
                }
                if (i == 4)
                {
                    button6.Text = "";
                    button6.BackColor = Color.Red;
                }
                if (i == 5)
                {
                    button9.Text = "";
                    button9.BackColor = Color.Pink;
                }
                if (i == 6)
                {
                    button8.Text = "";
                    button8.BackColor = Color.Purple;
                }
                if (i == 7)
                {
                    button7.Text = "";
                    button7.BackColor = Color.Blue;
                }
                if (i == 8)
                {
                    button4.Text = "";
                    button4.BackColor = Color.Green;
                }
                if (i == 9)
                {
                    button5.Text = "";
                    button5.BackColor = Color.Black;
                }
            }
            i++;
        }
    }
}
