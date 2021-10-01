using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2_G4
{
    public partial class FrmMenu : Form1
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RDocentes doc = new RDocentes();
            this.Hide();
            doc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            REstudiantes est = new REstudiantes();
            this.Hide();
            est.Show();
        }
    }
}
