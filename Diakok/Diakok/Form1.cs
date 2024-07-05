using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diakok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int ev = 1924; ev <= 2005; ev++)
            {
                listBox2.Items.Add(ev.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("evszamok.txt");
            sw.WriteLine(listBox2.Text.ToString());
            sw.Close();
            if (checkBox1.Checked)
            {
                listBox1.Items.Add(checkBox1.Text + " " + listBox2.SelectedItem.ToString());
            }
            if (checkBox2.Checked)
            {
                listBox1.Items.Add(checkBox2.Text + " " + listBox2.SelectedItem.ToString());
            }
            if (checkBox3.Checked)
            {
                listBox1.Items.Add(checkBox3.Text + " " + listBox2.SelectedItem.ToString());
            }
            if (checkBox4.Checked)
            {
                listBox1.Items.Add(checkBox4.Text + " " + listBox2.SelectedItem.ToString());
            }
            if (checkBox5.Checked)
            {
                listBox1.Items.Add(checkBox5.Text + " " + listBox2.SelectedItem.ToString());
            }
            if (checkBox6.Checked)
            {
                listBox1.Items.Add(checkBox6.Text + " " + listBox2.SelectedItem.ToString());
            }
            if (checkBox7.Checked)
            {
                listBox1.Items.Add(checkBox7.Text + " " + listBox2.SelectedItem.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Visible = true;

            checkBox2.Visible = true;


            checkBox3.Visible = true;

            checkBox4.Visible = true;

            checkBox5.Visible = true;

            checkBox6.Visible = true;

            checkBox7.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("d:\\evszamok.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                lista.Add(sor);
            }
            sr.Close();
            int a = 2024;
            textBox3.Text = $"A legidősebb ember: {a - Int32.Parse(lista.Min())} éves";
        }
    }
}