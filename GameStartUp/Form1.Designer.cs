namespace GameStartUp
{
    partial class MyGame
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
            this.StartGame = new System.Windows.Forms.Button();
            this.StartTimer = new System.Windows.Forms.Label();
            this.PlayGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.Black;
            this.StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartGame.Location = new System.Drawing.Point(67, 12);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(181, 86);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Play Game";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // StartTimer
            // 
            this.StartTimer.AutoSize = true;
            this.StartTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimer.ForeColor = System.Drawing.Color.White;
            this.StartTimer.Location = new System.Drawing.Point(32, 186);
            this.StartTimer.Name = "StartTimer";
            this.StartTimer.Size = new System.Drawing.Size(258, 33);
            this.StartTimer.TabIndex = 1;
            this.StartTimer.Text = "Game Will Start In...";
            this.StartTimer.Visible = false;
            // 
            // PlayGame
            // 
            this.PlayGame.AutoSize = true;
            this.PlayGame.BackColor = System.Drawing.Color.Green;
            this.PlayGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGame.ForeColor = System.Drawing.Color.Black;
            this.PlayGame.Location = new System.Drawing.Point(105, 117);
            this.PlayGame.Name = "PlayGame";
            this.PlayGame.Size = new System.Drawing.Size(93, 46);
            this.PlayGame.TabIndex = 2;
            this.PlayGame.Text = "GO!";
            this.PlayGame.Visible = false;
            // 
            // MyGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(325, 261);
            this.Controls.Add(this.PlayGame);
            this.Controls.Add(this.StartTimer);
            this.Controls.Add(this.StartGame);
            this.Name = "MyGame";
            this.Text = "MyGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Label StartTimer;
        private System.Windows.Forms.Label PlayGame;
    }
}

