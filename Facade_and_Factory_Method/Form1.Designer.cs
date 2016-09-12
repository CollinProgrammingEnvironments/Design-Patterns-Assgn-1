namespace Facade_and_Factory_Method
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
            this.m_btnPlaySong = new System.Windows.Forms.Button();
            this.m_radbtnTwins = new System.Windows.Forms.RadioButton();
            this.m_radbtnMutilator = new System.Windows.Forms.RadioButton();
            this.m_radbtnInnocent = new System.Windows.Forms.RadioButton();
            this.m_radbtnPopSong = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.m_gpboxSelectLabel = new System.Windows.Forms.GroupBox();
            this.m_txtboxSong = new System.Windows.Forms.TextBox();
            this.m_txtboxRPM = new System.Windows.Forms.TextBox();
            this.m_txtboxVolume = new System.Windows.Forms.TextBox();
            this.m_lblSong = new System.Windows.Forms.Label();
            this.m_lblVolume = new System.Windows.Forms.Label();
            this.m_lblRPM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_btnPlaySong
            // 
            this.m_btnPlaySong.BackColor = System.Drawing.Color.Red;
            this.m_btnPlaySong.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnPlaySong.Location = new System.Drawing.Point(355, 12);
            this.m_btnPlaySong.Name = "m_btnPlaySong";
            this.m_btnPlaySong.Size = new System.Drawing.Size(314, 168);
            this.m_btnPlaySong.TabIndex = 0;
            this.m_btnPlaySong.Text = "Start Turntable";
            this.m_btnPlaySong.UseVisualStyleBackColor = false;
            this.m_btnPlaySong.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_radbtnTwins
            // 
            this.m_radbtnTwins.AutoSize = true;
            this.m_radbtnTwins.Location = new System.Drawing.Point(12, 270);
            this.m_radbtnTwins.Name = "m_radbtnTwins";
            this.m_radbtnTwins.Size = new System.Drawing.Size(114, 17);
            this.m_radbtnTwins.TabIndex = 1;
            this.m_radbtnTwins.TabStop = true;
            this.m_radbtnTwins.Text = "Twins by Ty Segall";
            this.m_radbtnTwins.UseVisualStyleBackColor = true;
            this.m_radbtnTwins.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // m_radbtnMutilator
            // 
            this.m_radbtnMutilator.AutoSize = true;
            this.m_radbtnMutilator.Location = new System.Drawing.Point(12, 293);
            this.m_radbtnMutilator.Name = "m_radbtnMutilator";
            this.m_radbtnMutilator.Size = new System.Drawing.Size(236, 17);
            this.m_radbtnMutilator.TabIndex = 2;
            this.m_radbtnMutilator.TabStop = true;
            this.m_radbtnMutilator.Text = "Multilator Defeated At Last by Thee Oh Sees";
            this.m_radbtnMutilator.UseVisualStyleBackColor = true;
            // 
            // m_radbtnInnocent
            // 
            this.m_radbtnInnocent.AutoSize = true;
            this.m_radbtnInnocent.Location = new System.Drawing.Point(12, 316);
            this.m_radbtnInnocent.Name = "m_radbtnInnocent";
            this.m_radbtnInnocent.Size = new System.Drawing.Size(263, 17);
            this.m_radbtnInnocent.TabIndex = 3;
            this.m_radbtnInnocent.TabStop = true;
            this.m_radbtnInnocent.Text = "For The Recently Found Innocent by White Fence";
            this.m_radbtnInnocent.UseVisualStyleBackColor = true;
            // 
            // m_radbtnPopSong
            // 
            this.m_radbtnPopSong.AutoSize = true;
            this.m_radbtnPopSong.Location = new System.Drawing.Point(12, 339);
            this.m_radbtnPopSong.Name = "m_radbtnPopSong";
            this.m_radbtnPopSong.Size = new System.Drawing.Size(215, 17);
            this.m_radbtnPopSong.TabIndex = 4;
            this.m_radbtnPopSong.TabStop = true;
            this.m_radbtnPopSong.Text = "Pop Song by Ty Segall and Mikal Cronin";
            this.m_radbtnPopSong.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 362);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(257, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "The Traditional Fools EP by The Traditional Fools";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // m_gpboxSelectLabel
            // 
            this.m_gpboxSelectLabel.Location = new System.Drawing.Point(3, 255);
            this.m_gpboxSelectLabel.Name = "m_gpboxSelectLabel";
            this.m_gpboxSelectLabel.Size = new System.Drawing.Size(280, 134);
            this.m_gpboxSelectLabel.TabIndex = 8;
            this.m_gpboxSelectLabel.TabStop = false;
            this.m_gpboxSelectLabel.Text = "Select your album";
            this.m_gpboxSelectLabel.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // m_txtboxSong
            // 
            this.m_txtboxSong.Location = new System.Drawing.Point(461, 226);
            this.m_txtboxSong.Name = "m_txtboxSong";
            this.m_txtboxSong.Size = new System.Drawing.Size(119, 20);
            this.m_txtboxSong.TabIndex = 9;
            // 
            // m_txtboxRPM
            // 
            this.m_txtboxRPM.Location = new System.Drawing.Point(461, 278);
            this.m_txtboxRPM.Name = "m_txtboxRPM";
            this.m_txtboxRPM.Size = new System.Drawing.Size(119, 20);
            this.m_txtboxRPM.TabIndex = 10;
            // 
            // m_txtboxVolume
            // 
            this.m_txtboxVolume.Location = new System.Drawing.Point(461, 252);
            this.m_txtboxVolume.Name = "m_txtboxVolume";
            this.m_txtboxVolume.Size = new System.Drawing.Size(119, 20);
            this.m_txtboxVolume.TabIndex = 11;
            // 
            // m_lblSong
            // 
            this.m_lblSong.AutoSize = true;
            this.m_lblSong.Location = new System.Drawing.Point(420, 229);
            this.m_lblSong.Name = "m_lblSong";
            this.m_lblSong.Size = new System.Drawing.Size(32, 13);
            this.m_lblSong.TabIndex = 12;
            this.m_lblSong.Text = "Song";
            // 
            // m_lblVolume
            // 
            this.m_lblVolume.AutoSize = true;
            this.m_lblVolume.Location = new System.Drawing.Point(415, 255);
            this.m_lblVolume.Name = "m_lblVolume";
            this.m_lblVolume.Size = new System.Drawing.Size(42, 13);
            this.m_lblVolume.TabIndex = 13;
            this.m_lblVolume.Text = "Volume";
            // 
            // m_lblRPM
            // 
            this.m_lblRPM.AutoSize = true;
            this.m_lblRPM.Location = new System.Drawing.Point(422, 281);
            this.m_lblRPM.Name = "m_lblRPM";
            this.m_lblRPM.Size = new System.Drawing.Size(31, 13);
            this.m_lblRPM.TabIndex = 14;
            this.m_lblRPM.Text = "RPM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 597);
            this.Controls.Add(this.m_lblRPM);
            this.Controls.Add(this.m_lblVolume);
            this.Controls.Add(this.m_lblSong);
            this.Controls.Add(this.m_txtboxVolume);
            this.Controls.Add(this.m_txtboxRPM);
            this.Controls.Add(this.m_txtboxSong);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.m_radbtnPopSong);
            this.Controls.Add(this.m_radbtnInnocent);
            this.Controls.Add(this.m_radbtnMutilator);
            this.Controls.Add(this.m_radbtnTwins);
            this.Controls.Add(this.m_btnPlaySong);
            this.Controls.Add(this.m_gpboxSelectLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnPlaySong;
        private System.Windows.Forms.RadioButton m_radbtnTwins;
        private System.Windows.Forms.RadioButton m_radbtnMutilator;
        private System.Windows.Forms.RadioButton m_radbtnInnocent;
        private System.Windows.Forms.RadioButton m_radbtnPopSong;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox m_gpboxSelectLabel;
        private System.Windows.Forms.TextBox m_txtboxSong;
        private System.Windows.Forms.TextBox m_txtboxRPM;
        private System.Windows.Forms.TextBox m_txtboxVolume;
        private System.Windows.Forms.Label m_lblSong;
        private System.Windows.Forms.Label m_lblVolume;
        private System.Windows.Forms.Label m_lblRPM;
    }
}