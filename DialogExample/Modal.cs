using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DialogExample
{
    public partial class Modal : Form
    {
        public delegate void infoevent(object sender, EventArgs e);
        public event infoevent dlgevent;

        public Modal()
        {
            InitializeComponent();
            //These values are returned from ShowDialog method.
            this.button2.DialogResult = DialogResult.OK;
            this.button3.DialogResult = DialogResult.Cancel;
            AcceptButton = DefaultButton;
            DefaultButton = Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
           // Text = textBox1.Text;
            m_strText = textBox1.Text;
            dlgevent(this, e);
        }

        public string TEXT
        {
            get
            {
                return m_strText;
            }
        }

        private string m_strText;

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            m_strText = "Default Button";
            dlgevent(this, e);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            m_strText = "Cancel Button";
            dlgevent(this, e);
        }
    }
}