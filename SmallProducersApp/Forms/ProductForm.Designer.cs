namespace SmallProducersApp.Forms
{
    partial class ProductForm
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
            btnRemoveProduct = new Button();
            dataGridProducts = new DataGridView();
            comboProductUnit = new ComboBox();
            comboProductCategory = new ComboBox();
            tBoxProductName = new TextBox();
            tBoxProductNumber = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEditProduct = new Button();
            btnAddProduct = new Button();
            btnUnitType = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).BeginInit();
            SuspendLayout();
            // 
            // btnRemoveProduct
            // 
            btnRemoveProduct.Location = new Point(401, 75);
            btnRemoveProduct.Name = "btnRemoveProduct";
            btnRemoveProduct.Size = new Size(60, 60);
            btnRemoveProduct.TabIndex = 48;
            btnRemoveProduct.Text = "Remove";
            btnRemoveProduct.UseVisualStyleBackColor = true;
            btnRemoveProduct.Click += btnRemoveProduct_Click;
            // 
            // dataGridProducts
            // 
            dataGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProducts.Location = new Point(1, 148);
            dataGridProducts.Name = "dataGridProducts";
            dataGridProducts.RowTemplate.Height = 25;
            dataGridProducts.Size = new Size(1232, 462);
            dataGridProducts.TabIndex = 47;
            // 
            // comboProductUnit
            // 
            comboProductUnit.FormattingEnabled = true;
            comboProductUnit.Location = new Point(87, 111);
            comboProductUnit.Name = "comboProductUnit";
            comboProductUnit.Size = new Size(91, 23);
            comboProductUnit.TabIndex = 46;
            // 
            // comboProductCategory
            // 
            comboProductCategory.FormattingEnabled = true;
            comboProductCategory.Location = new Point(87, 75);
            comboProductCategory.Name = "comboProductCategory";
            comboProductCategory.Size = new Size(142, 23);
            comboProductCategory.TabIndex = 45;
            // 
            // tBoxProductName
            // 
            tBoxProductName.Location = new Point(87, 43);
            tBoxProductName.Name = "tBoxProductName";
            tBoxProductName.Size = new Size(374, 23);
            tBoxProductName.TabIndex = 44;
            // 
            // tBoxProductNumber
            // 
            tBoxProductNumber.Location = new Point(87, 11);
            tBoxProductNumber.Name = "tBoxProductNumber";
            tBoxProductNumber.Size = new Size(66, 23);
            tBoxProductNumber.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 114);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 42;
            label4.Text = "Unidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 78);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 41;
            label3.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 46);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 40;
            label2.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 14);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 39;
            label1.Text = "Código:";
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(335, 75);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(60, 60);
            btnEditProduct.TabIndex = 38;
            btnEditProduct.Text = "Edit";
            btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackgroundImageLayout = ImageLayout.None;
            btnAddProduct.Image = Properties.Resources.add_FILL0_wght400_GRAD0_opsz24;
            btnAddProduct.ImageAlign = ContentAlignment.TopCenter;
            btnAddProduct.Location = new Point(269, 75);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(60, 60);
            btnAddProduct.TabIndex = 37;
            btnAddProduct.Text = "Novo Registo";
            btnAddProduct.TextAlign = ContentAlignment.BottomCenter;
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnUnitType
            // 
            btnUnitType.Location = new Point(467, 75);
            btnUnitType.Name = "btnUnitType";
            btnUnitType.Size = new Size(64, 59);
            btnUnitType.TabIndex = 49;
            btnUnitType.Text = "Unidades";
            btnUnitType.UseVisualStyleBackColor = true;
            btnUnitType.Click += btnUnitType_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 611);
            Controls.Add(btnUnitType);
            Controls.Add(btnRemoveProduct);
            Controls.Add(dataGridProducts);
            Controls.Add(comboProductUnit);
            Controls.Add(comboProductCategory);
            Controls.Add(tBoxProductName);
            Controls.Add(tBoxProductNumber);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEditProduct);
            Controls.Add(btnAddProduct);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemoveProduct;
        private DataGridView dataGridProducts;
        private ComboBox comboProductUnit;
        private ComboBox comboProductCategory;
        private TextBox tBoxProductName;
        private TextBox tBoxProductNumber;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEditProduct;
        private Button btnAddProduct;
        private Button btnUnitType;
    }
}