using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReqFerramentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGerir_Click(object sender, EventArgs e)
        {
            frmColaboradores frm = new frmColaboradores();
            frm.ShowDialog();
        }

        private void btFerramentas_Click(object sender, EventArgs e)
        {
            frmFerramentas frm = new frmFerramentas();
            frm.ShowDialog();
        }
    }
}
