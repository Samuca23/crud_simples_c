namespace Confin
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.buttonListar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonIncluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExclui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.buttonListaCidade = new System.Windows.Forms.Button();
            this.buttonIncluirCidade = new System.Windows.Forms.Button();
            this.buttonAlterarCidade = new System.Windows.Forms.Button();
            this.buttonExcluirCidade = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(12, 51);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 23);
            this.buttonListar.TabIndex = 0;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(93, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(323, 210);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonIncluir
            // 
            this.buttonIncluir.Location = new System.Drawing.Point(12, 80);
            this.buttonIncluir.Name = "buttonIncluir";
            this.buttonIncluir.Size = new System.Drawing.Size(75, 23);
            this.buttonIncluir.TabIndex = 2;
            this.buttonIncluir.Text = "Incluir";
            this.buttonIncluir.UseVisualStyleBackColor = true;
            this.buttonIncluir.Click += new System.EventHandler(this.buttonIncluir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(12, 109);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 3;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExclui
            // 
            this.buttonExclui.Location = new System.Drawing.Point(12, 138);
            this.buttonExclui.Name = "buttonExclui";
            this.buttonExclui.Size = new System.Drawing.Size(75, 23);
            this.buttonExclui.TabIndex = 4;
            this.buttonExclui.Text = "Excluir";
            this.buttonExclui.UseVisualStyleBackColor = true;
            this.buttonExclui.Click += new System.EventHandler(this.buttonExclui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estado";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(573, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(323, 210);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // buttonListaCidade
            // 
            this.buttonListaCidade.Location = new System.Drawing.Point(492, 51);
            this.buttonListaCidade.Name = "buttonListaCidade";
            this.buttonListaCidade.Size = new System.Drawing.Size(75, 23);
            this.buttonListaCidade.TabIndex = 7;
            this.buttonListaCidade.Text = "Listar";
            this.buttonListaCidade.UseVisualStyleBackColor = true;
            this.buttonListaCidade.Click += new System.EventHandler(this.buttonListaCidade_Click);
            // 
            // buttonIncluirCidade
            // 
            this.buttonIncluirCidade.Location = new System.Drawing.Point(492, 80);
            this.buttonIncluirCidade.Name = "buttonIncluirCidade";
            this.buttonIncluirCidade.Size = new System.Drawing.Size(75, 23);
            this.buttonIncluirCidade.TabIndex = 8;
            this.buttonIncluirCidade.Text = "Incluir";
            this.buttonIncluirCidade.UseVisualStyleBackColor = true;
            this.buttonIncluirCidade.Click += new System.EventHandler(this.buttonIncluirCidade_Click);
            // 
            // buttonAlterarCidade
            // 
            this.buttonAlterarCidade.Location = new System.Drawing.Point(492, 108);
            this.buttonAlterarCidade.Name = "buttonAlterarCidade";
            this.buttonAlterarCidade.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarCidade.TabIndex = 9;
            this.buttonAlterarCidade.Text = "Alterar";
            this.buttonAlterarCidade.UseVisualStyleBackColor = true;
            this.buttonAlterarCidade.Click += new System.EventHandler(this.buttonAlterarCidade_Click);
            // 
            // buttonExcluirCidade
            // 
            this.buttonExcluirCidade.Location = new System.Drawing.Point(492, 137);
            this.buttonExcluirCidade.Name = "buttonExcluirCidade";
            this.buttonExcluirCidade.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirCidade.TabIndex = 10;
            this.buttonExcluirCidade.Text = "Excluir";
            this.buttonExcluirCidade.UseVisualStyleBackColor = true;
            this.buttonExcluirCidade.Click += new System.EventHandler(this.buttonExcluirCidade_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(514, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cidade";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 564);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExcluirCidade);
            this.Controls.Add(this.buttonAlterarCidade);
            this.Controls.Add(this.buttonIncluirCidade);
            this.Controls.Add(this.buttonListaCidade);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExclui);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonIncluir);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonListar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConFin - Controle Fincanceiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonIncluir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExclui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button buttonListaCidade;
        private System.Windows.Forms.Button buttonIncluirCidade;
        private System.Windows.Forms.Button buttonAlterarCidade;
        private System.Windows.Forms.Button buttonExcluirCidade;
        private System.Windows.Forms.Label label2;
    }
}

