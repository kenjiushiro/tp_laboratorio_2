﻿namespace Forms
{
    partial class FrmPpal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxEstadoPaquetes = new System.Windows.Forms.GroupBox();
            this.grpBoxPaquete = new System.Windows.Forms.GroupBox();
            this.lblIngresado = new System.Windows.Forms.Label();
            this.listBoxIngresado = new System.Windows.Forms.ListBox();
            this.listBoxEnViaje = new System.Windows.Forms.ListBox();
            this.lblEnViaje = new System.Windows.Forms.Label();
            this.listBoxEntregado = new System.Windows.Forms.ListBox();
            this.lblEntregado = new System.Windows.Forms.Label();
            this.mtxtTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTrackingID = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.grpBoxEstadoPaquetes.SuspendLayout();
            this.grpBoxPaquete.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxEstadoPaquetes
            // 
            this.grpBoxEstadoPaquetes.Controls.Add(this.listBoxEntregado);
            this.grpBoxEstadoPaquetes.Controls.Add(this.lblEntregado);
            this.grpBoxEstadoPaquetes.Controls.Add(this.listBoxEnViaje);
            this.grpBoxEstadoPaquetes.Controls.Add(this.lblEnViaje);
            this.grpBoxEstadoPaquetes.Controls.Add(this.listBoxIngresado);
            this.grpBoxEstadoPaquetes.Controls.Add(this.lblIngresado);
            this.grpBoxEstadoPaquetes.Location = new System.Drawing.Point(13, 13);
            this.grpBoxEstadoPaquetes.Name = "grpBoxEstadoPaquetes";
            this.grpBoxEstadoPaquetes.Size = new System.Drawing.Size(733, 272);
            this.grpBoxEstadoPaquetes.TabIndex = 0;
            this.grpBoxEstadoPaquetes.TabStop = false;
            this.grpBoxEstadoPaquetes.Text = "Estado Paquetes";
            // 
            // grpBoxPaquete
            // 
            this.grpBoxPaquete.Controls.Add(this.btnMostrarTodos);
            this.grpBoxPaquete.Controls.Add(this.btnAgregar);
            this.grpBoxPaquete.Controls.Add(this.lblDireccion);
            this.grpBoxPaquete.Controls.Add(this.lblTrackingID);
            this.grpBoxPaquete.Controls.Add(this.txtDireccion);
            this.grpBoxPaquete.Controls.Add(this.mtxtTrackingID);
            this.grpBoxPaquete.Location = new System.Drawing.Point(452, 291);
            this.grpBoxPaquete.Name = "grpBoxPaquete";
            this.grpBoxPaquete.Size = new System.Drawing.Size(294, 140);
            this.grpBoxPaquete.TabIndex = 1;
            this.grpBoxPaquete.TabStop = false;
            this.grpBoxPaquete.Text = "Paquete";
            // 
            // lblIngresado
            // 
            this.lblIngresado.AutoSize = true;
            this.lblIngresado.Location = new System.Drawing.Point(7, 37);
            this.lblIngresado.Name = "lblIngresado";
            this.lblIngresado.Size = new System.Drawing.Size(54, 13);
            this.lblIngresado.TabIndex = 0;
            this.lblIngresado.Text = "Ingresado";
            // 
            // listBoxIngresado
            // 
            this.listBoxIngresado.FormattingEnabled = true;
            this.listBoxIngresado.Location = new System.Drawing.Point(10, 53);
            this.listBoxIngresado.Name = "listBoxIngresado";
            this.listBoxIngresado.Size = new System.Drawing.Size(212, 199);
            this.listBoxIngresado.TabIndex = 1;
            // 
            // listBoxEnViaje
            // 
            this.listBoxEnViaje.FormattingEnabled = true;
            this.listBoxEnViaje.Location = new System.Drawing.Point(265, 53);
            this.listBoxEnViaje.Name = "listBoxEnViaje";
            this.listBoxEnViaje.Size = new System.Drawing.Size(212, 199);
            this.listBoxEnViaje.TabIndex = 3;
            // 
            // lblEnViaje
            // 
            this.lblEnViaje.AutoSize = true;
            this.lblEnViaje.Location = new System.Drawing.Point(262, 37);
            this.lblEnViaje.Name = "lblEnViaje";
            this.lblEnViaje.Size = new System.Drawing.Size(45, 13);
            this.lblEnViaje.TabIndex = 2;
            this.lblEnViaje.Text = "En viaje";
            // 
            // listBoxEntregado
            // 
            this.listBoxEntregado.FormattingEnabled = true;
            this.listBoxEntregado.Location = new System.Drawing.Point(515, 53);
            this.listBoxEntregado.Name = "listBoxEntregado";
            this.listBoxEntregado.Size = new System.Drawing.Size(212, 199);
            this.listBoxEntregado.TabIndex = 5;
            // 
            // lblEntregado
            // 
            this.lblEntregado.AutoSize = true;
            this.lblEntregado.Location = new System.Drawing.Point(512, 37);
            this.lblEntregado.Name = "lblEntregado";
            this.lblEntregado.Size = new System.Drawing.Size(56, 13);
            this.lblEntregado.TabIndex = 4;
            this.lblEntregado.Text = "Entregado";
            // 
            // mtxtTrackingID
            // 
            this.mtxtTrackingID.Location = new System.Drawing.Point(18, 41);
            this.mtxtTrackingID.Name = "mtxtTrackingID";
            this.mtxtTrackingID.Size = new System.Drawing.Size(137, 20);
            this.mtxtTrackingID.TabIndex = 0;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(18, 105);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(137, 20);
            this.txtDireccion.TabIndex = 1;
            // 
            // lblTrackingID
            // 
            this.lblTrackingID.AutoSize = true;
            this.lblTrackingID.Location = new System.Drawing.Point(15, 25);
            this.lblTrackingID.Name = "lblTrackingID";
            this.lblTrackingID.Size = new System.Drawing.Size(63, 13);
            this.lblTrackingID.TabIndex = 6;
            this.lblTrackingID.Text = "Tracking ID";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(15, 89);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Direccion";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(180, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 35);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(180, 89);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(97, 35);
            this.btnMostrarTodos.TabIndex = 9;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(13, 292);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(433, 139);
            this.rtbMostrar.TabIndex = 2;
            this.rtbMostrar.Text = "";
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 443);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.grpBoxPaquete);
            this.Controls.Add(this.grpBoxEstadoPaquetes);
            this.Name = "FrmPpal";
            this.Text = "Correo UTN por Kenji.Ushiro.2C";
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            this.grpBoxEstadoPaquetes.ResumeLayout(false);
            this.grpBoxEstadoPaquetes.PerformLayout();
            this.grpBoxPaquete.ResumeLayout(false);
            this.grpBoxPaquete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxEstadoPaquetes;
        private System.Windows.Forms.ListBox listBoxEntregado;
        private System.Windows.Forms.Label lblEntregado;
        private System.Windows.Forms.ListBox listBoxEnViaje;
        private System.Windows.Forms.Label lblEnViaje;
        private System.Windows.Forms.ListBox listBoxIngresado;
        private System.Windows.Forms.Label lblIngresado;
        private System.Windows.Forms.GroupBox grpBoxPaquete;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTrackingID;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox mtxtTrackingID;
        private System.Windows.Forms.RichTextBox rtbMostrar;
    }
}
