using System.Data.SqlTypes;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private string playerName;
        private Random rand = new Random();
        private bool turn = true; // true = player's turn, false = computer's turn 

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

            // Determine first player
            FirstPlayer();

            // Start the game (enables Tic Tac Toe board)
            StartGame();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (!turn) return; // player can't input during computer's turn

            Button button = (Button)sender;

            if (turn)
                button.Text = "X";
            else
                button.Text = "O";

            turn = !turn;
            button.Enabled = false; // Disables the button
        }

        private void ComputerMove()
        {
            if (turn) return;



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

        }

        /// <summary>
        /// Randomly generates first player and assign them as X
        /// </summary>
        private void FirstPlayer()
        {

            // playerName is first if generate 0, 
            // else generated 1 and computer is first 
            if (turn = rand.Next(2) == 0) // equal chance of turn
            {
                turn = true;
                playerTurnLabel.Text = $"{playerName} goes first as X.";
            }
            else
            {
                turn = false;
                playerTurnLabel.Text = "Computer goes first as X.";
                ComputerMove();
            }
        }

        

       
    }
}
