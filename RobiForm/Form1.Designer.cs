namespace RobiForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.txtMotor1Speed = new System.Windows.Forms.TextBox();
            this.txtMotor2Speed = new System.Windows.Forms.TextBox();
            this.txtMotor1Acc = new System.Windows.Forms.TextBox();
            this.txtMotor2Acc = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMotor2 = new System.Windows.Forms.Label();
            this.lblMotor1 = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblFront = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.motor3 = new System.Windows.Forms.Panel();
            this.motor4 = new System.Windows.Forms.Panel();
            this.motor1 = new System.Windows.Forms.Panel();
            this.motor2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed Motor 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speed Motor 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Acceleration Motor 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Acceleration Motor 2:";
            // 
            // btnSpeed
            // 
            this.btnSpeed.Enabled = false;
            this.btnSpeed.Location = new System.Drawing.Point(339, 40);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(148, 84);
            this.btnSpeed.TabIndex = 4;
            this.btnSpeed.Text = "Set Speed";
            this.btnSpeed.UseVisualStyleBackColor = true;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // txtMotor1Speed
            // 
            this.txtMotor1Speed.Location = new System.Drawing.Point(33, 64);
            this.txtMotor1Speed.Name = "txtMotor1Speed";
            this.txtMotor1Speed.Size = new System.Drawing.Size(159, 26);
            this.txtMotor1Speed.TabIndex = 5;
            // 
            // txtMotor2Speed
            // 
            this.txtMotor2Speed.Location = new System.Drawing.Point(33, 128);
            this.txtMotor2Speed.Name = "txtMotor2Speed";
            this.txtMotor2Speed.Size = new System.Drawing.Size(159, 26);
            this.txtMotor2Speed.TabIndex = 6;
            // 
            // txtMotor1Acc
            // 
            this.txtMotor1Acc.Location = new System.Drawing.Point(37, 200);
            this.txtMotor1Acc.Name = "txtMotor1Acc";
            this.txtMotor1Acc.Size = new System.Drawing.Size(155, 26);
            this.txtMotor1Acc.TabIndex = 7;
            // 
            // txtMotor2Acc
            // 
            this.txtMotor2Acc.Location = new System.Drawing.Point(37, 266);
            this.txtMotor2Acc.Name = "txtMotor2Acc";
            this.txtMotor2Acc.Size = new System.Drawing.Size(155, 26);
            this.txtMotor2Acc.TabIndex = 8;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(339, 211);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(148, 84);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbSpeed
            // 
            this.tbSpeed.LargeChange = 20;
            this.tbSpeed.Location = new System.Drawing.Point(743, 40);
            this.tbSpeed.Maximum = 90;
            this.tbSpeed.Minimum = -90;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbSpeed.Size = new System.Drawing.Size(69, 252);
            this.tbSpeed.SmallChange = 10;
            this.tbSpeed.TabIndex = 11;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(534, 40);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(148, 84);
            this.btnLeft.TabIndex = 12;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(534, 211);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(148, 84);
            this.btnRight.TabIndex = 13;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkRed;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(664, 832);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(148, 84);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.Teal;
            this.btnActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActivate.Location = new System.Drawing.Point(494, 832);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(148, 84);
            this.btnActivate.TabIndex = 15;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = false;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.ItemHeight = 20;
            this.lbEvents.Location = new System.Drawing.Point(33, 631);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(779, 184);
            this.lbEvents.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Motor 2-2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Motor 1-2";
            // 
            // lblMotor2
            // 
            this.lblMotor2.AutoSize = true;
            this.lblMotor2.Location = new System.Drawing.Point(449, 366);
            this.lblMotor2.Name = "lblMotor2";
            this.lblMotor2.Size = new System.Drawing.Size(77, 20);
            this.lblMotor2.TabIndex = 47;
            this.lblMotor2.Text = "Motor 2-1";
            // 
            // lblMotor1
            // 
            this.lblMotor1.AutoSize = true;
            this.lblMotor1.Location = new System.Drawing.Point(310, 366);
            this.lblMotor1.Name = "lblMotor1";
            this.lblMotor1.Size = new System.Drawing.Size(77, 20);
            this.lblMotor1.TabIndex = 46;
            this.lblMotor1.Text = "Motor 1-1";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(388, 339);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(47, 20);
            this.lblRight.TabIndex = 45;
            this.lblRight.Text = "Right";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(388, 574);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(37, 20);
            this.lblLeft.TabIndex = 44;
            this.lblLeft.Text = "Left";
            // 
            // lblFront
            // 
            this.lblFront.AutoSize = true;
            this.lblFront.Location = new System.Drawing.Point(211, 457);
            this.lblFront.Name = "lblFront";
            this.lblFront.Size = new System.Drawing.Size(47, 20);
            this.lblFront.TabIndex = 43;
            this.lblFront.Text = "Front";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(554, 457);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(45, 20);
            this.lblBack.TabIndex = 42;
            this.lblBack.Text = "Back";
            // 
            // motor3
            // 
            this.motor3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.motor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.motor3.Location = new System.Drawing.Point(453, 389);
            this.motor3.Name = "motor3";
            this.motor3.Size = new System.Drawing.Size(53, 53);
            this.motor3.TabIndex = 39;
            // 
            // motor4
            // 
            this.motor4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.motor4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.motor4.Location = new System.Drawing.Point(453, 491);
            this.motor4.Name = "motor4";
            this.motor4.Size = new System.Drawing.Size(53, 53);
            this.motor4.TabIndex = 41;
            // 
            // motor1
            // 
            this.motor1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.motor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.motor1.Location = new System.Drawing.Point(313, 389);
            this.motor1.Name = "motor1";
            this.motor1.Size = new System.Drawing.Size(53, 53);
            this.motor1.TabIndex = 40;
            // 
            // motor2
            // 
            this.motor2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.motor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.motor2.Location = new System.Drawing.Point(313, 491);
            this.motor2.Name = "motor2";
            this.motor2.Size = new System.Drawing.Size(53, 53);
            this.motor2.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 1035);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMotor2);
            this.Controls.Add(this.lblMotor1);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblFront);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.motor3);
            this.Controls.Add(this.motor4);
            this.Controls.Add(this.motor1);
            this.Controls.Add(this.motor2);
            this.Controls.Add(this.lbEvents);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtMotor2Acc);
            this.Controls.Add(this.txtMotor1Acc);
            this.Controls.Add(this.txtMotor2Speed);
            this.Controls.Add(this.txtMotor1Speed);
            this.Controls.Add(this.btnSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.TextBox txtMotor1Speed;
        private System.Windows.Forms.TextBox txtMotor2Speed;
        private System.Windows.Forms.TextBox txtMotor1Acc;
        private System.Windows.Forms.TextBox txtMotor2Acc;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.ListBox lbEvents;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMotor2;
        private System.Windows.Forms.Label lblMotor1;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblFront;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Panel motor3;
        private System.Windows.Forms.Panel motor4;
        private System.Windows.Forms.Panel motor1;
        private System.Windows.Forms.Panel motor2;
    }
}

