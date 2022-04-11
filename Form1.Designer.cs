namespace Jogo
{
    partial class Form1
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
            this.botaoPedra = new System.Windows.Forms.Button();
            this.botaoPapel = new System.Windows.Forms.Button();
            this.botaoTesoura = new System.Windows.Forms.Button();
            this.pictureBoxJogador = new System.Windows.Forms.PictureBox();
            this.pictureBoxCPU = new System.Windows.Forms.PictureBox();
            this.Jogador = new System.Windows.Forms.Label();
            this.labelDescricaoJogador = new System.Windows.Forms.Label();
            this.labelPontuacaoJogador = new System.Windows.Forms.Label();
            this.labelDescricaoCPU = new System.Windows.Forms.Label();
            this.labelPontuacaoCPU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoPedra
            // 
            this.botaoPedra.BackgroundImage = global::Jogo.Properties.Resources.PedraJ;
            this.botaoPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPedra.Location = new System.Drawing.Point(12, 207);
            this.botaoPedra.Name = "botaoPedra";
            this.botaoPedra.Size = new System.Drawing.Size(120, 120);
            this.botaoPedra.TabIndex = 0;
            this.botaoPedra.Tag = "0";
            this.botaoPedra.UseVisualStyleBackColor = true;
            this.botaoPedra.Click += new System.EventHandler(this.ClickJogada);
            // 
            // botaoPapel
            // 
            this.botaoPapel.BackgroundImage = global::Jogo.Properties.Resources.PapelJ;
            this.botaoPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPapel.Location = new System.Drawing.Point(172, 207);
            this.botaoPapel.Name = "botaoPapel";
            this.botaoPapel.Size = new System.Drawing.Size(120, 120);
            this.botaoPapel.TabIndex = 1;
            this.botaoPapel.Tag = "1";
            this.botaoPapel.UseVisualStyleBackColor = true;
            this.botaoPapel.Click += new System.EventHandler(this.ClickJogada);
            // 
            // botaoTesoura
            // 
            this.botaoTesoura.BackgroundImage = global::Jogo.Properties.Resources.TesouraJ;
            this.botaoTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoTesoura.Location = new System.Drawing.Point(328, 207);
            this.botaoTesoura.Name = "botaoTesoura";
            this.botaoTesoura.Size = new System.Drawing.Size(120, 120);
            this.botaoTesoura.TabIndex = 2;
            this.botaoTesoura.Tag = "2";
            this.botaoTesoura.UseVisualStyleBackColor = true;
            this.botaoTesoura.Click += new System.EventHandler(this.ClickJogada);
            // 
            // pictureBoxJogador
            // 
            this.pictureBoxJogador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxJogador.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxJogador.Name = "pictureBoxJogador";
            this.pictureBoxJogador.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxJogador.TabIndex = 3;
            this.pictureBoxJogador.TabStop = false;
            // 
            // pictureBoxCPU
            // 
            this.pictureBoxCPU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxCPU.Location = new System.Drawing.Point(298, 12);
            this.pictureBoxCPU.Name = "pictureBoxCPU";
            this.pictureBoxCPU.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCPU.TabIndex = 4;
            this.pictureBoxCPU.TabStop = false;
            // 
            // Jogador
            // 
            this.Jogador.AutoSize = true;
            this.Jogador.Location = new System.Drawing.Point(169, 31);
            this.Jogador.Name = "Jogador";
            this.Jogador.Size = new System.Drawing.Size(0, 13);
            this.Jogador.TabIndex = 5;
            // 
            // labelDescricaoJogador
            // 
            this.labelDescricaoJogador.AutoSize = true;
            this.labelDescricaoJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricaoJogador.Location = new System.Drawing.Point(168, 44);
            this.labelDescricaoJogador.Name = "labelDescricaoJogador";
            this.labelDescricaoJogador.Size = new System.Drawing.Size(67, 20);
            this.labelDescricaoJogador.TabIndex = 6;
            this.labelDescricaoJogador.Text = "Jogador";
            // 
            // labelPontuacaoJogador
            // 
            this.labelPontuacaoJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPontuacaoJogador.Location = new System.Drawing.Point(168, 82);
            this.labelPontuacaoJogador.Name = "labelPontuacaoJogador";
            this.labelPontuacaoJogador.Size = new System.Drawing.Size(40, 20);
            this.labelPontuacaoJogador.TabIndex = 7;
            this.labelPontuacaoJogador.Text = "0";
            this.labelPontuacaoJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDescricaoCPU
            // 
            this.labelDescricaoCPU.AutoSize = true;
            this.labelDescricaoCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricaoCPU.Location = new System.Drawing.Point(250, 44);
            this.labelDescricaoCPU.Name = "labelDescricaoCPU";
            this.labelDescricaoCPU.Size = new System.Drawing.Size(42, 20);
            this.labelDescricaoCPU.TabIndex = 8;
            this.labelDescricaoCPU.Text = "CPU";
            // 
            // labelPontuacaoCPU
            // 
            this.labelPontuacaoCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPontuacaoCPU.Location = new System.Drawing.Point(252, 82);
            this.labelPontuacaoCPU.Name = "labelPontuacaoCPU";
            this.labelPontuacaoCPU.Size = new System.Drawing.Size(40, 20);
            this.labelPontuacaoCPU.TabIndex = 9;
            this.labelPontuacaoCPU.Text = "0";
            this.labelPontuacaoCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(459, 347);
            this.Controls.Add(this.labelPontuacaoCPU);
            this.Controls.Add(this.labelDescricaoCPU);
            this.Controls.Add(this.labelPontuacaoJogador);
            this.Controls.Add(this.labelDescricaoJogador);
            this.Controls.Add(this.Jogador);
            this.Controls.Add(this.pictureBoxCPU);
            this.Controls.Add(this.pictureBoxJogador);
            this.Controls.Add(this.botaoTesoura);
            this.Controls.Add(this.botaoPapel);
            this.Controls.Add(this.botaoPedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pedra, papel e tesoura.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoPedra;
        private System.Windows.Forms.Button botaoPapel;
        private System.Windows.Forms.Button botaoTesoura;
        private System.Windows.Forms.PictureBox pictureBoxJogador;
        private System.Windows.Forms.PictureBox pictureBoxCPU;
        private System.Windows.Forms.Label Jogador;
        private System.Windows.Forms.Label labelDescricaoJogador;
        private System.Windows.Forms.Label labelPontuacaoJogador;
        private System.Windows.Forms.Label labelDescricaoCPU;
        private System.Windows.Forms.Label labelPontuacaoCPU;
    }
}

