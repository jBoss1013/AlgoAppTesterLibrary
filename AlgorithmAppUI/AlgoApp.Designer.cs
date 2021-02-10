namespace AlgorithmAppUI
{
    partial class AlgorithmApp
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
            this.AlgoListBox = new System.Windows.Forms.ListBox();
            this.CodePreviewBox = new System.Windows.Forms.RichTextBox();
            this.InstructionTxtBox = new System.Windows.Forms.RichTextBox();
            this.AnswerTxtBox = new System.Windows.Forms.TextBox();
            this.UserInputBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AlgoSelectionLabel = new System.Windows.Forms.Label();
            this.CodeViewLabel = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.AnswerOutputLabel = new System.Windows.Forms.Label();
            this.UserInputLabel = new System.Windows.Forms.Label();
            this.AdditionalInputTxtBox = new System.Windows.Forms.TextBox();
            this.AdditionalInputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AlgoListBox
            // 
            this.AlgoListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.AlgoListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlgoListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgoListBox.ForeColor = System.Drawing.SystemColors.Control;
            this.AlgoListBox.FormattingEnabled = true;
            this.AlgoListBox.ItemHeight = 18;
            this.AlgoListBox.Items.AddRange(new object[] {
            "Find three largest numbers in array",
            "Move elements in array to end",
            "Nth Fibonacci",
            "Palindrome validator",
            "Sub sequence validator"});
            this.AlgoListBox.Location = new System.Drawing.Point(12, 32);
            this.AlgoListBox.Name = "AlgoListBox";
            this.AlgoListBox.Size = new System.Drawing.Size(383, 56);
            this.AlgoListBox.Sorted = true;
            this.AlgoListBox.TabIndex = 0;
            this.AlgoListBox.SelectedIndexChanged += new System.EventHandler(this.AlgoListBox_SelectedIndexChanged);
            // 
            // CodePreviewBox
            // 
            this.CodePreviewBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.CodePreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodePreviewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodePreviewBox.ForeColor = System.Drawing.Color.White;
            this.CodePreviewBox.Location = new System.Drawing.Point(402, 32);
            this.CodePreviewBox.Name = "CodePreviewBox";
            this.CodePreviewBox.ReadOnly = true;
            this.CodePreviewBox.Size = new System.Drawing.Size(541, 544);
            this.CodePreviewBox.TabIndex = 1;
            this.CodePreviewBox.Text = "Displays code used for selected algorithim";
            // 
            // InstructionTxtBox
            // 
            this.InstructionTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.InstructionTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InstructionTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionTxtBox.ForeColor = System.Drawing.SystemColors.Control;
            this.InstructionTxtBox.Location = new System.Drawing.Point(13, 112);
            this.InstructionTxtBox.Name = "InstructionTxtBox";
            this.InstructionTxtBox.ReadOnly = true;
            this.InstructionTxtBox.Size = new System.Drawing.Size(382, 258);
            this.InstructionTxtBox.TabIndex = 2;
            this.InstructionTxtBox.Text = "Use the Algorithim Selector above to select the algorithim you wish to test";
            // 
            // AnswerTxtBox
            // 
            this.AnswerTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.AnswerTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerTxtBox.ForeColor = System.Drawing.SystemColors.Control;
            this.AnswerTxtBox.Location = new System.Drawing.Point(12, 391);
            this.AnswerTxtBox.Multiline = true;
            this.AnswerTxtBox.Name = "AnswerTxtBox";
            this.AnswerTxtBox.ReadOnly = true;
            this.AnswerTxtBox.Size = new System.Drawing.Size(382, 27);
            this.AnswerTxtBox.TabIndex = 3;
            // 
            // UserInputBox
            // 
            this.UserInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.UserInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserInputBox.ForeColor = System.Drawing.SystemColors.Control;
            this.UserInputBox.Location = new System.Drawing.Point(13, 440);
            this.UserInputBox.Name = "UserInputBox";
            this.UserInputBox.Size = new System.Drawing.Size(382, 20);
            this.UserInputBox.TabIndex = 4;
            this.UserInputBox.Click += new System.EventHandler(this.UserInputBox_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.SeaGreen;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitButton.Location = new System.Drawing.Point(45, 518);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(150, 58);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Khaki;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ClearButton.Location = new System.Drawing.Point(201, 518);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(150, 58);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AlgoSelectionLabel
            // 
            this.AlgoSelectionLabel.AutoSize = true;
            this.AlgoSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgoSelectionLabel.Location = new System.Drawing.Point(13, 13);
            this.AlgoSelectionLabel.Name = "AlgoSelectionLabel";
            this.AlgoSelectionLabel.Size = new System.Drawing.Size(122, 16);
            this.AlgoSelectionLabel.TabIndex = 7;
            this.AlgoSelectionLabel.Text = "Algorithin Selection";
            // 
            // CodeViewLabel
            // 
            this.CodeViewLabel.AutoSize = true;
            this.CodeViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeViewLabel.Location = new System.Drawing.Point(399, 13);
            this.CodeViewLabel.Name = "CodeViewLabel";
            this.CodeViewLabel.Size = new System.Drawing.Size(73, 16);
            this.CodeViewLabel.TabIndex = 8;
            this.CodeViewLabel.Text = "Code View";
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel.Location = new System.Drawing.Point(13, 96);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(74, 16);
            this.InstructionLabel.TabIndex = 9;
            this.InstructionLabel.Text = "Instructions";
            // 
            // AnswerOutputLabel
            // 
            this.AnswerOutputLabel.AutoSize = true;
            this.AnswerOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerOutputLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AnswerOutputLabel.Location = new System.Drawing.Point(13, 375);
            this.AnswerOutputLabel.Name = "AnswerOutputLabel";
            this.AnswerOutputLabel.Size = new System.Drawing.Size(55, 16);
            this.AnswerOutputLabel.TabIndex = 10;
            this.AnswerOutputLabel.Text = "Answer ";
            // 
            // UserInputLabel
            // 
            this.UserInputLabel.AutoSize = true;
            this.UserInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UserInputLabel.Location = new System.Drawing.Point(13, 421);
            this.UserInputLabel.Name = "UserInputLabel";
            this.UserInputLabel.Size = new System.Drawing.Size(70, 16);
            this.UserInputLabel.TabIndex = 11;
            this.UserInputLabel.Text = "Submittion";
            // 
            // AdditionalInputTxtBox
            // 
            this.AdditionalInputTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.AdditionalInputTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdditionalInputTxtBox.ForeColor = System.Drawing.SystemColors.Control;
            this.AdditionalInputTxtBox.Location = new System.Drawing.Point(12, 482);
            this.AdditionalInputTxtBox.Name = "AdditionalInputTxtBox";
            this.AdditionalInputTxtBox.Size = new System.Drawing.Size(382, 20);
            this.AdditionalInputTxtBox.TabIndex = 12;
            this.AdditionalInputTxtBox.Visible = false;
            this.AdditionalInputTxtBox.Click += new System.EventHandler(this.AddtionalInputTxtBox_Click);
            // 
            // AdditionalInputLabel
            // 
            this.AdditionalInputLabel.AutoSize = true;
            this.AdditionalInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalInputLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AdditionalInputLabel.Location = new System.Drawing.Point(13, 463);
            this.AdditionalInputLabel.Name = "AdditionalInputLabel";
            this.AdditionalInputLabel.Size = new System.Drawing.Size(99, 16);
            this.AdditionalInputLabel.TabIndex = 13;
            this.AdditionalInputLabel.Text = "Additional Input";
            this.AdditionalInputLabel.Visible = false;
            // 
            // AlgorithmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(955, 588);
            this.Controls.Add(this.AdditionalInputLabel);
            this.Controls.Add(this.AdditionalInputTxtBox);
            this.Controls.Add(this.UserInputLabel);
            this.Controls.Add(this.AnswerOutputLabel);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.CodeViewLabel);
            this.Controls.Add(this.AlgoSelectionLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.UserInputBox);
            this.Controls.Add(this.AnswerTxtBox);
            this.Controls.Add(this.InstructionTxtBox);
            this.Controls.Add(this.CodePreviewBox);
            this.Controls.Add(this.AlgoListBox);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "AlgorithmApp";
            this.Text = "Algorithim App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AlgoListBox;
        private System.Windows.Forms.RichTextBox CodePreviewBox;
        private System.Windows.Forms.RichTextBox InstructionTxtBox;
        private System.Windows.Forms.TextBox AnswerTxtBox;
        private System.Windows.Forms.TextBox UserInputBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label AlgoSelectionLabel;
        private System.Windows.Forms.Label CodeViewLabel;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.Label AnswerOutputLabel;
        private System.Windows.Forms.Label UserInputLabel;
        private System.Windows.Forms.TextBox AdditionalInputTxtBox;
        private System.Windows.Forms.Label AdditionalInputLabel;
    }
}

