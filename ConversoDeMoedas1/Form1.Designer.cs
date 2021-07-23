
namespace ConversoDeMoedas1
{
    partial class ConversorDeMoedas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversorDeMoedas));
            this.cmbPaises = new System.Windows.Forms.ComboBox();
            this.txtValorReal = new System.Windows.Forms.TextBox();
            this.txtValorConvertido = new System.Windows.Forms.TextBox();
            this.pictureBoxPais = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPais)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPaises
            // 
            this.cmbPaises.AutoCompleteCustomSource.AddRange(new string[] {
            "Dolar Americano",
            "Dolar Canadense",
            "Dolar Australiano",
            "Euro",
            "Coroa Sueca",
            "Peso Argentino",
            "Peso Boliviano",
            "Iene Japones",
            "Renminbi"});
            this.cmbPaises.BackColor = System.Drawing.Color.White;
            this.cmbPaises.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaises.FormattingEnabled = true;
            this.cmbPaises.Items.AddRange(new object[] {
            "Coroa Sueca",
            "Dolar Americano",
            "Dolar Australiano",
            "Dolar Canadense",
            "Euro",
            "Franco Suiço",
            "Iene japones",
            "Libra Esterlina",
            "Lira Turca",
            "Peso Argentino",
            "Peso Boliviano",
            "Renminbi"});
            this.cmbPaises.Location = new System.Drawing.Point(406, 139);
            this.cmbPaises.Name = "cmbPaises";
            this.cmbPaises.Size = new System.Drawing.Size(209, 28);
            this.cmbPaises.TabIndex = 2;
            this.cmbPaises.TabStop = false;
            this.cmbPaises.Text = "Selecione a moeda";
            this.cmbPaises.SelectedIndexChanged += new System.EventHandler(this.cmbPaises_SelectedIndexChanged);
            // 
            // txtValorReal
            // 
            this.txtValorReal.BackColor = System.Drawing.Color.White;
            this.txtValorReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorReal.Location = new System.Drawing.Point(180, 60);
            this.txtValorReal.Multiline = true;
            this.txtValorReal.Name = "txtValorReal";
            this.txtValorReal.Size = new System.Drawing.Size(220, 51);
            this.txtValorReal.TabIndex = 1;
            this.txtValorReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorConvertido
            // 
            this.txtValorConvertido.BackColor = System.Drawing.Color.White;
            this.txtValorConvertido.Enabled = false;
            this.txtValorConvertido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorConvertido.Location = new System.Drawing.Point(180, 409);
            this.txtValorConvertido.Multiline = true;
            this.txtValorConvertido.Name = "txtValorConvertido";
            this.txtValorConvertido.Size = new System.Drawing.Size(220, 51);
            this.txtValorConvertido.TabIndex = 2;
            this.txtValorConvertido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxPais
            // 
            this.pictureBoxPais.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPais.Location = new System.Drawing.Point(180, 139);
            this.pictureBoxPais.Name = "pictureBoxPais";
            this.pictureBoxPais.Size = new System.Drawing.Size(220, 209);
            this.pictureBoxPais.TabIndex = 3;
            this.pictureBoxPais.TabStop = false;
            this.pictureBoxPais.Visible = false;
            this.pictureBoxPais.WaitOnLoad = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor em Real";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor Convertido";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(180, 489);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(105, 41);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(295, 489);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 41);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // ConversorDeMoedas
            // 
            this.AcceptButton = this.btnConverter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(627, 566);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxPais);
            this.Controls.Add(this.txtValorConvertido);
            this.Controls.Add(this.txtValorReal);
            this.Controls.Add(this.cmbPaises);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConversorDeMoedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor De Moedas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPaises;
        private System.Windows.Forms.TextBox txtValorReal;
        private System.Windows.Forms.TextBox txtValorConvertido;
        private System.Windows.Forms.PictureBox pictureBoxPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnLimpar;
    }
}

