using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.DataFormats;

namespace App_Interfaces
{
    public partial class Crisp : Form
    {
        // Referencia opcional al formulario principal
        private readonly Form1? _main;


        public Crisp()
        {
            InitializeComponent();
            // Deshabilitar maximizar y minimizar
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            StartPosition = FormStartPosition.CenterScreen;
        }



        // Constructor que recibe la referencia al Form1 para enviar AgregarAlPedido
        public Crisp(Form1 main) : this()
        {
            _main = main;
        }

        private void btn_crisp_saladas_Click(object sender, EventArgs e)
        {
            // Crear objeto AgregarAlPedido y enviarlo a Form1.menu
            var item = new AgregarAlPedido("Crispetas pequeñas (Saladas)", 1);
            _main?.AddToMenu(item);

            MessageBox.Show("Crispetas pequeñas Saladas agregadas a tu pedido");
        }

        private void btn_crisp_dulces_Click(object sender, EventArgs e)
        {
            var item = new AgregarAlPedido("Crispetas pequeñas (Dulces)", 1);
            _main?.AddToMenu(item);

            MessageBox.Show("Crispetas pequeñas (Dulces) agregadas a tu pedido");
        }
    
        private void btn_crisp_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
