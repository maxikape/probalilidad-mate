namespace probabilidad
{
    partial class form1
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
            this.components = new System.ComponentModel.Container();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xixfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xi2xfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnN = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtcuadrado = new System.Windows.Forms.TextBox();
            this.txtvarianza = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.ListaNumeros = new System.Windows.Forms.ListBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Modatxt = new System.Windows.Forms.TextBox();
            this.Medianatxt = new System.Windows.Forms.TextBox();
            this.Mediatxt = new System.Windows.Forms.TextBox();
            this.Moda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btcalcular = new System.Windows.Forms.Button();
            this.Error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Error3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.BtAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw
            // 
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xi,
            this.fi,
            this.Xixfi,
            this.xfi,
            this.xi2xfi});
            this.dgw.Location = new System.Drawing.Point(8, 234);
            this.dgw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 62;
            this.dgw.RowTemplate.Height = 28;
            this.dgw.Size = new System.Drawing.Size(814, 117);
            this.dgw.TabIndex = 0;
            this.dgw.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellEndEdit_1);
            // 
            // Xi
            // 
            this.Xi.HeaderText = "Xi";
            this.Xi.MinimumWidth = 8;
            this.Xi.Name = "Xi";
            this.Xi.Width = 150;
            // 
            // fi
            // 
            this.fi.HeaderText = "fi";
            this.fi.MinimumWidth = 8;
            this.fi.Name = "fi";
            this.fi.Width = 150;
            // 
            // Xixfi
            // 
            this.Xixfi.HeaderText = "Xi * fi";
            this.Xixfi.MinimumWidth = 8;
            this.Xixfi.Name = "Xixfi";
            this.Xixfi.Width = 150;
            // 
            // xfi
            // 
            this.xfi.HeaderText = "* fi";
            this.xfi.MinimumWidth = 8;
            this.xfi.Name = "xfi";
            this.xfi.Width = 150;
            // 
            // xi2xfi
            // 
            this.xi2xfi.HeaderText = "xi2 *fi";
            this.xi2xfi.MinimumWidth = 8;
            this.xi2xfi.Name = "xi2xfi";
            this.xi2xfi.Width = 150;
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(37, 45);
            this.btnN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(76, 29);
            this.btnN.TabIndex = 1;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(126, 45);
            this.txtN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtN.Multiline = true;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(68, 30);
            this.txtN.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xi * fi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(126, 87);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtproducto.Multiline = true;
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(68, 30);
            this.txtproducto.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 135);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xi² * fi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtcuadrado
            // 
            this.txtcuadrado.Location = new System.Drawing.Point(126, 135);
            this.txtcuadrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcuadrado.Multiline = true;
            this.txtcuadrado.Name = "txtcuadrado";
            this.txtcuadrado.Size = new System.Drawing.Size(68, 30);
            this.txtcuadrado.TabIndex = 6;
            // 
            // txtvarianza
            // 
            this.txtvarianza.Location = new System.Drawing.Point(126, 185);
            this.txtvarianza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtvarianza.Multiline = true;
            this.txtvarianza.Name = "txtvarianza";
            this.txtvarianza.Size = new System.Drawing.Size(68, 30);
            this.txtvarianza.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtAceptar);
            this.panel1.Controls.Add(this.txtDatos);
            this.panel1.Controls.Add(this.Modatxt);
            this.panel1.Controls.Add(this.Medianatxt);
            this.panel1.Controls.Add(this.Mediatxt);
            this.panel1.Controls.Add(this.Moda);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Btcalcular);
            this.panel1.Controls.Add(this.BtAgregar);
            this.panel1.Controls.Add(this.ListaNumeros);
            this.panel1.Controls.Add(this.TxtCantidad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 204);
            this.panel1.TabIndex = 8;
            // 
            // BtAgregar
            // 
            this.BtAgregar.Location = new System.Drawing.Point(124, 102);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtAgregar.TabIndex = 16;
            this.BtAgregar.Text = "Agregar";
            this.BtAgregar.UseVisualStyleBackColor = true;
            // 
            // ListaNumeros
            // 
            this.ListaNumeros.FormattingEnabled = true;
            this.ListaNumeros.Location = new System.Drawing.Point(223, 14);
            this.ListaNumeros.Name = "ListaNumeros";
            this.ListaNumeros.Size = new System.Drawing.Size(78, 108);
            this.ListaNumeros.TabIndex = 15;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(6, 56);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.TxtCantidad.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ponga cuantos numeros desea agregar ";
            // 
            // Modatxt
            // 
            this.Modatxt.Location = new System.Drawing.Point(449, 156);
            this.Modatxt.Name = "Modatxt";
            this.Modatxt.Size = new System.Drawing.Size(100, 20);
            this.Modatxt.TabIndex = 30;
            // 
            // Medianatxt
            // 
            this.Medianatxt.Location = new System.Drawing.Point(449, 115);
            this.Medianatxt.Name = "Medianatxt";
            this.Medianatxt.Size = new System.Drawing.Size(100, 20);
            this.Medianatxt.TabIndex = 29;
            // 
            // Mediatxt
            // 
            this.Mediatxt.Location = new System.Drawing.Point(449, 74);
            this.Mediatxt.Name = "Mediatxt";
            this.Mediatxt.Size = new System.Drawing.Size(100, 20);
            this.Mediatxt.TabIndex = 28;
            // 
            // Moda
            // 
            this.Moda.AutoSize = true;
            this.Moda.Location = new System.Drawing.Point(328, 156);
            this.Moda.Name = "Moda";
            this.Moda.Size = new System.Drawing.Size(34, 13);
            this.Moda.TabIndex = 27;
            this.Moda.Text = "Moda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mediana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Media";
            // 
            // Btcalcular
            // 
            this.Btcalcular.Location = new System.Drawing.Point(449, 14);
            this.Btcalcular.Name = "Btcalcular";
            this.Btcalcular.Size = new System.Drawing.Size(75, 23);
            this.Btcalcular.TabIndex = 24;
            this.Btcalcular.Text = "Calcular";
            this.Btcalcular.UseVisualStyleBackColor = true;
            // 
            // Error1
            // 
            this.Error1.ContainerControl = this;
            // 
            // Error2
            // 
            this.Error2.ContainerControl = this;
            // 
            // Error3
            // 
            this.Error3.ContainerControl = this;
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(6, 102);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(100, 20);
            this.txtDatos.TabIndex = 31;
            // 
            // BtAceptar
            // 
            this.BtAceptar.Location = new System.Drawing.Point(124, 54);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtAceptar.TabIndex = 32;
            this.BtAceptar.Text = "Aceptar";
            this.BtAceptar.UseVisualStyleBackColor = true;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 826);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtvarianza);
            this.Controls.Add(this.txtcuadrado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.dgw);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xixfi;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfi;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi2xfi;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtcuadrado;
        private System.Windows.Forms.TextBox txtvarianza;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Modatxt;
        private System.Windows.Forms.TextBox Medianatxt;
        private System.Windows.Forms.TextBox Mediatxt;
        private System.Windows.Forms.Label Moda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btcalcular;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.ListBox ListaNumeros;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider Error1;
        private System.Windows.Forms.ErrorProvider Error2;
        private System.Windows.Forms.ErrorProvider Error3;
        private System.Windows.Forms.Button BtAceptar;
        private System.Windows.Forms.TextBox txtDatos;
    }
}

