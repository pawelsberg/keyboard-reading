using Pawelsberg.KeyboardReading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pawelsberg.KeyboardReading
{
    public partial class MainForm : Form
    {
        private Game game;
        public MainForm()
        {
            InitializeComponent();
            SetControlsBeforeStart();
        }
        private void SetControlsBeforeStart()
        {
            buttonStart.Enabled = true;
            textBoxTryWord.Enabled = false;
            buttonTryWord.Enabled = false;
            statusWindow.ShowItem(new StatusWindowItem("Press \"Start Game\" button to start the game", Color.LightGray, Color.Black));
        }
        private void SetControlsForPlaying()
        {
            textBoxTryWord.Enabled = true;
            textBoxTryWord.Text = "";
            textBoxTryWord.Focus();
            buttonTryWord.Enabled = true;
            textBoxSrc.Text = game.word.Text;
            statusWindow.ShowItem(new StatusWindowItem("", Color.White, Color.Black));
        }
        private void SetControlsForPreparation()
        {
            textLevel.Text = (game.lvl + 1).ToString();
            textWord.Text = (game.lvl_progress + 1).ToString() + "/" + game.lvl_progress_max.ToString();

            //
            textBoxTryWord.Enabled = false;
            textBoxTryWord.Text = "";
            buttonTryWord.Enabled = false;
            textBoxSrc.Text = "";

            statusWindow.Items.AddItem("Ready!", Color.White, Color.Red, 1000);
            statusWindow.Items.AddItem("Steady!", Color.White, Color.Orange, 1000);
            statusWindow.Items.AddItem("GO!", Color.White, Color.Green, 1000);
            statusWindow.Start();
        }
        private void buttonChk_Click(object sender, EventArgs e)
        {
            game.TryWord(textBoxTryWord.Text);
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            game = Game.CreateNewGame();
            game.GameOver += new EventHandler(game_GameOver);
            game.StartGame += new EventHandler(game_StartGame);
            game.GoodTry += new EventHandler<GoodTryEventArgs>(game_GoodTry);
            game.BadTry += new EventHandler(game_BadTry);
            game.Start();
            SetControlsForPreparation();
        }

        void game_GoodTry(object sender, GoodTryEventArgs e)
        {
            statusWindow.Items.AddItem("Good one!", Color.Green, Color.White, 2000);
            if (e.LevelIncreased)
                statusWindow.Items.AddItem("Movin to next level!", Color.Blue, Color.White, 3000);
            SetControlsForPreparation();
        }
        void game_BadTry(object sender, EventArgs e)
        {
            if (game.status == Game.GameStatus.GameOver)
                return;
            statusWindow.Items.AddItem("You are wrong! Try again", Color.Red, Color.White,5000);
            SetControlsForPreparation();
        }
        void game_StartGame(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
        }
        void game_GameOver(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            textBoxTryWord.Enabled = false;
            buttonTryWord.Enabled = false;
            statusWindow.ShowItem(new StatusWindowItem("Game Over", Color.Black, Color.White));
        }
        private void textBoxUsr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                game.TryWord(textBoxTryWord.Text);
                e.Handled = true;
            }
        }
        private void statusWindow_Stop(object sender, EventArgs e)
        {
            statusWindow.ShowItem(new StatusWindowItem("", Color.White, Color.Black));
            keyboardControl.Type(game.word.Text, game.word.KeyDelay);
        }
        private void keyboardControl_Stop(object sender, EventArgs e)
        {
            SetControlsForPlaying();
        }
    }
}
