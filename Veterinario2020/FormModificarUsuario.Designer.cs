namespace Veterinario2020
{
    partial class FormModificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarUsuario));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonaddmascota = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBorrarUsuario = new System.Windows.Forms.Button();
            this.buttonCambios = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.textBoxdni = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Revisiones = new System.Windows.Forms.Label();
            this.dgOtrosLibres = new System.Windows.Forms.DataGridView();
            this.dgPeluqueriaLibre = new System.Windows.Forms.DataGridView();
            this.dgVacunasLibres = new System.Windows.Forms.DataGridView();
            this.dgRevisionesLibres = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.dgProximasCitas = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgHistorialCita = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOtrosLibres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeluqueriaLibre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVacunasLibres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRevisionesLibres)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProximasCitas)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorialCita)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1374, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPage1.Controls.Add(this.buttonaddmascota);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.buttonBorrarUsuario);
            this.tabPage1.Controls.Add(this.buttonCambios);
            this.tabPage1.Controls.Add(this.textBoxEmail);
            this.tabPage1.Controls.Add(this.textBoxDir);
            this.tabPage1.Controls.Add(this.textBoxdni);
            this.tabPage1.Controls.Add(this.textBoxTelefono);
            this.tabPage1.Controls.Add(this.textBoxApellido);
            this.tabPage1.Controls.Add(this.textBoxNombre);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1366, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            // 
            // buttonaddmascota
            // 
            this.buttonaddmascota.Location = new System.Drawing.Point(1071, 395);
            this.buttonaddmascota.Name = "buttonaddmascota";
            this.buttonaddmascota.Size = new System.Drawing.Size(195, 45);
            this.buttonaddmascota.TabIndex = 55;
            this.buttonaddmascota.Text = "Añadir mascota";
            this.buttonaddmascota.UseVisualStyleBackColor = true;
            this.buttonaddmascota.Click += new System.EventHandler(this.buttonaddmascota_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(987, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(351, 350);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(958, -40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 578);
            this.panel1.TabIndex = 53;
            // 
            // buttonBorrarUsuario
            // 
            this.buttonBorrarUsuario.Location = new System.Drawing.Point(32, 395);
            this.buttonBorrarUsuario.Name = "buttonBorrarUsuario";
            this.buttonBorrarUsuario.Size = new System.Drawing.Size(195, 45);
            this.buttonBorrarUsuario.TabIndex = 52;
            this.buttonBorrarUsuario.Text = "Eliminar usuario";
            this.buttonBorrarUsuario.UseVisualStyleBackColor = true;
            this.buttonBorrarUsuario.Click += new System.EventHandler(this.buttonBorrarUsuario_Click);
            // 
            // buttonCambios
            // 
            this.buttonCambios.Location = new System.Drawing.Point(722, 395);
            this.buttonCambios.Name = "buttonCambios";
            this.buttonCambios.Size = new System.Drawing.Size(195, 45);
            this.buttonCambios.TabIndex = 51;
            this.buttonCambios.Text = "Guardar Cambios";
            this.buttonCambios.UseVisualStyleBackColor = true;
            this.buttonCambios.Click += new System.EventHandler(this.buttonCambios_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(643, 281);
            this.textBoxEmail.MaxLength = 30;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(274, 22);
            this.textBoxEmail.TabIndex = 50;
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(172, 280);
            this.textBoxDir.MaxLength = 50;
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(344, 22);
            this.textBoxDir.TabIndex = 49;
            // 
            // textBoxdni
            // 
            this.textBoxdni.Location = new System.Drawing.Point(643, 160);
            this.textBoxdni.MaxLength = 20;
            this.textBoxdni.Name = "textBoxdni";
            this.textBoxdni.Size = new System.Drawing.Size(274, 22);
            this.textBoxdni.TabIndex = 48;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(172, 160);
            this.textBoxTelefono.MaxLength = 30;
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(250, 22);
            this.textBoxTelefono.TabIndex = 47;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(643, 67);
            this.textBoxApellido.MaxLength = 20;
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(274, 22);
            this.textBoxApellido.TabIndex = 46;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(148, 67);
            this.textBoxNombre.MaxLength = 20;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(274, 22);
            this.textBoxNombre.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(537, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 44;
            this.label6.Text = "Apellido:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(537, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Email:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.ImageKey = "citas.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1366, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Citas";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1366, 502);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.Revisiones);
            this.tabPage4.Controls.Add(this.dgOtrosLibres);
            this.tabPage4.Controls.Add(this.dgPeluqueriaLibre);
            this.tabPage4.Controls.Add(this.dgVacunasLibres);
            this.tabPage4.Controls.Add(this.dgRevisionesLibres);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1358, 473);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Citas disponibles";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(1064, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(296, 23);
            this.label12.TabIndex = 7;
            this.label12.Text = "Otros";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(683, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(296, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "Peluquería";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(341, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(296, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "Vacunas";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Revisiones
            // 
            this.Revisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Revisiones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Revisiones.Location = new System.Drawing.Point(0, 84);
            this.Revisiones.Name = "Revisiones";
            this.Revisiones.Size = new System.Drawing.Size(296, 23);
            this.Revisiones.TabIndex = 4;
            this.Revisiones.Text = "Revisiones";
            this.Revisiones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgOtrosLibres
            // 
            this.dgOtrosLibres.AllowUserToAddRows = false;
            this.dgOtrosLibres.AllowUserToDeleteRows = false;
            this.dgOtrosLibres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgOtrosLibres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOtrosLibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOtrosLibres.Location = new System.Drawing.Point(1064, 122);
            this.dgOtrosLibres.Name = "dgOtrosLibres";
            this.dgOtrosLibres.ReadOnly = true;
            this.dgOtrosLibres.RowHeadersWidth = 51;
            this.dgOtrosLibres.RowTemplate.Height = 24;
            this.dgOtrosLibres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgOtrosLibres.ShowCellErrors = false;
            this.dgOtrosLibres.ShowCellToolTips = false;
            this.dgOtrosLibres.ShowEditingIcon = false;
            this.dgOtrosLibres.ShowRowErrors = false;
            this.dgOtrosLibres.Size = new System.Drawing.Size(295, 351);
            this.dgOtrosLibres.TabIndex = 3;
            this.dgOtrosLibres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellClick);
            // 
            // dgPeluqueriaLibre
            // 
            this.dgPeluqueriaLibre.AllowUserToAddRows = false;
            this.dgPeluqueriaLibre.AllowUserToDeleteRows = false;
            this.dgPeluqueriaLibre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgPeluqueriaLibre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPeluqueriaLibre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeluqueriaLibre.Location = new System.Drawing.Point(684, 123);
            this.dgPeluqueriaLibre.Name = "dgPeluqueriaLibre";
            this.dgPeluqueriaLibre.ReadOnly = true;
            this.dgPeluqueriaLibre.RowHeadersWidth = 51;
            this.dgPeluqueriaLibre.RowTemplate.Height = 24;
            this.dgPeluqueriaLibre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgPeluqueriaLibre.ShowCellErrors = false;
            this.dgPeluqueriaLibre.ShowCellToolTips = false;
            this.dgPeluqueriaLibre.ShowEditingIcon = false;
            this.dgPeluqueriaLibre.ShowRowErrors = false;
            this.dgPeluqueriaLibre.Size = new System.Drawing.Size(295, 354);
            this.dgPeluqueriaLibre.TabIndex = 2;
            this.dgPeluqueriaLibre.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            // 
            // dgVacunasLibres
            // 
            this.dgVacunasLibres.AllowUserToAddRows = false;
            this.dgVacunasLibres.AllowUserToDeleteRows = false;
            this.dgVacunasLibres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgVacunasLibres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgVacunasLibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVacunasLibres.Location = new System.Drawing.Point(346, 123);
            this.dgVacunasLibres.Name = "dgVacunasLibres";
            this.dgVacunasLibres.ReadOnly = true;
            this.dgVacunasLibres.RowHeadersWidth = 51;
            this.dgVacunasLibres.RowTemplate.Height = 24;
            this.dgVacunasLibres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgVacunasLibres.ShowCellErrors = false;
            this.dgVacunasLibres.ShowCellToolTips = false;
            this.dgVacunasLibres.ShowEditingIcon = false;
            this.dgVacunasLibres.ShowRowErrors = false;
            this.dgVacunasLibres.Size = new System.Drawing.Size(295, 351);
            this.dgVacunasLibres.TabIndex = 1;
            this.dgVacunasLibres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // dgRevisionesLibres
            // 
            this.dgRevisionesLibres.AllowUserToAddRows = false;
            this.dgRevisionesLibres.AllowUserToDeleteRows = false;
            this.dgRevisionesLibres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgRevisionesLibres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgRevisionesLibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRevisionesLibres.Location = new System.Drawing.Point(0, 122);
            this.dgRevisionesLibres.Name = "dgRevisionesLibres";
            this.dgRevisionesLibres.ReadOnly = true;
            this.dgRevisionesLibres.RowHeadersWidth = 51;
            this.dgRevisionesLibres.RowTemplate.Height = 24;
            this.dgRevisionesLibres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgRevisionesLibres.ShowCellErrors = false;
            this.dgRevisionesLibres.ShowCellToolTips = false;
            this.dgRevisionesLibres.ShowEditingIcon = false;
            this.dgRevisionesLibres.ShowRowErrors = false;
            this.dgRevisionesLibres.Size = new System.Drawing.Size(295, 345);
            this.dgRevisionesLibres.TabIndex = 0;
            this.dgRevisionesLibres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.dgProximasCitas);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1358, 473);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Mis próximas citas";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1350, 52);
            this.label13.TabIndex = 3;
            this.label13.Text = "Próximas citas";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgProximasCitas
            // 
            this.dgProximasCitas.AllowUserToAddRows = false;
            this.dgProximasCitas.AllowUserToDeleteRows = false;
            this.dgProximasCitas.AllowUserToResizeColumns = false;
            this.dgProximasCitas.AllowUserToResizeRows = false;
            this.dgProximasCitas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgProximasCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProximasCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProximasCitas.Location = new System.Drawing.Point(308, 104);
            this.dgProximasCitas.Name = "dgProximasCitas";
            this.dgProximasCitas.ReadOnly = true;
            this.dgProximasCitas.RowHeadersWidth = 51;
            this.dgProximasCitas.RowTemplate.Height = 24;
            this.dgProximasCitas.ShowCellErrors = false;
            this.dgProximasCitas.ShowCellToolTips = false;
            this.dgProximasCitas.ShowEditingIcon = false;
            this.dgProximasCitas.ShowRowErrors = false;
            this.dgProximasCitas.Size = new System.Drawing.Size(754, 348);
            this.dgProximasCitas.TabIndex = 2;
            this.dgProximasCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPage3.Controls.Add(this.dgHistorialCita);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1358, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Historial";
            // 
            // dgHistorialCita
            // 
            this.dgHistorialCita.AllowUserToAddRows = false;
            this.dgHistorialCita.AllowUserToDeleteRows = false;
            this.dgHistorialCita.AllowUserToResizeColumns = false;
            this.dgHistorialCita.AllowUserToResizeRows = false;
            this.dgHistorialCita.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgHistorialCita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgHistorialCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorialCita.Location = new System.Drawing.Point(87, 62);
            this.dgHistorialCita.Name = "dgHistorialCita";
            this.dgHistorialCita.ReadOnly = true;
            this.dgHistorialCita.RowHeadersWidth = 51;
            this.dgHistorialCita.RowTemplate.Height = 24;
            this.dgHistorialCita.ShowCellErrors = false;
            this.dgHistorialCita.ShowCellToolTips = false;
            this.dgHistorialCita.ShowEditingIcon = false;
            this.dgHistorialCita.ShowRowErrors = false;
            this.dgHistorialCita.Size = new System.Drawing.Size(1168, 348);
            this.dgHistorialCita.TabIndex = 3;
            this.dgHistorialCita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView7_CellClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "citas.png");
            this.imageList1.Images.SetKeyName(1, "datos.ico");
            // 
            // FormModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1371, 531);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOtrosLibres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeluqueriaLibre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVacunasLibres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRevisionesLibres)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProximasCitas)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorialCita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonaddmascota;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBorrarUsuario;
        private System.Windows.Forms.Button buttonCambios;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.TextBox textBoxdni;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Revisiones;
        private System.Windows.Forms.DataGridView dgOtrosLibres;
        private System.Windows.Forms.DataGridView dgPeluqueriaLibre;
        private System.Windows.Forms.DataGridView dgVacunasLibres;
        private System.Windows.Forms.DataGridView dgRevisionesLibres;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgProximasCitas;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgHistorialCita;
    }
}