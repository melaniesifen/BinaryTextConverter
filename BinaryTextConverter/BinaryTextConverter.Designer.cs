
namespace BinaryTextConverter
{
    partial class BinaryTextConverter
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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.BinaryTextBox = new System.Windows.Forms.TextBox();
            this.TextTextBox = new System.Windows.Forms.TextBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.ReverseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.Location = new System.Drawing.Point(633, 141);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(155, 42);
            this.ConvertButton.TabIndex = 1;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);

            // 
            // BinaryTextBox
            // 
            this.BinaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BinaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinaryTextBox.Location = new System.Drawing.Point(44, 149);
            this.BinaryTextBox.Name = "BinaryTextBox";
            this.BinaryTextBox.ReadOnly = true;
            this.BinaryTextBox.Size = new System.Drawing.Size(100, 25);
            this.BinaryTextBox.TabIndex = 2;
            this.BinaryTextBox.Text = "Binary:";
            this.BinaryTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextTextBox
            // 
            this.TextTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTextBox.Location = new System.Drawing.Point(44, 231);
            this.TextTextBox.Name = "TextTextBox";
            this.TextTextBox.ReadOnly = true;
            this.TextTextBox.Size = new System.Drawing.Size(100, 25);
            this.TextTextBox.TabIndex = 3;
            this.TextTextBox.Text = "Text:";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(164, 147);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(453, 26);
            this.InputTextBox.TabIndex = 4;
            this.InputTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OutputTextBox.Location = new System.Drawing.Point(164, 233);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(453, 26);
            this.OutputTextBox.TabIndex = 5;
            // 
            // ReverseButton
            // 
            this.ReverseButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ReverseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReverseButton.Location = new System.Drawing.Point(26, 299);
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(155, 40);
            this.ReverseButton.TabIndex = 1;
            this.ReverseButton.Text = "Reverse";
            this.ReverseButton.UseVisualStyleBackColor = false;
            this.ReverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // BinaryTextConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReverseButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.TextTextBox);
            this.Controls.Add(this.BinaryTextBox);
            this.Controls.Add(this.ConvertButton);
            this.Name = "BinaryTextConverter";
            this.Text = "Binary Text Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox BinaryTextBox;
        private System.Windows.Forms.TextBox TextTextBox;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button ReverseButton;
    }
}

