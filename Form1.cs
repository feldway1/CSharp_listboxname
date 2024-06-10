using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_listboxname
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            lbskq.Items.Add(txtensv.Text);
            txtensv.Text = "";

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            lbskq.Items.RemoveAt(lbskq.SelectedIndex);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lbskq.SelectedIndex < 0) return;
            lbskq.Items[lbskq.SelectedIndex] = txtensv.Text;
        }

        private void lbskq_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbskq.SelectedIndex >= 0)
            {
                txtensv.Text = lbskq.SelectedItem.ToString();
            }
            
        }
    }           
}              
                                                    