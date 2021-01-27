
namespace Desktop_TP_Final
{
    partial class FormMain
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
            this.criar_usuario_btn = new System.Windows.Forms.Button();
            this.gerenciar_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // criar_usuario_btn
            // 
            this.criar_usuario_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.criar_usuario_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criar_usuario_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.criar_usuario_btn.Location = new System.Drawing.Point(72, 115);
            this.criar_usuario_btn.Name = "criar_usuario_btn";
            this.criar_usuario_btn.Size = new System.Drawing.Size(158, 41);
            this.criar_usuario_btn.TabIndex = 0;
            this.criar_usuario_btn.Text = "Criar Usuario";
            this.criar_usuario_btn.UseVisualStyleBackColor = false;
            this.criar_usuario_btn.Click += new System.EventHandler(this.criar_usuario_btn_Click);
            // 
            // gerenciar_btn
            // 
            this.gerenciar_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.gerenciar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerenciar_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gerenciar_btn.Location = new System.Drawing.Point(72, 54);
            this.gerenciar_btn.Name = "gerenciar_btn";
            this.gerenciar_btn.Size = new System.Drawing.Size(158, 42);
            this.gerenciar_btn.TabIndex = 1;
            this.gerenciar_btn.Text = "Gerenciar Usuarios";
            this.gerenciar_btn.UseVisualStyleBackColor = false;
            this.gerenciar_btn.Click += new System.EventHandler(this.gerenciar_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(102, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem Vindo!";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desktop_TP_Final.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(307, 185);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gerenciar_btn);
            this.Controls.Add(this.criar_usuario_btn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar/Gerenciar Usuários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button criar_usuario_btn;
        private System.Windows.Forms.Button gerenciar_btn;
        private System.Windows.Forms.Label label1;
    }
}

