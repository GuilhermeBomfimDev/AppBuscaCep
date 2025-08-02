namespace AppBuscaCep
{
    partial class TelaRetorno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRetorno));
            this.BotaoNovaConsulta = new System.Windows.Forms.Button();
            this.TabelaDados = new System.Windows.Forms.TableLayoutPanel();
            this.CampoDDD = new System.Windows.Forms.TextBox();
            this.CampoRegiao = new System.Windows.Forms.TextBox();
            this.CampoEstado = new System.Windows.Forms.TextBox();
            this.CampoUF = new System.Windows.Forms.TextBox();
            this.CampoLocal = new System.Windows.Forms.TextBox();
            this.CampoBairro = new System.Windows.Forms.TextBox();
            this.CampoComp = new System.Windows.Forms.TextBox();
            this.CampoLog = new System.Windows.Forms.TextBox();
            this.CampoCep = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TabelaDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotaoNovaConsulta
            // 
            this.BotaoNovaConsulta.Location = new System.Drawing.Point(219, 508);
            this.BotaoNovaConsulta.Name = "BotaoNovaConsulta";
            this.BotaoNovaConsulta.Size = new System.Drawing.Size(255, 34);
            this.BotaoNovaConsulta.TabIndex = 1;
            this.BotaoNovaConsulta.Text = "Nova consulta";
            this.BotaoNovaConsulta.UseVisualStyleBackColor = true;
            this.BotaoNovaConsulta.Click += new System.EventHandler(this.BotaoNovaConsulta_Click);
            // 
            // TabelaDados
            // 
            this.TabelaDados.BackColor = System.Drawing.Color.Transparent;
            this.TabelaDados.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TabelaDados.ColumnCount = 2;
            this.TabelaDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TabelaDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TabelaDados.Controls.Add(this.CampoDDD, 1, 8);
            this.TabelaDados.Controls.Add(this.CampoRegiao, 1, 7);
            this.TabelaDados.Controls.Add(this.CampoEstado, 1, 6);
            this.TabelaDados.Controls.Add(this.CampoUF, 1, 5);
            this.TabelaDados.Controls.Add(this.CampoLocal, 1, 4);
            this.TabelaDados.Controls.Add(this.CampoBairro, 1, 3);
            this.TabelaDados.Controls.Add(this.CampoComp, 1, 2);
            this.TabelaDados.Controls.Add(this.CampoLog, 1, 1);
            this.TabelaDados.Controls.Add(this.CampoCep, 1, 0);
            this.TabelaDados.Controls.Add(this.textBox2, 0, 1);
            this.TabelaDados.Controls.Add(this.textBox3, 0, 2);
            this.TabelaDados.Controls.Add(this.textBox4, 0, 3);
            this.TabelaDados.Controls.Add(this.textBox5, 0, 4);
            this.TabelaDados.Controls.Add(this.textBox6, 0, 5);
            this.TabelaDados.Controls.Add(this.textBox7, 0, 6);
            this.TabelaDados.Controls.Add(this.textBox8, 0, 7);
            this.TabelaDados.Controls.Add(this.textBox9, 0, 8);
            this.TabelaDados.Controls.Add(this.textBox1, 0, 0);
            this.TabelaDados.Enabled = false;
            this.TabelaDados.Location = new System.Drawing.Point(126, 121);
            this.TabelaDados.Name = "TabelaDados";
            this.TabelaDados.RowCount = 9;
            this.TabelaDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelaDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelaDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelaDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelaDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelaDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelaDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelaDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelaDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelaDados.Size = new System.Drawing.Size(448, 309);
            this.TabelaDados.TabIndex = 2;
            this.TabelaDados.Tag = "";
            // 
            // CampoDDD
            // 
            this.CampoDDD.Enabled = false;
            this.CampoDDD.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.CampoDDD.Location = new System.Drawing.Point(227, 276);
            this.CampoDDD.Name = "CampoDDD";
            this.CampoDDD.Size = new System.Drawing.Size(217, 30);
            this.CampoDDD.TabIndex = 17;
            this.CampoDDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CampoRegiao
            // 
            this.CampoRegiao.Enabled = false;
            this.CampoRegiao.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.CampoRegiao.Location = new System.Drawing.Point(227, 242);
            this.CampoRegiao.Name = "CampoRegiao";
            this.CampoRegiao.Size = new System.Drawing.Size(217, 30);
            this.CampoRegiao.TabIndex = 16;
            this.CampoRegiao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CampoEstado
            // 
            this.CampoEstado.Enabled = false;
            this.CampoEstado.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.CampoEstado.Location = new System.Drawing.Point(227, 208);
            this.CampoEstado.Name = "CampoEstado";
            this.CampoEstado.Size = new System.Drawing.Size(217, 30);
            this.CampoEstado.TabIndex = 15;
            this.CampoEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CampoUF
            // 
            this.CampoUF.Enabled = false;
            this.CampoUF.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.CampoUF.Location = new System.Drawing.Point(227, 174);
            this.CampoUF.Name = "CampoUF";
            this.CampoUF.Size = new System.Drawing.Size(217, 30);
            this.CampoUF.TabIndex = 14;
            this.CampoUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CampoLocal
            // 
            this.CampoLocal.Enabled = false;
            this.CampoLocal.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.CampoLocal.Location = new System.Drawing.Point(227, 140);
            this.CampoLocal.Name = "CampoLocal";
            this.CampoLocal.Size = new System.Drawing.Size(217, 30);
            this.CampoLocal.TabIndex = 13;
            this.CampoLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CampoBairro
            // 
            this.CampoBairro.Enabled = false;
            this.CampoBairro.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.CampoBairro.Location = new System.Drawing.Point(227, 106);
            this.CampoBairro.Name = "CampoBairro";
            this.CampoBairro.Size = new System.Drawing.Size(217, 30);
            this.CampoBairro.TabIndex = 12;
            this.CampoBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CampoComp
            // 
            this.CampoComp.Enabled = false;
            this.CampoComp.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.CampoComp.Location = new System.Drawing.Point(227, 72);
            this.CampoComp.Name = "CampoComp";
            this.CampoComp.Size = new System.Drawing.Size(217, 30);
            this.CampoComp.TabIndex = 11;
            this.CampoComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CampoLog
            // 
            this.CampoLog.Enabled = false;
            this.CampoLog.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.CampoLog.Location = new System.Drawing.Point(227, 38);
            this.CampoLog.Name = "CampoLog";
            this.CampoLog.Size = new System.Drawing.Size(217, 30);
            this.CampoLog.TabIndex = 10;
            this.CampoLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CampoCep
            // 
            this.CampoCep.Enabled = false;
            this.CampoCep.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.CampoCep.Location = new System.Drawing.Point(227, 4);
            this.CampoCep.Name = "CampoCep";
            this.CampoCep.Size = new System.Drawing.Size(217, 30);
            this.CampoCep.TabIndex = 9;
            this.CampoCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(4, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 30);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Logradouro";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(4, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 30);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Complemento";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(4, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(216, 30);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Bairro";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.textBox5.Location = new System.Drawing.Point(4, 140);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(216, 30);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Localidade";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.textBox6.Location = new System.Drawing.Point(4, 174);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(216, 30);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "UF";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.textBox7.Location = new System.Drawing.Point(4, 208);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(216, 30);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Estado";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.textBox8.Location = new System.Drawing.Point(4, 242);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(216, 30);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "Região";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.textBox9.Location = new System.Drawing.Point(4, 276);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(216, 30);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "DDD";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(216, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "CEP";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TelaRetorno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.BotaoNovaConsulta);
            this.Controls.Add(this.TabelaDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaRetorno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaRetorno";
            this.TabelaDados.ResumeLayout(false);
            this.TabelaDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BotaoNovaConsulta;
        private System.Windows.Forms.TableLayoutPanel TabelaDados;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox CampoDDD;
        private System.Windows.Forms.TextBox CampoRegiao;
        private System.Windows.Forms.TextBox CampoEstado;
        private System.Windows.Forms.TextBox CampoUF;
        private System.Windows.Forms.TextBox CampoLocal;
        private System.Windows.Forms.TextBox CampoBairro;
        private System.Windows.Forms.TextBox CampoComp;
        private System.Windows.Forms.TextBox CampoLog;
        private System.Windows.Forms.TextBox CampoCep;
    }
}