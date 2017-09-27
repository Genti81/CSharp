using GameDiceLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGameGUI
{
    public partial class Form1 : Form
    {
        private Game _game = new Game(new Random());
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThrowDice_Click(object sender, EventArgs e)
        {
            _game.ThrowDices();
            lblFeedback.Content = _game.ToString();
        }
    }
}
