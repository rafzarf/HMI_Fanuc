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
            this.ZWorkOffsetLabel = new System.Windows.Forms.Label();
            this.YWorkOffsetLabel = new System.Windows.Forms.Label();
            this.XWorkOffsetLabel = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.ZRemainCoorLabel = new System.Windows.Forms.Label();
            this.YRemainCoorLabel = new System.Windows.Forms.Label();
            this.XRemainCoorLabel = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.ZRelativeCoorLabel = new System.Windows.Forms.Label();
            this.YRelativeCoorLabel = new System.Windows.Forms.Label();
            this.XRelativeCoorLabel = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
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
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            // ZWorkOffsetLabel
            // 
            this.ZWorkOffsetLabel.AutoSize = true;
            this.ZWorkOffsetLabel.Location = new System.Drawing.Point(396, 449);
            this.ZWorkOffsetLabel.Name = "ZWorkOffsetLabel";
            this.ZWorkOffsetLabel.Size = new System.Drawing.Size(39, 16);
            this.ZWorkOffsetLabel.TabIndex = 182;
            this.ZWorkOffsetLabel.Text = "0 mm";
            // 
            // YWorkOffsetLabel
            // 
            this.YWorkOffsetLabel.AutoSize = true;
            this.YWorkOffsetLabel.Location = new System.Drawing.Point(396, 414);
            this.YWorkOffsetLabel.Name = "YWorkOffsetLabel";
            this.YWorkOffsetLabel.Size = new System.Drawing.Size(39, 16);
            this.YWorkOffsetLabel.TabIndex = 181;
            this.YWorkOffsetLabel.Text = "0 mm";
            // 
            // XWorkOffsetLabel
            // 
            this.XWorkOffsetLabel.AutoSize = true;
            this.XWorkOffsetLabel.Location = new System.Drawing.Point(396, 381);
            this.XWorkOffsetLabel.Name = "XWorkOffsetLabel";
            this.XWorkOffsetLabel.Size = new System.Drawing.Size(39, 16);
            this.XWorkOffsetLabel.TabIndex = 180;
            this.XWorkOffsetLabel.Text = "0 mm";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(362, 449);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(21, 16);
            this.label71.TabIndex = 179;
            this.label71.Text = "Z :";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(362, 414);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(22, 16);
            this.label72.TabIndex = 178;
            this.label72.Text = "Y :";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(362, 381);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(21, 16);
            this.label73.TabIndex = 177;
            this.label73.Text = "X :";
            // 
            // ZRemainCoorLabel
            // 
            this.ZRemainCoorLabel.AutoSize = true;
            this.ZRemainCoorLabel.Location = new System.Drawing.Point(571, 305);
            this.ZRemainCoorLabel.Name = "ZRemainCoorLabel";
            this.ZRemainCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.ZRemainCoorLabel.TabIndex = 176;
            this.ZRemainCoorLabel.Text = "0 mm";
            // 
            // YRemainCoorLabel
            // 
            this.YRemainCoorLabel.AutoSize = true;
            this.YRemainCoorLabel.Location = new System.Drawing.Point(571, 270);
            this.YRemainCoorLabel.Name = "YRemainCoorLabel";
            this.YRemainCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.YRemainCoorLabel.TabIndex = 175;
            this.YRemainCoorLabel.Text = "0 mm";
            // 
            // XRemainCoorLabel
            // 
            this.XRemainCoorLabel.AutoSize = true;
            this.XRemainCoorLabel.Location = new System.Drawing.Point(571, 237);
            this.XRemainCoorLabel.Name = "XRemainCoorLabel";
            this.XRemainCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.XRemainCoorLabel.TabIndex = 174;
            this.XRemainCoorLabel.Text = "0 mm";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(538, 305);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(21, 16);
            this.label64.TabIndex = 173;
            this.label64.Text = "Z :";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(538, 270);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(22, 16);
            this.label65.TabIndex = 172;
            this.label65.Text = "Y :";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(538, 237);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(21, 16);
            this.label66.TabIndex = 171;
            this.label66.Text = "X :";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(538, 198);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(144, 16);
            this.label67.TabIndex = 170;
            this.label67.Text = "Remaining Coordinate:";
            // 
            // ZRelativeCoorLabel
            // 
            this.ZRelativeCoorLabel.AutoSize = true;
            this.ZRelativeCoorLabel.Location = new System.Drawing.Point(395, 305);
            this.ZRelativeCoorLabel.Name = "ZRelativeCoorLabel";
            this.ZRelativeCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.ZRelativeCoorLabel.TabIndex = 169;
            this.ZRelativeCoorLabel.Text = "0 mm";
            // 
            // YRelativeCoorLabel
            // 
            this.YRelativeCoorLabel.AutoSize = true;
            this.YRelativeCoorLabel.Location = new System.Drawing.Point(395, 270);
            this.YRelativeCoorLabel.Name = "YRelativeCoorLabel";
            this.YRelativeCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.YRelativeCoorLabel.TabIndex = 168;
            this.YRelativeCoorLabel.Text = "0 mm";
            // 
            // XRelativeCoorLabel
            // 
            this.XRelativeCoorLabel.AutoSize = true;
            this.XRelativeCoorLabel.Location = new System.Drawing.Point(395, 237);
            this.XRelativeCoorLabel.Name = "XRelativeCoorLabel";
            this.XRelativeCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.XRelativeCoorLabel.TabIndex = 167;
            this.XRelativeCoorLabel.Text = "0 mm";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(362, 305);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(21, 16);
            this.label57.TabIndex = 166;
            this.label57.Text = "Z :";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(362, 270);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(22, 16);
            this.label58.TabIndex = 165;
            this.label58.Text = "Y :";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(362, 237);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(21, 16);
            this.label59.TabIndex = 164;
            this.label59.Text = "X :";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(362, 198);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(129, 16);
            this.label60.TabIndex = 163;
            this.label60.Text = "Relative Coordinate:";
            // 
            // ZMechCoorLabel
            // 
            this.ZMechCoorLabel.AutoSize = true;
            this.ZMechCoorLabel.Location = new System.Drawing.Point(571, 150);
            this.ZMechCoorLabel.Name = "ZMechCoorLabel";
            this.ZMechCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.ZMechCoorLabel.TabIndex = 162;
            this.ZMechCoorLabel.Text = "0 mm";
            // 
            // YMechCoorLabel
            // 
            this.YMechCoorLabel.AutoSize = true;
            this.YMechCoorLabel.Location = new System.Drawing.Point(571, 116);
            this.YMechCoorLabel.Name = "YMechCoorLabel";
            this.YMechCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.YMechCoorLabel.TabIndex = 161;
            this.YMechCoorLabel.Text = "0 mm";
            // 
            // XMechCoorLabel
            // 
            this.XMechCoorLabel.AutoSize = true;
            this.XMechCoorLabel.Location = new System.Drawing.Point(571, 82);
            this.XMechCoorLabel.Name = "XMechCoorLabel";
            this.XMechCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.XMechCoorLabel.TabIndex = 160;
            this.XMechCoorLabel.Text = "0 mm";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(538, 150);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(21, 16);
            this.label50.TabIndex = 159;
            this.label50.Text = "Z :";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(538, 116);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(22, 16);
            this.label51.TabIndex = 158;
            this.label51.Text = "Y :";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(538, 82);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(21, 16);
            this.label52.TabIndex = 157;
            this.label52.Text = "X :";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(538, 44);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(148, 16);
            this.label53.TabIndex = 156;
            this.label53.Text = "Mechanical Coordinate:";
            // 
            // ZAbsCoorLabel
            // 
            this.ZAbsCoorLabel.AutoSize = true;
            this.ZAbsCoorLabel.Location = new System.Drawing.Point(395, 150);
            this.ZAbsCoorLabel.Name = "ZAbsCoorLabel";
            this.ZAbsCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.ZAbsCoorLabel.TabIndex = 155;
            this.ZAbsCoorLabel.Text = "0 mm";
            // 
            // YAbsCoorLabel
            // 
            this.YAbsCoorLabel.AutoSize = true;
            this.YAbsCoorLabel.Location = new System.Drawing.Point(395, 116);
            this.YAbsCoorLabel.Name = "YAbsCoorLabel";
            this.YAbsCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.YAbsCoorLabel.TabIndex = 154;
            this.YAbsCoorLabel.Text = "0 mm";
            // 
            // XAbsCoorLabel
            // 
            this.XAbsCoorLabel.AutoSize = true;
            this.XAbsCoorLabel.Location = new System.Drawing.Point(395, 82);
            this.XAbsCoorLabel.Name = "XAbsCoorLabel";
            this.XAbsCoorLabel.Size = new System.Drawing.Size(39, 16);
            this.XAbsCoorLabel.TabIndex = 153;
            this.XAbsCoorLabel.Text = "0 mm";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(362, 150);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(21, 16);
            this.label43.TabIndex = 152;
            this.label43.Text = "Z :";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(362, 116);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(22, 16);
            this.label42.TabIndex = 151;
            this.label42.Text = "Y :";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(362, 82);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(21, 16);
            this.label41.TabIndex = 150;
            this.label41.Text = "X :";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(362, 44);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(135, 16);
            this.label40.TabIndex = 149;
            this.label40.Text = "Absolute Coordinate :";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(430, 390);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(0, 16);
            this.label35.TabIndex = 148;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(362, 344);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(117, 16);
            this.label34.TabIndex = 147;
            this.label34.Text = "Work Offset Value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 492);
            this.Controls.Add(this.ZWorkOffsetLabel);
            this.Controls.Add(this.YWorkOffsetLabel);
            this.Controls.Add(this.XWorkOffsetLabel);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.label73);
            this.Controls.Add(this.ZRemainCoorLabel);
            this.Controls.Add(this.YRemainCoorLabel);
            this.Controls.Add(this.XRemainCoorLabel);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.ZRelativeCoorLabel);
            this.Controls.Add(this.YRelativeCoorLabel);
            this.Controls.Add(this.XRelativeCoorLabel);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label60);
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
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
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
        private System.Windows.Forms.Label ZWorkOffsetLabel;
        private System.Windows.Forms.Label YWorkOffsetLabel;
        private System.Windows.Forms.Label XWorkOffsetLabel;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label ZRemainCoorLabel;
        private System.Windows.Forms.Label YRemainCoorLabel;
        private System.Windows.Forms.Label XRemainCoorLabel;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label ZRelativeCoorLabel;
        private System.Windows.Forms.Label YRelativeCoorLabel;
        private System.Windows.Forms.Label XRelativeCoorLabel;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
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
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Timer timer1;
    }
}

