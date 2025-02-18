namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private string playerName;
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // Get the name from TextBox
            playerName = nameTextBox.Text;

            // Display the greeting message with name on form
            greetingLabel.Text = ($"Welcome, {playerName}! Let's play Tic Tac Toe!");

        }

    }
}
