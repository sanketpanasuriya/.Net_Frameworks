namespace DialogExample
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
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modeless";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Modeless_Click);
            // 
            // treeView1
            // 
            this.treeView1.LineColor = System.Drawing.Color.ForestGreen;
            this.treeView1.Location = new System.Drawing.Point(69, 33);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(170, 124);
            this.treeView1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Modal_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(161, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 24);
            this.button4.TabIndex = 4;
            this.button4.Text = "Modeless Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ModellessClose);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}

