﻿using StupidBlackjackSln.Code;
using StupidBlackjackSln.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StupidBlackjackSln
{
    public partial class FrmNewGame : Form
    {
        public static Deck deck;
        private Player player1;
        private PictureBox[] picPlayerCards;
        private int ticks = 15;  //15 seconds for a player's turn

        public FrmNewGame()
        {
            InitializeComponent();
            timer1.Start();
            picPlayerCards = new PictureBox[5];
            for (int i = 0; i < 5; i++)
            {
                picPlayerCards[i] = Controls.Find("picPlayerCard" + (i + 1).ToString(), true)[0] as PictureBox;
            }
        }

        private void FrmNewGame_Load(object sender, EventArgs e)
        {
            deck = new Deck(FindBitmap);
            player1 = new BlackjackPlayer();

            player1.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
            showHand();
        }

        private void showHand()
        {
            for (int i = 0; i < player1.Hand.Count(); i++)
            {
                picPlayerCards[i].BackgroundImage = player1.Hand[i].Bitmap;
            }
            lblPlayerScore.Text = player1.Score.ToString();
        }

        private void FrmNewGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            player1.giveCard(deck.dealCard());
            showHand();
        }

        private Bitmap FindBitmap(string value, string suit)
        {
            string textName = "";
            int valueAsNum;
            if (int.TryParse(value, out valueAsNum))
            {
                textName += "_";
            }

            textName += value;
            textName += "_of_";
            textName += suit;

            return (Bitmap)Resources.ResourceManager.GetObject(textName);
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            Player.isTurn = false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Get rid of connection to server
            //TODO
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks--;    //Time ticks down each second
            label2.Text = ticks.ToString();
            this.Text = ticks.ToString();

            if (ticks <= 0)
            {
                this.Text = "Turn Over";
                timer1.Stop();        //ToDo
            }                        //This would end the player's turn and make them Stand.
        }
    }
}
