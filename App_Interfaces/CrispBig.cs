using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Interfaces
{
    public partial class CrispBig : Form
    {
        // Referencia opcional al formulario principal
        private readonly Form1? _main;

        public CrispBig()
        {
            InitializeComponent();
            // Deshabilitar maximizar y minimizar
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        // Constructor que recibe la referencia al Form1 para enviar AgregarAlPedido
        public CrispBig(Form1 main) : this()
        {
            _main = main;
        }

        private void btn_crispbig_saladas_Click(object sender, EventArgs e)
        {
            // Crear objeto AgregarAlPedido y enviarlo a Form1.menu
            var item = new AgregarAlPedido("Crispetas grandes (Saladas)", 1);
            _main?.AddToMenu(item);
            MessageBox.Show("Crispetas grandes Saladas agregadas a tu pedido");
        }
        private void btn_crispbig_dulces_Click(object sender, EventArgs e)
        {
            // Crear objeto AgregarAlPedido y enviarlo a Form1.menu
            var item = new AgregarAlPedido("Crispetas grandes (Dulces)", 1);
            _main?.AddToMenu(item);
            MessageBox.Show("Crispetas grandes Dulces agregadas a tu pedido");
        }
        private void btn_crispbig_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
