namespace cadastroSimples
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
            this.btcadastrar = new System.Windows.Forms.Button();
            this.txbnome = new System.Windows.Forms.Label();
            this.txbtelefone = new System.Windows.Forms.Label();
            this.texnome = new System.Windows.Forms.TextBox();
            this.textelefone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btcadastrar
            // 
            this.btcadastrar.Location = new System.Drawing.Point(85, 331);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(171, 23);
            this.btcadastrar.TabIndex = 0;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // txbnome
            // 
            this.txbnome.AutoSize = true;
            this.txbnome.Location = new System.Drawing.Point(82, 129);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(35, 13);
            this.txbnome.TabIndex = 1;
            this.txbnome.Text = "Nome";
            // 
            // txbtelefone
            // 
            this.txbtelefone.AutoSize = true;
            this.txbtelefone.Location = new System.Drawing.Point(82, 217);
            this.txbtelefone.Name = "txbtelefone";
            this.txbtelefone.Size = new System.Drawing.Size(49, 13);
            this.txbtelefone.TabIndex = 2;
            this.txbtelefone.Text = "Telefone";
            // 
            // texnome
            // 
            this.texnome.Location = new System.Drawing.Point(138, 129);
            this.texnome.Name = "texnome";
            this.texnome.Size = new System.Drawing.Size(322, 20);
            this.texnome.TabIndex = 3;
            // 
            // textelefone
            // 
            this.textelefone.Location = new System.Drawing.Point(138, 214);
            this.textelefone.Name = "textelefone";
            this.textelefone.Size = new System.Drawing.Size(215, 20);
            this.textelefone.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.textelefone);
            this.Controls.Add(this.texnome);
            this.Controls.Add(this.txbtelefone);
            this.Controls.Add(this.txbnome);
            this.Controls.Add(this.btcadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Label txbnome;
        private System.Windows.Forms.Label txbtelefone;
        private System.Windows.Forms.TextBox texnome;
        private System.Windows.Forms.TextBox textelefone;
    }
}

