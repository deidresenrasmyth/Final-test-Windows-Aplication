using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeidreDevelopingWindowsApplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
                      
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            teamFrm frm = new teamFrm();
            frm.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
