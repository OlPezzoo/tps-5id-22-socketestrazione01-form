
namespace serverForm
{
    partial class frmServer
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblServer = new System.Windows.Forms.Label();
            this.btnAttiva = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(346, 27);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(102, 32);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "SERVER";
            // 
            // btnAttiva
            // 
            this.btnAttiva.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAttiva.FlatAppearance.BorderSize = 0;
            this.btnAttiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttiva.Location = new System.Drawing.Point(60, 83);
            this.btnAttiva.Name = "btnAttiva";
            this.btnAttiva.Size = new System.Drawing.Size(75, 23);
            this.btnAttiva.TabIndex = 1;
            this.btnAttiva.Text = "Attiva";
            this.btnAttiva.UseVisualStyleBackColor = false;
            this.btnAttiva.Click += new System.EventHandler(this.btnAttiva_Click);
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(60, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(677, 264);
            this.listBox1.TabIndex = 2;
            this.listBox1.Visible = false;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAttiva);
            this.Controls.Add(this.lblServer);
            this.Name = "frmServer";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Button btnAttiva;
        private System.Windows.Forms.ListBox listBox1;
    }
}

