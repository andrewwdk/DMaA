namespace Lab4
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
            this.learnButton = new System.Windows.Forms.Button();
            this.classCountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.functionsTextBox = new System.Windows.Forms.TextBox();
            this.x1TextBox = new System.Windows.Forms.TextBox();
            this.x2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decideButton = new System.Windows.Forms.Button();
            this.decisionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // learnButton
            // 
            this.learnButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.learnButton.Location = new System.Drawing.Point(354, 26);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(78, 35);
            this.learnButton.TabIndex = 0;
            this.learnButton.Text = "LEARN";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // classCountTextBox
            // 
            this.classCountTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classCountTextBox.Location = new System.Drawing.Point(261, 26);
            this.classCountTextBox.Name = "classCountTextBox";
            this.classCountTextBox.Size = new System.Drawing.Size(36, 36);
            this.classCountTextBox.TabIndex = 4;
            this.classCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.classCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.classCountTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count  of classes(2-5)";
            // 
            // functionsTextBox
            // 
            this.functionsTextBox.BackColor = System.Drawing.Color.White;
            this.functionsTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.functionsTextBox.Location = new System.Drawing.Point(12, 103);
            this.functionsTextBox.Multiline = true;
            this.functionsTextBox.Name = "functionsTextBox";
            this.functionsTextBox.ReadOnly = true;
            this.functionsTextBox.Size = new System.Drawing.Size(249, 216);
            this.functionsTextBox.TabIndex = 6;
            this.functionsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x1TextBox
            // 
            this.x1TextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x1TextBox.Location = new System.Drawing.Point(396, 116);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(52, 36);
            this.x1TextBox.TabIndex = 7;
            this.x1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x1TextBox_KeyPress);
            // 
            // x2TextBox
            // 
            this.x2TextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x2TextBox.Location = new System.Drawing.Point(396, 175);
            this.x2TextBox.Name = "x2TextBox";
            this.x2TextBox.Size = new System.Drawing.Size(52, 36);
            this.x2TextBox.TabIndex = 8;
            this.x2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x2TextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(304, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "X1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(304, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "X2";
            // 
            // decideButton
            // 
            this.decideButton.Enabled = false;
            this.decideButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decideButton.Location = new System.Drawing.Point(336, 242);
            this.decideButton.Name = "decideButton";
            this.decideButton.Size = new System.Drawing.Size(86, 35);
            this.decideButton.TabIndex = 11;
            this.decideButton.Text = "DECIDE";
            this.decideButton.UseVisualStyleBackColor = true;
            // 
            // decisionLabel
            // 
            this.decisionLabel.AutoSize = true;
            this.decisionLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decisionLabel.Location = new System.Drawing.Point(275, 306);
            this.decisionLabel.Name = "decisionLabel";
            this.decisionLabel.Size = new System.Drawing.Size(203, 28);
            this.decisionLabel.TabIndex = 12;
            this.decisionLabel.Text = "Image belongs to x class";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.decisionLabel);
            this.Controls.Add(this.decideButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x2TextBox);
            this.Controls.Add(this.x1TextBox);
            this.Controls.Add(this.functionsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classCountTextBox);
            this.Controls.Add(this.learnButton);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Text = "Perceptron";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.TextBox classCountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox functionsTextBox;
        private System.Windows.Forms.TextBox x1TextBox;
        private System.Windows.Forms.TextBox x2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button decideButton;
        private System.Windows.Forms.Label decisionLabel;
    }
}

