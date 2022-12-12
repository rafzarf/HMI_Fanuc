namespace FanucProgram_04108544
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IPAdressTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.CaptureButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NCCodeRichtxtbox = new System.Windows.Forms.RichTextBox();
            this.FeedrateLabel = new System.Windows.Forms.Label();
            this.RotSpeedLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SpindleLoadLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProccessingTimeLabel = new System.Windows.Forms.Label();
            this.ZMechCoorLabel = new System.Windows.Forms.Label();
            this.YMechCoorLabel = new System.Windows.Forms.Label();
            this.XMechCoorLabel = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.ZAbsCoorLabel = new System.Windows.Forms.Label();
            this.YAbsCoorLabel = new System.Windows.Forms.Label();
            this.XAbsCoorLabel = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ZVibLabel = new System.Windows.Forms.Label();
            this.YVibLabel = new System.Windows.Forms.Label();
            this.XVibLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.StopButtonLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Adress: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port: ";
            // 
            // IPAdressTextBox
            // 
            this.IPAdressTextBox.Location = new System.Drawing.Point(107, 45);
            this.IPAdressTextBox.Name = "IPAdressTextBox";
            this.IPAdressTextBox.Size = new System.Drawing.Size(100, 22);
            this.IPAdressTextBox.TabIndex = 2;
            this.IPAdressTextBox.Text = "192.168.10.12";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(107, 97);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 22);
            this.PortTextBox.TabIndex = 3;
            this.PortTextBox.Text = "8193";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(255, 44);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // CaptureButton
            // 
            this.CaptureButton.Location = new System.Drawing.Point(28, 150);
            this.CaptureButton.Name = "CaptureButton";
            this.CaptureButton.Size = new System.Drawing.Size(75, 23);
            this.CaptureButton.TabIndex = 5;
            this.CaptureButton.Text = "Capture";
            this.CaptureButton.UseVisualStyleBackColor = true;
            this.CaptureButton.Click += new System.EventHandler(this.CaptureButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Feedrate: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rotational Speed: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "NC Code Execution:";
            // 
            // NCCodeRichtxtbox
            // 
            this.NCCodeRichtxtbox.Location = new System.Drawing.Point(28, 321);
            this.NCCodeRichtxtbox.Name = "NCCodeRichtxtbox";
            this.NCCodeRichtxtbox.Size = new System.Drawing.Size(251, 58);
            this.NCCodeRichtxtbox.TabIndex = 9;
            this.NCCodeRichtxtbox.Text = "";
            // 
            // FeedrateLabel
            // 
            this.FeedrateLabel.AutoSize = true;
            this.FeedrateLabel.Location = new System.Drawing.Point(193, 215);
            this.FeedrateLabel.Name = "FeedrateLabel";
            this.FeedrateLabel.Size = new System.Drawing.Size(14, 16);
            this.FeedrateLabel.TabIndex = 10;
            this.FeedrateLabel.Text = "0";
            // 
            // RotSpeedLabel
            // 
            this.RotSpeedLabel.AutoSize = true;
            this.RotSpeedLabel.Location = new System.Drawing.Point(193, 254);
            this.RotSpeedLabel.Name = "RotSpeedLabel";
            this.RotSpeedLabel.Size = new System.Drawing.Size(14, 16);
            this.RotSpeedLabel.TabIndex = 11;
            this.RotSpeedLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Spindle Load:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SpindleLoadLabel
            // 
            this.SpindleLoadLabel.AutoSize = true;
            this.SpindleLoadLabel.Location = new System.Drawing.Point(193, 398);
            this.SpindleLoadLabel.Name = "SpindleLoadLabel";
            this.SpindleLoadLabel.Size = new System.Drawing.Size(14, 16);
            this.SpindleLoadLabel.TabIndex = 13;
            this.SpindleLoadLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Proccesing Time:";
            // 
            // ProccessingTimeLabel
            // 
            this.ProccessingTimeLabel.AutoSize = true;
            this.ProccessingTimeLabel.Location = new System.Drawing.Point(193, 442);
            this.ProccessingTimeLabel.Name = "ProccessingTimeLabel";
            this.ProccessingTimeLabel.Size = new System.Drawing.Size(14, 16);
            this.ProccessingTimeLabel.TabIndex = 15;
            this.ProccessingTimeLabel.Text = "0";
            this.ProccessingTimeLabel.Click += new System.EventHandler(this.ProccessingTimeLabel_Click);
            // 
            // ZMechCoorLabel
            // 
            this.ZMechCoorLabel.AutoSize = true;
            this.ZMechCoorLabel.Location = new System.Drawing.Point(401, 150);
            this.ZMechCoorLabel.Name = "ZMechCoorLabel";
            this.ZMechCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.ZMechCoorLabel.TabIndex = 162;
            this.ZMechCoorLabel.Text = "0 mm";
            // 
            // YMechCoorLabel
            // 
            this.YMechCoorLabel.AutoSize = true;
            this.YMechCoorLabel.Location = new System.Drawing.Point(401, 116);
            this.YMechCoorLabel.Name = "YMechCoorLabel";
            this.YMechCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.YMechCoorLabel.TabIndex = 161;
            this.YMechCoorLabel.Text = "0 mm";
            // 
            // XMechCoorLabel
            // 
            this.XMechCoorLabel.AutoSize = true;
            this.XMechCoorLabel.Location = new System.Drawing.Point(401, 82);
            this.XMechCoorLabel.Name = "XMechCoorLabel";
            this.XMechCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.XMechCoorLabel.TabIndex = 160;
            this.XMechCoorLabel.Text = "0 mm";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(368, 150);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(21, 16);
            this.label50.TabIndex = 159;
            this.label50.Text = "Z :";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(368, 116);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(22, 16);
            this.label51.TabIndex = 158;
            this.label51.Text = "Y :";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(368, 82);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(21, 16);
            this.label52.TabIndex = 157;
            this.label52.Text = "X :";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(368, 44);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(148, 16);
            this.label53.TabIndex = 156;
            this.label53.Text = "Mechanical Coordinate:";
            // 
            // ZAbsCoorLabel
            // 
            this.ZAbsCoorLabel.AutoSize = true;
            this.ZAbsCoorLabel.Location = new System.Drawing.Point(401, 291);
            this.ZAbsCoorLabel.Name = "ZAbsCoorLabel";
            this.ZAbsCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.ZAbsCoorLabel.TabIndex = 155;
            this.ZAbsCoorLabel.Text = "0 mm";
            // 
            // YAbsCoorLabel
            // 
            this.YAbsCoorLabel.AutoSize = true;
            this.YAbsCoorLabel.Location = new System.Drawing.Point(401, 257);
            this.YAbsCoorLabel.Name = "YAbsCoorLabel";
            this.YAbsCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.YAbsCoorLabel.TabIndex = 154;
            this.YAbsCoorLabel.Text = "0 mm";
            // 
            // XAbsCoorLabel
            // 
            this.XAbsCoorLabel.AutoSize = true;
            this.XAbsCoorLabel.Location = new System.Drawing.Point(401, 223);
            this.XAbsCoorLabel.Name = "XAbsCoorLabel";
            this.XAbsCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.XAbsCoorLabel.TabIndex = 153;
            this.XAbsCoorLabel.Text = "0 mm";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(368, 291);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(21, 16);
            this.label43.TabIndex = 152;
            this.label43.Text = "Z :";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(368, 257);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(22, 16);
            this.label42.TabIndex = 151;
            this.label42.Text = "Y :";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(368, 223);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(21, 16);
            this.label41.TabIndex = 150;
            this.label41.Text = "X :";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(368, 185);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(135, 16);
            this.label40.TabIndex = 149;
            this.label40.Text = "Absolute Coordinate :";
            // 
            // ZVibLabel
            // 
            this.ZVibLabel.AutoSize = true;
            this.ZVibLabel.Location = new System.Drawing.Point(401, 430);
            this.ZVibLabel.Name = "ZVibLabel";
            this.ZVibLabel.Size = new System.Drawing.Size(39, 16);
            this.ZVibLabel.TabIndex = 169;
            this.ZVibLabel.Text = "0 mm";
            // 
            // YVibLabel
            // 
            this.YVibLabel.AutoSize = true;
            this.YVibLabel.Location = new System.Drawing.Point(401, 396);
            this.YVibLabel.Name = "YVibLabel";
            this.YVibLabel.Size = new System.Drawing.Size(39, 16);
            this.YVibLabel.TabIndex = 168;
            this.YVibLabel.Text = "0 mm";
            // 
            // XVibLabel
            // 
            this.XVibLabel.AutoSize = true;
            this.XVibLabel.Location = new System.Drawing.Point(401, 362);
            this.XVibLabel.Name = "XVibLabel";
            this.XVibLabel.Size = new System.Drawing.Size(39, 16);
            this.XVibLabel.TabIndex = 167;
            this.XVibLabel.Text = "0 mm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(368, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 16);
            this.label11.TabIndex = 166;
            this.label11.Text = "Z :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(368, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 16);
            this.label12.TabIndex = 165;
            this.label12.Text = "Y :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(368, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 16);
            this.label13.TabIndex = 164;
            this.label13.Text = "X :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(368, 324);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 16);
            this.label14.TabIndex = 163;
            this.label14.Text = "Vibration Sensor:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // StopButtonLabel
            // 
            this.StopButtonLabel.Location = new System.Drawing.Point(132, 150);
            this.StopButtonLabel.Name = "StopButtonLabel";
            this.StopButtonLabel.Size = new System.Drawing.Size(75, 23);
            this.StopButtonLabel.TabIndex = 170;
            this.StopButtonLabel.Text = "Stop Capture";
            this.StopButtonLabel.UseVisualStyleBackColor = true;
            this.StopButtonLabel.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 492);
            this.Controls.Add(this.StopButtonLabel);
            this.Controls.Add(this.ZVibLabel);
            this.Controls.Add(this.YVibLabel);
            this.Controls.Add(this.XVibLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ZMechCoorLabel);
            this.Controls.Add(this.YMechCoorLabel);
            this.Controls.Add(this.XMechCoorLabel);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.ZAbsCoorLabel);
            this.Controls.Add(this.YAbsCoorLabel);
            this.Controls.Add(this.XAbsCoorLabel);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.ProccessingTimeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SpindleLoadLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RotSpeedLabel);
            this.Controls.Add(this.FeedrateLabel);
            this.Controls.Add(this.NCCodeRichtxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CaptureButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.IPAdressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IPAdressTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button CaptureButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox NCCodeRichtxtbox;
        private System.Windows.Forms.Label FeedrateLabel;
        private System.Windows.Forms.Label RotSpeedLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SpindleLoadLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ProccessingTimeLabel;
        private System.Windows.Forms.Label ZMechCoorLabel;
        private System.Windows.Forms.Label YMechCoorLabel;
        private System.Windows.Forms.Label XMechCoorLabel;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label ZAbsCoorLabel;
        private System.Windows.Forms.Label YAbsCoorLabel;
        private System.Windows.Forms.Label XAbsCoorLabel;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ZVibLabel;
        private System.Windows.Forms.Label YVibLabel;
        private System.Windows.Forms.Label XVibLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button StopButtonLabel;
    }
}

