using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace App_Interfaces
{
    public partial class Form1 : Form
    {
        // Diccionario público para almacenar datos desde otros formularios.

        public Dictionary<string, int> menu = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            // Mostrar valores al iniciar la aplicación

        }



        // Nuevo método público para recibir objetos AgregarAlPedido desde otros formularios.
        public void AddToMenu(AgregarAlPedido item)
        {
            if (item == null || string.IsNullOrWhiteSpace(item.Producto))
                return;

            if (menu.ContainsKey(item.Producto))
                menu[item.Producto] += item.Cantidad;
            else
                menu[item.Producto] = item.Cantidad;

            // Actualiza la UI después de modificar el diccionario
            MostrarDatos();
        }

        // Mostrar datos del diccionario 'menu' en el panel Pnl_Pedido
        public void MostrarDatos()
        {
            Pnl_Pedido.Controls.Clear();
            int y = 10;
            foreach (var par in menu)
            {
                Label lbl = new Label();
                lbl.Text = $"{par.Key}: {par.Value}";
                lbl.Location = new Point(10, y);
                lbl.AutoSize = true;
                Pnl_Pedido.Controls.Add(lbl);
                y += 25;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hotdog hotdog = new Hotdog(this);
            hotdog.Show();
            MostrarDatos();
        }

        private void pb_crispetas_grandes_Click(object sender, EventArgs e)
        {
            CrispBig crispBig = new CrispBig(this);
            crispBig.Show();
            MostrarDatos();
        }

        private void pb_crispetas_pequenas_Click(object sender, EventArgs e)
        {
            Crisp crisp = new Crisp(this);
            crisp.Show();
            MostrarDatos();
        }
        private void pb_coca_Click(object sender, EventArgs e)
        {
            var item = new AgregarAlPedido("Coca-Cola", 1);
            AddToMenu(item);
            MessageBox.Show("Coca-Cola agregada al pedido.");
        }
    }
}
