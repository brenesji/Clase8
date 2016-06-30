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
    public partial class Form1 : Form
    {
        public string name;
        public string lastname;
        Persona person1 = new Persona("Jorge","Oviedo");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Global.Gname = person1.Name;
            Global.Glastname = person1.LastName;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {


            person1.Name = TxtNombre.Text;
            person1.LastName = TxtApellidos.Text;

            label3.Text = person1.Name;
            label4.Text = person1.LastName;

            Global.Gname = label3.Text;
            Global.Glastname = label4.Text;

            //TxtNombre.Text = person1.getname(); //Global.Gname;
            //TxtApellidos.Text = person1.getlastname();

            //label3.Text = Global.Gname;
            //label4.Text = Global.Glastname;

            pictureBox1.Image = Properties.Resources.Flag_of_Costa_Rica_svg;
        }                

        /* Mensaje para persona
         * Indicar provincia por cédula
         * Bandera por provincia 
         * ocultar bandera si no tiene 
         */
    }
}
