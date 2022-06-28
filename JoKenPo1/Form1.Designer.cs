namespace JoKenPo1
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picResultado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(24, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(969, 79);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Escolha: Pedra, Papel ou Tesoura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(376, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // picResultado
            // 
            this.picResultado.Location = new System.Drawing.Point(716, 165);
            this.picResultado.Name = "picResultado";
            this.picResultado.Size = new System.Drawing.Size(250, 250);
            this.picResultado.TabIndex = 3;
            this.picResultado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(116, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "você";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(481, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "PC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(313, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "vs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(657, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(824, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnPedra
            // 
            this.btnPedra.BackgroundImage = global::JoKenPo1.Properties.Resources.Pedra;
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedra.Location = new System.Drawing.Point(36, 421);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(250, 250);
            this.btnPedra.TabIndex = 9;
            this.btnPedra.UseVisualStyleBackColor = true;
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = global::JoKenPo1.Properties.Resources.Papel;
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.Location = new System.Drawing.Point(376, 421);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(250, 250);
            this.btnPapel.TabIndex = 10;
            this.btnPapel.UseVisualStyleBackColor = true;
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackgroundImage = global::JoKenPo1.Properties.Resources.Tesoura;
            this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTesoura.Location = new System.Drawing.Point(716, 421);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(250, 250);
            this.btnTesoura.TabIndex = 11;
            this.btnTesoura.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 687);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picResultado);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTesoura;
    }
}

