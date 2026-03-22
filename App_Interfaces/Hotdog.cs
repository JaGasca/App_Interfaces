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
    public partial class Hotdog : Form
    {
        // Referencia opcional al formulario principal
        private readonly Form1? _main;
        
        public Hotdog()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            // Deshabilitar maximizar y minimizar
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        public Hotdog(Form1 main) : this()
        {
            _main = main;
        }

        private void btn_hotdog_full_Click(object sender, EventArgs e)
        {
            var item = new AgregarAlPedido("Perro Caliente (Ketchup y Mostaza)", 1);
            _main?.AddToMenu(item);
            MessageBox.Show("Hotdog Full agregado a tu pedido");
        }
        private void btn_hotdog_kep_Click(object sender, EventArgs e)
        {
            var item = new AgregarAlPedido("Perro Caliente (Solo Ketchup)", 1);
            _main?.AddToMenu(item);
            MessageBox.Show("Hotdog con solo Ketchup agregado a tu pedido");
        }
        private void btn_hotdog_mos_Click(object sender, EventArgs e)
        {
            var item = new AgregarAlPedido("Perro Caliente (Solo Mostaza)", 1);
            _main?.AddToMenu(item);
            MessageBox.Show("Hotdog con solo Mostaza agregado a tu pedido");
        }
    }
}
