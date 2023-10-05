namespace SmallProducersApp.Forms
{
    partial class ClientForm
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
            dataGridClients = new DataGridView();
            btnRemoveProduct = new Button();
            btnEditProduct = new Button();
            tBoxProductName = new TextBox();
            label2 = new Label();
            btnSearch = new Button();
            btnAddClient = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridClients).BeginInit();
            SuspendLayout();
            // 
            // dataGridClients
            // 
            dataGridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClients.Location = new Point(250, 76);
            dataGridClients.Name = "dataGridClients";
            dataGridClients.RowTemplate.Height = 25;
            dataGridClients.Size = new Size(999, 527);
            dataGridClients.TabIndex = 48;
            // 
            // btnRemoveProduct
            // 
            btnRemoveProduct.Location = new Point(1189, 10);
            btnRemoveProduct.Name = "btnRemoveProduct";
            btnRemoveProduct.Size = new Size(60, 60);
            btnRemoveProduct.TabIndex = 50;
            btnRemoveProduct.Text = "Remove";
            btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(1123, 10);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(60, 60);
            btnEditProduct.TabIndex = 49;
            btnEditProduct.Text = "Edit";
            btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // tBoxProductName
            // 
            tBoxProductName.Location = new Point(12, 103);
            tBoxProductName.Name = "tBoxProductName";
            tBoxProductName.Size = new Size(221, 23);
            tBoxProductName.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 51;
            label2.Text = "Nome:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(68, 574);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(165, 29);
            btnSearch.TabIndex = 53;
            btnSearch.Text = "Pesquisar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(250, 10);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(90, 60);
            btnAddClient.TabIndex = 54;
            btnAddClient.Text = "Adicionar";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 615);
            Controls.Add(btnAddClient);
            Controls.Add(btnSearch);
            Controls.Add(tBoxProductName);
            Controls.Add(label2);
            Controls.Add(btnRemoveProduct);
            Controls.Add(btnEditProduct);
            Controls.Add(dataGridClients);
            Name = "ClientForm";
            Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)dataGridClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridClients;
        private Button btnRemoveProduct;
        private Button btnEditProduct;
        private TextBox tBoxProductName;
        private Label label2;
        private Button btnSearch;
        private Button btnAddClient;
    }
}