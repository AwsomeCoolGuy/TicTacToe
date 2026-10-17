using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Button[,] buttons;
        string winnerWinnerChickenDinner = "";
        Button resetbutton;
        int clickAmount = 0;
        int XNumWins = 0;
        int ONumWins = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string win;

            buttons = new Button[3, 3];
            resetbutton = new Button();

            
            resetbutton.Location = new Point(50, 50);
            resetbutton.Text = "RESET";
            Controls.Add(resetbutton);
            resetbutton.Click += ResetButtonClick;
            resetbutton.Visible = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Location = new Point(257 + (100 * i), 96 + (100 * j));
                    buttons[i, j].Size = new Size(100, 100);
                    buttons[i, j].Click += ButtonClick;
                    Controls.Add(buttons[i, j]);
                }
            }
        }

        bool xPlayerTurn = true;
        private bool checkWins()
        {
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[0, 0].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    return true;

                }
            }
            if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[2, 0].Text == buttons[0, 2].Text)
            {
                if (buttons[0, 2].Text != "")
                {
                    return true;

                }
            }

            for (int Index = 0; Index < buttons.GetLength(0); Index++)
            {
                if (buttons[0, Index].Text == buttons[1, Index].Text && buttons[0, Index].Text == buttons[2, Index].Text)
                {
                    if (buttons[0, Index].Text != "")
                    {
                        return true;

                    }



                }


                if (buttons[Index, 0].Text == buttons[Index, 1].Text && buttons[Index, 0].Text == buttons[Index, 2].Text)
                {
                    if (buttons[Index, 0].Text != "")
                    {
                        return true;

                    }

                }
            }
            return false;
        }



        private void ButtonClick(object sender, EventArgs e)
        {
           


            Button Sender = (Button)sender;
            clickAmount++;

            if (Sender.Text != "") return;

            
            if (xPlayerTurn == true)
            {
                Sender.Text = "X";

                xPlayerTurn = false;

                if (checkWins() == true)
                {
                    winnerWinnerChickenDinner = "YAYYYYY X Won!!!! YOU SUCK O";
                    winScreen(winnerWinnerChickenDinner);
                    clickAmount = 0;
                    XNumWins++;
                     
                }

            }

            else
            {
                Sender.Text = "O";
                xPlayerTurn = true;

                if (checkWins() == true)
                {
                    winnerWinnerChickenDinner = "YAYYYYY O Won!!!! YOU SUCK X";
                    winScreen(winnerWinnerChickenDinner);
                    clickAmount = 0;
                    ONumWins++;
                }
            }
            if (clickAmount >= 9 && checkWins() == false)
            {
                winnerWinnerChickenDinner = "You tied and both yall freaking suck. Never play TICTACTOE ever again!";
                winScreen(winnerWinnerChickenDinner);
                clickAmount = 0;
            }

            XWins.Text = "X Wins: " + XNumWins;
            OWins.Text = "O Wins: " + ONumWins;



        }

        private void winScreen(string winnerWinnerChickenDinner)
        {
            if (winnerWinnerChickenDinner != "")
            {
                MessageBox.Show(winnerWinnerChickenDinner);
                resetbutton.Visible = true;
                for(int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        buttons[i, j].Visible = false;
                    }
                }
            }
        }


        private void ResetButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Visible = true;
                    buttons[i, j].ResetText();
                }
            }
            resetbutton.Visible = false;
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
    }
}
