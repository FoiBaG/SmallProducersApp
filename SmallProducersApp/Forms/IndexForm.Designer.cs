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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            btnClients = new Button();
            btnSuppiers = new Button();
            btnBuys = new Button();
            btnSells = new Button();
            btnAccounting = new Button();
            btnProducts = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnClients
            // 
            btnClients.Image = (Image)resources.GetObject("btnClients.Image");
            btnClients.ImageAlign = ContentAlignment.TopCenter;
            btnClients.Location = new Point(12, 12);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(110, 50);
            btnClients.TabIndex = 0;
            btnClients.Text = "Clientes";
            btnClients.TextAlign = ContentAlignment.BottomCenter;
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // btnSuppiers
            // 
            btnSuppiers.Image = (Image)resources.GetObject("btnSuppiers.Image");
            btnSuppiers.ImageAlign = ContentAlignment.TopCenter;
            btnSuppiers.Location = new Point(128, 12);
            btnSuppiers.Name = "btnSuppiers";
            btnSuppiers.Size = new Size(110, 50);
            btnSuppiers.TabIndex = 1;
            btnSuppiers.Text = "Fornecedores";
            btnSuppiers.TextAlign = ContentAlignment.BottomCenter;
            btnSuppiers.UseVisualStyleBackColor = true;
            // 
            // btnBuys
            // 
            btnBuys.Image = (Image)resources.GetObject("btnBuys.Image");
            btnBuys.ImageAlign = ContentAlignment.TopCenter;
            btnBuys.Location = new Point(306, 12);
            btnBuys.Name = "btnBuys";
            btnBuys.Size = new Size(110, 50);
            btnBuys.TabIndex = 2;
            btnBuys.Text = "Compras";
            btnBuys.TextAlign = ContentAlignment.BottomCenter;
            btnBuys.UseVisualStyleBackColor = true;
            // 
            // btnSells
            // 
            btnSells.Image = (Image)resources.GetObject("btnSells.Image");
            btnSells.ImageAlign = ContentAlignment.TopCenter;
            btnSells.Location = new Point(422, 12);
            btnSells.Name = "btnSells";
            btnSells.Size = new Size(110, 50);
            btnSells.TabIndex = 3;
            btnSells.Text = "Vendas";
            btnSells.TextAlign = ContentAlignment.BottomCenter;
            btnSells.UseVisualStyleBackColor = true;
            // 
            // btnAccounting
            // 
            btnAccounting.Image = (Image)resources.GetObject("btnAccounting.Image");
            btnAccounting.ImageAlign = ContentAlignment.TopCenter;
            btnAccounting.Location = new Point(594, 12);
            btnAccounting.Name = "btnAccounting";
            btnAccounting.Size = new Size(110, 50);
            btnAccounting.TabIndex = 4;
            btnAccounting.Text = "Estatísticas";
            btnAccounting.TextAlign = ContentAlignment.BottomCenter;
            btnAccounting.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.Image = (Image)resources.GetObject("btnProducts.Image");
            btnProducts.ImageAlign = ContentAlignment.TopCenter;
            btnProducts.Location = new Point(12, 97);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(110, 50);
            btnProducts.TabIndex = 5;
            btnProducts.Text = "Produtos";
            btnProducts.TextAlign = ContentAlignment.BottomCenter;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(306, 97);
            button1.Name = "button1";
            button1.Size = new Size(110, 50);
            button1.TabIndex = 6;
            button1.Text = "Trabalhadores";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // IndexForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 611);
            Controls.Add(button1);
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
        private Button button1;
    }
}