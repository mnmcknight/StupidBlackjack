﻿namespace StupidBlackjackSln
{
    partial class FrmNewGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard3 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard4 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard5 = new System.Windows.Forms.PictureBox();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard5)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayerCard1
            // 
            this.picPlayerCard1.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerCard1.Location = new System.Drawing.Point(112, 242);
            this.picPlayerCard1.Name = "picPlayerCard1";
            this.picPlayerCard1.Size = new System.Drawing.Size(106, 144);
            this.picPlayerCard1.TabIndex = 0;
            this.picPlayerCard1.TabStop = false;
            // 
            // picPlayerCard2
            // 
            this.picPlayerCard2.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerCard2.Location = new System.Drawing.Point(254, 242);
            this.picPlayerCard2.Name = "picPlayerCard2";
            this.picPlayerCard2.Size = new System.Drawing.Size(106, 144);
            this.picPlayerCard2.TabIndex = 1;
            this.picPlayerCard2.TabStop = false;
            // 
            // picPlayerCard3
            // 
            this.picPlayerCard3.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerCard3.Location = new System.Drawing.Point(396, 242);
            this.picPlayerCard3.Name = "picPlayerCard3";
            this.picPlayerCard3.Size = new System.Drawing.Size(106, 144);
            this.picPlayerCard3.TabIndex = 2;
            this.picPlayerCard3.TabStop = false;
            // 
            // picPlayerCard4
            // 
            this.picPlayerCard4.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerCard4.Location = new System.Drawing.Point(538, 242);
            this.picPlayerCard4.Name = "picPlayerCard4";
            this.picPlayerCard4.Size = new System.Drawing.Size(106, 144);
            this.picPlayerCard4.TabIndex = 3;
            this.picPlayerCard4.TabStop = false;
            // 
            // picPlayerCard5
            // 
            this.picPlayerCard5.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerCard5.Location = new System.Drawing.Point(680, 242);
            this.picPlayerCard5.Name = "picPlayerCard5";
            this.picPlayerCard5.Size = new System.Drawing.Size(106, 144);
            this.picPlayerCard5.TabIndex = 4;
            this.picPlayerCard5.TabStop = false;
            // 
            // btnHit
            // 
            this.btnHit.AutoSize = true;
            this.btnHit.Location = new System.Drawing.Point(74, 177);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(30, 23);
            this.btnHit.TabIndex = 5;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.AutoSize = true;
            this.btnStand.Location = new System.Drawing.Point(230, 177);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(53, 24);
            this.btnStand.TabIndex = 6;
            this.btnStand.Text = "Stand";
            this.btnStand.UseCompatibleTextRendering = true;
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(435, 162);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(106, 37);
            this.lblPlayerScore.TabIndex = 7;
            this.lblPlayerScore.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StupidBlackjackSln.Properties.Resources.greenfelt;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.picPlayerCard5);
            this.Controls.Add(this.picPlayerCard4);
            this.Controls.Add(this.picPlayerCard3);
            this.Controls.Add(this.picPlayerCard2);
            this.Controls.Add(this.picPlayerCard1);
            this.Name = "FrmNewGame";
            this.Text = "FrmNewGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNewGame_FormClosed);
            this.Load += new System.EventHandler(this.FrmNewGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayerCard1;
        private System.Windows.Forms.PictureBox picPlayerCard2;
        private System.Windows.Forms.PictureBox picPlayerCard3;
        private System.Windows.Forms.PictureBox picPlayerCard4;
        private System.Windows.Forms.PictureBox picPlayerCard5;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}