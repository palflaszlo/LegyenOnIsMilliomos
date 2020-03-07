using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_milliomos
{
    public partial class Segitseg : Form
    {
        public Segitseg()
        {
            InitializeComponent();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
