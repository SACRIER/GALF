namespace GALF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1Pedido = new System.Windows.Forms.Button();
            this.button2Pagar = new System.Windows.Forms.Button();
            this.button3Sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(550, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(330, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "GALF - SUA LANCHONETE";
            // 
            // button1Pedido
            // 
            this.button1Pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1Pedido.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Pedido.Location = new System.Drawing.Point(342, 332);
            this.button1Pedido.Name = "button1Pedido";
            this.button1Pedido.Size = new System.Drawing.Size(133, 33);
            this.button1Pedido.TabIndex = 2;
            this.button1Pedido.Text = "PEDIDO";
            this.button1Pedido.UseVisualStyleBackColor = false;
            this.button1Pedido.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2Pagar
            // 
            this.button2Pagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2Pagar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Pagar.Location = new System.Drawing.Point(917, 332);
            this.button2Pagar.Name = "button2Pagar";
            this.button2Pagar.Size = new System.Drawing.Size(132, 33);
            this.button2Pagar.TabIndex = 3;
            this.button2Pagar.Text = "PAGAR";
            this.button2Pagar.UseVisualStyleBackColor = false;
            this.button2Pagar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3Sair
            // 
            this.button3Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Sair.Location = new System.Drawing.Point(12, 12);
            this.button3Sair.Name = "button3Sair";
            this.button3Sair.Size = new System.Drawing.Size(75, 23);
            this.button3Sair.TabIndex = 4;
            this.button3Sair.Text = "SAIR";
            this.button3Sair.UseVisualStyleBackColor = true;
            this.button3Sair.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button3Sair);
            this.Controls.Add(this.button2Pagar);
            this.Controls.Add(this.button1Pedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "GALF - CAIXA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Pedido;
        private System.Windows.Forms.Button button2Pagar;
        private System.Windows.Forms.Button button3Sair;
    }
}

