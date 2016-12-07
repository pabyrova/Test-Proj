using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace Test_Winforms_Proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            Closing += Form1_Closing;
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            Dispose();
            Dispose();
            Dispose();
            Dispose();
            Dispose();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Invalidate();//remove visible
            Invalidate();//remove visible
            Invalidate();//remove visible
        }
    }
}
