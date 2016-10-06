namespace COMP1004_F2016_Lesson5
{
    partial class AbilityForm
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
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.StrengthTextBox = new System.Windows.Forms.TextBox();
            this.DexterityTextBox = new System.Windows.Forms.TextBox();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Constitution = new System.Windows.Forms.Label();
            this.IntelligenceTextBox = new System.Windows.Forms.TextBox();
            this.IntelligenceLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.WisdomLabel = new System.Windows.Forms.Label();
            this.CharismaTextBox = new System.Windows.Forms.TextBox();
            this.CharismaLabel = new System.Windows.Forms.Label();
            this.RollButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Location = new System.Drawing.Point(13, 31);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(132, 32);
            this.StrengthLabel.TabIndex = 0;
            this.StrengthLabel.Text = "Strength";
            // 
            // StrengthTextBox
            // 
            this.StrengthTextBox.BackColor = System.Drawing.Color.White;
            this.StrengthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthTextBox.Enabled = false;
            this.StrengthTextBox.Location = new System.Drawing.Point(204, 28);
            this.StrengthTextBox.Name = "StrengthTextBox";
            this.StrengthTextBox.ReadOnly = true;
            this.StrengthTextBox.Size = new System.Drawing.Size(105, 39);
            this.StrengthTextBox.TabIndex = 1;
            // 
            // DexterityTextBox
            // 
            this.DexterityTextBox.BackColor = System.Drawing.Color.White;
            this.DexterityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DexterityTextBox.Enabled = false;
            this.DexterityTextBox.Location = new System.Drawing.Point(204, 73);
            this.DexterityTextBox.Name = "DexterityTextBox";
            this.DexterityTextBox.ReadOnly = true;
            this.DexterityTextBox.Size = new System.Drawing.Size(105, 39);
            this.DexterityTextBox.TabIndex = 3;
            this.DexterityTextBox.TextChanged += new System.EventHandler(this.DexterityTextBox_TextChanged);
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.AutoSize = true;
            this.DexterityLabel.Location = new System.Drawing.Point(13, 76);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(142, 32);
            this.DexterityLabel.TabIndex = 2;
            this.DexterityLabel.Text = "Dexterity";
            this.DexterityLabel.Click += new System.EventHandler(this.DexterityLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(204, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(105, 39);
            this.textBox1.TabIndex = 5;
            // 
            // Constitution
            // 
            this.Constitution.AutoSize = true;
            this.Constitution.Location = new System.Drawing.Point(13, 121);
            this.Constitution.Name = "Constitution";
            this.Constitution.Size = new System.Drawing.Size(185, 32);
            this.Constitution.TabIndex = 4;
            this.Constitution.Text = "Constitution";
            // 
            // IntelligenceTextBox
            // 
            this.IntelligenceTextBox.BackColor = System.Drawing.Color.White;
            this.IntelligenceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntelligenceTextBox.Enabled = false;
            this.IntelligenceTextBox.Location = new System.Drawing.Point(204, 163);
            this.IntelligenceTextBox.Name = "IntelligenceTextBox";
            this.IntelligenceTextBox.ReadOnly = true;
            this.IntelligenceTextBox.Size = new System.Drawing.Size(105, 39);
            this.IntelligenceTextBox.TabIndex = 7;
            // 
            // IntelligenceLabel
            // 
            this.IntelligenceLabel.AutoSize = true;
            this.IntelligenceLabel.Location = new System.Drawing.Point(13, 166);
            this.IntelligenceLabel.Name = "IntelligenceLabel";
            this.IntelligenceLabel.Size = new System.Drawing.Size(173, 32);
            this.IntelligenceLabel.TabIndex = 6;
            this.IntelligenceLabel.Text = "Intelligence";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(204, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(105, 39);
            this.textBox3.TabIndex = 9;
            // 
            // WisdomLabel
            // 
            this.WisdomLabel.AutoSize = true;
            this.WisdomLabel.Location = new System.Drawing.Point(13, 211);
            this.WisdomLabel.Name = "WisdomLabel";
            this.WisdomLabel.Size = new System.Drawing.Size(121, 32);
            this.WisdomLabel.TabIndex = 8;
            this.WisdomLabel.Text = "Wisdom";
            // 
            // CharismaTextBox
            // 
            this.CharismaTextBox.BackColor = System.Drawing.Color.White;
            this.CharismaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CharismaTextBox.Enabled = false;
            this.CharismaTextBox.Location = new System.Drawing.Point(204, 253);
            this.CharismaTextBox.Name = "CharismaTextBox";
            this.CharismaTextBox.ReadOnly = true;
            this.CharismaTextBox.Size = new System.Drawing.Size(105, 39);
            this.CharismaTextBox.TabIndex = 11;
            // 
            // CharismaLabel
            // 
            this.CharismaLabel.AutoSize = true;
            this.CharismaLabel.Location = new System.Drawing.Point(13, 256);
            this.CharismaLabel.Name = "CharismaLabel";
            this.CharismaLabel.Size = new System.Drawing.Size(145, 32);
            this.CharismaLabel.TabIndex = 10;
            this.CharismaLabel.Text = "Charisma";
            // 
            // RollButton
            // 
            this.RollButton.Location = new System.Drawing.Point(81, 321);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(228, 44);
            this.RollButton.TabIndex = 12;
            this.RollButton.Text = "Roll Abilities";
            this.RollButton.UseVisualStyleBackColor = true;
            // 
            // AbilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 395);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.CharismaTextBox);
            this.Controls.Add(this.CharismaLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.WisdomLabel);
            this.Controls.Add(this.IntelligenceTextBox);
            this.Controls.Add(this.IntelligenceLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Constitution);
            this.Controls.Add(this.DexterityTextBox);
            this.Controls.Add(this.DexterityLabel);
            this.Controls.Add(this.StrengthTextBox);
            this.Controls.Add(this.StrengthLabel);
            this.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AbilityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ability Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.TextBox StrengthTextBox;
        private System.Windows.Forms.TextBox DexterityTextBox;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Constitution;
        private System.Windows.Forms.TextBox IntelligenceTextBox;
        private System.Windows.Forms.Label IntelligenceLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label WisdomLabel;
        private System.Windows.Forms.TextBox CharismaTextBox;
        private System.Windows.Forms.Label CharismaLabel;
        private System.Windows.Forms.Button RollButton;
    }
}

