using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Encube
{
    partial class GameWindow : Form
    {
        public GameWindow(Game game)
        {
            InitializeComponent();
            this.game = game;

            //databinding
            dicesForRollingDataGridView.DataSource = game.DicesForRolling;//bindingSource1;
            dicesWithChanceForRollingDataGridView.DataSource = game.DicesWithChanceForRolling;
            dicesResultDataGridView.DataSource = game.DicesResult;

            numericUpDown1.Maximum = game.DicesForRolling.Count;
            this.firstTime=true;
            this.timer=new Stopwatch();
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var diceForRolling in game.DicesForRolling)
                diceForRolling.roll();
            updateDataGrids();



            if (firstTime)
            {
                button1.Enabled = false;
                button1.Hide();
                label1.Enabled = true;
                label1.Show();
                numericUpDown1.Enabled = true;
                numericUpDown1.Show();
                button2.Enabled = true;
                button2.Show();
                game.sortDices();
                updateDataGrids();
            }
            else
            {
                game.moveFromChancesToResult();
                game.moveFromRollingToChances();
                updateDataGrids();
                if (game.isGameOver())
                    gameEnd(game.isGameWon()==1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (firstTime)
            {
                int wybranaLiczba = (int)(numericUpDown1.Value);
                game.setNumer(wybranaLiczba);
                if (game.isThereNumber(wybranaLiczba) == false)
                    gameEnd(false);
                firstTime = false;
            }


            game.moveFromRollingToChances();

            button2.Enabled = false;
            button2.Hide();
            label1.Enabled = false;
            label1.Text = "Wybrano numer:";
            numericUpDown1.Enabled = false;
            //numericUpDown1.Hide();

            button1.Enabled = true;
            button1.Show();
            updateDataGrids();
        }

        public void updateDataGrids()
        {
            
            //databinding
            dicesForRollingDataGridView.DataSource = game.DicesForRolling;//bindingSource1;
            dicesWithChanceForRollingDataGridView.DataSource = game.DicesWithChanceForRolling;
            dicesResultDataGridView.DataSource = game.DicesResult;
            dicesForRollingDataGridView.Refresh();
            dicesWithChanceForRollingDataGridView.Refresh();
            dicesResultDataGridView.Refresh();
        }

        public void gameEnd(bool isGameWon)
        {
            timer.Stop();
            if (isGameWon)
                MessageBox.Show("Gratulacje, Wygrałeś!\n Twój czas to: " + (timer.ElapsedMilliseconds / 1000.0).ToString() + "s");
            else
                MessageBox.Show("Koniec gry.\nPrzegrałeś...");
            this.Close();
        }

        private void zasadyGryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Game.rules());
        }

        private void autorzyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Game.authors());
        }

        private void oGrzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Game.aboutGame());
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool firstTime;
        private Game game;
        private Stopwatch timer;
    }
}
