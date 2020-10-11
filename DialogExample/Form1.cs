using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DialogExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ///Add two top nodes in tree
            m_ModelessTN = treeView1.Nodes.Add("Modeless");
            m_ModalTN = treeView1.Nodes.Add("Modal");            
        }

        /// <summary>
        /// This method displays modal dialog box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Modal_Click(object sender, EventArgs e)
        {
            objModal = new Modal();
            
            //Set event handler which is called by dialog box.
            objModal.dlgevent += InfoEvent;

            //ShowDialog dispalys dialog box.
            //Return value in Modal constructor
            if (DialogResult.OK == objModal.ShowDialog())
            {
                m_ModalTN.Nodes.Add("Ok Pressed");
            }
            else
            {
                m_ModalTN.Nodes.Add("Cancel or ESC Pressed");
            }
            treeView1.ExpandAll();
        }
        /// <summary>
        /// This method is fired by dailog boxes and set the value
        /// into tree view.
        /// </summary>
        /// <param name="sender">This is sender obejct which fires this event</param>
        /// <param name="e"></param>
        private void InfoEvent(object sender, EventArgs e)
        {
            Modeless objSrc = sender as Modeless;

            //Set background color
            this.BackColor = Color.FromArgb(new Random().Next(255), 0, 0);
            if (null != objSrc)
            {
                m_ModelessTN.Nodes.Add(objSrc.TEXT);
            }
            else
            {
                Modal objModalSrc = sender as Modal;
                if (null != objModalSrc)
                {
                    m_ModalTN.Nodes.Add(objModalSrc.TEXT);
                }
            }

            treeView1.ExpandAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Modeless_Click(object sender, EventArgs e)
        {
            objModeless = new Modeless();
            objModeless.dlgevent += InfoEvent;

            //Modeless dialog box is displayed by Show method.
            objModeless.Show();
            
        }

        private TreeNode m_ModelessTN;
        private TreeNode m_ModalTN;
        private Modal objModal;
        private Modeless objModeless;

        private void ModellessClose(object sender, EventArgs e)
        {
            try
            {
                objModeless.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}