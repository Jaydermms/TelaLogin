namespace TelaLogin
{
    partial class FrmHome
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
            this.labelBoasVindas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBoasVindas
            // 
            this.labelBoasVindas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBoasVindas.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBoasVindas.Location = new System.Drawing.Point(0, 0);
            this.labelBoasVindas.Name = "labelBoasVindas";
            this.labelBoasVindas.Size = new System.Drawing.Size(907, 554);
            this.labelBoasVindas.TabIndex = 0;
            this.labelBoasVindas.Text = "Bem Vindo";
            this.labelBoasVindas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(907, 554);
            this.Controls.Add(this.labelBoasVindas);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBoasVindas;
    }
}

