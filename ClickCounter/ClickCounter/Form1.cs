using System;
using System.Windows.Forms;

namespace ClickCounter
{
    public partial class Form1 : Form
    {
        private int clickCount;       

        public Form1()
        {
            InitializeComponent();
            clickCount = 0;

            this.MouseClick += MainForm_MouseClick;

            this.Controls.Add(clickCountLabel);
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            clickCount++;
            clickCountLabel.Text = $"Mouse Clicks: {clickCount}";
        }
    }
}
