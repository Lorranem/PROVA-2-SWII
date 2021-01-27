
namespace Desktop_TP_Final
{
    partial class FormEdit
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
            this.editar_ok_btn = new System.Windows.Forms.Button();
            this.status_cb = new System.Windows.Forms.CheckBox();
            this.senha_txt = new System.Windows.Forms.TextBox();
            this.nome_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editar_ok_btn
            // 
            this.editar_ok_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.editar_ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar_ok_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editar_ok_btn.Location = new System.Drawing.Point(92, 194);
            this.editar_ok_btn.Name = "editar_ok_btn";
            this.editar_ok_btn.Size = new System.Drawing.Size(106, 32);
            this.editar_ok_btn.TabIndex = 12;
            this.editar_ok_btn.Text = "Editar";
            this.editar_ok_btn.UseVisualStyleBackColor = false;
            this.editar_ok_btn.Click += new System.EventHandler(this.editar_ok_btn_Click);
            // 
            // status_cb
            // 
            this.status_cb.AutoSize = true;
            this.status_cb.BackColor = System.Drawing.Color.Transparent;
            this.status_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_cb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.status_cb.Location = new System.Drawing.Point(56, 159);
            this.status_cb.Name = "status_cb";
            this.status_cb.Size = new System.Drawing.Size(70, 20);
            this.status_cb.TabIndex = 11;
            this.status_cb.Text = "Status";
            this.status_cb.UseVisualStyleBackColor = false;
            // 
            // senha_txt
            // 
            this.senha_txt.Location = new System.Drawing.Point(70, 119);
            this.senha_txt.Name = "senha_txt";
            this.senha_txt.Size = new System.Drawing.Size(166, 20);
            this.senha_txt.TabIndex = 10;
            // 
            // nome_txt
            // 
            this.nome_txt.Location = new System.Drawing.Point(70, 69);
            this.nome_txt.Name = "nome_txt";
            this.nome_txt.Size = new System.Drawing.Size(166, 20);
            this.nome_txt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(15, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Edite as informações abaixo:";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desktop_TP_Final.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(288, 238);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editar_ok_btn);
            this.Controls.Add(this.status_cb);
            this.Controls.Add(this.senha_txt);
            this.Controls.Add(this.nome_txt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editar_ok_btn;
        private System.Windows.Forms.CheckBox status_cb;
        private System.Windows.Forms.TextBox senha_txt;
        private System.Windows.Forms.TextBox nome_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}