using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEstados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblEstados.Text = cboEstados.Items.Count.ToString();
        }

        private void lblEstados_Click(object sender, EventArgs e)
        {

        }
    }
}
