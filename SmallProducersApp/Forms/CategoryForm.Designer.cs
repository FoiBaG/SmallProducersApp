namespace SmallProducersApp
{
    partial class CategoryForm
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
            label1 = new Label();
            label2 = new Label();
            tBoxCategoryName = new TextBox();
            tBoxIVA = new TextBox();
            btnAddCategory = new Button();
            categoryDataGrid = new DataGridView();
            btnRemoveCategory = new Button();
            ((System.ComponentModel.ISupportInitialize)categoryDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 79);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome da categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 108);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "IVA:";
            // 
            // tBoxCategoryName
            // 
            tBoxCategoryName.Location = new Point(143, 76);
            tBoxCategoryName.Name = "tBoxCategoryName";
            tBoxCategoryName.Size = new Size(159, 23);
            tBoxCategoryName.TabIndex = 2;
            // 
            // tBoxIVA
            // 
            tBoxIVA.Location = new Point(143, 105);
            tBoxIVA.Name = "tBoxIVA";
            tBoxIVA.Size = new Size(159, 23);
            tBoxIVA.TabIndex = 3;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(26, 17);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(66, 50);
            btnAddCategory.TabIndex = 4;
            btnAddCategory.Text = "Adicionar";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // categoryDataGrid
            // 
            categoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoryDataGrid.Location = new Point(1, 153);
            categoryDataGrid.Name = "categoryDataGrid";
            categoryDataGrid.RowTemplate.Height = 25;
            categoryDataGrid.Size = new Size(340, 438);
            categoryDataGrid.TabIndex = 5;
            // 
            // btnRemoveCategory
            // 
            btnRemoveCategory.Location = new Point(3, 594);
            btnRemoveCategory.Name = "btnRemoveCategory";
            btnRemoveCategory.Size = new Size(64, 32);
            btnRemoveCategory.TabIndex = 6;
            btnRemoveCategory.Text = "Remover";
            btnRemoveCategory.UseVisualStyleBackColor = true;
            btnRemoveCategory.Click += btnRemoveCategory_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 629);
            Controls.Add(btnRemoveCategory);
            Controls.Add(categoryDataGrid);
            Controls.Add(btnAddCategory);
            Controls.Add(tBoxIVA);
            Controls.Add(tBoxCategoryName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CategoryForm";
            Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)categoryDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tBoxCategoryName;
        private TextBox tBoxIVA;
        private Button btnAddCategory;
        private DataGridView categoryDataGrid;
        private Button btnRemoveCategory;
    }
}