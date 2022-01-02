using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Cathrine_GameCoinGuess
{
    public partial class FormGuessTheCoinFace : Form
    {
        Random generator = new Random();
        double money, numberGuess, correctGuess, betMoney, percentageGuess;
        string resourcespath = Application.StartupPath + "\\Resources\\";
        WindowsMediaPlayer loopSound = new WindowsMediaPlayer();
        WindowsMediaPlayer normalSound = new WindowsMediaPlayer();

        public FormGuessTheCoinFace()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //ngerandom gambar
            int randomNumber = generator.Next(1, 3);
            numberGuess++;
            if (randomNumber == 1)
            {
                pictureBoxCoin.Image = Properties.Resources.CoinHead;
            }
            else if (randomNumber == 2)
            {
                pictureBoxCoin.Image = Properties.Resources.CoinTail;
            }

            //cek jawaban benar atau salah
            if (randomNumber == 1 && radioButtonHead.Checked)
            {
                normalSound.URL = resourcespath + "Correct.wav";
                money = money + (betMoney * 2.0);
                correctGuess++;
                labelDisplayComment.Text = "You win";
            }
            else if (randomNumber == 1 && radioButtonTail.Checked)
            {
                normalSound.URL = resourcespath + "Incorrect.wav";
                money = money;
                labelDisplayComment.Text = "You lose";
            }
            else if (randomNumber == 2 && radioButtonTail.Checked)
            {
                normalSound.URL = resourcespath + "Correct.wav";
                money = money + (betMoney * 2.0);
                correctGuess++;
                labelDisplayComment.Text = "You win";
            }
            else if (randomNumber == 2 && radioButtonHead.Checked)
            {
                normalSound.URL = resourcespath + "Incorrect.wav";
                money = money;
                labelDisplayComment.Text = "You lose";
            }

            buttonContinue.Enabled = true;
            buttonLock.Enabled = false;
            buttonSubmit.Enabled = false;
            groupBoxGuess.Enabled = false;

            percentageGuess = (correctGuess / numberGuess) * 100;
            labelShowPercentage.Text =percentageGuess.ToString();

            labelDisplayMoney.Text = money.ToString("n0");
            labelShowCorrect.Text = correctGuess.ToString();
            labelShowGuess.Text = numberGuess.ToString();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            pictureBoxCoin.Image = Properties.Resources.QuestionMark;
            textBoxBet.Enabled = true;
            buttonContinue.Enabled = false;
            buttonLock.Enabled = true;
            buttonSubmit.Enabled = false;
            groupBoxGuess.Enabled = true;
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            buttonLock.Enabled = false;
            textBoxBet.Enabled = false;
            groupBoxGuess.Enabled = false;
            buttonSubmit.Enabled = true;
            betMoney = int.Parse(textBoxBet.Text);

            if (betMoney>0)
            {
                if (betMoney<=money)
                {
                    money = money - betMoney;
                    labelDisplayMoney.Text = money.ToString("n0");
                }
                else
                {
                    MessageBox.Show("You don't have enough money.");
                }
            }
            else
            {
                MessageBox.Show("You aren't allowed to input negative number. ");
            }
        }

        private void FormGuessTheCoinFace_Load(object sender, EventArgs e)
        {
            loopSound.URL = resourcespath + "\\BackgroundMusic.mid";
            loopSound.settings.setMode("loop", true);

            money = 0;
            numberGuess = 0;
            correctGuess = 0;
            percentageGuess = 0;

            labelDisplayMoney.Text=money.ToString("N0");
            labelShowCorrect.Text =correctGuess.ToString();
            labelShowPercentage.Text =percentageGuess.ToString();
            labelShowGuess.Text = numberGuess.ToString();

            textBoxBet.Enabled = false;
            labelDisplayComment.Text = "";
            buttonContinue.Enabled = false;
            buttonLock.Enabled = false;
            groupBoxGuess.Enabled = false;
            buttonSubmit.Enabled = false;
        }

        private void buttonStartRestart_Click(object sender, EventArgs e)
        {
            money = 1000000;

            pictureBoxCoin.Image = Properties.Resources.QuestionMark;
            labelDisplayMoney.Text = money.ToString("n0");
            buttonLock.Enabled = true;
            textBoxBet.Enabled = true;
            groupBoxGuess.Enabled = true;
            
        }
    }
}
