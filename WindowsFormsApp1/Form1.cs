using System;
using System.Windows.Forms;

namespace PlaytoztheGame
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gamePanel = new System.Windows.Forms.Panel();
            this.player1ColorButton = new System.Windows.Forms.Button();
            this.player2ColorButton = new System.Windows.Forms.Button();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.logoLabel = new System.Windows.Forms.Label();
            this.telegramButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Location = new System.Drawing.Point(12, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(500, 500);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Paint);
            this.gamePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GamePanel_MouseClick);
            // 
            // player1ColorButton
            // 
            this.player1ColorButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.player1ColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1ColorButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player1ColorButton.Location = new System.Drawing.Point(521, 50);
            this.player1ColorButton.Name = "player1ColorButton";
            this.player1ColorButton.Size = new System.Drawing.Size(120, 32);
            this.player1ColorButton.TabIndex = 1;
            this.player1ColorButton.Text = "Цвет игрока 1";
            this.player1ColorButton.UseVisualStyleBackColor = false;
            this.player1ColorButton.Click += new System.EventHandler(this.Player1ColorButton_Click);
            // 
            // player2ColorButton
            // 
            this.player2ColorButton.BackColor = System.Drawing.Color.Violet;
            this.player2ColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player2ColorButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player2ColorButton.Location = new System.Drawing.Point(521, 88);
            this.player2ColorButton.Name = "player2ColorButton";
            this.player2ColorButton.Size = new System.Drawing.Size(120, 32);
            this.player2ColorButton.TabIndex = 2;
            this.player2ColorButton.Text = "Цвет игрока 2";
            this.player2ColorButton.UseVisualStyleBackColor = false;
            this.player2ColorButton.Click += new System.EventHandler(this.Player2ColorButton_Click);
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.backgroundColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backgroundColorButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backgroundColorButton.Location = new System.Drawing.Point(521, 12);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(120, 32);
            this.backgroundColorButton.TabIndex = 3;
            this.backgroundColorButton.Text = "Цвет фона";
            this.backgroundColorButton.UseVisualStyleBackColor = false;
            this.backgroundColorButton.Click += new System.EventHandler(this.BackgroundColorButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(521, 261);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 49);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Очистить поле";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.SteelBlue;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startButton.Location = new System.Drawing.Point(521, 160);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 32);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.MediumPurple;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stopButton.Location = new System.Drawing.Point(521, 198);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(120, 32);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.Color.Black;
            this.logoLabel.Location = new System.Drawing.Point(525, 444);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(116, 24);
            this.logoLabel.TabIndex = 7;
            this.logoLabel.Text = "MartinBroni";
            // 
            // telegramButton
            // 
            this.telegramButton.BackColor = System.Drawing.Color.SkyBlue;
            this.telegramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telegramButton.ForeColor = System.Drawing.Color.Transparent;
            this.telegramButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.telegramButton.Location = new System.Drawing.Point(521, 471);
            this.telegramButton.Name = "telegramButton";
            this.telegramButton.Size = new System.Drawing.Size(120, 41);
            this.telegramButton.TabIndex = 11;
            this.telegramButton.Text = "Telegram";
            this.telegramButton.UseVisualStyleBackColor = false;
            this.telegramButton.Click += new System.EventHandler(this.TelegramButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(650, 526);
            this.Controls.Add(this.telegramButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.backgroundColorButton);
            this.Controls.Add(this.player2ColorButton);
            this.Controls.Add(this.player1ColorButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gamePanel);
            this.Name = "MainForm";
            this.Text = "Игра в жизнь";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button player1ColorButton;
        private System.Windows.Forms.Button player2ColorButton;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label logoLabel;
        private Button telegramButton;

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}