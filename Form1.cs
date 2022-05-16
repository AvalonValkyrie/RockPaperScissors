using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baldwin_Asg7_RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //method def area start
        enum RPS {Rock, Paper, Scissors};//define RPS
        Random random = new Random();//define random
        private RPS getComputerChoice()
        {
            RPS computerChoice;
            int choiceNumber = random.Next(1,4);
            if (choiceNumber == 1)
                computerChoice = RPS.Rock;
            else if (choiceNumber == 2)
                computerChoice = RPS.Paper;
            else
                computerChoice = RPS.Scissors;
            return computerChoice;
        }//end get computer choice
        private string getWinner(RPS computerChoice, RPS playerChoice)
        {
            string winner = "";
            if (playerChoice == RPS.Rock)
            {
                if (computerChoice == RPS.Rock)
                    winner = "tie";
                else if (computerChoice == RPS.Paper)
                    winner = "computer";
                else if (computerChoice == RPS.Scissors)
                    winner = "player";
            }
            else if (playerChoice == RPS.Paper)
            {

                if (computerChoice == RPS.Rock)
                    winner = "player";
                else if (computerChoice == RPS.Paper)
                    winner = "tie";
                else if (computerChoice == RPS.Scissors)
                    winner = "computer";
            }
            else if (playerChoice == RPS.Scissors)
            {

                if (computerChoice == RPS.Rock)
                    winner = "computer";
                else if (computerChoice == RPS.Paper)
                    winner = "player";
                else if (computerChoice == RPS.Scissors)
                    winner = "tie";
            }
            return winner;
        }//end get winner
        private void changeTotals(string winner)
        {
            int score = 0;
            //change total games
            int total = int.Parse(labelTotalGames.Text);
            total = total + 1;
            labelTotalGames.Text = total.ToString();
            //end of changing total games
            if (winner.ToLower() == "player")//player wins
            {
                score = int.Parse(labelPlayerWinTotal.Text);
                score = score + 1;
                labelPlayerWinTotal.Text = score.ToString();
            }
            else if (winner.ToLower() == "computer"){//computer wins
                score = int.Parse(labelComputerWinTotal.Text);
                score = score + 1;
                labelComputerWinTotal.Text = score.ToString();
            }
            else
            {//Tie
                score = int.Parse(labelTieCountTotal.Text);
                score = score + 1;
                labelTieCountTotal.Text = score.ToString();
            }
        }//end change totals
        private void playRound(RPS playerChoice)
        {
            labelComputerChoice.Text = "";
            labelPlayerChoice.Text = playerChoice.ToString().ToUpper();
            labelWinner.Text = "";

            RPS computerChoice = getComputerChoice();
            labelComputerChoice.Text = computerChoice.ToString().ToUpper();

            string winner = getWinner(computerChoice, playerChoice);
            labelWinner.Text = winner.ToString().ToUpper();

            changeTotals(winner);
        }

        //method def area end

        //Button click area start
        private void buttonChooseRock_Click(object sender, EventArgs e)
        {
            playRound(RPS.Rock);
        }

        private void buttonChoosePaper_Click(object sender, EventArgs e)
        {
            playRound(RPS.Paper);
        }

        private void buttonChooseScissors_Click(object sender, EventArgs e)
        {
            playRound(RPS.Scissors);
        }

        private void buttonResetScores_Click(object sender, EventArgs e)
        {//reset scores and clear labels
            labelPlayerWinTotal.Text = "0";
            labelComputerWinTotal.Text = "0";
            labelTieCountTotal.Text = "0";
            labelTotalGames.Text = "0";
            labelComputerChoice.Text = "";
            labelPlayerChoice.Text = "";
            labelWinner.Text = "";
        }
        //Button click area end
    }
}
