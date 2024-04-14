using System.Collections;
using System.Text;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        ArrayList wordsToGuess = new ArrayList();
        int count = 0;
        StringBuilder currentGuess = new StringBuilder();
        ArrayList wrongGuesses = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void submitGuessButton_Click(object sender, EventArgs e)
        {
            String guessWord = guessTextBox.Text;
            if (guessWord != "")
            {
                if (guessWord.Equals(wordsToGuess[count].ToString(), StringComparison.CurrentCultureIgnoreCase))
                {
                    guessWordLabel.Text = wordsToGuess[count].ToString();

                    if (wordsToGuess.Count - 1 != count)
                    {
                        MessageBox.Show("Correct guess!");
                        guessTextBox.Text = "";
                        count++;
                    }
                    else
                    {
                        MessageBox.Show("Correct guess!\nYou win!");
                        restartGame();
                        guessTextBox.Text = "";
                    }
                    wordsHide(currentGuess);
                }
                else
                {
                    wrongGuesses.Add(guessWord);
                    foreach (String wrongGuess in wrongGuesses)
                    {
                        wrongGuessBox.Items.Add(wrongGuess);

                    }
                    wrongGuesses.Clear();


                    MessageBox.Show("Wrong guess!\nTry again.");
                    guessTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please input!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wordsToGuess.Add("computer");
            wordsToGuess.Add("Programming");
            wordsToGuess.Add("BSIT");
            wordsToGuess.Add("Elijah");

            wordsHide(currentGuess);
        }

        public void wordsHide(StringBuilder word)
        {
            word.Clear();
            guessWordLabel.Text = "";

            for (int i = 0; i < wordsToGuess[count].ToString().Length; i++)
            {
                if (i >= 1 && i <= wordsToGuess[count].ToString().Length - 2)
                {
                    word.Append("?");
                }
                else
                {
                    word.Append(wordsToGuess[count].ToString()[i]);
                }
            }

            guessWordLabel.Text = word.ToString();
        }

        public void restartGame()
        {
            count = 0;
            wrongGuessBox.Items.Clear();
        }

        private void guessWordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
