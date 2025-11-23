    using rock_paper_scizzors.Properties;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace rock_paper_scizzors
    {
        public partial class frmGameArena : Form
        {
            frmGameSetup.enGameMode gameMode;
            enum enChoice {rock =1, scissors = 2,paper =3};
            enum enWinner { Player, Computer, Draw };
        struct stgameInfo
        {
               public int playerWin;
               public int computerWin;
               public string playerName;
           public  int goalScore;
        }
            stgameInfo gameInfo = new stgameInfo();
            private Random rnd = new Random();

            
            
            public frmGameArena(string playerName,frmGameSetup.enGameMode gameMode)
            {
                InitializeComponent();
                this.gameMode = gameMode;
                this.gameInfo.playerName = playerName;
            }
            private void setGoalScore()
            {
                if (gameMode == frmGameSetup.enGameMode.BestOf3)
                    gameInfo.goalScore = 2;
                else if(gameMode == frmGameSetup.enGameMode.BestOf5)
                    gameInfo.goalScore = 3;
                else
                    gameInfo.goalScore= 0;
            
            }
            private int generateRandomNumber()
            {
                return rnd.Next(1, 4);
            }
            private enChoice ComputerChoice()
            {
                return (enChoice)generateRandomNumber();
            }
           private void resetPictures()
            {
                pictureBox1.Image = Resources.rock_paper_scissors;
                pictureBox2.Image = Resources.rock_paper_scissors;

            }
            private void changeImageBasedOnCPChoice(enChoice choice)
            {
                if (choice == enChoice.rock)
                    pictureBox2.Image = Resources.fist;
                else if (choice == enChoice.paper)
                    pictureBox2.Image = Resources.hand_paper;
                else
                    pictureBox2.Image = Resources.scissors;
            }
        private enWinner getRoundWinner(enChoice player, enChoice Computer)
        {
       
            if (player == Computer)
            {
                return enWinner.Draw;
            }

            if ((player == enChoice.rock && Computer == enChoice.scissors) ||
                (player == enChoice.paper && Computer == enChoice.rock) ||
                (player == enChoice.scissors && Computer == enChoice.paper))
            {
                return enWinner.Player;
            }

            return enWinner.Computer;
  
        }
        private void UpdateGameScreen(enChoice playerChoice, enChoice computerChoice)
        {
            enWinner winner = getRoundWinner(playerChoice, computerChoice);

            switch (winner)
            {
                case enWinner.Player:
                    lbMain.Text = $"{gameInfo.playerName} Won the Round!";
                    gameInfo.playerWin++;
                    lbPlayerScore.Text = gameInfo.playerWin.ToString();
                    break;

                case enWinner.Computer:
                    lbMain.Text = "Computer Won the Round!";
                    gameInfo.computerWin++;
                    lbComputerScore.Text = gameInfo.computerWin.ToString();
                    break;

                case enWinner.Draw:
                    lbMain.Text = "Oh! It's a Tie!";
                    break;
            }
        }
        //private void determineWinner(enChoice playerChoice, enChoice computerChoice)
        //    {
        //        int player = (int)playerChoice;
        //        int computer = (int)computerChoice;

           
        //        if (playerChoice == enChoice.rock && computerChoice == enChoice.scissors||
        //        playerChoice == enChoice.paper && computerChoice == enChoice.rock||
        //        playerChoice == enChoice.scissors && computerChoice == enChoice.paper)
        //        {
        //            lbMain.Text = $"{playerName} Won!";
        //            gameInfo.playerWin++;
        //            lbPlayerScore.Text = gameInfo.playerWin.ToString();

        //        }
        //        else if (playerChoice == computerChoice)
        //        {
        //            lbMain.Text = $"  Oh! it's a Tie!";
        //        }
        //        else
        //        {
        //            lbMain.Text = $"Computer Won!";
        //            gameInfo.computerWin++;
        //            lbComputerScore.Text = gameInfo.computerWin.ToString();
                
        //        }
        //    }
            private string gameWinner(int playerWins, int computerWins)
            {
                return (playerWins > computerWins) ? gameInfo.playerName : "Computer";
            }
            private void frmGameArena_Load(object sender, EventArgs e)
            {
                
                setGoalScore();
                
                lbRounds.Text = $"Game Mode: {gameMode.ToString()}";
                lbPlayerName.Text = $"Player1: {gameInfo.playerName}";
            

            }
            private void peformRound(enChoice playerChoice)
            {
                enChoice computerChoice = ComputerChoice();
                panel1.Visible = false;
                changeImageBasedOnCPChoice(computerChoice);
                UpdateGameScreen(playerChoice, computerChoice);
                //determineWinner(playerChoice, computerChoice);
            
                btnNextRound.Visible = true;
            }
            private void prepareEndGame()
            {
                panel1.Visible = false;
                btnExit.Visible = true;
                btnNextRound.Visible = false;
            }
            private void performEndGame()
            {
                prepareEndGame();
                string winner = gameWinner(gameInfo.playerWin, gameInfo.computerWin);
                lbEndGame.Text = $"Game Ended! , {winner} Wins";
            
            }
            private bool isEndGame()
            {
                return (gameInfo.playerWin == gameInfo.goalScore || gameInfo.computerWin == gameInfo.goalScore);
            }
            private void handlePlayerChoice(enChoice choice,Image choiceImage)
            {
                pictureBox1.Image = choiceImage;
                 peformRound(choice);

                if (gameInfo.goalScore != 0 && isEndGame())
                {
                    performEndGame();

                }
                else
                {
                    if(gameInfo.goalScore ==0)
                        btnExit.Visible = true;
                }
            }
            private void btnRock_Click(object sender, EventArgs e)
            {
                handlePlayerChoice(enChoice.rock,Resources.fist);
            } 

            private void btnPaper_Click(object sender, EventArgs e)
            {
                handlePlayerChoice(enChoice.paper, Resources.hand_paper);
            }

            private void btnScissors_Click(object sender, EventArgs e)
            {
                handlePlayerChoice(enChoice.scissors, Resources.scissors);
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Thank You for Playing !");
                this.Close();

            }

       
            private void btnNextRound_Click(object sender, EventArgs e)
            {
                panel1.Visible = true;
                btnNextRound.Visible = false;
                lbMain.Text = "Choose Your Move!";
                resetPictures();
            }
        }
    }
