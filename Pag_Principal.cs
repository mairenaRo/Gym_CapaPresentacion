using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_CapaPresentacion
{
    public partial class Pag_Principal : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
            );


        public Pag_Principal()
        {

            InitializeComponent();

            
        }

        private void Pag_Principal_Load(object sender, EventArgs e)
        {
            btn_Clientes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Clientes.Width, btn_Clientes.Height, 15, 15));
            btn_Pagos.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Pagos.Width, btn_Pagos.Height, 15, 15));
            btn_Reportes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Reportes.Width, btn_Reportes.Height, 15, 15));
            btn_ModificarCliente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ModificarCliente.Width, btn_ModificarCliente.Height, 15, 15));
            
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
