namespace Lista01
{
    partial class Ex01
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblvlr01 = new System.Windows.Forms.Label();
            this.lblVlr02 = new System.Windows.Forms.Label();
            this.txtVlr01 = new System.Windows.Forms.TextBox();
            this.txtVlr02 = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(135, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(142, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Exercício 01";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 134);
            this.panel1.TabIndex = 1;
            // 
            // lblvlr01
            // 
            this.lblvlr01.AutoSize = true;
            this.lblvlr01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvlr01.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblvlr01.Location = new System.Drawing.Point(42, 180);
            this.lblvlr01.Name = "lblvlr01";
            this.lblvlr01.Size = new System.Drawing.Size(74, 24);
            this.lblvlr01.TabIndex = 2;
            this.lblvlr01.Text = "Valor01";
            // 
            // lblVlr02
            // 
            this.lblVlr02.AutoSize = true;
            this.lblVlr02.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlr02.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVlr02.Location = new System.Drawing.Point(42, 234);
            this.lblVlr02.Name = "lblVlr02";
            this.lblVlr02.Size = new System.Drawing.Size(74, 24);
            this.lblVlr02.TabIndex = 3;
            this.lblVlr02.Text = "Valor02";
            // 
            // txtVlr01
            // 
            this.txtVlr01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlr01.Location = new System.Drawing.Point(139, 180);
            this.txtVlr01.Name = "txtVlr01";
            this.txtVlr01.Size = new System.Drawing.Size(165, 26);
            this.txtVlr01.TabIndex = 4;
            // 
            // txtVlr02
            // 
            this.txtVlr02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlr02.Location = new System.Drawing.Point(138, 234);
            this.txtVlr02.Name = "txtVlr02";
            this.txtVlr02.Size = new System.Drawing.Size(166, 26);
            this.txtVlr02.TabIndex = 5;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(179, 331);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 6;
            this.btnResultado.Text = "Calcular";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultado.Location = new System.Drawing.Point(69, 287);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(16, 24);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "-";
            // 
            // Ex01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtVlr02);
            this.Controls.Add(this.txtVlr01);
            this.Controls.Add(this.lblVlr02);
            this.Controls.Add(this.lblvlr01);
            this.Controls.Add(this.panel1);
            this.Name = "Ex01";
            this.Text = "Exercícios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblvlr01;
        private System.Windows.Forms.Label lblVlr02;
        private System.Windows.Forms.TextBox txtVlr01;
        private System.Windows.Forms.TextBox txtVlr02;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}

