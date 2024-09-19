namespace WaiteJordan3309Ex4 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnLoadBook = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.btnShowStatistics = new System.Windows.Forms.Button();
            this.lblInstructionOne = new System.Windows.Forms.Label();
            this.lbStatistics = new System.Windows.Forms.ListBox();
            this.lblInstructionTwo = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.lblInstructionThree = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblEncodedMessage = new System.Windows.Forms.Label();
            this.lblCurrentMessage = new System.Windows.Forms.Label();
            this.txtClearMessage = new System.Windows.Forms.TextBox();
            this.lblInstructionFour = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.lblDecodedMessage = new System.Windows.Forms.Label();
            this.txtOutDecodedMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInstructions.Location = new System.Drawing.Point(281, 23);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(128, 25);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Instructions:";
            // 
            // btnLoadBook
            // 
            this.btnLoadBook.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoadBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadBook.Location = new System.Drawing.Point(754, 98);
            this.btnLoadBook.Name = "btnLoadBook";
            this.btnLoadBook.Size = new System.Drawing.Size(160, 42);
            this.btnLoadBook.TabIndex = 1;
            this.btnLoadBook.Text = "Load Book";
            this.btnLoadBook.UseVisualStyleBackColor = false;
            this.btnLoadBook.Click += new System.EventHandler(this.btnLoadBook_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(775, 398);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(627, 31);
            this.txtOut.TabIndex = 2;
            // 
            // btnShowStatistics
            // 
            this.btnShowStatistics.Location = new System.Drawing.Point(678, 176);
            this.btnShowStatistics.Name = "btnShowStatistics";
            this.btnShowStatistics.Size = new System.Drawing.Size(236, 42);
            this.btnShowStatistics.TabIndex = 3;
            this.btnShowStatistics.Text = "Show Statistics";
            this.btnShowStatistics.UseVisualStyleBackColor = true;
            this.btnShowStatistics.Click += new System.EventHandler(this.btnShowStatistics_Click);
            // 
            // lblInstructionOne
            // 
            this.lblInstructionOne.AutoSize = true;
            this.lblInstructionOne.Location = new System.Drawing.Point(12, 107);
            this.lblInstructionOne.Name = "lblInstructionOne";
            this.lblInstructionOne.Size = new System.Drawing.Size(681, 25);
            this.lblInstructionOne.TabIndex = 4;
            this.lblInstructionOne.Text = "1: Click the \"Load Book\" button to read in and normalize the book text.";
            // 
            // lbStatistics
            // 
            this.lbStatistics.FormattingEnabled = true;
            this.lbStatistics.ItemHeight = 25;
            this.lbStatistics.Location = new System.Drawing.Point(1035, 55);
            this.lbStatistics.Name = "lbStatistics";
            this.lbStatistics.Size = new System.Drawing.Size(357, 179);
            this.lbStatistics.TabIndex = 5;
            // 
            // lblInstructionTwo
            // 
            this.lblInstructionTwo.AutoSize = true;
            this.lblInstructionTwo.Location = new System.Drawing.Point(12, 185);
            this.lblInstructionTwo.Name = "lblInstructionTwo";
            this.lblInstructionTwo.Size = new System.Drawing.Size(592, 25);
            this.lblInstructionTwo.TabIndex = 6;
            this.lblInstructionTwo.Text = "2: Click the \"Show Statistics\" button to see word frequencies.";
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(106, 352);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(236, 44);
            this.btnEncode.TabIndex = 7;
            this.btnEncode.Text = "Encode Message";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // lblInstructionThree
            // 
            this.lblInstructionThree.AutoSize = true;
            this.lblInstructionThree.Location = new System.Drawing.Point(12, 270);
            this.lblInstructionThree.Name = "lblInstructionThree";
            this.lblInstructionThree.Size = new System.Drawing.Size(955, 25);
            this.lblInstructionThree.TabIndex = 8;
            this.lblInstructionThree.Text = "3. Click the \"Encode Message\" button to read in the clear message and output the " +
    "encoded format.";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(1163, 23);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(105, 25);
            this.lblStats.TabIndex = 9;
            this.lblStats.Text = "Statistics:";
            // 
            // lblEncodedMessage
            // 
            this.lblEncodedMessage.AutoSize = true;
            this.lblEncodedMessage.Location = new System.Drawing.Point(557, 401);
            this.lblEncodedMessage.Name = "lblEncodedMessage";
            this.lblEncodedMessage.Size = new System.Drawing.Size(197, 25);
            this.lblEncodedMessage.TabIndex = 10;
            this.lblEncodedMessage.Text = "Encoded Message:";
            // 
            // lblCurrentMessage
            // 
            this.lblCurrentMessage.AutoSize = true;
            this.lblCurrentMessage.Location = new System.Drawing.Point(429, 335);
            this.lblCurrentMessage.Name = "lblCurrentMessage";
            this.lblCurrentMessage.Size = new System.Drawing.Size(325, 25);
            this.lblCurrentMessage.TabIndex = 11;
            this.lblCurrentMessage.Text = "Current message to be encoded:";
            // 
            // txtClearMessage
            // 
            this.txtClearMessage.Location = new System.Drawing.Point(775, 332);
            this.txtClearMessage.Name = "txtClearMessage";
            this.txtClearMessage.Size = new System.Drawing.Size(627, 31);
            this.txtClearMessage.TabIndex = 12;
            // 
            // lblInstructionFour
            // 
            this.lblInstructionFour.AutoSize = true;
            this.lblInstructionFour.Location = new System.Drawing.Point(12, 478);
            this.lblInstructionFour.Name = "lblInstructionFour";
            this.lblInstructionFour.Size = new System.Drawing.Size(789, 25);
            this.lblInstructionFour.TabIndex = 13;
            this.lblInstructionFour.Text = "4. Click the \"Decode Message\" button to decode and view the encoded message.";
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(106, 540);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(236, 44);
            this.btnDecode.TabIndex = 14;
            this.btnDecode.Text = "Decode Message";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // lblDecodedMessage
            // 
            this.lblDecodedMessage.AutoSize = true;
            this.lblDecodedMessage.Location = new System.Drawing.Point(556, 550);
            this.lblDecodedMessage.Name = "lblDecodedMessage";
            this.lblDecodedMessage.Size = new System.Drawing.Size(198, 25);
            this.lblDecodedMessage.TabIndex = 15;
            this.lblDecodedMessage.Text = "Decoded Message:";
            // 
            // txtOutDecodedMessage
            // 
            this.txtOutDecodedMessage.Location = new System.Drawing.Point(775, 543);
            this.txtOutDecodedMessage.Name = "txtOutDecodedMessage";
            this.txtOutDecodedMessage.Size = new System.Drawing.Size(627, 31);
            this.txtOutDecodedMessage.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1424, 940);
            this.Controls.Add(this.txtOutDecodedMessage);
            this.Controls.Add(this.lblDecodedMessage);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.lblInstructionFour);
            this.Controls.Add(this.txtClearMessage);
            this.Controls.Add(this.lblCurrentMessage);
            this.Controls.Add(this.lblEncodedMessage);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblInstructionThree);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.lblInstructionTwo);
            this.Controls.Add(this.lbStatistics);
            this.Controls.Add(this.lblInstructionOne);
            this.Controls.Add(this.btnShowStatistics);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnLoadBook);
            this.Controls.Add(this.lblInstructions);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnLoadBook;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Button btnShowStatistics;
        private System.Windows.Forms.Label lblInstructionOne;
        private System.Windows.Forms.ListBox lbStatistics;
        private System.Windows.Forms.Label lblInstructionTwo;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Label lblInstructionThree;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblEncodedMessage;
        private System.Windows.Forms.Label lblCurrentMessage;
        private System.Windows.Forms.TextBox txtClearMessage;
        private System.Windows.Forms.Label lblInstructionFour;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Label lblDecodedMessage;
        private System.Windows.Forms.TextBox txtOutDecodedMessage;
    }
}

