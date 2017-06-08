using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hungmen
{
    public partial class Form1 : Form
    {
        int LivesLeft;
        int score = 0;
        string Guess;
        string GuessCopy;
        List<char> GuessedChar = new List<char>();

        public Form1()
        {
            InitializeComponent();
            //form1.AcceptButton = GuessButton;
            Start();
        }

        public void Start()
        {
            //Word Bank initialisation
            string[] wordBank = { "Apple", "Box", "Creation", "Dystopia", "Establishmentarian", "Flogging", "Gargantuan", "Hysteria", "Incendiary" };
            GuessedChar.Clear();

            //Game Parameters
            LivesLeft = 7;

            //Random pick from Word Bank
            Random rand = new Random();
            Guess = wordBank[rand.Next(0, wordBank.Length)];
            Guess = Guess.ToUpper();
            GuessCopy = Guess;

            //MessageBox.Show(Guess);
            //Generate OutputBox State
            HungState(LivesLeft);

            //Reset Answer State
            AnswerState(GuessCopy);


            //Focus Cursor
            GuessBox.Select();
        }

        public void HungState(int LivesLeft)
        {
          #region 
          switch(LivesLeft)
            {
                case 0:
                    OutputBox.Text = " _________     \r\n |                 |    \r\n |                O    \r\n |               /|\\  \r\n |               / \\  \r\n |              \r\n";
                    break;
                case 1:
                    OutputBox.Text = " _________     \r\n |                 |    \r\n |                O    \r\n |               /|\\  \r\n |               /    \r\n |              \r\n";
                    break;
                case 2:
                    OutputBox.Text = " _________     \r\n |                 |    \r\n |                O    \r\n |               /|\\  \r\n |                    \r\n |              \r\n";
                    break;
                case 3:
                    OutputBox.Text = " _________     \r\n |                 |    \r\n |                O    \r\n |               /|   \r\n |                    \r\n |              \r\n";
                    break;
                case 4:
                    OutputBox.Text = " _________     \r\n |                 |    \r\n |                O    \r\n |                |   \r\n |                    \r\n |              \r\n";
                    break;
                case 5:
                    OutputBox.Text = " _________     \r\n |                 |    \r\n |                O    \r\n |                    \r\n |                    \r\n |              \r\n";
                    break;
                case 6:
                    OutputBox.Text = " _________     \r\n |                 |    \r\n |                     \r\n |                    \r\n |                    \r\n |              \r\n";
                    break;
                case 7:
                    OutputBox.Text = " _________     \r\n |                      \r\n |                     \r\n |                    \r\n |                    \r\n |              \r\n";
                    break;

            }
            #endregion
        }
            
        public void UpdatedGuessed(List<char> List)
        {
            for (int i = 0; i < List.Count ; i++)
            {
                OutputBox.AppendText(Char.ToString(List[i]));
                
                if (!(i == List.Count - 1))
                    OutputBox.AppendText(" ");
            }
        }

        //State of answer, if alphabet,
        private void AnswerState(string ACopy)
        {
            bool game = true;

            for (int i = 0; i < Guess.Length; i++)
            {
                if (char.IsUpper(ACopy[i]))
                {
                    game = false;
                    OutputBox.AppendText("_");
                }
                else if(char.IsLower(ACopy[i]))
                {
                    OutputBox.AppendText(Char.ToString(Char.ToUpper(ACopy[i])));
                }
                if (!(i == Guess.Length - 1))
                    OutputBox.AppendText(" ");
                else
                    OutputBox.AppendText("\n");
            }
            if(game)
            {
                score++;
                MessageBox.Show("You so good dood. Your score is now " + score + ". Restarting gaem");
                Start();
            }
            
            if(LivesLeft == 0)
            {
                MessageBox.Show("Game Over LUL. You so bayed. Answer is " + GuessCopy.ToUpper() +", and your score so far is " + score +".\nRestarting gaem");
                Start();
            }
        }

        private bool IsValid(string str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z]$");
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            //IsValid() Test
            //MessageBox.Show(Convert.ToString((IsValid(GuessBox.Text)))); 

            //HungState() Test
            //HungState(Convert.ToInt32(GuessBox.Text));

            if (!(IsValid(GuessBox.Text)))
            {
                MessageBox.Show("Please enter a letter.");
            }
            else if (LivesLeft > 0)
            {
                GuessBox.Text = GuessBox.Text.ToUpper();

                if (GuessedChar.Contains(Convert.ToChar(GuessBox.Text)))
                {
                    MessageBox.Show("Pls no repeat urself");
                }

                if(Regex.IsMatch(Guess,@"["+GuessBox.Text+@"]+"))
                {
                    MessageBox.Show("You so good");
                    GuessCopy = GuessCopy.Replace(GuessBox.Text, GuessBox.Text.ToLower());
                    GuessedChar.Add(Convert.ToChar(GuessBox.Text));
                }
                else
                {
                    MessageBox.Show("You so bad");
                    LivesLeft--;
                    GuessedChar.Add(Convert.ToChar(GuessBox.Text));
                }

                HungState(LivesLeft);
                AnswerState(GuessCopy);
                UpdatedGuessed(GuessedChar);
            }
        }

        private void GuessBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
