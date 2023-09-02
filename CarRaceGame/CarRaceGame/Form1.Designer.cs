namespace CarRaceGame
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
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.line4 = new System.Windows.Forms.PictureBox();
            this.line2 = new System.Windows.Forms.PictureBox();
            this.line1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.line3 = new System.Windows.Forms.PictureBox();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.over = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.over)).BeginInit();
            this.SuspendLayout();
            // 
            // coin2
            // 
            this.coin2.Image = ((System.Drawing.Image)(resources.GetObject("coin2.Image")));
            this.coin2.Location = new System.Drawing.Point(329, 134);
            this.coin2.Margin = new System.Windows.Forms.Padding(2);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(23, 25);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 2;
            this.coin2.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.Image = ((System.Drawing.Image)(resources.GetObject("coin3.Image")));
            this.coin3.Location = new System.Drawing.Point(67, 294);
            this.coin3.Margin = new System.Windows.Forms.Padding(2);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(23, 25);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 3;
            this.coin3.TabStop = false;
            // 
            // coin4
            // 
            this.coin4.Image = ((System.Drawing.Image)(resources.GetObject("coin4.Image")));
            this.coin4.Location = new System.Drawing.Point(329, 240);
            this.coin4.Margin = new System.Windows.Forms.Padding(2);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(23, 25);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin4.TabIndex = 4;
            this.coin4.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(80, 16);
            this.enemy1.Margin = new System.Windows.Forms.Padding(2);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(18, 46);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 5;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(172, 68);
            this.enemy2.Margin = new System.Windows.Forms.Padding(2);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(18, 46);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 6;
            this.enemy2.TabStop = false;
            this.enemy2.Click += new System.EventHandler(this.enemy2_Click);
            // 
            // coin1
            // 
            this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
            this.coin1.Location = new System.Drawing.Point(133, 37);
            this.coin1.Margin = new System.Windows.Forms.Padding(2);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(23, 25);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 7;
            this.coin1.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(320, 16);
            this.enemy3.Margin = new System.Windows.Forms.Padding(2);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(18, 46);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 8;
            this.enemy3.TabStop = false;
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(165, 389);
            this.car.Margin = new System.Windows.Forms.Padding(2);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(35, 61);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 9;
            this.car.TabStop = false;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.White;
            this.line4.Location = new System.Drawing.Point(204, 365);
            this.line4.Margin = new System.Windows.Forms.Padding(2);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(10, 94);
            this.line4.TabIndex = 10;
            this.line4.TabStop = false;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.White;
            this.line2.Location = new System.Drawing.Point(204, 117);
            this.line2.Margin = new System.Windows.Forms.Padding(2);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(10, 94);
            this.line2.TabIndex = 11;
            this.line2.TabStop = false;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.Location = new System.Drawing.Point(204, -6);
            this.line1.Margin = new System.Windows.Forms.Padding(2);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 94);
            this.line1.TabIndex = 12;
            this.line1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.White;
            this.line3.Location = new System.Drawing.Point(204, 236);
            this.line3.Margin = new System.Windows.Forms.Padding(2);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(10, 94);
            this.line3.TabIndex = 13;
            this.line3.TabStop = false;
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Location = new System.Drawing.Point(13, 16);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(35, 13);
            this.scoreLbl.TabIndex = 14;
            this.scoreLbl.Text = "Score";
            // 
            // over
            // 
            this.over.Image = ((System.Drawing.Image)(resources.GetObject("over.Image")));
            this.over.Location = new System.Drawing.Point(133, 194);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(134, 37);
            this.over.TabIndex = 15;
            this.over.TabStop = false;
            this.over.Click += new System.EventHandler(this.over_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.over);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.car);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin4);
            this.Name = "Form1";
            this.Text = "RacingCarsGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_ArrowsKeysPress);
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.over)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin4;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox line4;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox line3;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.PictureBox over;

    }
}

