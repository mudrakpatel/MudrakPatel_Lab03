namespace MudrakPatel_Lab03_Ex3
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
            this.headingLabel = new System.Windows.Forms.Label();
            this.intTextBox = new System.Windows.Forms.TextBox();
            this.doubleTextBox = new System.Windows.Forms.TextBox();
            this.generateNumberButton = new System.Windows.Forms.Button();
            this.searchIntTextBox = new System.Windows.Forms.TextBox();
            this.searchDoubleTextBox = new System.Windows.Forms.TextBox();
            this.subHeadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(13, 13);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(429, 29);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Array element index search program.";
            // 
            // intTextBox
            // 
            this.intTextBox.Location = new System.Drawing.Point(77, 87);
            this.intTextBox.Multiline = true;
            this.intTextBox.Name = "intTextBox";
            this.intTextBox.Size = new System.Drawing.Size(100, 144);
            this.intTextBox.TabIndex = 1;
            // 
            // doubleTextBox
            // 
            this.doubleTextBox.Location = new System.Drawing.Point(267, 87);
            this.doubleTextBox.Multiline = true;
            this.doubleTextBox.Name = "doubleTextBox";
            this.doubleTextBox.Size = new System.Drawing.Size(99, 144);
            this.doubleTextBox.TabIndex = 2;
            // 
            // generateNumberButton
            // 
            this.generateNumberButton.Location = new System.Drawing.Point(179, 355);
            this.generateNumberButton.Name = "generateNumberButton";
            this.generateNumberButton.Size = new System.Drawing.Size(100, 23);
            this.generateNumberButton.TabIndex = 3;
            this.generateNumberButton.Text = "Generate";
            this.generateNumberButton.UseVisualStyleBackColor = true;
            // 
            // searchIntTextBox
            // 
            this.searchIntTextBox.Location = new System.Drawing.Point(129, 261);
            this.searchIntTextBox.Name = "searchIntTextBox";
            this.searchIntTextBox.Size = new System.Drawing.Size(202, 20);
            this.searchIntTextBox.TabIndex = 4;
            this.searchIntTextBox.Text = "Search int index";
            // 
            // searchDoubleTextBox
            // 
            this.searchDoubleTextBox.Location = new System.Drawing.Point(129, 300);
            this.searchDoubleTextBox.Name = "searchDoubleTextBox";
            this.searchDoubleTextBox.Size = new System.Drawing.Size(202, 20);
            this.searchDoubleTextBox.TabIndex = 5;
            this.searchDoubleTextBox.Text = "Search double index";
            // 
            // subHeadingLabel
            // 
            this.subHeadingLabel.AutoSize = true;
            this.subHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.subHeadingLabel.Location = new System.Drawing.Point(72, 55);
            this.subHeadingLabel.Name = "subHeadingLabel";
            this.subHeadingLabel.Size = new System.Drawing.Size(288, 29);
            this.subHeadingLabel.TabIndex = 6;
            this.subHeadingLabel.Text = "     Int                   Double";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 390);
            this.Controls.Add(this.subHeadingLabel);
            this.Controls.Add(this.searchDoubleTextBox);
            this.Controls.Add(this.searchIntTextBox);
            this.Controls.Add(this.generateNumberButton);
            this.Controls.Add(this.doubleTextBox);
            this.Controls.Add(this.intTextBox);
            this.Controls.Add(this.headingLabel);
            this.Name = "Form1";
            this.Text = "Random number program.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.TextBox intTextBox;
        private System.Windows.Forms.TextBox doubleTextBox;
        private System.Windows.Forms.Button generateNumberButton;
        private System.Windows.Forms.TextBox searchIntTextBox;
        private System.Windows.Forms.TextBox searchDoubleTextBox;
        private System.Windows.Forms.Label subHeadingLabel;
    }
}

