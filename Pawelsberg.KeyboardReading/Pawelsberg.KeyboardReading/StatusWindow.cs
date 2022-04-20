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
    public partial class StatusWindow : UserControl
    {
        private StatusWindowItemList m_Items = new StatusWindowItemList();
        public StatusWindowItemList Items
        {
            get { return m_Items; }
        }
        public event EventHandler Stop;
        protected void OnStop(EventArgs e)
        {
            if (Stop != null)
                Stop(this, e);
        }
        public StatusWindow()
        {
            InitializeComponent();
        }
        public void ShowItem(StatusWindowItem item)
        {
            labelStatusWindow.Text = item.Text;
            labelStatusWindow.BackColor = item.BackColor;
            labelStatusWindow.ForeColor = item.ForeColor;
        }
        private void PlayFirstItem()
        {
            ShowItem(Items[0]);
            timerStatusChange.Stop();
            timerStatusChange.Interval = Items[0].Interval;
            timerStatusChange.Start();
        }
        public void Start()
        {
            if (Items.Count == 0)
                throw new InvalidOperationException("Can't start without items");
            PlayFirstItem();
            Items.RemoveItemAt(0);
        }
        private void timerStatusChange_Tick(object sender, EventArgs e)
        {
            if (Items.Count != 0)
            {
                PlayFirstItem();
                Items.RemoveItemAt(0);
            }
            else
            {
                timerStatusChange.Stop();
                OnStop(null);
            }
        }
    }
    public struct StatusWindowItem
    {
        private string m_Text;
        public string Text
        {
            get { return m_Text; }
            set { m_Text = value; }
        }
        private Color m_BackColor;
        public Color BackColor
        {
            get { return m_BackColor; }
            set { m_BackColor = value; }
        }
        private int m_Interval;
        public int Interval
        {
            get { return m_Interval; }
            set { m_Interval = value; }
        }
        private Color m_ForeColor;
        public Color ForeColor
        {
            get { return m_ForeColor; }
            set { m_ForeColor = value; }
        }
        public StatusWindowItem(string text, Color back_color, Color fore_color, int interval)
        {
            m_Text = text;
            m_BackColor = back_color;
            m_ForeColor = fore_color;
            m_Interval = interval;
        }
        public StatusWindowItem(string text, Color back_color, Color fore_color) : this(text,back_color,fore_color,1000)
        {
        }
    }
    public class StatusWindowItemList
    {
        private List<StatusWindowItem> m_Items = new List<StatusWindowItem>();
        public StatusWindowItem AddItem(string text, Color back_color, Color fore_color, int interval)
        {
            StatusWindowItem swi = new StatusWindowItem(text, back_color, fore_color, interval);
            m_Items.Add(swi);
            return swi;
        }
        public int Count
        {
            get { return m_Items.Count; }
        }
        public void RemoveItem(StatusWindowItem swi)
        {
            m_Items.Remove(swi);
        }
        public void RemoveItemAt(int index)
        {
            m_Items.RemoveAt(index);
        }
        public StatusWindowItem this[int index]
        {
            get { return m_Items[index]; }
            set { m_Items[index] = value; }
        }
    }
}
