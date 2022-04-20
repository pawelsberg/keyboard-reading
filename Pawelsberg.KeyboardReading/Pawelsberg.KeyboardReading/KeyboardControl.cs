using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pawelsberg.KeyboardReading
{
    public partial class KeyboardControl : UserControl
    {
        private Label m_lbl = null;
        private Label m_shlbl = null;
        private string m_buf = "";
        private int m_key_delay;
        public int KeyDelay 
        { 
            get
            {
                return m_key_delay;
            } 
            set
            {
                m_key_delay = value;
                timerType.Interval = m_key_delay;
            } 
        }
        public event EventHandler Stop;
        protected void OnStop(EventArgs e)
        {
            if (Stop != null)
                Stop(this, e);
        }
        public KeyboardControl()
        {
            InitializeComponent();
            KeyDelay = 1000;
        }
        private Rectangle KeyPosition(System.ConsoleKey key)
        {
            Rectangle keyrec = new Rectangle();
            switch (key)
            {

                case System.ConsoleKey.Z: keyrec = new Rectangle(97, 175, 24, 28); break;
                case System.ConsoleKey.X: keyrec = new Rectangle(138, 175, 24, 28); break;
                case System.ConsoleKey.C: keyrec = new Rectangle(179, 175, 24, 28); break;
                case System.ConsoleKey.V: keyrec = new Rectangle(220, 175, 24, 28); break;
                case System.ConsoleKey.B: keyrec = new Rectangle(260, 175, 24, 28); break;
                case System.ConsoleKey.N: keyrec = new Rectangle(300, 175, 24, 28); break;
                case System.ConsoleKey.M: keyrec = new Rectangle(341, 175, 24, 28); break;

                case System.ConsoleKey.A: keyrec = new Rectangle(78, 133,  24, 28); break;
                case System.ConsoleKey.S: keyrec = new Rectangle(119, 133, 24, 28); break;
                case System.ConsoleKey.D: keyrec = new Rectangle(160, 133, 24, 28); break;
                case System.ConsoleKey.F: keyrec = new Rectangle(201, 133, 24, 28); break;
                case System.ConsoleKey.G: keyrec = new Rectangle(242, 133, 24, 28); break;
                case System.ConsoleKey.H: keyrec = new Rectangle(282, 133, 24, 28); break;
                case System.ConsoleKey.J: keyrec = new Rectangle(322, 133, 24, 28); break;
                case System.ConsoleKey.K: keyrec = new Rectangle(362, 133, 24, 28); break;
                case System.ConsoleKey.L: keyrec = new Rectangle(402, 133, 24, 28); break;



                case System.ConsoleKey.Q: keyrec = new Rectangle(68, 92,  24, 28); break;
                case System.ConsoleKey.W: keyrec = new Rectangle(109, 92, 24, 28); break;
                case System.ConsoleKey.E: keyrec = new Rectangle(150, 92, 24, 28); break;
                case System.ConsoleKey.R: keyrec = new Rectangle(191, 92, 24, 28); break;
                case System.ConsoleKey.T: keyrec = new Rectangle(232, 92, 24, 28); break;
                case System.ConsoleKey.Y: keyrec = new Rectangle(272, 92, 24, 28); break;
                case System.ConsoleKey.U: keyrec = new Rectangle(312, 92, 24, 28); break;
                case System.ConsoleKey.I: keyrec = new Rectangle(352, 92, 24, 28); break;
                case System.ConsoleKey.O: keyrec = new Rectangle(392, 92, 24, 28); break;
                case System.ConsoleKey.P: keyrec = new Rectangle(432, 92, 24, 28); break;
               
                case System.ConsoleKey.D1: keyrec = new Rectangle(48, 52, 24, 28); break;
                case System.ConsoleKey.D2: keyrec = new Rectangle(89, 52, 24, 28); break;
                case System.ConsoleKey.D3: keyrec = new Rectangle(130, 52, 24, 28); break;
                case System.ConsoleKey.D4: keyrec = new Rectangle(171, 52, 24, 28); break;
                case System.ConsoleKey.D5: keyrec = new Rectangle(212, 52, 24, 28); break;
                case System.ConsoleKey.D6: keyrec = new Rectangle(253, 52, 24, 28); break;
                case System.ConsoleKey.D7: keyrec = new Rectangle(292, 52, 24, 28); break;
                case System.ConsoleKey.D8: keyrec = new Rectangle(333, 52, 24, 28); break;
                case System.ConsoleKey.D9: keyrec = new Rectangle(373, 52, 24, 28); break;
                case System.ConsoleKey.D0: keyrec = new Rectangle(412, 52, 24, 28); break;
            }
            return keyrec;
        }
        private Rectangle ShiftPosition()
        {
            return new Rectangle(5, 175, 30, 28);
        }
        private ConsoleKey CharToKey(char c)
        {
            if ((c >= 'A') && (c <= 'Z')) 
                return CharToKey((char)(c-('A'-'a')));

            switch (c)
            {
                case '1': return ConsoleKey.D1;
                case '2': return ConsoleKey.D2;
                case '3': return ConsoleKey.D3;
                case '4': return ConsoleKey.D4;
                case '5': return ConsoleKey.D5;
                case '6': return ConsoleKey.D6;
                case '7': return ConsoleKey.D7;
                case '8': return ConsoleKey.D8;
                case '9': return ConsoleKey.D9;
                case '0': return ConsoleKey.D0;

                case '!': return ConsoleKey.D1;
                case '@': return ConsoleKey.D2;
                case '#': return ConsoleKey.D3;
                case '$': return ConsoleKey.D4;
                case '%': return ConsoleKey.D5;
                case '^': return ConsoleKey.D6;
                case '&': return ConsoleKey.D7;
                case '*': return ConsoleKey.D8;
                case '(': return ConsoleKey.D9;
                case ')': return ConsoleKey.D0;

                
                
                
                case 'q': return ConsoleKey.Q;
                case 'w': return ConsoleKey.W;
                case 'e': return ConsoleKey.E;
                case 'r': return ConsoleKey.R;
                case 't': return ConsoleKey.T;
                case 'y': return ConsoleKey.Y;
                case 'u': return ConsoleKey.U;
                case 'i': return ConsoleKey.I;
                case 'o': return ConsoleKey.O;
                case 'p': return ConsoleKey.P;

                case 'a': return ConsoleKey.A;
                case 's': return ConsoleKey.S;
                case 'd': return ConsoleKey.D;
                case 'f': return ConsoleKey.F;
                case 'g': return ConsoleKey.G;
                case 'h': return ConsoleKey.H;
                case 'j': return ConsoleKey.J;
                case 'k': return ConsoleKey.K;
                case 'l': return ConsoleKey.L;

                case 'z': return ConsoleKey.Z;
                case 'x': return ConsoleKey.X;
                case 'c': return ConsoleKey.C;
                case 'v': return ConsoleKey.V;
                case 'b': return ConsoleKey.B;
                case 'n': return ConsoleKey.N;
                case 'm': return ConsoleKey.M;

            
            
            
            }
            return ConsoleKey.NoName;
        }
        private bool CharToShift(char c)
        {
            if ((c >= 'A') && (c <= 'Z')) return true;
            if ((c >= 'a') && (c <= 'z')) return false;
            if ((c >= '0') && (c <= '9')) return false;
            if ("!@#$%^&*()".Contains(c)) return true;
            throw new ArgumentOutOfRangeException("c");
        }
        public void DeSelectKey()
        {
            if (m_lbl != null)
            {
                this.Controls.Remove(m_lbl);
                m_lbl = null;
            }
        }
        public void DeSelectShift()
        {
            if (m_shlbl != null)
            {
                this.Controls.Remove(m_shlbl);
                m_shlbl = null;
            }
        }
        private void SelectRectangle(Rectangle rec, ref Label lbl)
        {
            // create new selection
            lbl = new Label();
            lbl.AutoSize = false;
            lbl.Location = rec.Location;
            lbl.Size = rec.Size;
            lbl.BackColor = Color.Black;
            this.Controls.Add(lbl);
            lbl.BringToFront();
        }
        private void SelectKey(System.ConsoleKey key)
        {
            SelectRectangle(KeyPosition(key),ref m_lbl);
        }
        private void SelectShift()
        {
            SelectRectangle(ShiftPosition(), ref m_shlbl);
        }
        public void Type(string str)
        {
            DeSelectKey();
            DeSelectShift(); 
            m_buf = str;
            timerPause.Start();
        }
        public void Type(string str, int keyDelay)
        {
            KeyDelay = keyDelay;
            Type(str);
        }
        private void timerType_Tick(object sender, EventArgs e)
        {
            timerType.Stop();
            DeSelectKey();
            DeSelectShift();
            timerPause.Start();
        }
        private void timerPause_Tick(object sender, EventArgs e)
        {
            timerPause.Stop();
            if (m_buf.Length > 0)
            {
                SelectKey(CharToKey(m_buf[0]));
                if (CharToShift(m_buf[0]))
                    SelectShift();

                m_buf = m_buf.Substring(1);
                timerType.Start();
            }
            else
            {
                OnStop(null);
            }

        }


    }
}
