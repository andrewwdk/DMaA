namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxForGraphics = new System.Windows.Forms.PictureBox();
            this.colorLabel1 = new System.Windows.Forms.Label();
            this.colorLabel2 = new System.Windows.Forms.Label();
            this.lineLabel1 = new System.Windows.Forms.Label();
            this.lineLabel2 = new System.Windows.Forms.Label();
            this.pc2Label = new System.Windows.Forms.Label();
            this.pc1Label = new System.Windows.Forms.Label();
            this.DrawButton = new System.Windows.Forms.Button();
            this.pc1TextBox = new System.Windows.Forms.TextBox();
            this.pc2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.falseAlarmLabel = new System.Windows.Forms.Label();
            this.detectionSkipLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForGraphics)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxForGraphics
            // 
            this.pictureBoxForGraphics.BackColor = System.Drawing.Color.White;
            this.pictureBoxForGraphics.Location = new System.Drawing.Point(21, 12);
            this.pictureBoxForGraphics.Name = "pictureBoxForGraphics";
            this.pictureBoxForGraphics.Size = new System.Drawing.Size(700, 400);
            this.pictureBoxForGraphics.TabIndex = 0;
            this.pictureBoxForGraphics.TabStop = false;
            // 
            // colorLabel1
            // 
            this.colorLabel1.AutoSize = true;
            this.colorLabel1.BackColor = System.Drawing.Color.Green;
            this.colorLabel1.Location = new System.Drawing.Point(124, 430);
            this.colorLabel1.Name = "colorLabel1";
            this.colorLabel1.Size = new System.Drawing.Size(40, 13);
            this.colorLabel1.TabIndex = 1;
            this.colorLabel1.Text = "           ";
            // 
            // colorLabel2
            // 
            this.colorLabel2.AutoSize = true;
            this.colorLabel2.BackColor = System.Drawing.Color.Red;
            this.colorLabel2.Location = new System.Drawing.Point(400, 430);
            this.colorLabel2.Name = "colorLabel2";
            this.colorLabel2.Size = new System.Drawing.Size(40, 13);
            this.colorLabel2.TabIndex = 2;
            this.colorLabel2.Text = "           ";
            // 
            // lineLabel1
            // 
            this.lineLabel1.AutoSize = true;
            this.lineLabel1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineLabel1.Location = new System.Drawing.Point(184, 421);
            this.lineLabel1.Name = "lineLabel1";
            this.lineLabel1.Size = new System.Drawing.Size(130, 28);
            this.lineLabel1.TabIndex = 3;
            this.lineLabel1.Text = "p(X/C1) P(C1)";
            // 
            // lineLabel2
            // 
            this.lineLabel2.AutoSize = true;
            this.lineLabel2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineLabel2.Location = new System.Drawing.Point(468, 421);
            this.lineLabel2.Name = "lineLabel2";
            this.lineLabel2.Size = new System.Drawing.Size(130, 28);
            this.lineLabel2.TabIndex = 4;
            this.lineLabel2.Text = "p(X/C2) P(C2)";
            // 
            // pc2Label
            // 
            this.pc2Label.AutoSize = true;
            this.pc2Label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pc2Label.Location = new System.Drawing.Point(753, 82);
            this.pc2Label.Name = "pc2Label";
            this.pc2Label.Size = new System.Drawing.Size(58, 28);
            this.pc2Label.TabIndex = 5;
            this.pc2Label.Text = "P(C2)";
            // 
            // pc1Label
            // 
            this.pc1Label.AutoSize = true;
            this.pc1Label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pc1Label.Location = new System.Drawing.Point(753, 42);
            this.pc1Label.Name = "pc1Label";
            this.pc1Label.Size = new System.Drawing.Size(58, 28);
            this.pc1Label.TabIndex = 6;
            this.pc1Label.Text = "P(C1)";
            // 
            // DrawButton
            // 
            this.DrawButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrawButton.Location = new System.Drawing.Point(812, 142);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(94, 41);
            this.DrawButton.TabIndex = 9;
            this.DrawButton.Text = "DRAW";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // pc1TextBox
            // 
            this.pc1TextBox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pc1TextBox.Location = new System.Drawing.Point(836, 42);
            this.pc1TextBox.Name = "pc1TextBox";
            this.pc1TextBox.Size = new System.Drawing.Size(112, 30);
            this.pc1TextBox.TabIndex = 10;
            this.pc1TextBox.Text = "0,000";
            this.pc1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pc1TextBox.Enter += new System.EventHandler(this.pc1TextBox_Enter);
            this.pc1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pc1TextBox_KeyPress);
            this.pc1TextBox.Leave += new System.EventHandler(this.pc1TextBox_Leave);
            // 
            // pc2TextBox
            // 
            this.pc2TextBox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pc2TextBox.Location = new System.Drawing.Point(836, 78);
            this.pc2TextBox.Name = "pc2TextBox";
            this.pc2TextBox.Size = new System.Drawing.Size(112, 30);
            this.pc2TextBox.TabIndex = 11;
            this.pc2TextBox.Text = "0,000";
            this.pc2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pc2TextBox.Enter += new System.EventHandler(this.pc2TextBox_Enter);
            this.pc2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pc2TextBox_KeyPress);
            this.pc2TextBox.Leave += new System.EventHandler(this.pc2TextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(777, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "False Alarm Error";
            // 
            // falseAlarmLabel
            // 
            this.falseAlarmLabel.AutoSize = true;
            this.falseAlarmLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.falseAlarmLabel.Location = new System.Drawing.Point(821, 242);
            this.falseAlarmLabel.Name = "falseAlarmLabel";
            this.falseAlarmLabel.Size = new System.Drawing.Size(65, 28);
            this.falseAlarmLabel.TabIndex = 13;
            this.falseAlarmLabel.Text = "0,000";
            // 
            // detectionSkipLabel
            // 
            this.detectionSkipLabel.AutoSize = true;
            this.detectionSkipLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detectionSkipLabel.Location = new System.Drawing.Point(821, 314);
            this.detectionSkipLabel.Name = "detectionSkipLabel";
            this.detectionSkipLabel.Size = new System.Drawing.Size(65, 28);
            this.detectionSkipLabel.TabIndex = 15;
            this.detectionSkipLabel.Text = "0,000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(760, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = " Detection Skip Error";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summaryLabel.Location = new System.Drawing.Point(821, 385);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(65, 28);
            this.summaryLabel.TabIndex = 17;
            this.summaryLabel.Text = "0,000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(783, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Summary Error";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.detectionSkipLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.falseAlarmLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pc2TextBox);
            this.Controls.Add(this.pc1TextBox);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.pc1Label);
            this.Controls.Add(this.pc2Label);
            this.Controls.Add(this.lineLabel2);
            this.Controls.Add(this.lineLabel1);
            this.Controls.Add(this.colorLabel2);
            this.Controls.Add(this.colorLabel1);
            this.Controls.Add(this.pictureBoxForGraphics);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForGraphics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxForGraphics;
        private System.Windows.Forms.Label colorLabel1;
        private System.Windows.Forms.Label colorLabel2;
        private System.Windows.Forms.Label lineLabel1;
        private System.Windows.Forms.Label lineLabel2;
        private System.Windows.Forms.Label pc2Label;
        private System.Windows.Forms.Label pc1Label;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.TextBox pc1TextBox;
        private System.Windows.Forms.TextBox pc2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label falseAlarmLabel;
        private System.Windows.Forms.Label detectionSkipLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Label label5;
    }
}

