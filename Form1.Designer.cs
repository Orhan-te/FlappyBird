﻿namespace Flappy_Bird
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
            this.pictureBox_zemın = new System.Windows.Forms.PictureBox();
            this.pictureBox_ustbarıyer = new System.Windows.Forms.PictureBox();
            this.pictureBox_altbarıyer = new System.Windows.Forms.PictureBox();
            this.pictureBox_kus = new System.Windows.Forms.PictureBox();
            this.label_skor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zemın)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ustbarıyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_altbarıyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_zemın
            // 
            this.pictureBox_zemın.AccessibleDescription = "";
            this.pictureBox_zemın.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.pictureBox_zemın.Location = new System.Drawing.Point(0, 821);
            this.pictureBox_zemın.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_zemın.Name = "pictureBox_zemın";
            this.pictureBox_zemın.Size = new System.Drawing.Size(980, 107);
            this.pictureBox_zemın.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_zemın.TabIndex = 0;
            this.pictureBox_zemın.TabStop = false;
            // 
            // pictureBox_ustbarıyer
            // 
            this.pictureBox_ustbarıyer.AccessibleDescription = "";
            this.pictureBox_ustbarıyer.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.pictureBox_ustbarıyer.Location = new System.Drawing.Point(776, 0);
            this.pictureBox_ustbarıyer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_ustbarıyer.Name = "pictureBox_ustbarıyer";
            this.pictureBox_ustbarıyer.Size = new System.Drawing.Size(136, 295);
            this.pictureBox_ustbarıyer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ustbarıyer.TabIndex = 1;
            this.pictureBox_ustbarıyer.TabStop = false;
            // 
            // pictureBox_altbarıyer
            // 
            this.pictureBox_altbarıyer.AccessibleDescription = "";
            this.pictureBox_altbarıyer.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.pictureBox_altbarıyer.Location = new System.Drawing.Point(647, 526);
            this.pictureBox_altbarıyer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_altbarıyer.Name = "pictureBox_altbarıyer";
            this.pictureBox_altbarıyer.Size = new System.Drawing.Size(136, 295);
            this.pictureBox_altbarıyer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_altbarıyer.TabIndex = 2;
            this.pictureBox_altbarıyer.TabStop = false;
            // 
            // pictureBox_kus
            // 
            this.pictureBox_kus.AccessibleDescription = "";
            this.pictureBox_kus.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_kus.Image")));
            this.pictureBox_kus.Location = new System.Drawing.Point(69, 357);
            this.pictureBox_kus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_kus.Name = "pictureBox_kus";
            this.pictureBox_kus.Size = new System.Drawing.Size(112, 81);
            this.pictureBox_kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_kus.TabIndex = 3;
            this.pictureBox_kus.TabStop = false;
            // 
            // label_skor
            // 
            this.label_skor.AutoSize = true;
            this.label_skor.Font = new System.Drawing.Font("Microsoft JhengHei Light", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_skor.Location = new System.Drawing.Point(16, 11);
            this.label_skor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_skor.Name = "label_skor";
            this.label_skor.Size = new System.Drawing.Size(181, 49);
            this.label_skor.TabIndex = 4;
            this.label_skor.Text = "SKOR : ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(979, 924);
            this.Controls.Add(this.label_skor);
            this.Controls.Add(this.pictureBox_kus);
            this.Controls.Add(this.pictureBox_altbarıyer);
            this.Controls.Add(this.pictureBox_ustbarıyer);
            this.Controls.Add(this.pictureBox_zemın);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zemın)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ustbarıyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_altbarıyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_zemın;
        private System.Windows.Forms.PictureBox pictureBox_ustbarıyer;
        private System.Windows.Forms.PictureBox pictureBox_altbarıyer;
        private System.Windows.Forms.PictureBox pictureBox_kus;
        private System.Windows.Forms.Label label_skor;
        private System.Windows.Forms.Timer timer1;
    }
}

