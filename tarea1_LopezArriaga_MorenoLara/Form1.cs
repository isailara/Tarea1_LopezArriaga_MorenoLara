using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea1_LopezArriaga_MorenoLara
{
    public partial class Form1 : Form
    {
        public decimal attempts;
        public String word;
        public char[] chWord;
        public String listBoxWord;
        public char[] chListBoxWord;
        public char letter;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainWordBox_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();
        }

        private void wordSetterButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            attempts = nAttemptsSetter.Value;
            word = mainWordBox.Text;

            if(attempts > 0)
            {
                chWord = new char[mainWordBox.Text.Length];
                chListBoxWord = new char[mainWordBox.Text.Length];

                for (int i = 0; i < mainWordBox.Text.Length; i++)
                {
                    chWord[i] = word[i];
                    listBox1.Items.Add("*");
                    chListBoxWord[i] = char.Parse("*");
                }

                wordLabel.Text = mainWordBox.Text;

                letterBox.Visible = true;
                letterSetterButton.Visible = true;
                finalWordBox.Visible = true;
                finalWordSetterButton.Visible = true;
                nAttempts.Visible = true;
                newGame.Visible = true;

                nAttempts.Text = "You have " + attempts + " attempts left";

                mainWordBox.Enabled = false;
                nAttemptsSetter.Enabled = false;

                mainWordBox.Text = "";

                wordSetterButton.Enabled = false;
            }
            
        }

        private void letterBox_TextChanged(object sender, EventArgs e)
        {
            letterSetterButton.Enabled = true;
            Console.ReadLine();
        }

        private void finalWordBox_TextChanged(object sender, EventArgs e)
        {
            finalWordSetterButton.Enabled = true;
            Console.ReadLine();
        }

        private void letterSetterButton_Click(object sender, EventArgs e)
        {
            nAttempts.Text = "You have " + attempts + " attempts left";

            letter = char.Parse(letterBox.Text);

            for (int i = 0; i < chWord.Length; i++)
            {
                if (chWord[i] == letter)
                {
                    listBox1.Items.RemoveAt(i);
                    listBox1.Items.Insert(i, letter);

                    chListBoxWord[i] = letter;
                }
            }

            letterBox.Text = "";
            StringBuilder sb = new StringBuilder();
            foreach (object o in listBox1.Items)
            {
                sb.Append(o.ToString());
            }
            string s = sb.ToString();

            if (s == word)
            {
                wordLabel.Text = "Congratulations";
                wordLabel.Visible = true;

                finalLabel.Text = "You guessed the word!";
                finalLabel.Visible = true;

                letterBox.Enabled = false;
                letterSetterButton.Enabled = false;
                finalWordBox.Enabled = false;
                finalWordSetterButton.Enabled = false;

                attempts--;
                nAttempts.Text = "You have " + attempts + " attempts left";
            }
            else
            {
                decreaseAttempts();
            }        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGame_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            wordLabel.Text = null;
            attempts = 0;

            mainWordBox.Enabled=true;
            wordSetterButton.Enabled=true;
            nAttemptsSetter.Enabled=true;
            
            nAttempts.Visible = false;
            letterBox.Visible=false;
            letterSetterButton.Visible=false;
            finalWordBox.Visible=false;
            finalWordSetterButton.Visible =false;
            wordLabel.Visible=false;
            finalLabel.Visible=false;

            letterBox.Enabled = true;
            letterSetterButton.Enabled = true;
            finalWordBox.Enabled = true;
            finalWordSetterButton.Enabled = true;

            wordSetterButton.Enabled = false;

            finalWordBox.Clear();
            nAttemptsSetter.Value = 0;
        }

        private void finalWordSetterButton_Click(object sender, EventArgs e)
        {
            if (word.Equals(finalWordBox.Text))
            {
                wordLabel.Text = "Congratulations";
                wordLabel.Visible = true;

                finalLabel.Text = "You guessed the word!";
                finalLabel.Visible = true;

                letterBox.Enabled = false;
                letterSetterButton.Enabled = false;
                finalWordBox.Enabled = false;
                finalWordSetterButton.Enabled = false;

                attempts--;
                nAttempts.Text = "You have " + attempts + " attempts left";
            }
            else
            {
                decreaseAttempts();
            }
        }

        private void nAttemptsSetter_ValueChanged(object sender, EventArgs e)
        {
            if(mainWordBox.Text != null)
            {
                wordSetterButton.Enabled = true;
            }
        }

        private void showWord()
        {
            for (int i = 0; i < word.Length; i++)
            {
                listBox1.Items.RemoveAt(i);
                listBox1.Items.Insert(i, word[i]);
            }
        }

        private void decreaseAttempts()
        {
            attempts--;

            nAttempts.Text = "You have " + attempts + " attempts left";

            if (attempts == 0)
            {
                wordLabel.Text = "☠️ Game over ☠️";
                wordLabel.Visible = true;

                finalLabel.Text = "You don't have attempts";
                finalLabel.Visible = true;
                letterBox.Enabled = false;
                letterSetterButton.Enabled = false;
                finalWordBox.Enabled = false;
                finalWordSetterButton.Enabled = false;

                this.showWord();

            }
        }

        private void wordLabel_Click(object sender, EventArgs e)
        {

        }

        private void finalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
