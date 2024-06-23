using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.tr/maps/place/14031+SE+61st+Ave,+Summerfield,+FL+34491,+Amerika+Birle%C5%9Fik+Devletleri/@29.0176054,-82.0498187,18.25z/data=!4m15!1m8!3m7!1s0x88e7d0185727dbd1:0xb4bca4ddd6ce2512!2s6110+SE+140th+Pl,+Summerfield,+FL+34491,+Amerika+Birle%C5%9Fik+Devletleri!3b1!8m2!3d29.0176272!4d-82.0491932!16s%2Fg%2F11c27j43xx!3m5!1s0x88e7d0185bd86e95:0xc6190433daca4e71!8m2!3d29.0180352!4d-82.049248!16s%2Fg%2F11c1zs5j9j?hl=tr&entry=ttu");
        }
    }
}
