using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TodoWFA
{
    public partial class TODO : Form
    {
        public TODO()
        {
            InitializeComponent();
        }

        private void TODO_Load(object sender, EventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            listBoxTo.Items.Add(dateTimePicker1.Value.ToShortDateString() + " " + textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            if (listBoxTo.SelectedIndex != -1)
            {
                listBoxDo.Items.Add(listBoxTo.SelectedItem);
                listBoxTo.Items.Remove(listBoxTo.SelectedItem);
            }
        }

        private void buttonTo_Click(object sender, EventArgs e)
        {
            if (listBoxDo.SelectedIndex != -1)
            {
                listBoxTo.Items.Add(listBoxDo.SelectedItem);
                listBoxDo.Items.Remove(listBoxDo.SelectedItem);
            }
        }

        private void buttonDoPliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(ofd.FileName);
                foreach (var item in listBoxTo.Items)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
                MessageBox.Show("Lista zapisana!");
            }
        }

        private void buttonZPliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listBoxTo.Items.Clear();
                using (StreamReader sr = new StreamReader(ofd.OpenFile()))
                {
                    string linia;
                    while ((linia = sr.ReadLine()) != null)
                    {
                        listBoxTo.Items.Add(linia);
                    }
                }
            }
        }

        private void buttonNaPulpit_Click(object sender, EventArgs e)
        {
            string sciezka = "C:\\Users\\Patryk\\Desktop\\ToDo.txt";
            StreamWriter sw = new StreamWriter(sciezka);
            foreach (var item in listBoxTo.Items)
            {
                sw.WriteLine(item);
            }
            sw.Close();
            MessageBox.Show("Lista zapisana!");      
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            listBoxTo.Items.Remove(listBoxTo.SelectedItem);
        }
    }
}
