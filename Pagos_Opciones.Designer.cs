
namespace Gym_CapaPresentacion
{
    partial class Pagos_Opciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Num_Identificacion = new System.Windows.Forms.Label();
            this.txb_Numero_ID = new System.Windows.Forms.TextBox();
            this.cb_Periodo_Pago = new System.Windows.Forms.ComboBox();
            this.lbl_Info_Cliente = new System.Windows.Forms.Label();
            this.cb_Categoria_Pago = new System.Windows.Forms.ComboBox();
            this.cb_Metodo_Pago = new System.Windows.Forms.ComboBox();
            this.dt_Fecha_Pago = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Monto = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_MetodoPago = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Registrar_Pago = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Num_Identificacion
            // 
            this.lbl_Num_Identificacion.AutoSize = true;
            this.lbl_Num_Identificacion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Num_Identificacion.Location = new System.Drawing.Point(484, 111);
            this.lbl_Num_Identificacion.Name = "lbl_Num_Identificacion";
            this.lbl_Num_Identificacion.Size = new System.Drawing.Size(230, 25);
            this.lbl_Num_Identificacion.TabIndex = 2;
            this.lbl_Num_Identificacion.Text = "Número de identificación:";
            // 
            // txb_Numero_ID
            // 
            this.txb_Numero_ID.Location = new System.Drawing.Point(484, 139);
            this.txb_Numero_ID.Name = "txb_Numero_ID";
            this.txb_Numero_ID.Size = new System.Drawing.Size(340, 23);
            this.txb_Numero_ID.TabIndex = 3;
            // 
            // cb_Periodo_Pago
            // 
            this.cb_Periodo_Pago.FormattingEnabled = true;
            this.cb_Periodo_Pago.Location = new System.Drawing.Point(678, 309);
            this.cb_Periodo_Pago.Name = "cb_Periodo_Pago";
            this.cb_Periodo_Pago.Size = new System.Drawing.Size(146, 23);
            this.cb_Periodo_Pago.TabIndex = 5;
            // 
            // lbl_Info_Cliente
            // 
            this.lbl_Info_Cliente.AutoSize = true;
            this.lbl_Info_Cliente.Location = new System.Drawing.Point(484, 223);
            this.lbl_Info_Cliente.Name = "lbl_Info_Cliente";
            this.lbl_Info_Cliente.Size = new System.Drawing.Size(37, 15);
            this.lbl_Info_Cliente.TabIndex = 6;
            this.lbl_Info_Cliente.Text = "..........";
            // 
            // cb_Categoria_Pago
            // 
            this.cb_Categoria_Pago.FormattingEnabled = true;
            this.cb_Categoria_Pago.Location = new System.Drawing.Point(678, 351);
            this.cb_Categoria_Pago.Name = "cb_Categoria_Pago";
            this.cb_Categoria_Pago.Size = new System.Drawing.Size(146, 23);
            this.cb_Categoria_Pago.TabIndex = 7;
            // 
            // cb_Metodo_Pago
            // 
            this.cb_Metodo_Pago.FormattingEnabled = true;
            this.cb_Metodo_Pago.Location = new System.Drawing.Point(678, 397);
            this.cb_Metodo_Pago.Name = "cb_Metodo_Pago";
            this.cb_Metodo_Pago.Size = new System.Drawing.Size(146, 23);
            this.cb_Metodo_Pago.TabIndex = 8;
            // 
            // dt_Fecha_Pago
            // 
            this.dt_Fecha_Pago.CustomFormat = "dd/MM/yyyy";
            this.dt_Fecha_Pago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Fecha_Pago.Location = new System.Drawing.Point(678, 442);
            this.dt_Fecha_Pago.Name = "dt_Fecha_Pago";
            this.dt_Fecha_Pago.Size = new System.Drawing.Size(146, 23);
            this.dt_Fecha_Pago.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(678, 486);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 23);
            this.textBox1.TabIndex = 10;
            // 
            // lbl_Monto
            // 
            this.lbl_Monto.AutoSize = true;
            this.lbl_Monto.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Monto.Location = new System.Drawing.Point(502, 486);
            this.lbl_Monto.Name = "lbl_Monto";
            this.lbl_Monto.Size = new System.Drawing.Size(78, 23);
            this.lbl_Monto.TabIndex = 11;
            this.lbl_Monto.Text = "Monto : ";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Categoria.Location = new System.Drawing.Point(502, 305);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(104, 23);
            this.lbl_Categoria.TabIndex = 12;
            this.lbl_Categoria.Text = "Categoría : ";
            // 
            // lbl_MetodoPago
            // 
            this.lbl_MetodoPago.AutoSize = true;
            this.lbl_MetodoPago.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_MetodoPago.Location = new System.Drawing.Point(502, 351);
            this.lbl_MetodoPago.Name = "lbl_MetodoPago";
            this.lbl_MetodoPago.Size = new System.Drawing.Size(163, 23);
            this.lbl_MetodoPago.TabIndex = 13;
            this.lbl_MetodoPago.Text = "Método de pago : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(502, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Periodo : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(502, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha de pago : ";
            // 
            // btn_Registrar_Pago
            // 
            this.btn_Registrar_Pago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Registrar_Pago.FlatAppearance.BorderSize = 0;
            this.btn_Registrar_Pago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar_Pago.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Registrar_Pago.Location = new System.Drawing.Point(565, 551);
            this.btn_Registrar_Pago.Name = "btn_Registrar_Pago";
            this.btn_Registrar_Pago.Size = new System.Drawing.Size(187, 36);
            this.btn_Registrar_Pago.TabIndex = 16;
            this.btn_Registrar_Pago.Text = "Registrar Pago";
            this.btn_Registrar_Pago.UseVisualStyleBackColor = false;
            this.btn_Registrar_Pago.Click += new System.EventHandler(this.btn_Registrar_Pago_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Buscar.Location = new System.Drawing.Point(565, 178);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(187, 36);
            this.btn_Buscar.TabIndex = 17;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // Pagos_Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1131, 729);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Registrar_Pago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_MetodoPago);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.lbl_Monto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dt_Fecha_Pago);
            this.Controls.Add(this.cb_Metodo_Pago);
            this.Controls.Add(this.cb_Categoria_Pago);
            this.Controls.Add(this.lbl_Info_Cliente);
            this.Controls.Add(this.cb_Periodo_Pago);
            this.Controls.Add(this.txb_Numero_ID);
            this.Controls.Add(this.lbl_Num_Identificacion);
            this.Name = "Pagos_Opciones";
            this.Text = "Pagos_Opciones";
            this.Load += new System.EventHandler(this.Pagos_Opciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Num_Identificacion;
        private System.Windows.Forms.TextBox txb_Numero_ID;
        private System.Windows.Forms.ComboBox cb_Periodo_Pago;
        private System.Windows.Forms.Label lbl_Info_Cliente;
        private System.Windows.Forms.ComboBox cb_Categoria_Pago;
        private System.Windows.Forms.ComboBox cb_Metodo_Pago;
        private System.Windows.Forms.DateTimePicker dt_Fecha_Pago;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Monto;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_MetodoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Registrar_Pago;
        private System.Windows.Forms.Button btn_Buscar;
    }
}