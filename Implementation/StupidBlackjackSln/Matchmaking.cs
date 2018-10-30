﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace StupidBlackjackSln
{
    public partial class Matchmaking : Form
    {

        private Thread RefreshThread;

        public Matchmaking()
        {
            InitializeComponent();
            RefreshThread = new Thread(RefreshLoop);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RefreshLoop()
        {
            while (true)
            {
                Thread.Sleep(3000);
                this.RefreshGameList();
            }
        }

        private void RefreshGameList()
        {
            String[] games = Program.GetConnector().FetchListOfGames();
            foreach (String game in games)
            {
                if (!lstBoxGames.Items.Contains(game))
                {
                    lstBoxGames.Items.Add(game);
                }
            }
            for (int i=0; i<lstBoxGames.Items.Count; i++)
            {
                if (!games.Contains(lstBoxGames.Items[i]))
                {
                    lstBoxGames.Items.RemoveAt(i);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshGameList();
        }

        private void Matchmaking_Load(object sender, EventArgs e)
        {

        }
    }
}
