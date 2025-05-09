namespace BancoNubank.CustomControls
{
    partial class UC_Depositar
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtSaldo = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblSaldoAtual = new System.Windows.Forms.Label();
            btnDepositar = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtSaldo
            // 
            txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSaldo.Location = new System.Drawing.Point(335, 230);
            txtSaldo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new System.Drawing.Size(254, 38);
            txtSaldo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(331, 211);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "Valor a Depositar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(331, 305);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Saldo em Conta";
            // 
            // lblSaldoAtual
            // 
            lblSaldoAtual.AutoSize = true;
            lblSaldoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSaldoAtual.Location = new System.Drawing.Point(330, 368);
            lblSaldoAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSaldoAtual.Name = "lblSaldoAtual";
            lblSaldoAtual.Size = new System.Drawing.Size(0, 42);
            lblSaldoAtual.TabIndex = 4;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new System.Drawing.Point(597, 230);
            btnDepositar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new System.Drawing.Size(94, 38);
            btnDepositar.TabIndex = 5;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(47, 42);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(253, 31);
            label3.TabIndex = 6;
            label3.Text = "Depósito em  Conta";
            // 
            // UC_Depositar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(btnDepositar);
            Controls.Add(lblSaldoAtual);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSaldo);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "UC_Depositar";
            Size = new System.Drawing.Size(1049, 683);
            Load += Depositar_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaldoAtual;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label label3;
    }
}
