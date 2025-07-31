namespace AppBuscaCep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CampoPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErroCepInvalido = new System.Windows.Forms.Label();
            this.ErroCepNaoEncontrado = new System.Windows.Forms.Label();
            this.ErroEndNaoEncontrado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(200, 387);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pesquisar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(407, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(407, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(233, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "BuscaCep";
            // 
            // CampoPesquisa
            // 
            this.CampoPesquisa.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoPesquisa.Location = new System.Drawing.Point(200, 285);
            this.CampoPesquisa.Name = "CampoPesquisa";
            this.CampoPesquisa.Size = new System.Drawing.Size(300, 33);
            this.CampoPesquisa.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(196, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Digite o N.º CEP ou Endereço";
            // 
            // ErroCepInvalido
            // 
            this.ErroCepInvalido.AutoSize = true;
            this.ErroCepInvalido.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.ErroCepInvalido.ForeColor = System.Drawing.Color.Red;
            this.ErroCepInvalido.Location = new System.Drawing.Point(277, 340);
            this.ErroCepInvalido.Name = "ErroCepInvalido";
            this.ErroCepInvalido.Size = new System.Drawing.Size(143, 19);
            this.ErroCepInvalido.TabIndex = 8;
            this.ErroCepInvalido.Text = "N.º do CEP inválido";
            this.ErroCepInvalido.Visible = false;
            // 
            // ErroCepNaoEncontrado
            // 
            this.ErroCepNaoEncontrado.AutoSize = true;
            this.ErroCepNaoEncontrado.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.ErroCepNaoEncontrado.ForeColor = System.Drawing.Color.Red;
            this.ErroCepNaoEncontrado.Location = new System.Drawing.Point(255, 340);
            this.ErroCepNaoEncontrado.Name = "ErroCepNaoEncontrado";
            this.ErroCepNaoEncontrado.Size = new System.Drawing.Size(198, 19);
            this.ErroCepNaoEncontrado.TabIndex = 9;
            this.ErroCepNaoEncontrado.Text = "N.º do CEP não encontrado";
            this.ErroCepNaoEncontrado.Visible = false;
            // 
            // ErroEndNaoEncontrado
            // 
            this.ErroEndNaoEncontrado.AutoSize = true;
            this.ErroEndNaoEncontrado.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.ErroEndNaoEncontrado.ForeColor = System.Drawing.Color.Red;
            this.ErroEndNaoEncontrado.Location = new System.Drawing.Point(255, 340);
            this.ErroEndNaoEncontrado.Name = "ErroEndNaoEncontrado";
            this.ErroEndNaoEncontrado.Size = new System.Drawing.Size(187, 19);
            this.ErroEndNaoEncontrado.TabIndex = 10;
            this.ErroEndNaoEncontrado.Text = "Endereço não encontrado";
            this.ErroEndNaoEncontrado.Visible = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.ErroEndNaoEncontrado);
            this.Controls.Add(this.ErroCepNaoEncontrado);
            this.Controls.Add(this.ErroCepInvalido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CampoPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscaCep";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CampoPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErroCepInvalido;
        private System.Windows.Forms.Label ErroCepNaoEncontrado;
        private System.Windows.Forms.Label ErroEndNaoEncontrado;
    }
}

