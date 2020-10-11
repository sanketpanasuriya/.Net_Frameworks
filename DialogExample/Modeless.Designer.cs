namespace DialogExample
{
    partial class Modeless
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DefaultButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DefaultButton
            // 
            this.DefaultButton.Location = new System.Drawing.Point(16, 187);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(94, 33);
            this.DefaultButton.TabIndex = 2;
            this.DefaultButton.Text = "Default Button";
            this.DefaultButton.UseVisualStyleBackColor = true;
            this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(128, 189);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 33);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel Button";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Modeless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.DefaultButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Modeless";
            this.Text = "Modeless";
            this.Load += new System.EventHandler(this.Modeless_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DefaultButton;
        private System.Windows.Forms.Button Cancel;
    }
}