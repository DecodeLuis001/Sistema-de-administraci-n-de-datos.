namespace CapaPresentacion.Ajustes
{
    partial class FrmUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.tsUsuarios = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripRegresar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.iDUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProyecto = new CapaPresentacion.DsProyecto();
            this.gbBusquedas = new System.Windows.Forms.GroupBox();
            this.txtBMaterno = new System.Windows.Forms.TextBox();
            this.txtBPaterno = new System.Windows.Forms.TextBox();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtDConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDContraseña = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDPaterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usuariosTableAdapter = new CapaPresentacion.DsProyectoTableAdapters.UsuariosTableAdapter();
            this.tsUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProyecto)).BeginInit();
            this.gbBusquedas.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsUsuarios
            // 
            this.tsUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripAgregar,
            this.toolStripSeparator2,
            this.toolStripModificar,
            this.toolStripSeparator3,
            this.toolStripBorrar,
            this.toolStripSeparator4,
            this.toolStripGuardar,
            this.toolStripSeparator5,
            this.toolStripRegresar,
            this.toolStripSeparator6,
            this.toolStripCancelar});
            this.tsUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tsUsuarios.Name = "tsUsuarios";
            this.tsUsuarios.Size = new System.Drawing.Size(684, 38);
            this.tsUsuarios.TabIndex = 0;
            this.tsUsuarios.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripAgregar
            // 
            this.toolStripAgregar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAgregar.Image")));
            this.toolStripAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAgregar.Name = "toolStripAgregar";
            this.toolStripAgregar.Size = new System.Drawing.Size(53, 35);
            this.toolStripAgregar.Text = "&Agregar";
            this.toolStripAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripAgregar.Click += new System.EventHandler(this.toolStripAgregar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripModificar
            // 
            this.toolStripModificar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripModificar.Image")));
            this.toolStripModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripModificar.Name = "toolStripModificar";
            this.toolStripModificar.Size = new System.Drawing.Size(62, 35);
            this.toolStripModificar.Text = "&Modificar";
            this.toolStripModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripModificar.Click += new System.EventHandler(this.toolStripModificar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripBorrar
            // 
            this.toolStripBorrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBorrar.Image")));
            this.toolStripBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBorrar.Name = "toolStripBorrar";
            this.toolStripBorrar.Size = new System.Drawing.Size(43, 35);
            this.toolStripBorrar.Text = "&Borrar";
            this.toolStripBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripBorrar.Click += new System.EventHandler(this.toolStripBorrar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripGuardar
            // 
            this.toolStripGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGuardar.Image")));
            this.toolStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGuardar.Name = "toolStripGuardar";
            this.toolStripGuardar.Size = new System.Drawing.Size(53, 35);
            this.toolStripGuardar.Text = "&Guardar";
            this.toolStripGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripGuardar.Click += new System.EventHandler(this.toolStripGuardar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripRegresar
            // 
            this.toolStripRegresar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRegresar.Image")));
            this.toolStripRegresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRegresar.Name = "toolStripRegresar";
            this.toolStripRegresar.Size = new System.Drawing.Size(56, 35);
            this.toolStripRegresar.Text = "&Regresar";
            this.toolStripRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripRegresar.Click += new System.EventHandler(this.toolStripRegresar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripCancelar
            // 
            this.toolStripCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCancelar.Image")));
            this.toolStripCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancelar.Name = "toolStripCancelar";
            this.toolStripCancelar.Size = new System.Drawing.Size(57, 35);
            this.toolStripCancelar.Text = "&Cancelar";
            this.toolStripCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripCancelar.Click += new System.EventHandler(this.toolStripCancelar_Click);
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.AutoGenerateColumns = false;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUsuarioDataGridViewTextBoxColumn,
            this.iDTipoUsuarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoPaternoDataGridViewTextBoxColumn,
            this.apellidoMaternoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.dgUsuarios.DataSource = this.usuariosBindingSource;
            this.dgUsuarios.Location = new System.Drawing.Point(0, 41);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.Size = new System.Drawing.Size(656, 150);
            this.dgUsuarios.TabIndex = 1;
            // 
            // iDUsuarioDataGridViewTextBoxColumn
            // 
            this.iDUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IDUsuario";
            this.iDUsuarioDataGridViewTextBoxColumn.HeaderText = "IDUsuario";
            this.iDUsuarioDataGridViewTextBoxColumn.Name = "iDUsuarioDataGridViewTextBoxColumn";
            this.iDUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDTipoUsuarioDataGridViewTextBoxColumn
            // 
            this.iDTipoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IDTipoUsuario";
            this.iDTipoUsuarioDataGridViewTextBoxColumn.HeaderText = "IDTipoUsuario";
            this.iDTipoUsuarioDataGridViewTextBoxColumn.Name = "iDTipoUsuarioDataGridViewTextBoxColumn";
            this.iDTipoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTipoUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoPaternoDataGridViewTextBoxColumn
            // 
            this.apellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.Name = "apellidoPaternoDataGridViewTextBoxColumn";
            this.apellidoPaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoMaternoDataGridViewTextBoxColumn
            // 
            this.apellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn.Name = "apellidoMaternoDataGridViewTextBoxColumn";
            this.apellidoMaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            this.contraseñaDataGridViewTextBoxColumn.ReadOnly = true;
            this.contraseñaDataGridViewTextBoxColumn.Visible = false;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.dsProyecto;
            // 
            // dsProyecto
            // 
            this.dsProyecto.DataSetName = "DsProyecto";
            this.dsProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbBusquedas
            // 
            this.gbBusquedas.Controls.Add(this.txtBMaterno);
            this.gbBusquedas.Controls.Add(this.txtBPaterno);
            this.gbBusquedas.Controls.Add(this.txtBNombre);
            this.gbBusquedas.Controls.Add(this.label3);
            this.gbBusquedas.Controls.Add(this.label2);
            this.gbBusquedas.Controls.Add(this.label1);
            this.gbBusquedas.Location = new System.Drawing.Point(12, 197);
            this.gbBusquedas.Name = "gbBusquedas";
            this.gbBusquedas.Size = new System.Drawing.Size(198, 220);
            this.gbBusquedas.TabIndex = 2;
            this.gbBusquedas.TabStop = false;
            this.gbBusquedas.Text = "Búsquedas";
            // 
            // txtBMaterno
            // 
            this.txtBMaterno.Location = new System.Drawing.Point(8, 177);
            this.txtBMaterno.Name = "txtBMaterno";
            this.txtBMaterno.Size = new System.Drawing.Size(182, 29);
            this.txtBMaterno.TabIndex = 8;
            this.txtBMaterno.TextChanged += new System.EventHandler(this.txtBMaterno_TextChanged);
            // 
            // txtBPaterno
            // 
            this.txtBPaterno.Location = new System.Drawing.Point(10, 112);
            this.txtBPaterno.Name = "txtBPaterno";
            this.txtBPaterno.Size = new System.Drawing.Size(182, 29);
            this.txtBPaterno.TabIndex = 7;
            this.txtBPaterno.TextChanged += new System.EventHandler(this.txtBPaterno_TextChanged);
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(10, 51);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(182, 29);
            this.txtBNombre.TabIndex = 6;
            this.txtBNombre.TextChanged += new System.EventHandler(this.txtBNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtDConfirmarContraseña);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.txtDContraseña);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.txtDUsuario);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.txtDPaterno);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.txtDMaterno);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.txtDNombre);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Location = new System.Drawing.Point(231, 197);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(425, 252);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos de Usuario";
            this.gbDatos.Enter += new System.EventHandler(this.gbDatos_Enter);
            // 
            // txtDConfirmarContraseña
            // 
            this.txtDConfirmarContraseña.Location = new System.Drawing.Point(145, 212);
            this.txtDConfirmarContraseña.Name = "txtDConfirmarContraseña";
            this.txtDConfirmarContraseña.Size = new System.Drawing.Size(274, 29);
            this.txtDConfirmarContraseña.TabIndex = 18;
            this.txtDConfirmarContraseña.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Confirmar Contraseña";
            // 
            // txtDContraseña
            // 
            this.txtDContraseña.Location = new System.Drawing.Point(98, 174);
            this.txtDContraseña.Name = "txtDContraseña";
            this.txtDContraseña.Size = new System.Drawing.Size(321, 29);
            this.txtDContraseña.TabIndex = 16;
            this.txtDContraseña.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Contraseña";
            // 
            // txtDUsuario
            // 
            this.txtDUsuario.Location = new System.Drawing.Point(98, 137);
            this.txtDUsuario.Name = "txtDUsuario";
            this.txtDUsuario.Size = new System.Drawing.Size(321, 29);
            this.txtDUsuario.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Usuario";
            // 
            // txtDPaterno
            // 
            this.txtDPaterno.Location = new System.Drawing.Point(98, 67);
            this.txtDPaterno.Name = "txtDPaterno";
            this.txtDPaterno.Size = new System.Drawing.Size(321, 29);
            this.txtDPaterno.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "A. Paterno";
            // 
            // txtDMaterno
            // 
            this.txtDMaterno.Location = new System.Drawing.Point(98, 102);
            this.txtDMaterno.Name = "txtDMaterno";
            this.txtDMaterno.Size = new System.Drawing.Size(321, 29);
            this.txtDMaterno.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "A. Materno";
            // 
            // txtDNombre
            // 
            this.txtDNombre.Location = new System.Drawing.Point(98, 32);
            this.txtDNombre.Name = "txtDNombre";
            this.txtDNombre.Size = new System.Drawing.Size(321, 29);
            this.txtDNombre.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre";
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbBusquedas);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.tsUsuarios);
            this.Font = new System.Drawing.Font("Perpetua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.tsUsuarios.ResumeLayout(false);
            this.tsUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProyecto)).EndInit();
            this.gbBusquedas.ResumeLayout(false);
            this.gbBusquedas.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsUsuarios;
        private System.Windows.Forms.ToolStripButton toolStripAgregar;
        private System.Windows.Forms.ToolStripButton toolStripModificar;
        private System.Windows.Forms.ToolStripButton toolStripBorrar;
        private System.Windows.Forms.ToolStripButton toolStripGuardar;
        private System.Windows.Forms.ToolStripButton toolStripRegresar;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private DsProyecto dsProyecto;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DsProyectoTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.GroupBox gbBusquedas;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtBMaterno;
        private System.Windows.Forms.TextBox txtBPaterno;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDPaterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDMaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDConfirmarContraseña;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDContraseña;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripCancelar;
    }
}