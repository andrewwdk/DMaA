namespace Lab8
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.newChainTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chainsLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.getNextButton = new System.Windows.Forms.Button();
            this.newChainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add terminal chain";
            // 
            // newChainTextBox
            // 
            this.newChainTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newChainTextBox.Location = new System.Drawing.Point(202, 15);
            this.newChainTextBox.Name = "newChainTextBox";
            this.newChainTextBox.Size = new System.Drawing.Size(160, 36);
            this.newChainTextBox.TabIndex = 1;
            this.newChainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(398, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(77, 36);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(497, 15);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 36);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(218, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Terminal chains";
            // 
            // chainsLabel
            // 
            this.chainsLabel.AutoSize = true;
            this.chainsLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chainsLabel.Location = new System.Drawing.Point(18, 113);
            this.chainsLabel.MinimumSize = new System.Drawing.Size(540, 0);
            this.chainsLabel.Name = "chainsLabel";
            this.chainsLabel.Size = new System.Drawing.Size(540, 28);
            this.chainsLabel.TabIndex = 5;
            this.chainsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Enabled = false;
            this.GenerateButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.Location = new System.Drawing.Point(179, 152);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(218, 36);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate rules";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(262, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rules";
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rulesLabel.Location = new System.Drawing.Point(18, 242);
            this.rulesLabel.MinimumSize = new System.Drawing.Size(540, 0);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(540, 28);
            this.rulesLabel.TabIndex = 8;
            this.rulesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getNextButton
            // 
            this.getNextButton.Enabled = false;
            this.getNextButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getNextButton.Location = new System.Drawing.Point(105, 295);
            this.getNextButton.Name = "getNextButton";
            this.getNextButton.Size = new System.Drawing.Size(100, 36);
            this.getNextButton.TabIndex = 9;
            this.getNextButton.Text = "Get Next";
            this.getNextButton.UseVisualStyleBackColor = true;
            this.getNextButton.Click += new System.EventHandler(this.getNextButton_Click);
            // 
            // newChainLabel
            // 
            this.newChainLabel.AutoSize = true;
            this.newChainLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newChainLabel.Location = new System.Drawing.Point(258, 299);
            this.newChainLabel.MinimumSize = new System.Drawing.Size(300, 0);
            this.newChainLabel.Name = "newChainLabel";
            this.newChainLabel.Size = new System.Drawing.Size(300, 28);
            this.newChainLabel.TabIndex = 10;
            this.newChainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.newChainLabel);
            this.Controls.Add(this.getNextButton);
            this.Controls.Add(this.rulesLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.chainsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.newChainTextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.Text = "Lab8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newChainTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chainsLabel;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rulesLabel;
        private System.Windows.Forms.Button getNextButton;
        private System.Windows.Forms.Label newChainLabel;
    }
}

