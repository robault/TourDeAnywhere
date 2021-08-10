namespace TourDeAnywhere
{
    partial class TourDeAnywhereForm
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
            this.sensorThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.jumpcomboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trigger1comboBox = new System.Windows.Forms.ComboBox();
            this.walkingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.maxSuitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.trigger3comboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trigger2comboBox = new System.Windows.Forms.ComboBox();
            this.runningNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.mphlabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sensoroutputlabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wheelSizeComboBox = new System.Windows.Forms.ComboBox();
            this.wheellowerlabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.wheelupperlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stopbutton = new System.Windows.Forms.Button();
            this.startbutton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sensorThresholdNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.walkingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSuitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sensorThresholdNumericUpDown
            // 
            this.sensorThresholdNumericUpDown.Location = new System.Drawing.Point(160, 142);
            this.sensorThresholdNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sensorThresholdNumericUpDown.Name = "sensorThresholdNumericUpDown";
            this.sensorThresholdNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.sensorThresholdNumericUpDown.TabIndex = 56;
            this.sensorThresholdNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.jumpcomboBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.trigger1comboBox);
            this.groupBox2.Controls.Add(this.walkingNumericUpDown);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.maxSuitNumericUpDown);
            this.groupBox2.Controls.Add(this.trigger3comboBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.trigger2comboBox);
            this.groupBox2.Controls.Add(this.runningNumericUpDown);
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 257);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Configuration";
            // 
            // jumpcomboBox
            // 
            this.jumpcomboBox.FormattingEnabled = true;
            this.jumpcomboBox.Location = new System.Drawing.Point(212, 204);
            this.jumpcomboBox.Name = "jumpcomboBox";
            this.jumpcomboBox.Size = new System.Drawing.Size(121, 21);
            this.jumpcomboBox.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Jump (joystick hat button):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Walking MPH Threshold:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Walking Trigger Key:";
            // 
            // trigger1comboBox
            // 
            this.trigger1comboBox.FormattingEnabled = true;
            this.trigger1comboBox.Location = new System.Drawing.Point(214, 71);
            this.trigger1comboBox.Name = "trigger1comboBox";
            this.trigger1comboBox.Size = new System.Drawing.Size(121, 21);
            this.trigger1comboBox.TabIndex = 44;
            // 
            // walkingNumericUpDown
            // 
            this.walkingNumericUpDown.Location = new System.Drawing.Point(215, 45);
            this.walkingNumericUpDown.Name = "walkingNumericUpDown";
            this.walkingNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.walkingNumericUpDown.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Running MPH Threshold:";
            // 
            // maxSuitNumericUpDown
            // 
            this.maxSuitNumericUpDown.Location = new System.Drawing.Point(213, 151);
            this.maxSuitNumericUpDown.Name = "maxSuitNumericUpDown";
            this.maxSuitNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.maxSuitNumericUpDown.TabIndex = 3;
            // 
            // trigger3comboBox
            // 
            this.trigger3comboBox.FormattingEnabled = true;
            this.trigger3comboBox.Location = new System.Drawing.Point(212, 177);
            this.trigger3comboBox.Name = "trigger3comboBox";
            this.trigger3comboBox.Size = new System.Drawing.Size(121, 21);
            this.trigger3comboBox.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Maximum Suit Speed MPH Threshold:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Maximum Suit Speed Trigger Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Running Trigger Key:";
            // 
            // trigger2comboBox
            // 
            this.trigger2comboBox.FormattingEnabled = true;
            this.trigger2comboBox.Location = new System.Drawing.Point(212, 124);
            this.trigger2comboBox.Name = "trigger2comboBox";
            this.trigger2comboBox.Size = new System.Drawing.Size(121, 21);
            this.trigger2comboBox.TabIndex = 2;
            // 
            // runningNumericUpDown
            // 
            this.runningNumericUpDown.Location = new System.Drawing.Point(213, 98);
            this.runningNumericUpDown.Name = "runningNumericUpDown";
            this.runningNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.runningNumericUpDown.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Sensor Threshold:";
            // 
            // mphlabel
            // 
            this.mphlabel.AutoSize = true;
            this.mphlabel.Location = new System.Drawing.Point(160, 90);
            this.mphlabel.Name = "mphlabel";
            this.mphlabel.Size = new System.Drawing.Size(13, 13);
            this.mphlabel.TabIndex = 52;
            this.mphlabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Sensor Ouput:";
            // 
            // sensoroutputlabel
            // 
            this.sensoroutputlabel.AutoSize = true;
            this.sensoroutputlabel.Location = new System.Drawing.Point(160, 116);
            this.sensoroutputlabel.Name = "sensoroutputlabel";
            this.sensoroutputlabel.Size = new System.Drawing.Size(13, 13);
            this.sensoroutputlabel.TabIndex = 54;
            this.sensoroutputlabel.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 477);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sensorThresholdNumericUpDown);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.sensoroutputlabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mphlabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.wheelSizeComboBox);
            this.groupBox1.Controls.Add(this.wheellowerlabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.wheelupperlabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 191);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensor Configuration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "MPH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "/";
            // 
            // wheelSizeComboBox
            // 
            this.wheelSizeComboBox.FormattingEnabled = true;
            this.wheelSizeComboBox.Items.AddRange(new object[] {
            "16in",
            "18in",
            "20in",
            "22in",
            "24in",
            "650A",
            "650B",
            "650C",
            "26in",
            "700C",
            "27in"});
            this.wheelSizeComboBox.Location = new System.Drawing.Point(160, 57);
            this.wheelSizeComboBox.Name = "wheelSizeComboBox";
            this.wheelSizeComboBox.Size = new System.Drawing.Size(50, 21);
            this.wheelSizeComboBox.TabIndex = 50;
            // 
            // wheellowerlabel
            // 
            this.wheellowerlabel.AutoSize = true;
            this.wheellowerlabel.Location = new System.Drawing.Point(215, 34);
            this.wheellowerlabel.Name = "wheellowerlabel";
            this.wheellowerlabel.Size = new System.Drawing.Size(25, 13);
            this.wheellowerlabel.TabIndex = 47;
            this.wheellowerlabel.Text = "LLL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Wheel Size:";
            // 
            // wheelupperlabel
            // 
            this.wheelupperlabel.AutoSize = true;
            this.wheelupperlabel.Location = new System.Drawing.Point(160, 34);
            this.wheelupperlabel.Name = "wheelupperlabel";
            this.wheelupperlabel.Size = new System.Drawing.Size(31, 13);
            this.wheelupperlabel.TabIndex = 48;
            this.wheelupperlabel.Text = "HHH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Wheel Sensor High/Low:";
            // 
            // stopbutton
            // 
            this.stopbutton.Location = new System.Drawing.Point(308, 472);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(75, 23);
            this.stopbutton.TabIndex = 50;
            this.stopbutton.Text = "Stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(226, 472);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(75, 23);
            this.startbutton.TabIndex = 49;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(53, 477);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(47, 13);
            this.statusLabel.TabIndex = 54;
            this.statusLabel.Text = "Stopped";
            // 
            // TourDeAnywhereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.statusLabel);
            this.Name = "TourDeAnywhereForm";
            this.Text = "TourDeAnywhere";
            this.Load += new System.EventHandler(this.TourDeAnywhereForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sensorThresholdNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.walkingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSuitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown sensorThresholdNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox jumpcomboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox trigger1comboBox;
        private System.Windows.Forms.NumericUpDown walkingNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown maxSuitNumericUpDown;
        private System.Windows.Forms.ComboBox trigger3comboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox trigger2comboBox;
        private System.Windows.Forms.NumericUpDown runningNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label mphlabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sensoroutputlabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox wheelSizeComboBox;
        private System.Windows.Forms.Label wheellowerlabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label wheelupperlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label statusLabel;
    }
}

