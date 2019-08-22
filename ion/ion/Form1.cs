using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string co = nombre.Text;
            string cn = contraseña.Text;
            if (co == "juancho" && cn == "123frijoles")
            {
                MessageBox.Show("Bienvenido a Pompom Land! (●´ω｀●)");
                this.Close();
            }
            else
            {
                MessageBox.Show("Acceso denegado. (￣□￣) ");

            }
        }
    }
}
