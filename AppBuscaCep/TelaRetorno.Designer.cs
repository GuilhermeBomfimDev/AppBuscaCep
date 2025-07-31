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
            this.label1 = new System.Windows.Forms.Label();
            this.BotaoNovaConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(160, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tela de Retorno API";
            // 
            // BotaoNovaConsulta
            // 
            this.BotaoNovaConsulta.Location = new System.Drawing.Point(227, 482);
            this.BotaoNovaConsulta.Name = "BotaoNovaConsulta";
            this.BotaoNovaConsulta.Size = new System.Drawing.Size(255, 34);
            this.BotaoNovaConsulta.TabIndex = 1;
            this.BotaoNovaConsulta.Text = "Nova consulta";
            this.BotaoNovaConsulta.UseVisualStyleBackColor = true;
            this.BotaoNovaConsulta.Click += new System.EventHandler(this.BotaoNovaConsulta_Click);
            // 
            // TelaRetorno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.BotaoNovaConsulta);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaRetorno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaRetorno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaRetorno_FormClosed);
            this.Load += new System.EventHandler(this.TelaRetorno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotaoNovaConsulta;
    }
}