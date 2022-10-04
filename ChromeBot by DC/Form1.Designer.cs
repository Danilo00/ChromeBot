
namespace ChromeBot_by_DC
{
    partial class Form1
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
            this.btnProxyList = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnUrlList = new System.Windows.Forms.Button();
            this.nThreads = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nVisitsUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProxyList
            // 
            this.btnProxyList.Location = new System.Drawing.Point(199, 12);
            this.btnProxyList.Name = "btnProxyList";
            this.btnProxyList.Size = new System.Drawing.Size(184, 35);
            this.btnProxyList.TabIndex = 0;
            this.btnProxyList.Text = "Proxy List";
            this.btnProxyList.UseVisualStyleBackColor = true;
            this.btnProxyList.Click += new System.EventHandler(this.btnProxyList_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 118);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(371, 48);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnUrlList
            // 
            this.btnUrlList.Location = new System.Drawing.Point(9, 12);
            this.btnUrlList.Name = "btnUrlList";
            this.btnUrlList.Size = new System.Drawing.Size(184, 35);
            this.btnUrlList.TabIndex = 2;
            this.btnUrlList.Text = "Url List";
            this.btnUrlList.UseVisualStyleBackColor = true;
            this.btnUrlList.Click += new System.EventHandler(this.btnUrlList_Click);
            // 
            // nThreads
            // 
            this.nThreads.Location = new System.Drawing.Point(263, 53);
            this.nThreads.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nThreads.Name = "nThreads";
            this.nThreads.Size = new System.Drawing.Size(120, 22);
            this.nThreads.TabIndex = 3;
            this.nThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Threads";
            // 
            // nVisitsUrl
            // 
            this.nVisitsUrl.Location = new System.Drawing.Point(263, 81);
            this.nVisitsUrl.Name = "nVisitsUrl";
            this.nVisitsUrl.Size = new System.Drawing.Size(120, 22);
            this.nVisitsUrl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Visits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 178);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nVisitsUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nThreads);
            this.Controls.Add(this.btnUrlList);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnProxyList);
            this.Name = "Form1";
            this.Text = "ChromeBot by DC";
            ((System.ComponentModel.ISupportInitialize)(this.nThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProxyList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnUrlList;
        private System.Windows.Forms.NumericUpDown nThreads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nVisitsUrl;
        private System.Windows.Forms.Label label2;
    }
}

