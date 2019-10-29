namespace Multas
{
    partial class Form1
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
            this.groupRegistrarComparendo = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblMultaValor = new System.Windows.Forms.Label();
            this.lblMultaEstablecida = new System.Windows.Forms.Label();
            this.inputVelocidad = new System.Windows.Forms.TextBox();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.inputPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblSelecionarCuadrante = new System.Windows.Forms.Label();
            this.selSeleccionarCuadrante = new System.Windows.Forms.ComboBox();
            this.groupConsultarMultas = new System.Windows.Forms.GroupBox();
            this.dataListaDeMultas = new System.Windows.Forms.DataGridView();
            this.groupCuadrante1 = new System.Windows.Forms.GroupBox();
            this.inputTotalMultasC1 = new System.Windows.Forms.TextBox();
            this.lblTotalC1 = new System.Windows.Forms.Label();
            this.inputMultaPromedioC1 = new System.Windows.Forms.TextBox();
            this.lblMultaPromedioC1 = new System.Windows.Forms.Label();
            this.inputTotalC1 = new System.Windows.Forms.TextBox();
            this.lblTotalInfraccionesC1 = new System.Windows.Forms.Label();
            this.groupCuadrante2 = new System.Windows.Forms.GroupBox();
            this.inputTotalMultasC2 = new System.Windows.Forms.TextBox();
            this.lblTotalC2 = new System.Windows.Forms.Label();
            this.inputMultaPromedioC2 = new System.Windows.Forms.TextBox();
            this.lblMultaPromedioC2 = new System.Windows.Forms.Label();
            this.inputTotalC2 = new System.Windows.Forms.TextBox();
            this.lblTotalInfraccionesC2 = new System.Windows.Forms.Label();
            this.groupCuadrante4 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.inputTotalMultasC4 = new System.Windows.Forms.TextBox();
            this.lblTotalC4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.inputMultaPromedioC4 = new System.Windows.Forms.TextBox();
            this.lblMultaPromedioC4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inputTotalC4 = new System.Windows.Forms.TextBox();
            this.lblTotalInfraccionesC4 = new System.Windows.Forms.Label();
            this.groupCuadrante3 = new System.Windows.Forms.GroupBox();
            this.inputTotalMultasC3 = new System.Windows.Forms.TextBox();
            this.lblTotalC3 = new System.Windows.Forms.Label();
            this.inputMultaPromedioC3 = new System.Windows.Forms.TextBox();
            this.lblMultaPromedioC3 = new System.Windows.Forms.Label();
            this.inputTotalC3 = new System.Windows.Forms.TextBox();
            this.lblTotalInfraccionesC3 = new System.Windows.Forms.Label();
            this.colPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVelocidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupRegistrarComparendo.SuspendLayout();
            this.groupConsultarMultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaDeMultas)).BeginInit();
            this.groupCuadrante1.SuspendLayout();
            this.groupCuadrante2.SuspendLayout();
            this.groupCuadrante4.SuspendLayout();
            this.groupCuadrante3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupRegistrarComparendo
            // 
            this.groupRegistrarComparendo.Controls.Add(this.btnRegistrar);
            this.groupRegistrarComparendo.Controls.Add(this.lblMultaValor);
            this.groupRegistrarComparendo.Controls.Add(this.lblMultaEstablecida);
            this.groupRegistrarComparendo.Controls.Add(this.inputVelocidad);
            this.groupRegistrarComparendo.Controls.Add(this.lblVelocidad);
            this.groupRegistrarComparendo.Controls.Add(this.inputPlaca);
            this.groupRegistrarComparendo.Controls.Add(this.lblPlaca);
            this.groupRegistrarComparendo.Controls.Add(this.lblSelecionarCuadrante);
            this.groupRegistrarComparendo.Controls.Add(this.selSeleccionarCuadrante);
            this.groupRegistrarComparendo.Location = new System.Drawing.Point(40, 31);
            this.groupRegistrarComparendo.Name = "groupRegistrarComparendo";
            this.groupRegistrarComparendo.Size = new System.Drawing.Size(313, 171);
            this.groupRegistrarComparendo.TabIndex = 0;
            this.groupRegistrarComparendo.TabStop = false;
            this.groupRegistrarComparendo.Text = "Agregar comparendo";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(186, 142);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(121, 23);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblMultaValor
            // 
            this.lblMultaValor.AutoSize = true;
            this.lblMultaValor.Location = new System.Drawing.Point(186, 116);
            this.lblMultaValor.Name = "lblMultaValor";
            this.lblMultaValor.Size = new System.Drawing.Size(37, 13);
            this.lblMultaValor.TabIndex = 8;
            this.lblMultaValor.Text = "20000";
            // 
            // lblMultaEstablecida
            // 
            this.lblMultaEstablecida.AutoSize = true;
            this.lblMultaEstablecida.Location = new System.Drawing.Point(6, 116);
            this.lblMultaEstablecida.Name = "lblMultaEstablecida";
            this.lblMultaEstablecida.Size = new System.Drawing.Size(90, 13);
            this.lblMultaEstablecida.TabIndex = 7;
            this.lblMultaEstablecida.Text = "Multa establecida";
            // 
            // inputVelocidad
            // 
            this.inputVelocidad.Location = new System.Drawing.Point(186, 86);
            this.inputVelocidad.Name = "inputVelocidad";
            this.inputVelocidad.Size = new System.Drawing.Size(121, 20);
            this.inputVelocidad.TabIndex = 6;
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(6, 89);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(200, 13);
            this.lblVelocidad.TabIndex = 5;
            this.lblVelocidad.Text = "Escriba la velocidad del vehículo            ";
            // 
            // inputPlaca
            // 
            this.inputPlaca.Location = new System.Drawing.Point(186, 59);
            this.inputPlaca.Name = "inputPlaca";
            this.inputPlaca.Size = new System.Drawing.Size(121, 20);
            this.inputPlaca.TabIndex = 4;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(6, 59);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(152, 13);
            this.lblPlaca.TabIndex = 3;
            this.lblPlaca.Text = "Escriba las placas del vehiculo";
            // 
            // lblSelecionarCuadrante
            // 
            this.lblSelecionarCuadrante.AutoSize = true;
            this.lblSelecionarCuadrante.Location = new System.Drawing.Point(6, 33);
            this.lblSelecionarCuadrante.Name = "lblSelecionarCuadrante";
            this.lblSelecionarCuadrante.Size = new System.Drawing.Size(126, 13);
            this.lblSelecionarCuadrante.TabIndex = 2;
            this.lblSelecionarCuadrante.Text = "Seleccione un cuadrante";
            // 
            // selSeleccionarCuadrante
            // 
            this.selSeleccionarCuadrante.FormattingEnabled = true;
            this.selSeleccionarCuadrante.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.selSeleccionarCuadrante.Location = new System.Drawing.Point(186, 30);
            this.selSeleccionarCuadrante.Name = "selSeleccionarCuadrante";
            this.selSeleccionarCuadrante.Size = new System.Drawing.Size(121, 21);
            this.selSeleccionarCuadrante.TabIndex = 1;
            this.selSeleccionarCuadrante.Tag = "selectCuadrante";
            // 
            // groupConsultarMultas
            // 
            this.groupConsultarMultas.Controls.Add(this.dataListaDeMultas);
            this.groupConsultarMultas.Location = new System.Drawing.Point(386, 31);
            this.groupConsultarMultas.Name = "groupConsultarMultas";
            this.groupConsultarMultas.Size = new System.Drawing.Size(364, 171);
            this.groupConsultarMultas.TabIndex = 1;
            this.groupConsultarMultas.TabStop = false;
            this.groupConsultarMultas.Text = "Ver multas";
            // 
            // dataListaDeMultas
            // 
            this.dataListaDeMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaDeMultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPlaca,
            this.colVelocidad,
            this.colMulta});
            this.dataListaDeMultas.Location = new System.Drawing.Point(6, 19);
            this.dataListaDeMultas.Name = "dataListaDeMultas";
            this.dataListaDeMultas.Size = new System.Drawing.Size(352, 130);
            this.dataListaDeMultas.TabIndex = 0;
            this.dataListaDeMultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaDeMultas_CellContentClick);
            // 
            // groupCuadrante1
            // 
            this.groupCuadrante1.Controls.Add(this.inputTotalMultasC1);
            this.groupCuadrante1.Controls.Add(this.lblTotalC1);
            this.groupCuadrante1.Controls.Add(this.inputMultaPromedioC1);
            this.groupCuadrante1.Controls.Add(this.lblMultaPromedioC1);
            this.groupCuadrante1.Controls.Add(this.inputTotalC1);
            this.groupCuadrante1.Controls.Add(this.lblTotalInfraccionesC1);
            this.groupCuadrante1.Location = new System.Drawing.Point(40, 208);
            this.groupCuadrante1.Name = "groupCuadrante1";
            this.groupCuadrante1.Size = new System.Drawing.Size(218, 107);
            this.groupCuadrante1.TabIndex = 2;
            this.groupCuadrante1.TabStop = false;
            this.groupCuadrante1.Text = "Cuadrante 1";
            // 
            // inputTotalMultasC1
            // 
            this.inputTotalMultasC1.Location = new System.Drawing.Point(158, 74);
            this.inputTotalMultasC1.Name = "inputTotalMultasC1";
            this.inputTotalMultasC1.ReadOnly = true;
            this.inputTotalMultasC1.Size = new System.Drawing.Size(54, 20);
            this.inputTotalMultasC1.TabIndex = 5;
            // 
            // lblTotalC1
            // 
            this.lblTotalC1.AutoSize = true;
            this.lblTotalC1.Location = new System.Drawing.Point(10, 77);
            this.lblTotalC1.Name = "lblTotalC1";
            this.lblTotalC1.Size = new System.Drawing.Size(64, 13);
            this.lblTotalC1.TabIndex = 4;
            this.lblTotalC1.Text = "Total multas";
            // 
            // inputMultaPromedioC1
            // 
            this.inputMultaPromedioC1.Location = new System.Drawing.Point(158, 48);
            this.inputMultaPromedioC1.Name = "inputMultaPromedioC1";
            this.inputMultaPromedioC1.ReadOnly = true;
            this.inputMultaPromedioC1.Size = new System.Drawing.Size(54, 20);
            this.inputMultaPromedioC1.TabIndex = 3;
            // 
            // lblMultaPromedioC1
            // 
            this.lblMultaPromedioC1.AutoSize = true;
            this.lblMultaPromedioC1.Location = new System.Drawing.Point(10, 51);
            this.lblMultaPromedioC1.Name = "lblMultaPromedioC1";
            this.lblMultaPromedioC1.Size = new System.Drawing.Size(79, 13);
            this.lblMultaPromedioC1.TabIndex = 2;
            this.lblMultaPromedioC1.Text = "Multa promedio";
            // 
            // inputTotalC1
            // 
            this.inputTotalC1.Location = new System.Drawing.Point(158, 22);
            this.inputTotalC1.Name = "inputTotalC1";
            this.inputTotalC1.ReadOnly = true;
            this.inputTotalC1.Size = new System.Drawing.Size(54, 20);
            this.inputTotalC1.TabIndex = 1;
            // 
            // lblTotalInfraccionesC1
            // 
            this.lblTotalInfraccionesC1.AutoSize = true;
            this.lblTotalInfraccionesC1.Location = new System.Drawing.Point(9, 25);
            this.lblTotalInfraccionesC1.Name = "lblTotalInfraccionesC1";
            this.lblTotalInfraccionesC1.Size = new System.Drawing.Size(91, 13);
            this.lblTotalInfraccionesC1.TabIndex = 0;
            this.lblTotalInfraccionesC1.Text = "Total infracciones";
            // 
            // groupCuadrante2
            // 
            this.groupCuadrante2.Controls.Add(this.inputTotalMultasC2);
            this.groupCuadrante2.Controls.Add(this.lblTotalC2);
            this.groupCuadrante2.Controls.Add(this.inputMultaPromedioC2);
            this.groupCuadrante2.Controls.Add(this.lblMultaPromedioC2);
            this.groupCuadrante2.Controls.Add(this.inputTotalC2);
            this.groupCuadrante2.Controls.Add(this.lblTotalInfraccionesC2);
            this.groupCuadrante2.Location = new System.Drawing.Point(282, 208);
            this.groupCuadrante2.Name = "groupCuadrante2";
            this.groupCuadrante2.Size = new System.Drawing.Size(218, 107);
            this.groupCuadrante2.TabIndex = 6;
            this.groupCuadrante2.TabStop = false;
            this.groupCuadrante2.Text = "Cuadrante 2";
            // 
            // inputTotalMultasC2
            // 
            this.inputTotalMultasC2.Location = new System.Drawing.Point(158, 74);
            this.inputTotalMultasC2.Name = "inputTotalMultasC2";
            this.inputTotalMultasC2.ReadOnly = true;
            this.inputTotalMultasC2.Size = new System.Drawing.Size(54, 20);
            this.inputTotalMultasC2.TabIndex = 5;
            // 
            // lblTotalC2
            // 
            this.lblTotalC2.AutoSize = true;
            this.lblTotalC2.Location = new System.Drawing.Point(10, 77);
            this.lblTotalC2.Name = "lblTotalC2";
            this.lblTotalC2.Size = new System.Drawing.Size(64, 13);
            this.lblTotalC2.TabIndex = 4;
            this.lblTotalC2.Text = "Total multas";
            // 
            // inputMultaPromedioC2
            // 
            this.inputMultaPromedioC2.Location = new System.Drawing.Point(158, 48);
            this.inputMultaPromedioC2.Name = "inputMultaPromedioC2";
            this.inputMultaPromedioC2.ReadOnly = true;
            this.inputMultaPromedioC2.Size = new System.Drawing.Size(54, 20);
            this.inputMultaPromedioC2.TabIndex = 3;
            // 
            // lblMultaPromedioC2
            // 
            this.lblMultaPromedioC2.AutoSize = true;
            this.lblMultaPromedioC2.Location = new System.Drawing.Point(10, 51);
            this.lblMultaPromedioC2.Name = "lblMultaPromedioC2";
            this.lblMultaPromedioC2.Size = new System.Drawing.Size(79, 13);
            this.lblMultaPromedioC2.TabIndex = 2;
            this.lblMultaPromedioC2.Text = "Multa promedio";
            // 
            // inputTotalC2
            // 
            this.inputTotalC2.Location = new System.Drawing.Point(158, 22);
            this.inputTotalC2.Name = "inputTotalC2";
            this.inputTotalC2.ReadOnly = true;
            this.inputTotalC2.Size = new System.Drawing.Size(54, 20);
            this.inputTotalC2.TabIndex = 1;
            // 
            // lblTotalInfraccionesC2
            // 
            this.lblTotalInfraccionesC2.AutoSize = true;
            this.lblTotalInfraccionesC2.Location = new System.Drawing.Point(9, 25);
            this.lblTotalInfraccionesC2.Name = "lblTotalInfraccionesC2";
            this.lblTotalInfraccionesC2.Size = new System.Drawing.Size(91, 13);
            this.lblTotalInfraccionesC2.TabIndex = 0;
            this.lblTotalInfraccionesC2.Text = "Total infracciones";
            // 
            // groupCuadrante4
            // 
            this.groupCuadrante4.Controls.Add(this.textBox3);
            this.groupCuadrante4.Controls.Add(this.inputTotalMultasC4);
            this.groupCuadrante4.Controls.Add(this.lblTotalC4);
            this.groupCuadrante4.Controls.Add(this.textBox2);
            this.groupCuadrante4.Controls.Add(this.inputMultaPromedioC4);
            this.groupCuadrante4.Controls.Add(this.lblMultaPromedioC4);
            this.groupCuadrante4.Controls.Add(this.textBox1);
            this.groupCuadrante4.Controls.Add(this.inputTotalC4);
            this.groupCuadrante4.Controls.Add(this.lblTotalInfraccionesC4);
            this.groupCuadrante4.Location = new System.Drawing.Point(282, 331);
            this.groupCuadrante4.Name = "groupCuadrante4";
            this.groupCuadrante4.Size = new System.Drawing.Size(218, 107);
            this.groupCuadrante4.TabIndex = 8;
            this.groupCuadrante4.TabStop = false;
            this.groupCuadrante4.Text = "Cuadrante 4";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(-90, -77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 20);
            this.textBox3.TabIndex = 5;
            // 
            // inputTotalMultasC4
            // 
            this.inputTotalMultasC4.Location = new System.Drawing.Point(158, 74);
            this.inputTotalMultasC4.Name = "inputTotalMultasC4";
            this.inputTotalMultasC4.ReadOnly = true;
            this.inputTotalMultasC4.Size = new System.Drawing.Size(54, 20);
            this.inputTotalMultasC4.TabIndex = 5;
            // 
            // lblTotalC4
            // 
            this.lblTotalC4.AutoSize = true;
            this.lblTotalC4.Location = new System.Drawing.Point(10, 77);
            this.lblTotalC4.Name = "lblTotalC4";
            this.lblTotalC4.Size = new System.Drawing.Size(64, 13);
            this.lblTotalC4.TabIndex = 4;
            this.lblTotalC4.Text = "Total multas";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-90, -103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 20);
            this.textBox2.TabIndex = 3;
            // 
            // inputMultaPromedioC4
            // 
            this.inputMultaPromedioC4.Location = new System.Drawing.Point(158, 48);
            this.inputMultaPromedioC4.Name = "inputMultaPromedioC4";
            this.inputMultaPromedioC4.ReadOnly = true;
            this.inputMultaPromedioC4.Size = new System.Drawing.Size(54, 20);
            this.inputMultaPromedioC4.TabIndex = 3;
            // 
            // lblMultaPromedioC4
            // 
            this.lblMultaPromedioC4.AutoSize = true;
            this.lblMultaPromedioC4.Location = new System.Drawing.Point(10, 51);
            this.lblMultaPromedioC4.Name = "lblMultaPromedioC4";
            this.lblMultaPromedioC4.Size = new System.Drawing.Size(79, 13);
            this.lblMultaPromedioC4.TabIndex = 2;
            this.lblMultaPromedioC4.Text = "Multa promedio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-90, -129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 1;
            // 
            // inputTotalC4
            // 
            this.inputTotalC4.Location = new System.Drawing.Point(158, 22);
            this.inputTotalC4.Name = "inputTotalC4";
            this.inputTotalC4.ReadOnly = true;
            this.inputTotalC4.Size = new System.Drawing.Size(54, 20);
            this.inputTotalC4.TabIndex = 1;
            // 
            // lblTotalInfraccionesC4
            // 
            this.lblTotalInfraccionesC4.AutoSize = true;
            this.lblTotalInfraccionesC4.Location = new System.Drawing.Point(9, 25);
            this.lblTotalInfraccionesC4.Name = "lblTotalInfraccionesC4";
            this.lblTotalInfraccionesC4.Size = new System.Drawing.Size(91, 13);
            this.lblTotalInfraccionesC4.TabIndex = 0;
            this.lblTotalInfraccionesC4.Text = "Total infracciones";
            // 
            // groupCuadrante3
            // 
            this.groupCuadrante3.Controls.Add(this.inputTotalMultasC3);
            this.groupCuadrante3.Controls.Add(this.lblTotalC3);
            this.groupCuadrante3.Controls.Add(this.inputMultaPromedioC3);
            this.groupCuadrante3.Controls.Add(this.lblMultaPromedioC3);
            this.groupCuadrante3.Controls.Add(this.inputTotalC3);
            this.groupCuadrante3.Controls.Add(this.lblTotalInfraccionesC3);
            this.groupCuadrante3.Location = new System.Drawing.Point(40, 331);
            this.groupCuadrante3.Name = "groupCuadrante3";
            this.groupCuadrante3.Size = new System.Drawing.Size(218, 107);
            this.groupCuadrante3.TabIndex = 7;
            this.groupCuadrante3.TabStop = false;
            this.groupCuadrante3.Text = "Cuadrante 3";
            // 
            // inputTotalMultasC3
            // 
            this.inputTotalMultasC3.Location = new System.Drawing.Point(158, 74);
            this.inputTotalMultasC3.Name = "inputTotalMultasC3";
            this.inputTotalMultasC3.ReadOnly = true;
            this.inputTotalMultasC3.Size = new System.Drawing.Size(54, 20);
            this.inputTotalMultasC3.TabIndex = 5;
            // 
            // lblTotalC3
            // 
            this.lblTotalC3.AutoSize = true;
            this.lblTotalC3.Location = new System.Drawing.Point(10, 77);
            this.lblTotalC3.Name = "lblTotalC3";
            this.lblTotalC3.Size = new System.Drawing.Size(64, 13);
            this.lblTotalC3.TabIndex = 4;
            this.lblTotalC3.Text = "Total multas";
            // 
            // inputMultaPromedioC3
            // 
            this.inputMultaPromedioC3.Location = new System.Drawing.Point(158, 48);
            this.inputMultaPromedioC3.Name = "inputMultaPromedioC3";
            this.inputMultaPromedioC3.ReadOnly = true;
            this.inputMultaPromedioC3.Size = new System.Drawing.Size(54, 20);
            this.inputMultaPromedioC3.TabIndex = 3;
            // 
            // lblMultaPromedioC3
            // 
            this.lblMultaPromedioC3.AutoSize = true;
            this.lblMultaPromedioC3.Location = new System.Drawing.Point(10, 51);
            this.lblMultaPromedioC3.Name = "lblMultaPromedioC3";
            this.lblMultaPromedioC3.Size = new System.Drawing.Size(79, 13);
            this.lblMultaPromedioC3.TabIndex = 2;
            this.lblMultaPromedioC3.Text = "Multa promedio";
            // 
            // inputTotalC3
            // 
            this.inputTotalC3.Location = new System.Drawing.Point(158, 22);
            this.inputTotalC3.Name = "inputTotalC3";
            this.inputTotalC3.ReadOnly = true;
            this.inputTotalC3.Size = new System.Drawing.Size(54, 20);
            this.inputTotalC3.TabIndex = 1;
            // 
            // lblTotalInfraccionesC3
            // 
            this.lblTotalInfraccionesC3.AutoSize = true;
            this.lblTotalInfraccionesC3.Location = new System.Drawing.Point(9, 25);
            this.lblTotalInfraccionesC3.Name = "lblTotalInfraccionesC3";
            this.lblTotalInfraccionesC3.Size = new System.Drawing.Size(91, 13);
            this.lblTotalInfraccionesC3.TabIndex = 0;
            this.lblTotalInfraccionesC3.Text = "Total infracciones";
            // 
            // colPlaca
            // 
            this.colPlaca.HeaderText = "Placa vehículo";
            this.colPlaca.Name = "colPlaca";
            this.colPlaca.ReadOnly = true;
            // 
            // colVelocidad
            // 
            this.colVelocidad.HeaderText = "Velocidad";
            this.colVelocidad.Name = "colVelocidad";
            this.colVelocidad.ReadOnly = true;
            // 
            // colMulta
            // 
            this.colMulta.HeaderText = "Multa";
            this.colMulta.Name = "colMulta";
            this.colMulta.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupCuadrante4);
            this.Controls.Add(this.groupCuadrante2);
            this.Controls.Add(this.groupCuadrante3);
            this.Controls.Add(this.groupCuadrante1);
            this.Controls.Add(this.groupConsultarMultas);
            this.Controls.Add(this.groupRegistrarComparendo);
            this.Name = "Form1";
            this.Text = "Sistema de registro de multas";
            this.groupRegistrarComparendo.ResumeLayout(false);
            this.groupRegistrarComparendo.PerformLayout();
            this.groupConsultarMultas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaDeMultas)).EndInit();
            this.groupCuadrante1.ResumeLayout(false);
            this.groupCuadrante1.PerformLayout();
            this.groupCuadrante2.ResumeLayout(false);
            this.groupCuadrante2.PerformLayout();
            this.groupCuadrante4.ResumeLayout(false);
            this.groupCuadrante4.PerformLayout();
            this.groupCuadrante3.ResumeLayout(false);
            this.groupCuadrante3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupRegistrarComparendo;
        private System.Windows.Forms.GroupBox groupConsultarMultas;
        private System.Windows.Forms.GroupBox groupCuadrante1;
        private System.Windows.Forms.ComboBox selSeleccionarCuadrante;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblSelecionarCuadrante;
        private System.Windows.Forms.TextBox inputPlaca;
        private System.Windows.Forms.TextBox inputVelocidad;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Label lblMultaValor;
        private System.Windows.Forms.Label lblMultaEstablecida;
        private System.Windows.Forms.DataGridView dataListaDeMultas;
        private System.Windows.Forms.Label lblTotalInfraccionesC1;
        private System.Windows.Forms.Label lblMultaPromedioC1;
        private System.Windows.Forms.TextBox inputTotalC1;
        private System.Windows.Forms.TextBox inputTotalMultasC1;
        private System.Windows.Forms.Label lblTotalC1;
        private System.Windows.Forms.TextBox inputMultaPromedioC1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupCuadrante2;
        private System.Windows.Forms.TextBox inputTotalMultasC2;
        private System.Windows.Forms.Label lblTotalC2;
        private System.Windows.Forms.TextBox inputMultaPromedioC2;
        private System.Windows.Forms.Label lblMultaPromedioC2;
        private System.Windows.Forms.TextBox inputTotalC2;
        private System.Windows.Forms.Label lblTotalInfraccionesC2;
        private System.Windows.Forms.GroupBox groupCuadrante4;
        private System.Windows.Forms.TextBox inputTotalMultasC4;
        private System.Windows.Forms.Label lblTotalC4;
        private System.Windows.Forms.TextBox inputMultaPromedioC4;
        private System.Windows.Forms.Label lblMultaPromedioC4;
        private System.Windows.Forms.TextBox inputTotalC4;
        private System.Windows.Forms.Label lblTotalInfraccionesC4;
        private System.Windows.Forms.GroupBox groupCuadrante3;
        private System.Windows.Forms.TextBox inputTotalMultasC3;
        private System.Windows.Forms.Label lblTotalC3;
        private System.Windows.Forms.TextBox inputMultaPromedioC3;
        private System.Windows.Forms.Label lblMultaPromedioC3;
        private System.Windows.Forms.TextBox inputTotalC3;
        private System.Windows.Forms.Label lblTotalInfraccionesC3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVelocidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMulta;
    }
}

