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
    public partial class Pagos_Opciones : Form
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


        public Pagos_Opciones()
        {
            InitializeComponent();




        }

        private void btn_Registrar_Pago_Click(object sender, EventArgs e)
        {

        }

        private void Pagos_Opciones_Load(object sender, EventArgs e)
        {
           btn_Registrar_Pago.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Registrar_Pago.Width, btn_Registrar_Pago.Height, 15, 15));
        }
    }
}
