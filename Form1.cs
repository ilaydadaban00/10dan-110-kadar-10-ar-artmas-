using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aralıklı_artırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            for(int i= 110; i > 10; i=i-10)
            {
                listbox.Items.Add(i);   
            }
        }
    }
}
