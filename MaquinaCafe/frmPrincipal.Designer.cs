namespace MaquinaCafe
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.imgCafe = new System.Windows.Forms.ImageList(this.components);
            this.imgBotao = new System.Windows.Forms.ImageList(this.components);
            this.grpDinheiro = new System.Windows.Forms.GroupBox();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnDez = new System.Windows.Forms.Button();
            this.btnVinteCinco = new System.Windows.Forms.Button();
            this.btnCinquenta = new System.Windows.Forms.Button();
            this.btnReal = new System.Windows.Forms.Button();
            this.grpSaldo = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.grpCafe = new System.Windows.Forms.GroupBox();
            this.btnCappuccino = new System.Windows.Forms.RadioButton();
            this.btnMocha = new System.Windows.Forms.RadioButton();
            this.btnLatte = new System.Windows.Forms.RadioButton();
            this.txtCapuccino = new System.Windows.Forms.TextBox();
            this.txtMocha = new System.Windows.Forms.TextBox();
            this.txtLatte = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpSaida = new System.Windows.Forms.GroupBox();
            this.grpTroco = new System.Windows.Forms.GroupBox();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.grpDinheiro.SuspendLayout();
            this.grpSaldo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.grpCafe.SuspendLayout();
            this.grpSaida.SuspendLayout();
            this.grpTroco.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgCafe
            // 
            this.imgCafe.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCafe.ImageStream")));
            this.imgCafe.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCafe.Images.SetKeyName(0, "cappuccino.png");
            this.imgCafe.Images.SetKeyName(1, "mocha.png");
            this.imgCafe.Images.SetKeyName(2, "latte.png");
            // 
            // imgBotao
            // 
            this.imgBotao.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgBotao.ImageStream")));
            this.imgBotao.TransparentColor = System.Drawing.Color.Transparent;
            this.imgBotao.Images.SetKeyName(0, "moeda.png");
            // 
            // grpDinheiro
            // 
            this.grpDinheiro.Controls.Add(this.imgLogo);
            this.grpDinheiro.Controls.Add(this.grpSaldo);
            this.grpDinheiro.Controls.Add(this.btnReal);
            this.grpDinheiro.Controls.Add(this.btnCinquenta);
            this.grpDinheiro.Controls.Add(this.btnVinteCinco);
            this.grpDinheiro.Controls.Add(this.btnDez);
            this.grpDinheiro.Controls.Add(this.btnCinco);
            this.grpDinheiro.Controls.Add(this.btnUm);
            this.grpDinheiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDinheiro.Location = new System.Drawing.Point(0, 0);
            this.grpDinheiro.Name = "grpDinheiro";
            this.grpDinheiro.Size = new System.Drawing.Size(468, 223);
            this.grpDinheiro.TabIndex = 0;
            this.grpDinheiro.TabStop = false;
            this.grpDinheiro.Text = "Insira sua moeda:";
            // 
            // btnUm
            // 
            this.btnUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUm.ImageIndex = 0;
            this.btnUm.ImageList = this.imgBotao;
            this.btnUm.Location = new System.Drawing.Point(12, 21);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(75, 82);
            this.btnUm.TabIndex = 0;
            this.btnUm.Text = "R$ 0,01";
            this.btnUm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinco.ImageIndex = 0;
            this.btnCinco.ImageList = this.imgBotao;
            this.btnCinco.Location = new System.Drawing.Point(93, 21);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(75, 82);
            this.btnCinco.TabIndex = 1;
            this.btnCinco.Text = "R$ 0,05";
            this.btnCinco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnDez
            // 
            this.btnDez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDez.ImageIndex = 0;
            this.btnDez.ImageList = this.imgBotao;
            this.btnDez.Location = new System.Drawing.Point(174, 21);
            this.btnDez.Name = "btnDez";
            this.btnDez.Size = new System.Drawing.Size(75, 82);
            this.btnDez.TabIndex = 2;
            this.btnDez.Text = "R$ 0,10";
            this.btnDez.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDez.UseVisualStyleBackColor = true;
            this.btnDez.Click += new System.EventHandler(this.btnDez_Click);
            // 
            // btnVinteCinco
            // 
            this.btnVinteCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVinteCinco.ImageIndex = 0;
            this.btnVinteCinco.ImageList = this.imgBotao;
            this.btnVinteCinco.Location = new System.Drawing.Point(12, 109);
            this.btnVinteCinco.Name = "btnVinteCinco";
            this.btnVinteCinco.Size = new System.Drawing.Size(75, 82);
            this.btnVinteCinco.TabIndex = 3;
            this.btnVinteCinco.Text = "R$ 0,25";
            this.btnVinteCinco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVinteCinco.UseVisualStyleBackColor = true;
            this.btnVinteCinco.Click += new System.EventHandler(this.btnVinteCinco_Click);
            // 
            // btnCinquenta
            // 
            this.btnCinquenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinquenta.ImageIndex = 0;
            this.btnCinquenta.ImageList = this.imgBotao;
            this.btnCinquenta.Location = new System.Drawing.Point(93, 109);
            this.btnCinquenta.Name = "btnCinquenta";
            this.btnCinquenta.Size = new System.Drawing.Size(75, 82);
            this.btnCinquenta.TabIndex = 4;
            this.btnCinquenta.Text = "R$ 0,50";
            this.btnCinquenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCinquenta.UseVisualStyleBackColor = true;
            this.btnCinquenta.Click += new System.EventHandler(this.btnCinquenta_Click);
            // 
            // btnReal
            // 
            this.btnReal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReal.ImageIndex = 0;
            this.btnReal.ImageList = this.imgBotao;
            this.btnReal.Location = new System.Drawing.Point(173, 109);
            this.btnReal.Name = "btnReal";
            this.btnReal.Size = new System.Drawing.Size(75, 82);
            this.btnReal.TabIndex = 5;
            this.btnReal.Text = "R$ 1,00";
            this.btnReal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReal.UseVisualStyleBackColor = true;
            this.btnReal.Click += new System.EventHandler(this.btnReal_Click);
            // 
            // grpSaldo
            // 
            this.grpSaldo.Controls.Add(this.txtSaldo);
            this.grpSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSaldo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpSaldo.Location = new System.Drawing.Point(255, 21);
            this.grpSaldo.Name = "grpSaldo";
            this.grpSaldo.Size = new System.Drawing.Size(200, 65);
            this.grpSaldo.TabIndex = 6;
            this.grpSaldo.TabStop = false;
            this.grpSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtSaldo.Location = new System.Drawing.Point(6, 30);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(188, 22);
            this.txtSaldo.TabIndex = 0;
            this.txtSaldo.TabStop = false;
            this.txtSaldo.Text = "0.0";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(255, 92);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(200, 99);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgLogo.TabIndex = 7;
            this.imgLogo.TabStop = false;
            // 
            // grpCafe
            // 
            this.grpCafe.Controls.Add(this.txtLatte);
            this.grpCafe.Controls.Add(this.txtMocha);
            this.grpCafe.Controls.Add(this.txtCapuccino);
            this.grpCafe.Controls.Add(this.btnLatte);
            this.grpCafe.Controls.Add(this.btnMocha);
            this.grpCafe.Controls.Add(this.btnCappuccino);
            this.grpCafe.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCafe.Location = new System.Drawing.Point(0, 223);
            this.grpCafe.Name = "grpCafe";
            this.grpCafe.Size = new System.Drawing.Size(468, 219);
            this.grpCafe.TabIndex = 1;
            this.grpCafe.TabStop = false;
            this.grpCafe.Text = "Escolha o café:";
            // 
            // btnCappuccino
            // 
            this.btnCappuccino.AutoSize = true;
            this.btnCappuccino.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCappuccino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCappuccino.ImageIndex = 0;
            this.btnCappuccino.ImageList = this.imgCafe;
            this.btnCappuccino.Location = new System.Drawing.Point(24, 34);
            this.btnCappuccino.Name = "btnCappuccino";
            this.btnCappuccino.Size = new System.Drawing.Size(110, 116);
            this.btnCappuccino.TabIndex = 0;
            this.btnCappuccino.TabStop = true;
            this.btnCappuccino.Text = "Cappuccino";
            this.btnCappuccino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCappuccino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCappuccino.UseVisualStyleBackColor = true;
            // 
            // btnMocha
            // 
            this.btnMocha.AutoSize = true;
            this.btnMocha.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMocha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMocha.ImageIndex = 1;
            this.btnMocha.ImageList = this.imgCafe;
            this.btnMocha.Location = new System.Drawing.Point(174, 34);
            this.btnMocha.Name = "btnMocha";
            this.btnMocha.Size = new System.Drawing.Size(110, 116);
            this.btnMocha.TabIndex = 1;
            this.btnMocha.TabStop = true;
            this.btnMocha.Text = "Mocha";
            this.btnMocha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMocha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMocha.UseVisualStyleBackColor = true;
            // 
            // btnLatte
            // 
            this.btnLatte.AutoSize = true;
            this.btnLatte.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLatte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLatte.ImageIndex = 2;
            this.btnLatte.ImageList = this.imgCafe;
            this.btnLatte.Location = new System.Drawing.Point(312, 34);
            this.btnLatte.Name = "btnLatte";
            this.btnLatte.Size = new System.Drawing.Size(125, 116);
            this.btnLatte.TabIndex = 2;
            this.btnLatte.TabStop = true;
            this.btnLatte.Text = "Café com leite";
            this.btnLatte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLatte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLatte.UseVisualStyleBackColor = true;
            // 
            // txtCapuccino
            // 
            this.txtCapuccino.Location = new System.Drawing.Point(24, 166);
            this.txtCapuccino.Name = "txtCapuccino";
            this.txtCapuccino.ReadOnly = true;
            this.txtCapuccino.Size = new System.Drawing.Size(100, 22);
            this.txtCapuccino.TabIndex = 3;
            this.txtCapuccino.TabStop = false;
            this.txtCapuccino.Text = "3,50";
            this.txtCapuccino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMocha
            // 
            this.txtMocha.Location = new System.Drawing.Point(176, 166);
            this.txtMocha.Name = "txtMocha";
            this.txtMocha.ReadOnly = true;
            this.txtMocha.Size = new System.Drawing.Size(100, 22);
            this.txtMocha.TabIndex = 4;
            this.txtMocha.TabStop = false;
            this.txtMocha.Text = "4,00";
            this.txtMocha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLatte
            // 
            this.txtLatte.Location = new System.Drawing.Point(327, 166);
            this.txtLatte.Name = "txtLatte";
            this.txtLatte.ReadOnly = true;
            this.txtLatte.Size = new System.Drawing.Size(100, 22);
            this.txtLatte.TabIndex = 5;
            this.txtLatte.TabStop = false;
            this.txtLatte.Text = "3,00";
            this.txtLatte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(187, 452);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 27);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grpSaida
            // 
            this.grpSaida.Controls.Add(this.txtSaida);
            this.grpSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSaida.Location = new System.Drawing.Point(12, 487);
            this.grpSaida.Name = "grpSaida";
            this.grpSaida.Size = new System.Drawing.Size(210, 62);
            this.grpSaida.TabIndex = 3;
            this.grpSaida.TabStop = false;
            this.grpSaida.Text = "Saída";
            // 
            // grpTroco
            // 
            this.grpTroco.Controls.Add(this.txtTroco);
            this.grpTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTroco.ForeColor = System.Drawing.Color.Red;
            this.grpTroco.Location = new System.Drawing.Point(228, 487);
            this.grpTroco.Name = "grpTroco";
            this.grpTroco.Size = new System.Drawing.Size(227, 62);
            this.grpTroco.TabIndex = 4;
            this.grpTroco.TabStop = false;
            this.grpTroco.Text = "Troco";
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(6, 21);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ReadOnly = true;
            this.txtSaida.Size = new System.Drawing.Size(198, 22);
            this.txtSaida.TabIndex = 0;
            this.txtSaida.TabStop = false;
            // 
            // txtTroco
            // 
            this.txtTroco.ForeColor = System.Drawing.Color.Red;
            this.txtTroco.Location = new System.Drawing.Point(6, 21);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(215, 22);
            this.txtTroco.TabIndex = 0;
            this.txtTroco.TabStop = false;
            this.txtTroco.Text = "0.0";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(468, 582);
            this.Controls.Add(this.grpTroco);
            this.Controls.Add(this.grpSaida);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpCafe);
            this.Controls.Add(this.grpDinheiro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máquina de Café Virtual";
            this.grpDinheiro.ResumeLayout(false);
            this.grpSaldo.ResumeLayout(false);
            this.grpSaldo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.grpCafe.ResumeLayout(false);
            this.grpCafe.PerformLayout();
            this.grpSaida.ResumeLayout(false);
            this.grpSaida.PerformLayout();
            this.grpTroco.ResumeLayout(false);
            this.grpTroco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgCafe;
        private System.Windows.Forms.ImageList imgBotao;
        private System.Windows.Forms.GroupBox grpDinheiro;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.GroupBox grpSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnReal;
        private System.Windows.Forms.Button btnCinquenta;
        private System.Windows.Forms.Button btnVinteCinco;
        private System.Windows.Forms.Button btnDez;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.GroupBox grpCafe;
        private System.Windows.Forms.TextBox txtMocha;
        private System.Windows.Forms.TextBox txtCapuccino;
        private System.Windows.Forms.RadioButton btnLatte;
        private System.Windows.Forms.RadioButton btnMocha;
        private System.Windows.Forms.RadioButton btnCappuccino;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grpSaida;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.GroupBox grpTroco;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtLatte;
    }
}

