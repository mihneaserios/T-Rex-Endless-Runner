namespace T_Rex_Endless_Runner
{
    partial class TRexMainClass
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trexpictureBox = new System.Windows.Forms.PictureBox();
            this.obstacle1pictureBox = new System.Windows.Forms.PictureBox();
            this.obstacle2pictureBox = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trexpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(0, 409);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(915, 47);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trexpictureBox
            // 
            this.trexpictureBox.Image = global::T_Rex_Endless_Runner.Properties.Resources.running;
            this.trexpictureBox.Location = new System.Drawing.Point(12, 300);
            this.trexpictureBox.Name = "trexpictureBox";
            this.trexpictureBox.Size = new System.Drawing.Size(40, 43);
            this.trexpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trexpictureBox.TabIndex = 1;
            this.trexpictureBox.TabStop = false;
            // 
            // obstacle1pictureBox
            // 
            this.obstacle1pictureBox.Image = global::T_Rex_Endless_Runner.Properties.Resources.obstacle_1;
            this.obstacle1pictureBox.Location = new System.Drawing.Point(406, 365);
            this.obstacle1pictureBox.Name = "obstacle1pictureBox";
            this.obstacle1pictureBox.Size = new System.Drawing.Size(23, 46);
            this.obstacle1pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1pictureBox.TabIndex = 2;
            this.obstacle1pictureBox.TabStop = false;
            this.obstacle1pictureBox.Tag = "obstacle";
            // 
            // obstacle2pictureBox
            // 
            this.obstacle2pictureBox.Image = global::T_Rex_Endless_Runner.Properties.Resources.obstacle_2;
            this.obstacle2pictureBox.Location = new System.Drawing.Point(748, 378);
            this.obstacle2pictureBox.Name = "obstacle2pictureBox";
            this.obstacle2pictureBox.Size = new System.Drawing.Size(32, 33);
            this.obstacle2pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle2pictureBox.TabIndex = 3;
            this.obstacle2pictureBox.TabStop = false;
            this.obstacle2pictureBox.Tag = "obstacle";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreLabel.Location = new System.Drawing.Point(36, 22);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(135, 33);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 50;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // TRexMainClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(907, 446);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.obstacle2pictureBox);
            this.Controls.Add(this.obstacle1pictureBox);
            this.Controls.Add(this.trexpictureBox);
            this.Name = "TRexMainClass";
            this.Text = "TRexMainClass";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trexpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox trexpictureBox;
        private System.Windows.Forms.PictureBox obstacle1pictureBox;
        private System.Windows.Forms.PictureBox obstacle2pictureBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer GameTimer;
    }
}

