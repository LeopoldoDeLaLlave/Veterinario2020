﻿namespace Veterinario2020
{
    partial class FormAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrador));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNMaascota = new System.Windows.Forms.Button();
            this.textBoxnmascota = new System.Windows.Forms.TextBox();
            this.textBoxchip = new System.Windows.Forms.TextBox();
            this.buttonChip = new System.Windows.Forms.Button();
            this.dgTodasMascotas = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNombre = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxdni = new System.Windows.Forms.TextBox();
            this.buttonbdni = new System.Windows.Forms.Button();
            this.dgTodosUsuarios = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxMotivo = new System.Windows.Forms.ComboBox();
            this.comboBoxHoras = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCitas = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTodasMascotas)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTodosUsuarios)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "citas.ico");
            this.imageList1.Images.SetKeyName(1, "huella.ico");
            this.imageList1.Images.SetKeyName(2, "user.ico");
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.buttonNMaascota);
            this.tabPage2.Controls.Add(this.textBoxnmascota);
            this.tabPage2.Controls.Add(this.textBoxchip);
            this.tabPage2.Controls.Add(this.buttonChip);
            this.tabPage2.Controls.Add(this.dgTodasMascotas);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1189, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mascotas";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1186, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buscar Mascotas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNMaascota
            // 
            this.buttonNMaascota.Location = new System.Drawing.Point(689, 134);
            this.buttonNMaascota.Name = "buttonNMaascota";
            this.buttonNMaascota.Size = new System.Drawing.Size(118, 23);
            this.buttonNMaascota.TabIndex = 13;
            this.buttonNMaascota.Text = "Buscar Nombre";
            this.buttonNMaascota.UseVisualStyleBackColor = true;
            this.buttonNMaascota.Click += new System.EventHandler(this.buttonNMaascota_Click);
            // 
            // textBoxnmascota
            // 
            this.textBoxnmascota.Location = new System.Drawing.Point(391, 134);
            this.textBoxnmascota.Name = "textBoxnmascota";
            this.textBoxnmascota.Size = new System.Drawing.Size(223, 22);
            this.textBoxnmascota.TabIndex = 12;
            // 
            // textBoxchip
            // 
            this.textBoxchip.Location = new System.Drawing.Point(391, 189);
            this.textBoxchip.Name = "textBoxchip";
            this.textBoxchip.Size = new System.Drawing.Size(223, 22);
            this.textBoxchip.TabIndex = 10;
            // 
            // buttonChip
            // 
            this.buttonChip.Location = new System.Drawing.Point(689, 189);
            this.buttonChip.Name = "buttonChip";
            this.buttonChip.Size = new System.Drawing.Size(118, 23);
            this.buttonChip.TabIndex = 11;
            this.buttonChip.Text = "Buscar Chip";
            this.buttonChip.UseVisualStyleBackColor = true;
            this.buttonChip.Click += new System.EventHandler(this.buttonChip_Click);
            // 
            // dataGridView2
            // 
            this.dgTodasMascotas.AllowUserToAddRows = false;
            this.dgTodasMascotas.AllowUserToDeleteRows = false;
            this.dgTodasMascotas.AllowUserToResizeColumns = false;
            this.dgTodasMascotas.AllowUserToResizeRows = false;
            this.dgTodasMascotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgTodasMascotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTodasMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTodasMascotas.Location = new System.Drawing.Point(224, 258);
            this.dgTodasMascotas.Name = "dataGridView2";
            this.dgTodasMascotas.ReadOnly = true;
            this.dgTodasMascotas.RowHeadersWidth = 51;
            this.dgTodasMascotas.RowTemplate.Height = 24;
            this.dgTodasMascotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgTodasMascotas.ShowCellErrors = false;
            this.dgTodasMascotas.ShowCellToolTips = false;
            this.dgTodasMascotas.ShowEditingIcon = false;
            this.dgTodasMascotas.ShowRowErrors = false;
            this.dgTodasMascotas.Size = new System.Drawing.Size(770, 231);
            this.dgTodasMascotas.TabIndex = 9;
            this.dgTodasMascotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPage1.Controls.Add(this.buttonAddUser);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonNombre);
            this.tabPage1.Controls.Add(this.textBoxNombre);
            this.tabPage1.Controls.Add(this.textBoxdni);
            this.tabPage1.Controls.Add(this.buttonbdni);
            this.tabPage1.Controls.Add(this.dgTodosUsuarios);
            this.tabPage1.ImageIndex = 2;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1189, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(36, 480);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(180, 38);
            this.buttonAddUser.TabIndex = 9;
            this.buttonAddUser.Text = "Añadir Usuario";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1186, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar Usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNombre
            // 
            this.buttonNombre.Location = new System.Drawing.Point(688, 134);
            this.buttonNombre.Name = "buttonNombre";
            this.buttonNombre.Size = new System.Drawing.Size(118, 23);
            this.buttonNombre.TabIndex = 7;
            this.buttonNombre.Text = "Buscar Nombre";
            this.buttonNombre.UseVisualStyleBackColor = true;
            this.buttonNombre.Click += new System.EventHandler(this.buttonNombre_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(390, 134);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(223, 22);
            this.textBoxNombre.TabIndex = 6;
            // 
            // textBoxdni
            // 
            this.textBoxdni.Location = new System.Drawing.Point(390, 189);
            this.textBoxdni.Name = "textBoxdni";
            this.textBoxdni.Size = new System.Drawing.Size(223, 22);
            this.textBoxdni.TabIndex = 4;
            // 
            // buttonbdni
            // 
            this.buttonbdni.Location = new System.Drawing.Point(688, 189);
            this.buttonbdni.Name = "buttonbdni";
            this.buttonbdni.Size = new System.Drawing.Size(118, 23);
            this.buttonbdni.TabIndex = 5;
            this.buttonbdni.Text = "Buscar DNI\r\n";
            this.buttonbdni.UseVisualStyleBackColor = true;
            this.buttonbdni.Click += new System.EventHandler(this.buttonbdni_Click);
            // 
            // dataGridView1
            // 
            this.dgTodosUsuarios.AllowUserToAddRows = false;
            this.dgTodosUsuarios.AllowUserToDeleteRows = false;
            this.dgTodosUsuarios.AllowUserToResizeColumns = false;
            this.dgTodosUsuarios.AllowUserToResizeRows = false;
            this.dgTodosUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgTodosUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTodosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTodosUsuarios.Location = new System.Drawing.Point(197, 249);
            this.dgTodosUsuarios.Name = "dataGridView1";
            this.dgTodosUsuarios.ReadOnly = true;
            this.dgTodosUsuarios.RowHeadersWidth = 51;
            this.dgTodosUsuarios.RowTemplate.Height = 24;
            this.dgTodosUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgTodosUsuarios.ShowCellErrors = false;
            this.dgTodosUsuarios.ShowCellToolTips = false;
            this.dgTodosUsuarios.ShowEditingIcon = false;
            this.dgTodosUsuarios.ShowRowErrors = false;
            this.dgTodosUsuarios.Size = new System.Drawing.Size(768, 202);
            this.dgTodosUsuarios.TabIndex = 3;
            this.dgTodosUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1197, 588);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPage3.Controls.Add(this.comboBoxMotivo);
            this.tabPage3.Controls.Add(this.comboBoxHoras);
            this.tabPage3.Controls.Add(this.dateTimePickerCitas);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.ImageIndex = 0;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1189, 545);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Citas";
            // 
            // comboBoxMotivo
            // 
            this.comboBoxMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMotivo.FormattingEnabled = true;
            this.comboBoxMotivo.Items.AddRange(new object[] {
            "Revisión",
            "Vacuna",
            "Peluquería",
            "Otros"});
            this.comboBoxMotivo.Location = new System.Drawing.Point(986, 248);
            this.comboBoxMotivo.Name = "comboBoxMotivo";
            this.comboBoxMotivo.Size = new System.Drawing.Size(146, 24);
            this.comboBoxMotivo.TabIndex = 46;
            // 
            // comboBoxHoras
            // 
            this.comboBoxHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHoras.FormattingEnabled = true;
            this.comboBoxHoras.Items.AddRange(new object[] {
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00"});
            this.comboBoxHoras.Location = new System.Drawing.Point(587, 250);
            this.comboBoxHoras.Name = "comboBoxHoras";
            this.comboBoxHoras.Size = new System.Drawing.Size(154, 24);
            this.comboBoxHoras.TabIndex = 45;
            // 
            // dateTimePickerCitas
            // 
            this.dateTimePickerCitas.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerCitas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCitas.Location = new System.Drawing.Point(176, 250);
            this.dateTimePickerCitas.MaxDate = new System.DateTime(2020, 4, 13, 0, 0, 0, 0);
            this.dateTimePickerCitas.Name = "dateTimePickerCitas";
            this.dateTimePickerCitas.Size = new System.Drawing.Size(177, 22);
            this.dateTimePickerCitas.TabIndex = 44;
            this.dateTimePickerCitas.Value = new System.DateTime(2020, 4, 13, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(953, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1181, 39);
            this.label6.TabIndex = 4;
            this.label6.Text = "Crear cita";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hora:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(881, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Motivo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Día:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1197, 588);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formAdministrador_FormClosing);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTodasMascotas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTodosUsuarios)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNMaascota;
        private System.Windows.Forms.TextBox textBoxnmascota;
        private System.Windows.Forms.TextBox textBoxchip;
        private System.Windows.Forms.Button buttonChip;
        private System.Windows.Forms.DataGridView dgTodasMascotas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxdni;
        private System.Windows.Forms.Button buttonbdni;
        private System.Windows.Forms.DataGridView dgTodosUsuarios;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerCitas;
        private System.Windows.Forms.ComboBox comboBoxMotivo;
        private System.Windows.Forms.ComboBox comboBoxHoras;
    }
}