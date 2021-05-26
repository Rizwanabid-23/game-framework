
namespace game
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
            this.enemy01 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player01 = new System.Windows.Forms.PictureBox();
            this.charactersUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enemy01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player01)).BeginInit();
            this.SuspendLayout();
            // 
            // enemy01
            // 
            this.enemy01.BackColor = System.Drawing.SystemColors.ControlDark;
            this.enemy01.Location = new System.Drawing.Point(265, 117);
            this.enemy01.Name = "enemy01";
            this.enemy01.Size = new System.Drawing.Size(49, 75);
            this.enemy01.TabIndex = 0;
            this.enemy01.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.tick);
            // 
            // player01
            // 
            this.player01.BackColor = System.Drawing.SystemColors.ControlDark;
            this.player01.Location = new System.Drawing.Point(427, 144);
            this.player01.Name = "player01";
            this.player01.Size = new System.Drawing.Size(49, 75);
            this.player01.TabIndex = 0;
            this.player01.TabStop = false;
            // 
            // charactersUpdate
            // 
            this.charactersUpdate.AutoSize = true;
            this.charactersUpdate.Location = new System.Drawing.Point(21, 16);
            this.charactersUpdate.Name = "charactersUpdate";
            this.charactersUpdate.Size = new System.Drawing.Size(35, 13);
            this.charactersUpdate.TabIndex = 1;
            this.charactersUpdate.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.charactersUpdate);
            this.Controls.Add(this.player01);
            this.Controls.Add(this.enemy01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.enemy01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox enemy01;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player01;
        private System.Windows.Forms.Label charactersUpdate;
    }
}

