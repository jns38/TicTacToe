using System.Data.SqlTypes;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private string playerName;
        private Random rand = new Random();
        private bool isPlayerXTurn = true;
        private string playerMarker, computerMarker;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets name from user and greets them.
        /// </summary>
        /// <param name="sender">The button that was clicked, passed as an object</param>
        /// <param name="e">Event argument for button click event</param>
        private void startBtn_Click(object sender, EventArgs e)
        {
            // Get the name from TextBox
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                playerName = nameTextBox.Text;
            }
            else
            {
                playerName = "Player"; // Default name if not exist
            }

            // Display the greeting message with name on form
            greetingLabel.Text = ($"Welcome, {playerName}! Let's play Tic Tac Toe!");

            // Start the game (enables Tic Tac Toe board)
            StartGame();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the form
        }

        /// <summary>
        /// Reset board without closing form
        /// </summary>
        private void stopBtn_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Enbles Tic Tac Toe board
        /// 
        /// 
        /// </summary>
        private void StartGame()
        {
            // Determine first player
            FirstPlayer();

            if (!isPlayerXTurn) return; // player can't input during computer's turn

        }

        /// <summary>
        /// Randomly generates first player and assign them as X
        /// </summary>
        private void FirstPlayer()
        {

            // playerName is first if generate 0, 
            // else generated 1 and computer is first 
            if (isPlayerXTurn = rand.Next(2) == 0) // equal chance of turn
            {
                isPlayerXTurn = true;
                playerMarker = "X";
                computerMarker = "O";
                greetingLabel.Text = $"{playerName} goes first as X.";
            }
            else
            {
                isPlayerXTurn = false;
                computerMarker = "X";
                playerName = "O";
                greetingLabel.Text = "Computer goes first as X.";
                ComputerMove();
            }
        }

        private void ComputerMove()
        {
            
        }
    }
}
