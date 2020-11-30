using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            lbFill.Items.Clear();
            int[] a = { 5, 1, 9, 6 };
            for (int i = 0; i < a.Length; i++)
            {
                Node.addInOrder(a[i]);
                lbFill.Items.Add(a[i]);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            lbRead.Items.Clear();
            int[] result = Node.getListAsArray();
        }
    }
}
