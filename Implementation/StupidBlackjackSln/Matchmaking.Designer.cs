﻿namespace StupidBlackjackSln
{
    partial class Matchmaking
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
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupMatchmaking = new System.Windows.Forms.GroupBox();
            this.labelError = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newGameName = new System.Windows.Forms.TextBox();
            this.radioBtnNewGame = new System.Windows.Forms.RadioButton();
            this.radioBtnExistingGame = new System.Windows.Forms.RadioButton();
            this.lstBoxGames = new System.Windows.Forms.ListBox();
            this.groupMatchmaking.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(516, 575);
            this.Ok.Margin = new System.Windows.Forms.Padding(4);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(100, 46);
            this.Ok.TabIndex = 3;
            this.Ok.Text = "Okay";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(336, 575);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(116, 46);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupMatchmaking
            // 
            this.groupMatchmaking.BackColor = System.Drawing.Color.Transparent;
            this.groupMatchmaking.Controls.Add(this.labelError);
            this.groupMatchmaking.Controls.Add(this.button1);
            this.groupMatchmaking.Controls.Add(this.label1);
            this.groupMatchmaking.Controls.Add(this.newGameName);
            this.groupMatchmaking.Controls.Add(this.radioBtnNewGame);
            this.groupMatchmaking.Controls.Add(this.radioBtnExistingGame);
            this.groupMatchmaking.Controls.Add(this.lstBoxGames);
            this.groupMatchmaking.Location = new System.Drawing.Point(12, 12);
            this.groupMatchmaking.Margin = new System.Windows.Forms.Padding(4);
            this.groupMatchmaking.Name = "groupMatchmaking";
            this.groupMatchmaking.Padding = new System.Windows.Forms.Padding(4);
            this.groupMatchmaking.Size = new System.Drawing.Size(602, 556);
            this.groupMatchmaking.TabIndex = 8;
            this.groupMatchmaking.TabStop = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(12, 1015);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(105, 25);
            this.labelError.TabIndex = 14;
            this.labelError.Text = "labelError";
            this.labelError.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 291);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(74, 442);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name: ";
            // 
            // newGameName
            // 
            this.newGameName.HideSelection = false;
            this.newGameName.Location = new System.Drawing.Point(226, 444);
            this.newGameName.Margin = new System.Windows.Forms.Padding(4);
            this.newGameName.Name = "newGameName";
            this.newGameName.Size = new System.Drawing.Size(214, 31);
            this.newGameName.TabIndex = 11;
            // 
            // radioBtnNewGame
            // 
            this.radioBtnNewGame.AutoSize = true;
            this.radioBtnNewGame.Checked = true;
            this.radioBtnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNewGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioBtnNewGame.Location = new System.Drawing.Point(34, 400);
            this.radioBtnNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnNewGame.Name = "radioBtnNewGame";
            this.radioBtnNewGame.Size = new System.Drawing.Size(209, 41);
            this.radioBtnNewGame.TabIndex = 10;
            this.radioBtnNewGame.TabStop = true;
            this.radioBtnNewGame.Text = "New game";
            this.radioBtnNewGame.UseVisualStyleBackColor = true;
            // 
            // radioBtnExistingGame
            // 
            this.radioBtnExistingGame.AutoSize = true;
            this.radioBtnExistingGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnExistingGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioBtnExistingGame.Location = new System.Drawing.Point(34, 31);
            this.radioBtnExistingGame.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnExistingGame.Name = "radioBtnExistingGame";
            this.radioBtnExistingGame.Size = new System.Drawing.Size(268, 41);
            this.radioBtnExistingGame.TabIndex = 9;
            this.radioBtnExistingGame.Text = "Existing Game";
            this.radioBtnExistingGame.UseVisualStyleBackColor = true;
            this.radioBtnExistingGame.CheckedChanged += new System.EventHandler(this.RadioBtnExistingGame_CheckedChanged);
            // 
            // lstBoxGames
            // 
            this.lstBoxGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lstBoxGames.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstBoxGames.FormattingEnabled = true;
            this.lstBoxGames.ItemHeight = 25;
            this.lstBoxGames.Location = new System.Drawing.Point(78, 77);
            this.lstBoxGames.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxGames.Name = "lstBoxGames";
            this.lstBoxGames.Size = new System.Drawing.Size(516, 204);
            this.lstBoxGames.TabIndex = 8;
            this.lstBoxGames.SelectedIndexChanged += new System.EventHandler(this.lstBoxGames_SelectedIndexChanged_1);
            // 
            // Matchmaking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StupidBlackjackSln.Properties.Resources.table_texture;
            this.ClientSize = new System.Drawing.Size(630, 635);
            this.Controls.Add(this.groupMatchmaking);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Matchmaking";
            this.Text = "Stupid Gray Blackjack Matchmaking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Matchmaking_FormClosed);
            this.Load += new System.EventHandler(this.Matchmaking_Load);
            this.groupMatchmaking.ResumeLayout(false);
            this.groupMatchmaking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupMatchmaking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newGameName;
        private System.Windows.Forms.RadioButton radioBtnNewGame;
        private System.Windows.Forms.RadioButton radioBtnExistingGame;
        private System.Windows.Forms.ListBox lstBoxGames;
        private System.Windows.Forms.Label labelError;
    }
}