using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tgsw5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DataTable cek = new DataTable();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            cek.Rows.Add(textBoxData.Text);
            int sama = 0;
            for (int i = 0; i < cek.Rows.Count; i++)
            {
                if (textBoxData.Text == cek.Rows[i][0].ToString() )
                {
                    sama++;
                }
            }
            if(sama == 1)
            {
                listBoxData.Items.Add(textBoxData.Text);
            }
            else
            {
                MessageBox.Show("Data yang dimasukkan tidak boleh sama!");
            }
            textBoxData.Text = "";
            textBoxData.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cek.Columns.Add("data");
        }

        private void listBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelOutput.Text = listBoxData.SelectedItem.ToString();
        }

        private void checkBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAktif.Checked == true && radioButtonMerah.Checked)
            {
                    labelOutput.ForeColor = Color.Red;
            }
            else if(checkBoxAktif.Checked == true && radioButtonBiru.Checked)
            {
                    labelOutput.ForeColor = Color.Blue;
            }
            else
            {
                labelOutput.ForeColor = Color.Black;
            }
        }

        private void radioButtonMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true && radioButtonMerah.Checked)
            {
                labelOutput.ForeColor = Color.Red;
            }
        }

        private void radioButtonBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true && radioButtonBiru.Checked)
            {
                labelOutput.ForeColor = Color.Blue;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            checkBoxAktif.Checked = false;
            radioButtonMerah.Checked = true;
            radioButtonBiru.Checked = false;
            labelOutput.Text = "";
        }
    }
}
