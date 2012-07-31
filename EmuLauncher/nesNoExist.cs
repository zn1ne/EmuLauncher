using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class snesNoExist : Form
    {
        public snesNoExist()
        {
            InitializeComponent();
        }

        private void nesNoExist_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.emulator-zone.com/doc.php/nes/nestopia.html");
        }
    }
}
