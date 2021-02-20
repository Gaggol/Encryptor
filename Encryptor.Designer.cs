namespace Encryptor
{
    partial class Encryptor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encryptor));
            this.SubmitButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.MuteErrors = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(0, 0);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(50, 20);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(1, 20);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(382, 140);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "Input Text to Encrypt";
            this.TextBox.Click += new System.EventHandler(this.TextBox_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(334, 0);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(50, 20);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MuteErrors
            // 
            this.MuteErrors.AutoSize = true;
            this.MuteErrors.Location = new System.Drawing.Point(155, 2);
            this.MuteErrors.Name = "MuteErrors";
            this.MuteErrors.Size = new System.Drawing.Size(80, 17);
            this.MuteErrors.TabIndex = 3;
            this.MuteErrors.Text = "Mute Errors";
            this.MuteErrors.UseVisualStyleBackColor = true;
            this.MuteErrors.CheckedChanged += new System.EventHandler(this.MuteErrors_CheckedChanged);
            // 
            // Encryptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.MuteErrors);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.SubmitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Encryptor";
            this.Text = "Encryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.CheckBox MuteErrors;
    }
}

