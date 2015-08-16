namespace ListaUI
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
            this.lbListaItens = new System.Windows.Forms.ListBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bntInserir = new System.Windows.Forms.Button();
            this.bntRemover = new System.Windows.Forms.Button();
            this.bntLimparLista = new System.Windows.Forms.Button();
            this.bntFechar = new System.Windows.Forms.Button();
            this.textTipo = new System.Windows.Forms.TextBox();
            this.textUnidade = new System.Windows.Forms.TextBox();
            this.textPreco = new System.Windows.Forms.TextBox();
            this.textCalorias = new System.Windows.Forms.TextBox();
            this.textCustoTotal = new System.Windows.Forms.TextBox();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textTotalLista = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbListaItens
            // 
            this.lbListaItens.FormattingEnabled = true;
            this.lbListaItens.Location = new System.Drawing.Point(25, 12);
            this.lbListaItens.Name = "lbListaItens";
            this.lbListaItens.Size = new System.Drawing.Size(168, 394);
            this.lbListaItens.TabIndex = 0;
            this.lbListaItens.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(15, 47);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(28, 13);
            this.labelTipo.TabIndex = 1;
            this.labelTipo.Text = "Tipo";
            this.labelTipo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(15, 71);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(47, 13);
            this.lblUnidade.TabIndex = 2;
            this.lblUnidade.Text = "Unidade";
            this.lblUnidade.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Calorias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Custo Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Quantidade";
            // 
            // bntInserir
            // 
            this.bntInserir.Location = new System.Drawing.Point(238, 383);
            this.bntInserir.Name = "bntInserir";
            this.bntInserir.Size = new System.Drawing.Size(75, 23);
            this.bntInserir.TabIndex = 8;
            this.bntInserir.Text = "Inserir";
            this.bntInserir.UseVisualStyleBackColor = true;
            this.bntInserir.Click += new System.EventHandler(this.bntInserir_Click);
            // 
            // bntRemover
            // 
            this.bntRemover.Location = new System.Drawing.Point(333, 383);
            this.bntRemover.Name = "bntRemover";
            this.bntRemover.Size = new System.Drawing.Size(75, 23);
            this.bntRemover.TabIndex = 9;
            this.bntRemover.Text = "Remover";
            this.bntRemover.UseVisualStyleBackColor = true;
            this.bntRemover.Click += new System.EventHandler(this.bntRemover_Click);
            // 
            // bntLimparLista
            // 
            this.bntLimparLista.Location = new System.Drawing.Point(429, 383);
            this.bntLimparLista.Name = "bntLimparLista";
            this.bntLimparLista.Size = new System.Drawing.Size(75, 23);
            this.bntLimparLista.TabIndex = 10;
            this.bntLimparLista.Text = "Limpar Lista";
            this.bntLimparLista.UseVisualStyleBackColor = true;
            this.bntLimparLista.Click += new System.EventHandler(this.bntLimparLista_Click);
            // 
            // bntFechar
            // 
            this.bntFechar.Location = new System.Drawing.Point(531, 383);
            this.bntFechar.Name = "bntFechar";
            this.bntFechar.Size = new System.Drawing.Size(75, 23);
            this.bntFechar.TabIndex = 11;
            this.bntFechar.Text = "Fechar";
            this.bntFechar.UseVisualStyleBackColor = true;
            // 
            // textTipo
            // 
            this.textTipo.Location = new System.Drawing.Point(76, 42);
            this.textTipo.Name = "textTipo";
            this.textTipo.Size = new System.Drawing.Size(100, 20);
            this.textTipo.TabIndex = 12;
            // 
            // textUnidade
            // 
            this.textUnidade.Location = new System.Drawing.Point(76, 68);
            this.textUnidade.Name = "textUnidade";
            this.textUnidade.Size = new System.Drawing.Size(100, 20);
            this.textUnidade.TabIndex = 13;
            // 
            // textPreco
            // 
            this.textPreco.Location = new System.Drawing.Point(76, 97);
            this.textPreco.Name = "textPreco";
            this.textPreco.Size = new System.Drawing.Size(100, 20);
            this.textPreco.TabIndex = 14;
            // 
            // textCalorias
            // 
            this.textCalorias.Location = new System.Drawing.Point(76, 125);
            this.textCalorias.Name = "textCalorias";
            this.textCalorias.Size = new System.Drawing.Size(100, 20);
            this.textCalorias.TabIndex = 15;
            // 
            // textCustoTotal
            // 
            this.textCustoTotal.Location = new System.Drawing.Point(76, 155);
            this.textCustoTotal.Name = "textCustoTotal";
            this.textCustoTotal.Size = new System.Drawing.Size(100, 20);
            this.textCustoTotal.TabIndex = 16;
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(76, 182);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(100, 20);
            this.textQuantidade.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTipo);
            this.groupBox1.Controls.Add(this.textQuantidade);
            this.groupBox1.Controls.Add(this.textTipo);
            this.groupBox1.Controls.Add(this.textCustoTotal);
            this.groupBox1.Controls.Add(this.textUnidade);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textCalorias);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textPreco);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblUnidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(238, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 326);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total da Lista";
            // 
            // textTotalLista
            // 
            this.textTotalLista.Location = new System.Drawing.Point(41, 425);
            this.textTotalLista.Name = "textTotalLista";
            this.textTotalLista.Size = new System.Drawing.Size(100, 20);
            this.textTotalLista.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 479);
            this.Controls.Add(this.textTotalLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntFechar);
            this.Controls.Add(this.bntLimparLista);
            this.Controls.Add(this.bntRemover);
            this.Controls.Add(this.bntInserir);
            this.Controls.Add(this.lbListaItens);
            this.Name = "Form1";
            this.Text = "Lista de Itens";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bntInserir;
        private System.Windows.Forms.Button bntRemover;
        private System.Windows.Forms.Button bntLimparLista;
        private System.Windows.Forms.Button bntFechar;
        private System.Windows.Forms.TextBox textTipo;
        private System.Windows.Forms.TextBox textUnidade;
        private System.Windows.Forms.TextBox textPreco;
        private System.Windows.Forms.TextBox textCalorias;
        private System.Windows.Forms.TextBox textCustoTotal;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTotalLista;
        private System.Windows.Forms.ListBox lbListaItens;
    }
}

