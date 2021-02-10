namespace AlgoAppTesterLibrary
{
    partial class AlgoAPPFormTest
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
            this.selectionBox = new System.Windows.Forms.ListBox();
            this.instructionTxtBox = new System.Windows.Forms.TextBox();
            this.codePreviewTxtBox = new System.Windows.Forms.TextBox();
            this.userInputTxtBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.answerTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectionBox
            // 
            this.selectionBox.FormattingEnabled = true;
            this.selectionBox.Items.AddRange(new object[] {
            "Find Three Largest Numbers in an Array",
            "Get Last Element In Array",
            "Palindrome Checker",
            "Sub Sequence Validator"});
            this.selectionBox.Location = new System.Drawing.Point(12, 12);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(320, 43);
            this.selectionBox.Sorted = true;
            this.selectionBox.TabIndex = 0;
            this.selectionBox.SelectedIndexChanged += new System.EventHandler(this.selectionBox_SelectedIndexChanged);
            // 
            // instructionTxtBox
            // 
            this.instructionTxtBox.Location = new System.Drawing.Point(12, 73);
            this.instructionTxtBox.Multiline = true;
            this.instructionTxtBox.Name = "instructionTxtBox";
            this.instructionTxtBox.ReadOnly = true;
            this.instructionTxtBox.Size = new System.Drawing.Size(320, 221);
            this.instructionTxtBox.TabIndex = 1;
            // 
            // codePreviewTxtBox
            // 
            this.codePreviewTxtBox.Location = new System.Drawing.Point(338, 73);
            this.codePreviewTxtBox.Multiline = true;
            this.codePreviewTxtBox.Name = "codePreviewTxtBox";
            this.codePreviewTxtBox.ReadOnly = true;
            this.codePreviewTxtBox.Size = new System.Drawing.Size(444, 399);
            this.codePreviewTxtBox.TabIndex = 2;
            // 
            // userInputTxtBox
            // 
            this.userInputTxtBox.Location = new System.Drawing.Point(12, 376);
            this.userInputTxtBox.Multiline = true;
            this.userInputTxtBox.Name = "userInputTxtBox";
            this.userInputTxtBox.Size = new System.Drawing.Size(320, 57);
            this.userInputTxtBox.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 439);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(123, 33);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // answerTxtBox
            // 
            this.answerTxtBox.Location = new System.Drawing.Point(12, 300);
            this.answerTxtBox.Multiline = true;
            this.answerTxtBox.Name = "answerTxtBox";
            this.answerTxtBox.ReadOnly = true;
            this.answerTxtBox.Size = new System.Drawing.Size(320, 70);
            this.answerTxtBox.TabIndex = 7;
            this.answerTxtBox.Text = "Answer Displays Here";
            this.answerTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AlgoAPPFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 539);
            this.Controls.Add(this.answerTxtBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.userInputTxtBox);
            this.Controls.Add(this.codePreviewTxtBox);
            this.Controls.Add(this.instructionTxtBox);
            this.Controls.Add(this.selectionBox);
            this.Name = "AlgoAPPFormTest";
            this.Text = "AlgoAPPFormTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox selectionBox;
        private System.Windows.Forms.TextBox instructionTxtBox;
        private System.Windows.Forms.TextBox codePreviewTxtBox;
        private System.Windows.Forms.TextBox userInputTxtBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox answerTxtBox;
    }
}