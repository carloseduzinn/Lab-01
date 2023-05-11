namespace Lab_01
{
    partial class TelaPrincipal
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
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_curso = new System.Windows.Forms.Label();
            this.lb_mensagem = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.cbox_curso = new System.Windows.Forms.ComboBox();
            this.btn_exibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo.Location = new System.Drawing.Point(118, 36);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(196, 25);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "laboratorio teste 01";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_nome.Location = new System.Drawing.Point(118, 98);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(56, 18);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_curso
            // 
            this.lb_curso.AutoSize = true;
            this.lb_curso.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_curso.Location = new System.Drawing.Point(112, 167);
            this.lb_curso.Name = "lb_curso";
            this.lb_curso.Size = new System.Drawing.Size(62, 18);
            this.lb_curso.TabIndex = 2;
            this.lb_curso.Text = "Curso:";
            // 
            // lb_mensagem
            // 
            this.lb_mensagem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_mensagem.Location = new System.Drawing.Point(118, 269);
            this.lb_mensagem.Name = "lb_mensagem";
            this.lb_mensagem.Size = new System.Drawing.Size(389, 90);
            this.lb_mensagem.TabIndex = 3;
            this.lb_mensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_mensagem.Click += new System.EventHandler(this.lb_mensagem_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(180, 98);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(262, 23);
            this.tb_nome.TabIndex = 4;
            // 
            // cbox_curso
            // 
            this.cbox_curso.FormattingEnabled = true;
            this.cbox_curso.Items.AddRange(new object[] {
            "Curso de C#",
            "Lógica de programação",
            "PHP",
            "Java",
            "C++",
            "C",
            "Phyton",
            "GO"});
            this.cbox_curso.Location = new System.Drawing.Point(180, 167);
            this.cbox_curso.Name = "cbox_curso";
            this.cbox_curso.Size = new System.Drawing.Size(262, 23);
            this.cbox_curso.TabIndex = 5;
            // 
            // btn_exibir
            // 
            this.btn_exibir.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_exibir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_exibir.Location = new System.Drawing.Point(118, 221);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(389, 32);
            this.btn_exibir.TabIndex = 6;
            this.btn_exibir.Text = "Exibir";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.btn_exibir_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 389);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.cbox_curso);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_mensagem);
            this.Controls.Add(this.lb_curso);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.lb_titulo);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio 01";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_titulo;
        private Label lb_nome;
        private Label lb_curso;
        private Label lb_mensagem;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox tb_nome;
        private ComboBox cbox_curso;
        private Button btn_exibir;
    }
}