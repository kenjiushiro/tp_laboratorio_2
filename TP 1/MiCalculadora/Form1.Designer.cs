namespace MiCalculadora
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
            this.Operar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.ConvertirABinario = new System.Windows.Forms.Button();
            this.ConvertirADecimal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ComboBoxOperador = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Operar
            // 
            this.Operar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Operar.Location = new System.Drawing.Point(31, 103);
            this.Operar.Name = "Operar";
            this.Operar.Size = new System.Drawing.Size(150, 45);
            this.Operar.TabIndex = 0;
            this.Operar.Text = "Operar";
            this.Operar.UseVisualStyleBackColor = true;
            this.Operar.Click += new System.EventHandler(this.Operar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Limpiar.Location = new System.Drawing.Point(251, 103);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(127, 45);
            this.Limpiar.TabIndex = 1;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Cerrar.Location = new System.Drawing.Point(421, 104);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(146, 45);
            this.Cerrar.TabIndex = 2;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // ConvertirABinario
            // 
            this.ConvertirABinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ConvertirABinario.Location = new System.Drawing.Point(31, 181);
            this.ConvertirABinario.Name = "ConvertirABinario";
            this.ConvertirABinario.Size = new System.Drawing.Size(240, 58);
            this.ConvertirABinario.TabIndex = 3;
            this.ConvertirABinario.Text = "Convertir a binario";
            this.ConvertirABinario.UseVisualStyleBackColor = true;
            this.ConvertirABinario.Click += new System.EventHandler(this.ConvertirABinario_Click);
            // 
            // ConvertirADecimal
            // 
            this.ConvertirADecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ConvertirADecimal.Location = new System.Drawing.Point(348, 181);
            this.ConvertirADecimal.Name = "ConvertirADecimal";
            this.ConvertirADecimal.Size = new System.Drawing.Size(219, 58);
            this.ConvertirADecimal.TabIndex = 4;
            this.ConvertirADecimal.Text = "Convetir a decimal";
            this.ConvertirADecimal.UseVisualStyleBackColor = true;
            this.ConvertirADecimal.Click += new System.EventHandler(this.ConvertirADecimal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox1.Location = new System.Drawing.Point(21, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 29);
            this.textBox1.TabIndex = 5;
            // 
            // ComboBoxOperador
            // 
            this.ComboBoxOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ComboBoxOperador.FormattingEnabled = true;
            this.ComboBoxOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.ComboBoxOperador.Location = new System.Drawing.Point(131, 41);
            this.ComboBoxOperador.Name = "ComboBoxOperador";
            this.ComboBoxOperador.Size = new System.Drawing.Size(50, 32);
            this.ComboBoxOperador.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox2.Location = new System.Drawing.Point(204, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 29);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(305, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "=";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Resultado.Location = new System.Drawing.Point(332, 41);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(0, 25);
            this.Resultado.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 251);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ComboBoxOperador);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ConvertirADecimal);
            this.Controls.Add(this.ConvertirABinario);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Operar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Kenji Ushiro del curso 2° C";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Operar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button ConvertirABinario;
        private System.Windows.Forms.Button ConvertirADecimal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox ComboBoxOperador;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Resultado;
    }
}

