namespace Cronometro
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
            this.label1 = new System.Windows.Forms.Label();
            this.startBTN = new System.Windows.Forms.Button();
            this.stopBTN = new System.Windows.Forms.Button();
            this.restartBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("LCDMono2", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00:00";
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.startBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBTN.ForeColor = System.Drawing.SystemColors.Window;
            this.startBTN.Location = new System.Drawing.Point(21, 153);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(160, 60);
            this.startBTN.TabIndex = 1;
            this.startBTN.Text = "Iniciar";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // stopBTN
            // 
            this.stopBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBTN.ForeColor = System.Drawing.SystemColors.Window;
            this.stopBTN.Location = new System.Drawing.Point(249, 153);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(160, 60);
            this.stopBTN.TabIndex = 2;
            this.stopBTN.Text = "Pausar";
            this.stopBTN.UseVisualStyleBackColor = false;
            this.stopBTN.Click += new System.EventHandler(this.stopBTN_Click);
            // 
            // restartBTN
            // 
            this.restartBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.restartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBTN.ForeColor = System.Drawing.SystemColors.Window;
            this.restartBTN.Location = new System.Drawing.Point(473, 153);
            this.restartBTN.Name = "restartBTN";
            this.restartBTN.Size = new System.Drawing.Size(160, 60);
            this.restartBTN.TabIndex = 3;
            this.restartBTN.Text = "Reiniciar";
            this.restartBTN.UseVisualStyleBackColor = false;
            this.restartBTN.Click += new System.EventHandler(this.restartBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(654, 258);
            this.Controls.Add(this.restartBTN);
            this.Controls.Add(this.stopBTN);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronometer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button stopBTN;
        private System.Windows.Forms.Button restartBTN;
    }
}

