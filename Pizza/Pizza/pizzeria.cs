using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class pizzeria : Form
    {
        public pizzeria()
        {
            InitializeComponent();
        }

        private void bezarBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void szamolBTN_Click(object sender, EventArgs e)
        {

            int osszeg = 0;
            int ar = 0;
            int db = 0;
            try
            {//vega
                if (vegaBOX.Checked)
                {
                    if (vegaKicsi.Checked)
                    {
                        ar = Int32.Parse(vegaKicsi.Text);
                    }
                    if (vegaNagy.Checked)
                    {
                        ar = Int32.Parse(vegaNagy.Text);
                    }
                }
                db = Int32.Parse(db1.Text);
                if (db < 0) throw new MissingFieldException("Válasszon méretet!");
                osszeg += ar * db;
                
                //magyaros
                if (magyarosBOX.Checked)
                {
                    if (magyarosKicsi.Checked)
                    {
                        ar = Int32.Parse(magyarosKicsi.Text);
                    }
                    if (magyarosNagy.Checked)
                    {
                        ar = Int32.Parse(magyarosNagy.Text);
                    }
                }
                db = Int32.Parse(db2.Text);
                if (db < 0) throw new MissingFieldException("Válasszon méretet!");
                osszeg += ar * db;

                //vesuivo
                if (vesuivoBOX.Checked)
                {
                    if (vesuivoKicsi.Checked)
                    {
                        ar = Int32.Parse(vesuivoKicsi.Text);
                    }
                    if (vesuivoNagy.Checked)
                    {
                        ar = Int32.Parse(vesuivoNagy.Text);
                    }
                }
                db = Int32.Parse(db3.Text);
                if (db < 0) throw new MissingFieldException("Válasszon méretet!");
                osszeg += ar * db;

                //negysajtos
                if (negysajtosBOX.Checked)
                {
                    if (negysajtosKicsi.Checked)
                    {
                        ar = Int32.Parse(negysajtosKicsi.Text);
                    }
                    if (negysajtosNagy.Checked)
                    {
                        ar = Int32.Parse(negysajtosNagy.Text);
                    }
                }
                db = int.Parse(db4.Text);
                if (db < 0) throw new MissingFieldException("Válasszon méretet!");
                osszeg += ar * db;

                //torino
                if (torinoBOX.Checked)
                {
                    if (torinoKicsi.Checked)
                    {
                        ar = Int32.Parse(torinoKicsi.Text);
                    }
                    if (torinoNagy.Checked)
                    {
                        ar = Int32.Parse(torinoNagy.Text);
                    }
                }
                db = Int32.Parse(db5.Text);
                if (db < 0) throw new MissingFieldException("Válasszon méretet!");
                osszeg += ar * db;

                if (!vegaBOX.Checked && !magyarosBOX.Checked && !vesuivoBOX.Checked && !negysajtosBOX.Checked && !torinoBOX.Checked) throw new MissingFieldException();
                fizetendoTEXTBOX.Text = Convert.ToString(osszeg) + "Ft";
            }
            catch (FormatException)
            {
            /*    MessageBox.Show("Hibásan adta meg a darabszámot", "Hiba");*/
            }
            catch (ArgumentException aox)
            {
                MessageBox.Show(aox.Message, "Hiba");
            }
            catch(MissingFieldException mex)
            {
                MessageBox.Show(mex.Message, "Hiba");
            }
        }

        private void torolBTN_Click(object sender, EventArgs e)
        {
            foreach(Control item in this.Controls)
            {
                if (item is CheckBox) (item as CheckBox).Checked = false;
                if (item is TextBox) ((TextBox)item).Clear();
                if (item is RadioButton) ((RadioButton)item).Checked = false;
                if (item.HasChildren)
                {
                    foreach(Control gyerek in item.Controls)
                    {
                        if (gyerek is RadioButton) (gyerek as RadioButton).Checked = false;
                    }
                }
            }
        }
    }
}
