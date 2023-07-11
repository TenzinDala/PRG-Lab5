namespace PRG_Lab5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.raceControl = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.picNaruto = new System.Windows.Forms.PictureBox();
            this.picLuffy = new System.Windows.Forms.PictureBox();
            this.timerChar1 = new System.Windows.Forms.Timer(this.components);
            this.timerChar2 = new System.Windows.Forms.Timer(this.components);
            this.lblLuffy = new System.Windows.Forms.Label();
            this.lblNaruto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            this.raceControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNaruto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLuffy)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.raceTrack.Image = ((System.Drawing.Image)(resources.GetObject("raceTrack.Image")));
            this.raceTrack.Location = new System.Drawing.Point(-11, 199);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(835, 253);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.raceTrack.TabIndex = 2;
            this.raceTrack.TabStop = false;
            // 
            // raceControl
            // 
            this.raceControl.BackColor = System.Drawing.SystemColors.Control;
            this.raceControl.Controls.Add(this.btnExit);
            this.raceControl.Controls.Add(this.btnRestart);
            this.raceControl.Controls.Add(this.btnStart);
            this.raceControl.Location = new System.Drawing.Point(87, 28);
            this.raceControl.Name = "raceControl";
            this.raceControl.Size = new System.Drawing.Size(617, 143);
            this.raceControl.TabIndex = 3;
            this.raceControl.TabStop = false;
            this.raceControl.Text = "Race Control";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(425, 41);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 51);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(232, 41);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(123, 51);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(47, 41);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 51);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picNaruto
            // 
            this.picNaruto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picNaruto.BackgroundImage")));
            this.picNaruto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNaruto.Location = new System.Drawing.Point(12, 346);
            this.picNaruto.Name = "picNaruto";
            this.picNaruto.Size = new System.Drawing.Size(88, 92);
            this.picNaruto.TabIndex = 4;
            this.picNaruto.TabStop = false;
            // 
            // picLuffy
            // 
            this.picLuffy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLuffy.BackgroundImage")));
            this.picLuffy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLuffy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.picLuffy.Location = new System.Drawing.Point(12, 219);
            this.picLuffy.Name = "picLuffy";
            this.picLuffy.Size = new System.Drawing.Size(88, 93);
            this.picLuffy.TabIndex = 5;
            this.picLuffy.TabStop = false;
            // 
            // timerChar1
            // 
            this.timerChar1.Interval = 1000;
            this.timerChar1.Tick += new System.EventHandler(this.timerChar1_Tick);
            // 
            // timerChar2
            // 
            this.timerChar2.Interval = 1000;
            this.timerChar2.Tick += new System.EventHandler(this.timerChar2_Tick);
            // 
            // lblLuffy
            // 
            this.lblLuffy.AutoSize = true;
            this.lblLuffy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLuffy.Location = new System.Drawing.Point(117, 261);
            this.lblLuffy.MaximumSize = new System.Drawing.Size(0, 20);
            this.lblLuffy.Name = "lblLuffy";
            this.lblLuffy.Size = new System.Drawing.Size(30, 13);
            this.lblLuffy.TabIndex = 6;
            this.lblLuffy.Text = "Luffy";
            // 
            // lblNaruto
            // 
            this.lblNaruto.AutoSize = true;
            this.lblNaruto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNaruto.Location = new System.Drawing.Point(117, 382);
            this.lblNaruto.Name = "lblNaruto";
            this.lblNaruto.Size = new System.Drawing.Size(39, 13);
            this.lblNaruto.TabIndex = 7;
            this.lblNaruto.Text = "Naruto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNaruto);
            this.Controls.Add(this.lblLuffy);
            this.Controls.Add(this.picLuffy);
            this.Controls.Add(this.picNaruto);
            this.Controls.Add(this.raceControl);
            this.Controls.Add(this.raceTrack);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            this.raceControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNaruto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLuffy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.GroupBox raceControl;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picNaruto;
        private System.Windows.Forms.PictureBox picLuffy;
        private System.Windows.Forms.Timer timerChar1;
        private System.Windows.Forms.Timer timerChar2;
        private System.Windows.Forms.Label lblLuffy;
        private System.Windows.Forms.Label lblNaruto;
    }
}

