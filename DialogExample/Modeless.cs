using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DialogExample
{
    public partial class Modeless : Form
    {
        public delegate void infoevent(object sender, EventArgs e);
        public event infoevent dlgevent;

        public Modeless()
        {
            InitializeComponent();
            AcceptButton = DefaultButton;
            CancelButton = Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }

            m_objText = textBox1.Text;
            dlgevent(this, e);
        }

        public string TEXT
        {
            get
            {
                return m_objText;
            }
        }
        private string m_objText;

        private void Modeless_Load(object sender, EventArgs e)
        {

        }

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            m_objText = "Default Button";
            dlgevent(this, e);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            m_objText = "Cancel Button";
            dlgevent(this, e);
        }

    }
}