using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinderAdventure.net
{
    public partial class tinderAdventure : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;

        Random randGen = new Random();
        int randomValue;

        public tinderAdventure()
        {
            InitializeComponent();
            // Display initial message and options
            outputLabel.Text = "You downloaded Tinder as a joke but have now found yourself\n very lonely. Do you want to start your adventure with Tinder?";

            option1Label.Text = "Yes";
            option2Label.Text = "No";
        }

        private void tinderAdventure_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 14;
            }
            if (page == 14)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 99;
            }
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You downloaded Tinder as a joke but have now found yourself very lonely. Do you want to start your adventure with Tinder?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 2:
                    outputLabel.Text = "You matched with Savannah! Do you take her on a date?";

                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 4:
                    outputLabel.Text = "Where will you take her? ";

                    option1Label.Text = "East side marios";
                    option2Label.Text = "McDonalds play place";
                    break;
                case 6:
                    outputLabel.Text = "She shows up, but comes 10 minutes late.";

                    option1Label.Text = "Continue with date";
                    option2Label.Text = "Ask why she's late";
                    break;
                case 8:
                    outputLabel.Text = "You sit down at a table and order some drinks, she begins to\n complain about her mom and you are intrigued about it";

                    option1Label.Text = "Agree with her";
                    option2Label.Text = "Tell her to stop talking";
                    break;
                case 10:
                    outputLabel.Text = "Savannah finds it nice that your listening to her and asks if you\n want to go back to her place";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 12:
                    outputLabel.Text = "Savannah respects you wishes, but seems infuriated by your\n answer, she then asks why?";

                    option1Label.Text = "Don't like her";
                    option2Label.Text = "Not ready";
                    break;
                case 14:
                    outputLabel.Text = "Savannah gets sad hearing this and files a restraining order on you, she says she never wants to hear from you again, she picks up a butter knife and throws it at you, impaling your lungs and killing you. Play Again?";

                    option1Label.Text = "Don't like her";
                    option2Label.Text = "Not ready";
                    break;
                case 99:
                    outputLabel.Text = "Play again";

                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                default:
                    break;
            }

        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 4)
            {
                randomValue = randGen.Next(1, 101);
                if (randomValue > 20)
                {
                    page = 6;
                }
                else
                {
                    page = 7;
                }
            }
            else if (page == 7)
            {
                page = 99;
            }
                else if (page == 6)
                {
                    page = 9;
                }
                else if (page == 9)
                {
                    page = 99;
                }
                else if (page == 8)
                {
                    page = 11;
                }
                else if (page == 11)
                {
                    page = 99;
                }
                else if (page == 10)
                {
                    page = 13;
                }
                else if (page == 13)
                {
                    page = 99;
                }
                else if (page == 12)
                {
                    page = 15;
                }
                else if (page == 15)
                {
                    page = 99;
                }
                else if (page == 4)
                {
                    page = 16;
                }
                else if (page == 16)
                {
                    page = 18;
                }
                else if (page == 18)
                {
                    page = 99;
                }
                else if (page == 17)
                {
                    page = 20;
                }
                else if (page == 20)
                {
                    page = 99;
                }
                

            

            }
        }
    }
