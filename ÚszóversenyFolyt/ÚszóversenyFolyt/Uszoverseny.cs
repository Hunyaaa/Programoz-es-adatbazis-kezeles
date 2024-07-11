using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Úszóverseny
{
    public partial class Uszoverseny : Form
    {
        public Uszoverseny()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uszoverseny form = new Uszoverseny();
            Verseny verseny = new Verseny();
            verseny.Show();
            Visible = false;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void Eredmény_Click(object sender, EventArgs e)
        {
            Uszoverseny form = new Uszoverseny();
            Eredmeny ered = new Eredmeny();
            ered.Show();
            Visible = false;
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verseny verseny = new Verseny();
            verseny.Show();
            Visible = false;
        }

        private void mentésCrtlSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Az adatok mentésre kerültek");
        }

        private void bezárásALTF4ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Névjegy_Click(object sender, EventArgs e)
        {
            Nevjegy nevjegy = new Nevjegy();
            nevjegy.Show();
            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
