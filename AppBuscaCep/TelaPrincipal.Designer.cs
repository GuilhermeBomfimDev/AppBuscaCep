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
            this.label2 = new System.Windows.Forms.Label();
            this.ErroCepInvalido = new System.Windows.Forms.Label();
            this.ErroCepNaoEncontrado = new System.Windows.Forms.Label();
            this.ErroEndNaoEncontrado = new System.Windows.Forms.Label();
            this.CampoBuscaCep = new System.Windows.Forms.MaskedTextBox();
            this.ErroCampoNull = new System.Windows.Forms.Label();
            this.CampoBuscaEndereco = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MensagemLoad = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(191, 437);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 47);
            this.button1.TabIndex = 1;
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
            this.pictureBox1.Location = new System.Drawing.Point(398, 110);
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
            this.pictureBox2.Location = new System.Drawing.Point(398, 98);
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
            this.label1.Location = new System.Drawing.Point(224, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "BuscaCep";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(187, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Digite o N.º CEP";
            // 
            // ErroCepInvalido
            // 
            this.ErroCepInvalido.AutoSize = true;
            this.ErroCepInvalido.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.ErroCepInvalido.ForeColor = System.Drawing.Color.Red;
            this.ErroCepInvalido.Location = new System.Drawing.Point(268, 392);
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
            this.ErroCepNaoEncontrado.Location = new System.Drawing.Point(246, 392);
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
            this.ErroEndNaoEncontrado.Location = new System.Drawing.Point(246, 392);
            this.ErroEndNaoEncontrado.Name = "ErroEndNaoEncontrado";
            this.ErroEndNaoEncontrado.Size = new System.Drawing.Size(187, 19);
            this.ErroEndNaoEncontrado.TabIndex = 10;
            this.ErroEndNaoEncontrado.Text = "Endereço não encontrado";
            this.ErroEndNaoEncontrado.Visible = false;
            // 
            // CampoBuscaCep
            // 
            this.CampoBuscaCep.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.CampoBuscaCep.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.CampoBuscaCep.HideSelection = false;
            this.CampoBuscaCep.Location = new System.Drawing.Point(191, 235);
            this.CampoBuscaCep.Mask = "00000-000";
            this.CampoBuscaCep.Name = "CampoBuscaCep";
            this.CampoBuscaCep.Size = new System.Drawing.Size(300, 25);
            this.CampoBuscaCep.TabIndex = 0;
            this.CampoBuscaCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.CampoBuscaCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CampoBuscaCep_KeyDown);
            // 
            // ErroCampoNull
            // 
            this.ErroCampoNull.AutoSize = true;
            this.ErroCampoNull.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.ErroCampoNull.ForeColor = System.Drawing.Color.Red;
            this.ErroCampoNull.Location = new System.Drawing.Point(236, 392);
            this.ErroCampoNull.Name = "ErroCampoNull";
            this.ErroCampoNull.Size = new System.Drawing.Size(208, 19);
            this.ErroCampoNull.TabIndex = 11;
            this.ErroCampoNull.Text = "CEP ou Endereço obrigatório";
            this.ErroCampoNull.Visible = false;
            // 
            // CampoBuscaEndereco
            // 
            this.CampoBuscaEndereco.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.CampoBuscaEndereco.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.CampoBuscaEndereco.HideSelection = false;
            this.CampoBuscaEndereco.Location = new System.Drawing.Point(191, 335);
            this.CampoBuscaEndereco.Name = "CampoBuscaEndereco";
            this.CampoBuscaEndereco.Size = new System.Drawing.Size(300, 25);
            this.CampoBuscaEndereco.TabIndex = 12;
            this.CampoBuscaEndereco.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(187, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Digite o endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(320, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ou";
            // 
            // MensagemLoad
            // 
            this.MensagemLoad.AutoSize = true;
            this.MensagemLoad.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.MensagemLoad.ForeColor = System.Drawing.Color.Green;
            this.MensagemLoad.Location = new System.Drawing.Point(207, 392);
            this.MensagemLoad.Name = "MensagemLoad";
            this.MensagemLoad.Size = new System.Drawing.Size(272, 19);
            this.MensagemLoad.TabIndex = 15;
            this.MensagemLoad.Text = "Buscando CEP, aguarde um instante...";
            this.MensagemLoad.Visible = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.MensagemLoad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CampoBuscaEndereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ErroCampoNull);
            this.Controls.Add(this.CampoBuscaCep);
            this.Controls.Add(this.ErroEndNaoEncontrado);
            this.Controls.Add(this.ErroCepNaoEncontrado);
            this.Controls.Add(this.ErroCepInvalido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErroCepInvalido;
        private System.Windows.Forms.Label ErroCepNaoEncontrado;
        private System.Windows.Forms.Label ErroEndNaoEncontrado;
        private System.Windows.Forms.MaskedTextBox CampoBuscaCep;
        private System.Windows.Forms.Label ErroCampoNull;
        private System.Windows.Forms.MaskedTextBox CampoBuscaEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MensagemLoad;
    }
}

