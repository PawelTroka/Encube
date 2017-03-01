using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encube
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialogNewGame = new NewGameWindow();
            if(dialogNewGame.ShowDialog()==DialogResult.OK)
            {
                var game = new Game(dialogNewGame.N);
                this.Hide();
                dialogNewGame.Close();
                var gameWindow = new GameWindow(game);
                gameWindow.FormClosed +=new FormClosedEventHandler(gameWindow_FormClosed);
                gameWindow.Show();
                
            }

        }

        public void gameWindow_FormClosed(object sender, System.EventArgs e)
        {
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Game.aboutGame());
        }
    }
}
