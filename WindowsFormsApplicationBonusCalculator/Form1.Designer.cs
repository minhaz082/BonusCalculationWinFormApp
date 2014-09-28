namespace WindowsFormsApplicationBonusCalculator
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
            this.bonusLabel = new System.Windows.Forms.Label();
            this.bonusInputTextBox = new System.Windows.Forms.TextBox();
            this.afterBonusLAbel = new System.Windows.Forms.Label();
            this.afterBonusTextBox = new System.Windows.Forms.TextBox();
            this.showBonusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bonusLabel
            // 
            this.bonusLabel.AutoSize = true;
            this.bonusLabel.Location = new System.Drawing.Point(56, 33);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(65, 13);
            this.bonusLabel.TabIndex = 0;
            this.bonusLabel.Text = "Insert Salary";
            // 
            // bonusInputTextBox
            // 
            this.bonusInputTextBox.Location = new System.Drawing.Point(165, 33);
            this.bonusInputTextBox.Name = "bonusInputTextBox";
            this.bonusInputTextBox.Size = new System.Drawing.Size(190, 20);
            this.bonusInputTextBox.TabIndex = 1;
            // 
            // afterBonusLAbel
            // 
            this.afterBonusLAbel.AutoSize = true;
            this.afterBonusLAbel.Location = new System.Drawing.Point(56, 127);
            this.afterBonusLAbel.Name = "afterBonusLAbel";
            this.afterBonusLAbel.Size = new System.Drawing.Size(104, 13);
            this.afterBonusLAbel.TabIndex = 2;
            this.afterBonusLAbel.Text = "Salary After Bonus is";
            // 
            // afterBonusTextBox
            // 
            this.afterBonusTextBox.Location = new System.Drawing.Point(165, 127);
            this.afterBonusTextBox.Name = "afterBonusTextBox";
            this.afterBonusTextBox.Size = new System.Drawing.Size(190, 20);
            this.afterBonusTextBox.TabIndex = 3;
            // 
            // showBonusButton
            // 
            this.showBonusButton.Location = new System.Drawing.Point(165, 70);
            this.showBonusButton.Name = "showBonusButton";
            this.showBonusButton.Size = new System.Drawing.Size(156, 23);
            this.showBonusButton.TabIndex = 4;
            this.showBonusButton.Text = "Show Salary After Bonus";
            this.showBonusButton.UseVisualStyleBackColor = true;
            this.showBonusButton.Click += new System.EventHandler(this.showBonusButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 262);
            this.Controls.Add(this.showBonusButton);
            this.Controls.Add(this.afterBonusTextBox);
            this.Controls.Add(this.afterBonusLAbel);
            this.Controls.Add(this.bonusInputTextBox);
            this.Controls.Add(this.bonusLabel);
            this.Name = "Form1";
            this.Text = "Bonus Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bonusLabel;
        private System.Windows.Forms.TextBox bonusInputTextBox;
        private System.Windows.Forms.Label afterBonusLAbel;
        private System.Windows.Forms.TextBox afterBonusTextBox;
        private System.Windows.Forms.Button showBonusButton;
    }
}

