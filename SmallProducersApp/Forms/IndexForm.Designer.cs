namespace SmallProducersApp
{
    partial class IndexForm
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
            btnClients = new Button();
            btnSuppiers = new Button();
            btnBuys = new Button();
            btnSells = new Button();
            btnAccounting = new Button();
            btnProducts = new Button();
            SuspendLayout();
            // 
            // btnClients
            // 
            btnClients.Location = new Point(54, 71);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(102, 41);
            btnClients.TabIndex = 0;
            btnClients.Text = "Clientes";
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // btnSuppiers
            // 
            btnSuppiers.Location = new Point(162, 71);
            btnSuppiers.Name = "btnSuppiers";
            btnSuppiers.Size = new Size(102, 41);
            btnSuppiers.TabIndex = 1;
            btnSuppiers.Text = "Fornecedores";
            btnSuppiers.UseVisualStyleBackColor = true;
            // 
            // btnBuys
            // 
            btnBuys.Location = new Point(270, 71);
            btnBuys.Name = "btnBuys";
            btnBuys.Size = new Size(102, 41);
            btnBuys.TabIndex = 2;
            btnBuys.Text = "Compras";
            btnBuys.UseVisualStyleBackColor = true;
            // 
            // btnSells
            // 
            btnSells.Location = new Point(378, 71);
            btnSells.Name = "btnSells";
            btnSells.Size = new Size(102, 41);
            btnSells.TabIndex = 3;
            btnSells.Text = "Vendas";
            btnSells.UseVisualStyleBackColor = true;
            // 
            // btnAccounting
            // 
            btnAccounting.Location = new Point(486, 71);
            btnAccounting.Name = "btnAccounting";
            btnAccounting.Size = new Size(102, 41);
            btnAccounting.TabIndex = 4;
            btnAccounting.Text = "Estatísticas";
            btnAccounting.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(54, 135);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(102, 41);
            btnProducts.TabIndex = 5;
            btnProducts.Text = "Produtos";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // IndexForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 611);
            Controls.Add(btnProducts);
            Controls.Add(btnAccounting);
            Controls.Add(btnSells);
            Controls.Add(btnBuys);
            Controls.Add(btnSuppiers);
            Controls.Add(btnClients);
            Name = "IndexForm";
            Text = "Menu Inicial";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClients;
        private Button btnSuppiers;
        private Button btnBuys;
        private Button btnSells;
        private Button btnAccounting;
        private Button btnProducts;
    }
}