namespace MetodosOrdenacao
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerarDados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCarregarArquivo = new System.Windows.Forms.Button();
            this.btnProcurarArquivo = new System.Windows.Forms.OpenFileDialog();
            this.btnFormSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGerarDados
            // 
            this.btnGerarDados.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerarDados.Location = new System.Drawing.Point(12, 30);
            this.btnGerarDados.Name = "btnGerarDados";
            this.btnGerarDados.Size = new System.Drawing.Size(254, 54);
            this.btnGerarDados.TabIndex = 0;
            this.btnGerarDados.Text = "Gerar Dados";
            this.btnGerarDados.UseVisualStyleBackColor = true;
            this.btnGerarDados.Click += new System.EventHandler(this.BtnGerarDados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerar dados aleatórios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Carregar arquivo";
            // 
            // btnCarregarArquivo
            // 
            this.btnCarregarArquivo.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCarregarArquivo.Location = new System.Drawing.Point(12, 126);
            this.btnCarregarArquivo.Name = "btnCarregarArquivo";
            this.btnCarregarArquivo.Size = new System.Drawing.Size(254, 54);
            this.btnCarregarArquivo.TabIndex = 4;
            this.btnCarregarArquivo.Text = "Carregar Arquivo";
            this.btnCarregarArquivo.UseVisualStyleBackColor = true;
            this.btnCarregarArquivo.Click += new System.EventHandler(this.BtnCarregarArquivo_Click);
            // 
            // btnProcurarArquivo
            // 
            this.btnProcurarArquivo.FileName = "openFileDialog1";
            // 
            // btnFormSair
            // 
            this.btnFormSair.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFormSair.Location = new System.Drawing.Point(12, 223);
            this.btnFormSair.Name = "btnFormSair";
            this.btnFormSair.Size = new System.Drawing.Size(254, 54);
            this.btnFormSair.TabIndex = 6;
            this.btnFormSair.Text = "Sair";
            this.btnFormSair.UseVisualStyleBackColor = true;
            this.btnFormSair.UseWaitCursor = true;
            this.btnFormSair.Click += new System.EventHandler(this.BtnFormSair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sair";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 295);
            this.Controls.Add(this.btnFormSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCarregarArquivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerarDados);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGerarDados;
        private Label label1;
        private Label label2;
        private Button btnCarregarArquivo;
        private OpenFileDialog btnProcurarArquivo;
        private Button btnFormSair;
        private Label label3;
    }
}