
namespace Desktop_TP_Final
{
    partial class FormGerenciar
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.deletar_btn = new System.Windows.Forms.Button();
            this.editar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(152, 199);
            this.listBox1.TabIndex = 0;
            // 
            // deletar_btn
            // 
            this.deletar_btn.BackColor = System.Drawing.Color.IndianRed;
            this.deletar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletar_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deletar_btn.Location = new System.Drawing.Point(212, 153);
            this.deletar_btn.Name = "deletar_btn";
            this.deletar_btn.Size = new System.Drawing.Size(129, 43);
            this.deletar_btn.TabIndex = 6;
            this.deletar_btn.Text = "Deletar Usuario";
            this.deletar_btn.UseVisualStyleBackColor = false;
            this.deletar_btn.Click += new System.EventHandler(this.deletar_btn_Click);
            // 
            // editar_btn
            // 
            this.editar_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.editar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editar_btn.Location = new System.Drawing.Point(212, 90);
            this.editar_btn.Name = "editar_btn";
            this.editar_btn.Size = new System.Drawing.Size(129, 40);
            this.editar_btn.TabIndex = 7;
            this.editar_btn.Text = "Editar Usuario";
            this.editar_btn.UseVisualStyleBackColor = false;
            this.editar_btn.Click += new System.EventHandler(this.editar_btn_Click);
            // 
            // FormGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desktop_TP_Final.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(370, 308);
            this.Controls.Add(this.editar_btn);
            this.Controls.Add(this.deletar_btn);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGerenciar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Usuários";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button deletar_btn;
        private System.Windows.Forms.Button editar_btn;
    }
}