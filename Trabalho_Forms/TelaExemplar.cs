using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Forms
{
    public partial class TelaExemplar : Form
    {
        public TelaExemplar()
        {
            InitializeComponent();
        }

        private void TelaExemplar_Load(object sender, EventArgs e)
        {
            painalEbook.Enabled = checkEBook.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void painalEbook_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
