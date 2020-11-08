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
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
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
            this.dgw.Location = new System.Drawing.Point(12, 360);
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 62;
            this.dgw.RowTemplate.Height = 28;
            this.dgw.Size = new System.Drawing.Size(1277, 180);
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
            this.btnN.Location = new System.Drawing.Point(56, 69);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(114, 44);
            this.btnN.TabIndex = 1;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(189, 69);
            this.txtN.Multiline = true;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 44);
            this.txtN.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xi * fi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(189, 134);
            this.txtproducto.Multiline = true;
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(100, 44);
            this.txtproducto.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xi² * fi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtcuadrado
            // 
            this.txtcuadrado.Location = new System.Drawing.Point(189, 207);
            this.txtcuadrado.Multiline = true;
            this.txtcuadrado.Name = "txtcuadrado";
            this.txtcuadrado.Size = new System.Drawing.Size(100, 44);
            this.txtcuadrado.TabIndex = 6;
            // 
            // txtvarianza
            // 
            this.txtvarianza.Location = new System.Drawing.Point(189, 285);
            this.txtvarianza.Multiline = true;
            this.txtvarianza.Name = "txtvarianza";
            this.txtvarianza.Size = new System.Drawing.Size(100, 44);
            this.txtvarianza.TabIndex = 7;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 568);
            this.Controls.Add(this.txtvarianza);
            this.Controls.Add(this.txtcuadrado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.dgw);
            this.Name = "form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
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
    }
}

