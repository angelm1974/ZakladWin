namespace ZakladWin
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddClient = new System.Windows.Forms.Button();
            this.ctnClientsList = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnServiceCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.Yellow;
            this.btnAddClient.Location = new System.Drawing.Point(12, 12);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(118, 30);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Dodaj klienta";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // ctnClientsList
            // 
            this.ctnClientsList.BackColor = System.Drawing.Color.Yellow;
            this.ctnClientsList.Location = new System.Drawing.Point(139, 12);
            this.ctnClientsList.Name = "ctnClientsList";
            this.ctnClientsList.Size = new System.Drawing.Size(118, 30);
            this.ctnClientsList.TabIndex = 1;
            this.ctnClientsList.Text = "Lista klientów";
            this.ctnClientsList.UseVisualStyleBackColor = false;
            this.ctnClientsList.Click += new System.EventHandler(this.ctnClientsList_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.Yellow;
            this.btnAddCar.Location = new System.Drawing.Point(266, 12);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(118, 30);
            this.btnAddCar.TabIndex = 2;
            this.btnAddCar.Text = "Dodaj samochód";
            this.btnAddCar.UseVisualStyleBackColor = false;
            // 
            // btnServiceCar
            // 
            this.btnServiceCar.BackColor = System.Drawing.Color.Yellow;
            this.btnServiceCar.Location = new System.Drawing.Point(393, 12);
            this.btnServiceCar.Name = "btnServiceCar";
            this.btnServiceCar.Size = new System.Drawing.Size(118, 30);
            this.btnServiceCar.TabIndex = 3;
            this.btnServiceCar.Text = "Oddaj do serwisu";
            this.btnServiceCar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1039, 557);
            this.Controls.Add(this.btnServiceCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.ctnClientsList);
            this.Controls.Add(this.btnAddClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1055, 596);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1055, 596);
            this.Name = "Form1";
            this.Text = "Zakład samochodowy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button ctnClientsList;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnServiceCar;
    }
}

