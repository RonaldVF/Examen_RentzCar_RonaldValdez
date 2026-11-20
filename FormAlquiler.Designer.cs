namespace Examen_RentzCar_RonaldValdez
{
    partial class FormAlquiler
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
            label1 = new Label();
            txtCliente = new TextBox();
            chkCorporativo = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            dtpSalida = new DateTimePicker();
            txtVehiculo = new TextBox();
            txtTarifa = new TextBox();
            nudDias = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            rbtBasico = new RadioButton();
            rbtDomicilio = new RadioButton();
            rbtSucursal = new RadioButton();
            rbtCompleto = new RadioButton();
            chkGps = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lblEncabezado = new Label();
            lstAlquileres = new ListBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            lblSubtotal = new Label();
            lblItbis = new Label();
            lblDomicilio = new Label();
            lblDescuento = new Label();
            lblTotal = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(76, 22);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(234, 27);
            txtCliente.TabIndex = 1;
            // 
            // chkCorporativo
            // 
            chkCorporativo.AutoSize = true;
            chkCorporativo.Location = new Point(12, 66);
            chkCorporativo.Name = "chkCorporativo";
            chkCorporativo.Size = new Size(160, 24);
            chkCorporativo.TabIndex = 2;
            chkCorporativo.Text = "Cliente Corporativo";
            chkCorporativo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "Salida:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 222);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "Dias:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 182);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 5;
            label4.Text = "Tarifa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 140);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 6;
            label5.Text = "Vehiculo:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(550, 22);
            button1.Name = "button1";
            button1.Size = new Size(210, 47);
            button1.TabIndex = 7;
            button1.Text = "Agregar al alquiler";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(76, 103);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(250, 27);
            dtpSalida.TabIndex = 8;
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(86, 140);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(211, 27);
            txtVehiculo.TabIndex = 9;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(76, 179);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(211, 27);
            txtTarifa.TabIndex = 10;
            // 
            // nudDias
            // 
            nudDias.Location = new Point(76, 222);
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(77, 27);
            nudDias.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 282);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(252, 282);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 13;
            // 
            // rbtBasico
            // 
            rbtBasico.AutoSize = true;
            rbtBasico.Location = new Point(11, 32);
            rbtBasico.Name = "rbtBasico";
            rbtBasico.Size = new Size(73, 24);
            rbtBasico.TabIndex = 14;
            rbtBasico.TabStop = true;
            rbtBasico.Text = "Basico";
            rbtBasico.UseVisualStyleBackColor = true;
            // 
            // rbtDomicilio
            // 
            rbtDomicilio.AutoSize = true;
            rbtDomicilio.Location = new Point(13, 74);
            rbtDomicilio.Name = "rbtDomicilio";
            rbtDomicilio.Size = new Size(171, 24);
            rbtDomicilio.TabIndex = 15;
            rbtDomicilio.TabStop = true;
            rbtDomicilio.Text = "Domicilio (+RD$500)";
            rbtDomicilio.UseVisualStyleBackColor = true;
            // 
            // rbtSucursal
            // 
            rbtSucursal.AutoSize = true;
            rbtSucursal.Location = new Point(13, 32);
            rbtSucursal.Name = "rbtSucursal";
            rbtSucursal.Size = new Size(102, 24);
            rbtSucursal.TabIndex = 16;
            rbtSucursal.TabStop = true;
            rbtSucursal.Text = "En sucursal";
            rbtSucursal.UseVisualStyleBackColor = true;
            // 
            // rbtCompleto
            // 
            rbtCompleto.AutoSize = true;
            rbtCompleto.Location = new Point(11, 72);
            rbtCompleto.Name = "rbtCompleto";
            rbtCompleto.Size = new Size(172, 24);
            rbtCompleto.TabIndex = 17;
            rbtCompleto.TabStop = true;
            rbtCompleto.Text = "Completo (+RD$300)";
            rbtCompleto.UseVisualStyleBackColor = true;
            // 
            // chkGps
            // 
            chkGps.AutoSize = true;
            chkGps.Location = new Point(12, 405);
            chkGps.Name = "chkGps";
            chkGps.Size = new Size(185, 24);
            chkGps.TabIndex = 18;
            chkGps.Text = "GPS (+RD$100 por dia)";
            chkGps.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ActiveBorder;
            btnCalcular.Location = new Point(40, 461);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(113, 47);
            btnCalcular.TabIndex = 19;
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveBorder;
            btnLimpiar.Location = new Point(197, 461);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(129, 47);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Nuevo Alquiler";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveBorder;
            btnSalir.Location = new Point(352, 461);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(97, 47);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Location = new Point(475, 110);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(335, 20);
            lblEncabezado.TabIndex = 22;
            lblEncabezado.Text = "Dias     Vehiculo                         Tarifa             Total";
            // 
            // lstAlquileres
            // 
            lstAlquileres.FormattingEnabled = true;
            lstAlquileres.Location = new Point(475, 140);
            lstAlquileres.Name = "lstAlquileres";
            lstAlquileres.Size = new Size(427, 164);
            lstAlquileres.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(475, 328);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 24;
            label8.Text = "Subtotal";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(475, 419);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 25;
            label9.Text = "ITBIS (18%)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(475, 387);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 26;
            label10.Text = "Domicilio";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(475, 358);
            label11.Name = "label11";
            label11.Size = new Size(79, 20);
            label11.TabIndex = 27;
            label11.Text = "Descuento";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(482, 461);
            label12.Name = "label12";
            label12.Size = new Size(124, 20);
            label12.TabIndex = 28;
            label12.Text = "TOTAL A PAGAR";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(603, 328);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(58, 20);
            lblSubtotal.TabIndex = 29;
            lblSubtotal.Text = "label13";
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new Point(603, 419);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(58, 20);
            lblItbis.TabIndex = 30;
            lblItbis.Text = "label13";
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Location = new Point(603, 387);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(58, 20);
            lblDomicilio.TabIndex = 31;
            lblDomicilio.Text = "label13";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(603, 356);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(58, 20);
            lblDescuento.TabIndex = 32;
            lblDescuento.Text = "label13";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(636, 461);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 20);
            lblTotal.TabIndex = 33;
            lblTotal.Text = "label13";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtBasico);
            groupBox1.Controls.Add(rbtCompleto);
            groupBox1.Location = new Point(12, 274);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 125);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seguro";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtSucursal);
            groupBox2.Controls.Add(rbtDomicilio);
            groupBox2.Location = new Point(243, 274);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(206, 125);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Entrega";
            // 
            // FormAlquiler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 520);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTotal);
            Controls.Add(lblDescuento);
            Controls.Add(lblDomicilio);
            Controls.Add(lblItbis);
            Controls.Add(lblSubtotal);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lstAlquileres);
            Controls.Add(lblEncabezado);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(chkGps);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(nudDias);
            Controls.Add(txtTarifa);
            Controls.Add(txtVehiculo);
            Controls.Add(dtpSalida);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(chkCorporativo);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Name = "FormAlquiler";
            Text = "RentaCar Express - Alquileres";
            Load += FormAlquiler_Load;
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCliente;
        private CheckBox chkCorporativo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private DateTimePicker dtpSalida;
        private TextBox txtVehiculo;
        private TextBox txtTarifa;
        private NumericUpDown nudDias;
        private Label label6;
        private Label label7;
        private RadioButton rbtBasico;
        private RadioButton rbtDomicilio;
        private RadioButton rbtSucursal;
        private RadioButton rbtCompleto;
        private CheckBox chkGps;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblEncabezado;
        private ListBox lstAlquileres;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lblSubtotal;
        private Label lblItbis;
        private Label lblDomicilio;
        private Label lblDescuento;
        private Label lblTotal;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}