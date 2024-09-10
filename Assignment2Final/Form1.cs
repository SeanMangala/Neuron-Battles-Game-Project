using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//Author: Sean Mangala
//Date: 2024-04-14
//Purpose: Assignment 2 - Neuron Battles
namespace Assignment2Final
{
    public partial class Form1 : Form
    {
        //Found these global variables really helpful for the overall code.
        //Declaration of players and the question
        Player playerOne;
        Player playerTwo;
        Question question;

        //This bool determines which player will answer the question.
        // true = player one
        // false = player two
        bool playerTurn = true;

        //Determines if the player is answering the question
        //  (for answerTb click)
        bool answering = false;

        //Time player has to answer a question in seconds
        int timeToAnswer, answeringTime = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void instructionsBtn_Click(object sender, EventArgs e)
        {
            //Provides the user an instructions button throughout the game
            showInstructions();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //Checks if the name and color inputs are filled in
            //  using the CompareTo() string function
            if (playerOneNameTb.Text.CompareTo("") == 0 ||
                playerTwoNameTb.Text.CompareTo("") == 0 ||
                playerOneColorLb.Text.CompareTo("") == 0 ||
                playerTwoColorLb.Text.CompareTo("") == 0)
                viewError("Must include values for players");
            else
            {
                //Player object instantiation
                //Used Trim() string function to remove white space
                //  on players names
                playerOne = new Player(playerOneNameTb.Text.Trim(),
                                        playerOneColorLb.Text,
                                        100);
                playerTwo = new Player(playerTwoNameTb.Text.Trim(),
                                       playerTwoColorLb.Text,
                                       100);
                //Initialize game
                hideInput();
                changePlayerName();
                viewPlayerHealth();
                viewQuestion();
                //View who's in turn on the forms
                checkPlayerTurn();
                //Updates the health
                updateHealth();
                //Move instructions in the middle of the bottom of the
                // forms and the battle field ground
                instructionsBtn.Top = 395;
            }
        } //end of function

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //Validates if the textbox is empty
            if (answerTb.Text.CompareTo("") == 0)
                viewError("Must have an input for the answer.");
            else
            {
                int trialInt;
                //Validates if the inputted character cannot be converted to an int
                if (!Int32.TryParse(answerTb.Text, out trialInt))
                    viewError("Answer must be in integer form.");
                else
                {
                    //Checks if the player in turn got the correct answer
                    bool correct = compareAnswer(question.Answer);
                    if (correct)
                    {
                        //Checks which player is in turn to deal damage
                        if (playerTurn) //Player One
                        {
                            playerTwo.Health -= question.Damage;
                            playerTwoDamagePopUp.Text = "-" + question.Damage.ToString();
                        }
                        else
                        {
                            playerOne.Health -= question.Damage;
                            playerOneDamagePopUp.Text = "-" + question.Damage.ToString();
                        }
                        questionLbl.Text = "Correct! The opposing player looses " +
                            question.Damage + " HP";
                    }
                    else
                    {
                        //Checks which player lost hp for incorrect answer
                        if (playerTurn)
                            playerOne.Health -= 10;
                        else
                            playerTwo.Health -= 10;
                        questionLbl.Text = "Wrong! You lost 10 HP";
                    }
                    damagePopUp(correct);
                    answerTb.Text = "";
                    //Centers the question label
                    questionLbl.Left = (this.Width - questionLbl.Width) / 2;
                    //Updates health for both players
                    updateHealth();
                    //Stop timer
                    answeringTimer.Stop();
                    timerLbl.Text = "0";
                    timerLbl.ForeColor = Color.Black;
                    //End of game
                    if (endOfGame())
                        gameOver();
                    //Switches the player to now answering the question
                    answering = false;
                    //Switch the player's turn
                    playerTurn = !playerTurn;
                }
            }
            //Changes the player turn label to the player in turn
            checkPlayerTurn();
        } //end of function

