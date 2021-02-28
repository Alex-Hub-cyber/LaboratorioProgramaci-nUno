using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramaciónUno
{
    public partial class FrmMenu : Form
    {
        private object cls;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombreUsuario_Click(object sender, EventArgs e)
        {
            FrmLoguin frm = new FrmLoguin();

            frm.Show();





        }
    }

    internal class FrmLoguin
    {
        internal void Show()
        {
        }
    }
}

 



    
           