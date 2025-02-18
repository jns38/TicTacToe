using System.Data.SqlTypes;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private string playerName;
        private Random rand = new Random();
        private bool turn = true; // true = player's turn, false = computer's turn 
        private bool isPlayerXTurn = true; 

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

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (!isPlayerXTurn) return; // player can't input during computer's turn

            Button button = (Button)sender;
            if (button.Text != "") return; // prevent multiple moves on the same cell
            
            button.Text = "X";
            isPlayerXTurn = false;
            playerName = "O";

            turn = !turn;
            button.Enabled = false; // Disables the button
            ComputerMove();
        }

        /// <summary>
        /// Computer randomly select an available button and marks
        /// </summary>
        private void ComputerMove()
        {
            if (turn) return; // computer's can't input during players's turn

            List<Button> buttons = new List<Button> { button1, button2, button3, button4,
            button5, button6, button7,  button8, button9 };

            int number;
            do
            {
                number = rand.Next(9);
            } while (buttons[number].Text != "");
            
            buttons[number].Text = "O";
            isPlayerXTurn = true;
            playerName = "X";
 

            turn = !turn;
            buttons[number].Enabled = false; // Disables the button
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
        /// Randomly generates first player and assign them as X
        /// </summary>
        private void FirstPlayer()
        {

            // playerName is first if generate 0, 
            // else generated 1 and computer is first 
            if (isPlayerXTurn = rand.Next(2) == 0) // equal chance of turn
            {
                isPlayerXTurn = true;
                playerTurnLabel.Text = $"{playerName} goes first as X.";
            }
            else
            {
                isPlayerXTurn = false;
                turn = false;
                playerTurnLabel.Text = "Computer goes first as X.";
                ComputerMove();
            }
        }

        

       
    }
}
