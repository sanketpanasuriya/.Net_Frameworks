namespace DialogExample
{
    partial class Modal
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DefaultButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DefaultButton
            // 
            this.DefaultButton.Location = new System.Drawing.Point(12, 181);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(106, 30);
            this.DefaultButton.TabIndex = 4;
            this.DefaultButton.Text = "Default Button";
            this.DefaultButton.UseVisualStyleBackColor = true;
            this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(145, 181);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(95, 29);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel Button";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.DefaultButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Location = new System.Drawing.Point(250, 250);
            this.Name = "Modal";
            this.Text = "Modal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button DefaultButton;
        private System.Windows.Forms.Button Cancel;
    }
}