
namespace game_framework_2
{
    partial class Form1
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
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hero1 = new System.Windows.Forms.PictureBox();
            this.characterCounters = new System.Windows.Forms.Label();
            this.hero2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero2)).BeginInit();
            this.SuspendLayout();
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.DarkGray;
            this.enemy1.Location = new System.Drawing.Point(332, 96);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(54, 85);
            this.enemy1.TabIndex = 0;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.DarkGray;
            this.enemy2.Location = new System.Drawing.Point(453, 96);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(54, 85);
            this.enemy2.TabIndex = 0;
            this.enemy2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.tick);
            // 
            // hero1
            // 
            this.hero1.BackColor = System.Drawing.Color.DarkGray;
            this.hero1.Location = new System.Drawing.Point(583, 96);
            this.hero1.Name = "hero1";
            this.hero1.Size = new System.Drawing.Size(54, 85);
            this.hero1.TabIndex = 0;
            this.hero1.TabStop = false;
            // 
            // characterCounters
            // 
            this.characterCounters.AutoSize = true;
            this.characterCounters.Location = new System.Drawing.Point(21, 9);
            this.characterCounters.Name = "characterCounters";
            this.characterCounters.Size = new System.Drawing.Size(35, 13);
            this.characterCounters.TabIndex = 1;
            this.characterCounters.Text = "label1";
            // 
            // hero2
            // 
            this.hero2.BackColor = System.Drawing.Color.DarkGray;
            this.hero2.Location = new System.Drawing.Point(214, 187);
            this.hero2.Name = "hero2";
            this.hero2.Size = new System.Drawing.Size(54, 85);
            this.hero2.TabIndex = 0;
            this.hero2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.characterCounters);
            this.Controls.Add(this.hero1);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.hero2);
            this.Controls.Add(this.enemy1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.downPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.downReleased);
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox hero1;
        private System.Windows.Forms.Label characterCounters;
        private System.Windows.Forms.PictureBox hero2;
    }
}

