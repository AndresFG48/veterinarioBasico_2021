using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 

namespace veterinarioBasico_2021
{
    public partial class ventana_Login : Form
    {

        conexion conexion = new conexion();
        public ventana_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String resultado = conexion.loginVeterinario(textBoxDNI.Text, textBoxpass.Text);
            MessageBox.Show(resultado);
            //Ventana_Principal ventana = new Ventana_Principal();
            //ventana.Show();
            
                
           
        }
    }
}