        private void answerTb_Click(object sender, EventArgs e)
        {
            //Hides error message
            errorLbl.Visible = false;
            //Checks if the player has not yet clicked the textbox
            if (!answering)
            {
                question = new Question();

                //Retrieves a new question from the object
                questionLbl.Text = question.getQuestion();
                questionLbl.Left = (this.Width - questionLbl.Width) / 2;

                //Hides damage pop up
                playerOneDamagePopUp.Visible = false;
                playerTwoDamagePopUp.Visible = false;

                //Show damage
                damageLbl.Visible = true;
                damageLbl.Text = "Damage: " + question.Damage + " HP";
                damageLbl.Left = (this.Width - damageLbl.Width) / 2;

                //Start timer
                timeToAnswer = answeringTime;
                timerLbl.Text = timeToAnswer.ToString();
                timerLbl.Left = (this.Width - timerLbl.Width) / 2;
                timerLbl.ForeColor = Color.Green;
                timeToAnswer--;
                answeringTimer.Start();

                //Player is answering the question
                answering = true;
            }
        } //end of function

        private void playerOneColorLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hides the error label
            errorLbl.Visible = false;

            //Changes the player one color
            if (playerOneColorLb.Text == "Red")
                playerOnePb.Image = Properties.Resources.playerOneRed;
            else if (playerOneColorLb.Text == "Blue")
                playerOnePb.Image = Properties.Resources.playerOneBlue;
            else if (playerOneColorLb.Text == "Yellow")
                playerOnePb.Image = Properties.Resources.playerOneYellow;
            else if (playerOneColorLb.Text == "Pink")
                playerOnePb.Image = Properties.Resources.playerOnePink;
            else if (playerOneColorLb.Text == "C# God")
                playerOnePb.Image = Properties.Resources.profcolinnobg;
            else
                playerOnePb.Image = Properties.Resources.janisnobg;
        }

        private void playerTwoColorLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hides the error label
            errorLbl.Visible = false;

            //Changes the player two color
            if (playerTwoColorLb.Text == "Red")
                playerTwoPb.Image = Properties.Resources.playerTwoRed;
            else if (playerTwoColorLb.Text == "Blue")
                playerTwoPb.Image = Properties.Resources.playerTwoBlue;
            else if (playerTwoColorLb.Text == "Yellow")
                playerTwoPb.Image = Properties.Resources.playerTwoYellow;
            else if (playerTwoColorLb.Text == "Pink")
                playerTwoPb.Image = Properties.Resources.playerTwoPink;
            else if (playerTwoColorLb.Text == "C# God")
                playerTwoPb.Image = Properties.Resources.profcolinnobg;
            else
                playerTwoPb.Image = Properties.Resources.janisnobg;
        }

        //Hides the error label when the textbox is clicked
        private void playerTwoNameTb_Click(object sender, EventArgs e)
        {
            errorLbl.Visible = false;
        }

        private void playerOneNameTb_Click(object sender, EventArgs e)
        {
            errorLbl.Visible = false;
        }

        /// <summary>
        /// Runs when the game is over. Prompts the players to play again.
        /// </summary>
        private void gameOver()
        {
            checkWinner();
            //hide question and answer elements
            clearGame();
            //Stop timer
            answeringTimer.Stop();
            //show restart or quit option
            if (MessageBox.Show("Would you like to retry?", "Game Over", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                //Resets player health
                playerOne.Health = 100;
                playerTwo.Health = 100;
                viewQuestion();
                //View turn
                checkPlayerTurn();
                //Updates the health
                updateHealth();
                playerOneDamagePopUp.Visible = false;
                playerTwoDamagePopUp.Visible = false;
                //Resets the progress bar to color green
                playerOneProgB.ForeColor = Color.Green;
                playerTwoProgB.ForeColor = Color.Green;
            }
            else
            {
                //Show a ending forms instead
                //gameOver form object
                gameOver gameOverScreen = new gameOver();
                this.Hide();
                gameOverScreen.ShowDialog();
            }
        }

        /// <summary>
        /// Creates a pop up whenever a player is dealt damage
        /// </summary> 
        /// <param name="correct"></param>
        private void damagePopUp(bool correct)
        {
            //Checks which player deals damage
            if (playerTurn)
            {
                if (correct)
                {
                    playerTwoDamagePopUp.Visible = true;
                    playerTwoDamagePopUp.Text = "-" + question.Damage.ToString();
                }
                else
                {
                    playerOneDamagePopUp.Visible = true;
                    playerOneDamagePopUp.Text = "-10";
                }
            }
            else
            {
                if (correct)
                {
                    playerOneDamagePopUp.Visible = true;
                    playerOneDamagePopUp.Text = "-" + question.Damage.ToString();
                }
                else
                {
                    playerTwoDamagePopUp.Visible = true;
                    playerTwoDamagePopUp.Text = "-10";
                }
            }
        }

        /// <summary>
        /// Views an error message to the form
        /// </summary>
        /// <param name="errorMsg"></param>
        private void viewError(string errorMsg)
        {
            errorLbl.Text = errorMsg;
            errorLbl.Visible = true;
            //Aligns the text to the center of the forms
            errorLbl.Left = (this.Width - errorLbl.Width) / 2;
        }

        /// <summary>
        /// Clears the game section
        /// </summary>
        private void clearGame()
        {
            playerTurnLbl.Visible = false;
            questionLbl.Visible = false;
            answerTb.Visible = false;
            submitBtn.Visible = false;
            damageLbl.Visible = false;
            timerLbl.Visible = false;
        }

        /// <summary>
        /// Checks if either of the player is on loosing hp
        /// </summary>
        /// <returns></returns>
        private bool endOfGame()
        {
            return (playerOne.Health <= 0 || playerTwo.Health <= 0);
        }

        /// <summary>
        /// Checks which player has won after the game has ended
        /// </summary>
        /// <returns></returns>
        private void checkWinner()
        {
            if (playerOne.Health <= 0)
                playerTwoHealth.Text = "Winner!";
            else
            {
                playerOneHealth.Text = "Winner!";
                //Moves health to the left
                //playerOneHealth.Left -= 40;
            }

        }

        /// <summary>
        /// Updates the health label for each player
        /// </summary>
        private void updateHealth()
        {
            playerOneHealth.Text = playerOne.Health.ToString();
            playerTwoHealth.Text = playerTwo.Health.ToString();
            //Checks if any of the players health is a positive value
            if (playerOne.Health < 0 || playerTwo.Health < 0)
            {
                //Sets the progress bar value to 0 whenever the
                //  players health is less than 0
                if (playerOne.Health < 0)
                    playerOneProgB.Value = 0;
                else
                    playerTwoProgB.Value = 0;
            }
            else
            {
                playerOneProgB.Value = playerOne.Health;
                playerTwoProgB.Value = playerTwo.Health;
            }
            //Checks the color of the progress bar
            if (playerOne.Health <= 20)
                playerOneProgB.ForeColor = Color.Red;
            else if (playerTwo.Health <= 20)
                playerTwoProgB.ForeColor = Color.Red;
        }

        
        /// <summary>
        /// Checks which player to display in the player turn label
        /// </summary>
        private void checkPlayerTurn()
        {
            //Resets players color to black (default)
            playerOneLbl.ForeColor = Color.Black;
            playerTwoLbl.ForeColor = Color.Black;
            if (playerTurn)
            {
                playerOneLbl.ForeColor = Color.Orange;
                playerTurnLbl.Text = playerOne.Name + "'s turn";
            }
            else
            {
                playerTwoLbl.ForeColor = Color.Orange;
                playerTurnLbl.Text = playerTwo.Name + "'s turn";
            }
            //Change question label x axis
            playerTurnLbl.Left = (this.Width - playerTurnLbl.Width) / 2;
        }

        /// <summary>
        /// Checks if the user answer matches the answer to the question.
        /// Uses Trim() string function
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        private bool compareAnswer(int answer)
        {
            string userAnswer = answerTb.Text;
            //Used Trim() string function to remove answer white space
            return (answer == Int32.Parse(userAnswer.Trim()));
        }


        private void hideInput()
        {
            //Player one input
            playerOneNameLbl.Visible = false;
            playerOneColorLbl.Visible = false;
            playerOneNameTb.Visible = false;
            playerOneColorLb.Visible = false;
            //PLayer two input
            playerTwoNameLbl.Visible = false;
            playerTwoColorLbl.Visible = false;
            playerTwoNameTb.Visible = false;
            playerTwoColorLb.Visible = false;
            //Start button
            startBtn.Visible = false;
            //Error message (If player created an input error)
            errorLbl.Visible = false;
        }

        private void changePlayerName()
        {
            playerOneLbl.Text = playerOne.Name;
            playerTwoLbl.Text = playerTwo.Name;  
        }

        private void viewQuestion()
        {
            playerTurnLbl.Visible = true;
            questionLbl.Visible = true;
            answerTb.Visible = true;
            submitBtn.Visible = true;
            //Timer
            timerLbl.Visible = true;
            //Sets the question
            questionLbl.Text = "Click the textbox to start...";
            questionLbl.Left = (this.Width - questionLbl.Width) / 2;
        }

        private void viewPlayerHealth()
        {
            //View health
            playerOneHealth.Visible = true;
            playerTwoHealth.Visible = true;
        }

        public void showInstructions()
        {
            //Welcome message to the players
            MessageBox.Show("Welcome to Neuron Battles! The goal of the game" +
                " is to answer as many questions to deal damage to the" +
                " opposing player. Once they have 0 HP, you win!" +
                " You have 10 seconds to answer each question." +
                " Click on the text box to start.\n\n" +
                "Question Types:\n" +
                "--------------------\n" +
                "Math:\n" +
                " Addition: 20 Damage\n" +
                " Subtraction: 35 Damage\n" +
                " Multiplication: 40 Damage\n\n" +
                "History:\n" +
                " Default: 45 Damage\n\n" +
                "Note: If you incorrectly answered a question," +
                " you will deal 10 damage to yourself!");
        }

        /// <summary>
        /// This event is used to change the timer label for every tick
        ///     as well as changing it's color and checks whenever the 
        ///     player has used their 10 seconds to answer.
        /// The function is called every 1000 ms (1 second) whenever
        ///     the answeringTimer timer is called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void answeringTimer_Tick(object sender, EventArgs e)
        {
            timerLbl.Text = timeToAnswer.ToString();
            timeToAnswer--;

            //Changes the color of the timer
            if (timeToAnswer >= 5)
                timerLbl.ForeColor = Color.Green;
            else if (timeToAnswer >= 3)
                timerLbl.ForeColor = Color.Orange;
            else
                timerLbl.ForeColor = Color.Red;

            //Times up for the player in turn
            if (timeToAnswer < 0)
            {
                //Stops the timer
                answeringTimer.Stop();
                //Times up for the player
                timerLbl.Text = "Times up!";

                //Checks which player lost hp for taking so long
                if (playerTurn)
                    playerOne.Health -= 10;
                else
                    playerTwo.Health -= 10;
                questionLbl.Text = "Too Slow! You lost 10 HP";
                questionLbl.Left = (this.Width - questionLbl.Width) / 2;
                answerTb.Text = "";

                //Pop up damage for an incorrect answer
                //Passed false to the function because the player in turn
                //  is incorrect regardless.
                damagePopUp(false);            
                
                updateHealth();
                if (endOfGame())
                    gameOver();
                answering = false;
                playerTurn = !playerTurn;
            }
            timerLbl.Left = (this.Width - timerLbl.Width) / 2;
            checkPlayerTurn();
        }

        /*
         private void answerTb_KeyDown(object sender, KeyEventArgs e)
         {
             //Added a fun function to the game where it allows
             // enter key down to submit an answer
             if (e.KeyCode == Keys.Enter)
             {
                 MessageBox.Show("Enter is clicked");
             }
         } */
    }
}