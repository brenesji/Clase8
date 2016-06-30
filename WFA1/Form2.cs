using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // la razon de la clase global es poderla usar en todos los modulos
            label1.Text = Global.Gname;
            label2.Text = Global.Glastname;


            comboBox2.Items.Add("Agua");
            comboBox2.Items.Add("Cafe");
            comboBox2.Items.Add("Leche");
            comboBox2.Items.Add("Chocolate");
            comboBox2.SelectedIndex = 1;
        }


    }
}
