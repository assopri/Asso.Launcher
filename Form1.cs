using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asso.Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tileBar1.ItemSize = 180;
            //tileBar1.WideTileWidth = 800;
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }
    }
}
