using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pawelsberg.KeyboardReading
{
    class Game
    {
        // Status of the Game 
        public enum GameStatus
        {
            BeforeStart, // before starting the game
            Playing, // game is currently going
            GameOver // game over
        }
        private GameStatus m_Status;
        public GameStatus status
        {
            get { return m_Status; }
            set
            {
                m_Status = value;
                // generate status change events
                switch (m_Status)
                {
                    case GameStatus.GameOver:
                        OnGameOver(null); break;
                    case GameStatus.Playing:
                        OnStartGame(null); break;
                }
            }
        }

        // public properties - game state
        public int lvl { get; set; } // current game level (from 0)
        public int lvl_progress { get; set; } // current level progress (from 0)
        public int lvl_progress_max { get; set; } // maximum progres per level
        public Word word { get; set; } // word that we are currently guessing
        public int tries_left { get; set; } // number of tries left of current word

        // event when game over
        public event EventHandler GameOver;
        protected void OnGameOver(EventArgs e)
        {
            if (GameOver != null)
                GameOver(this, e);
        }
        // event when starting the game
        public event EventHandler StartGame;
        protected void OnStartGame(EventArgs e)
        {
            if (StartGame != null)
                StartGame(this, e);
        }
        // event when player guess word - good try
        public event EventHandler<GoodTryEventArgs> GoodTry;
        protected void OnGoodTry(GoodTryEventArgs e)
        {
            if (GoodTry != null)
                GoodTry(this, e);
        }
        // event when player doesn't guess word - bad try
        public event EventHandler BadTry;
        protected void OnBadTry(EventArgs e)
        {
            if (BadTry != null)
                BadTry(this, e);
        }

        // return created new game - ready to start
        public static Game CreateNewGame()
        {
            Game ret = new Game(); // create new game
            ret.status = GameStatus.BeforeStart; // with status before start
            ret.lvl = 0; // with first level
            ret.lvl_progress = 0; // at first word
            ret.lvl_progress_max = 3; // set 3 words per level
            ret.tries_left = 3; // tries left = 3
            return ret;
        }
        // create random word for level
        private void CreateRandowmWord(int lvl)
        {
            switch (lvl) // get word for level - higher level - higher word complexity and showing speed
            {
                case 0: word = Word.GenerateRandomWord(4, 2000, true, true, true); break;
                case 1: word = Word.GenerateRandomWord(6, 1500, true, false, false); break;
                case 2: word = Word.GenerateRandomWord(5, 1500, true, true, false); break;
                case 3: word = Word.GenerateRandomWord(5, 1500, true, false, true); break;
                case 4: word = Word.GenerateRandomWord(6, 1200, true, false, false); break;
                case 5: word = Word.GenerateRandomWord(6, 1200, true, true, false); break;
                case 6: word = Word.GenerateRandomWord(6, 1000, true, false, true); break;
                case 7: word = Word.GenerateRandomWord(7, 800, true, false, false); break;
                default: word = Word.GenerateRandomWord(10, 500, true, true, true); break;
            }
        }
        // start new game
        public void Start()
        {
            status = GameStatus.Playing;
            CreateRandowmWord(lvl);
        }
        // increment game progress - return if level has increased
        private void IncrementProgress(out bool level_increased)
        {
            if (lvl_progress == lvl_progress_max - 1) // if progrex for this level is alredy at max
            {
                lvl++; // increase level
                lvl_progress = 0; // zero progress for this level
                level_increased = true; // return information that level has increased
            }
            else // if progress for this level is not at max
            {
                lvl_progress++; // increase progress
                level_increased = false; // return information that level has not increased
            }
        }
        // try word - check if it is good
        public bool TryWord(string tryword)
        {
            if (status != GameStatus.Playing) // check that we are playing
                throw new Exception("You are not playing. Cant try");
            if (word.Text == tryword) // if was good try - good guess
            {
                bool level_increased;
                IncrementProgress(out level_increased); // increase progress
                OnGoodTry(new GoodTryEventArgs(level_increased)); // generate event on good try and pass into information if level has increased
                CreateRandowmWord(lvl); // create new word 
                tries_left = 3; // restore number of tries for new word
                return true; // return information that it was good try
            }
            else // if it was bad try
            {
                tries_left--; // decrease number of tries left
                if (tries_left <= 0) // check if we can not try once again
                    status = GameStatus.GameOver; // set status game over
                OnBadTry(null); // generate event on bad try
                return false; // return information that it was bad try
            }
        }
    }
    // good try event arguments - with level increased bool information
    class GoodTryEventArgs : EventArgs
    {
        public GoodTryEventArgs(bool LvlIncreased)
        {
            m_LevelIncreased = LvlIncreased;
        }
        // level increased bool property - informs that after good try game level has increased
        private bool m_LevelIncreased;
        public bool LevelIncreased
        {
            get { return m_LevelIncreased; }
            set { m_LevelIncreased = value; }
        }
    }
}
