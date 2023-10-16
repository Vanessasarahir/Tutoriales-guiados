
namespace ejercicios_guiados.Formas
{
    partial class FormaCalculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelValor2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelValor1 = new System.Windows.Forms.Label();
            this.textValor2 = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textValor1 = new System.Windows.Forms.TextBox();
            this.ButtonCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suma de numeros";
            // 
            // labelValor2
            // 
            this.labelValor2.AutoSize = true;
            this.labelValor2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor2.Location = new System.Drawing.Point(67, 211);
            this.labelValor2.Name = "labelValor2";
            this.labelValor2.Size = new System.Drawing.Size(100, 31);
            this.labelValor2.TabIndex = 1;
            this.labelValor2.Text = "Valor 2";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(67, 279);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(76, 31);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "Total";
            // 
            // labelValor1
            // 
            this.labelValor1.AutoSize = true;
            this.labelValor1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor1.Location = new System.Drawing.Point(67, 147);
            this.labelValor1.Name = "labelValor1";
            this.labelValor1.Size = new System.Drawing.Size(100, 31);
            this.labelValor1.TabIndex = 3;
            this.labelValor1.Text = "Valor 1";
            // 
            // textValor2
            // 
            this.textValor2.Location = new System.Drawing.Point(218, 206);
            this.textValor2.Name = "textValor2";
            this.textValor2.Size = new System.Drawing.Size(400, 22);
            this.textValor2.TabIndex = 4;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(218, 274);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(400, 22);
            this.textTotal.TabIndex = 5;
            // 
            // textValor1
            // 
            this.textValor1.Location = new System.Drawing.Point(218, 147);
            this.textValor1.Name = "textValor1";
            this.textValor1.Size = new System.Drawing.Size(400, 22);
            this.textValor1.TabIndex = 6;
            // 
            // ButtonCalcular
            // 
            this.ButtonCalcular.Location = new System.Drawing.Point(629, 349);
            this.ButtonCalcular.Name = "ButtonCalcular";
            this.ButtonCalcular.Size = new System.Drawing.Size(123, 66);
            this.ButtonCalcular.TabIndex = 7;
            this.ButtonCalcular.Text = "Calcular";
            this.ButtonCalcular.UseVisualStyleBackColor = true;
            this.ButtonCalcular.Click += new System.EventHandler(this.ButtonCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ejercicios_guiados.Properties.Resources.calculadora;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(645, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 121);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormaCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonCalcular);
            this.Controls.Add(this.textValor1);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textValor2);
            this.Controls.Add(this.labelValor1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelValor2);
            this.Controls.Add(this.label1);
            this.Name = "FormaCalculadora";
            this.Text = "FormaCalculadora";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelValor2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelValor1;
        private System.Windows.Forms.TextBox textValor2;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.TextBox textValor1;
        private System.Windows.Forms.Button ButtonCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}