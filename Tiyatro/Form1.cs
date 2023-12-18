using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiyatro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         Tiyatro tiyatro;
         List<Tiyatro> tiyatroListesi = new List<Tiyatro>();

        private void Form1_Load(object sender, EventArgs e)
        {
            tiyatroListesi.Add(new Tiyatro());
        }
    }
}
