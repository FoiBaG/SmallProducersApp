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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            dataGridClients = new DataGridView();
            btnRemoveClient = new Button();
            btnEditClient = new Button();
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
            dataGridClients.Size = new Size(1005, 527);
            dataGridClients.TabIndex = 48;
            // 
            // btnRemoveClient
            // 
            btnRemoveClient.Image = (Image)resources.GetObject("btnRemoveClient.Image");
            btnRemoveClient.ImageAlign = ContentAlignment.TopCenter;
            btnRemoveClient.Location = new Point(396, 12);
            btnRemoveClient.Name = "btnRemoveClient";
            btnRemoveClient.Size = new Size(67, 58);
            btnRemoveClient.TabIndex = 50;
            btnRemoveClient.Text = "Remover Registo";
            btnRemoveClient.TextAlign = ContentAlignment.BottomCenter;
            btnRemoveClient.UseVisualStyleBackColor = true;
            // 
            // btnEditClient
            // 
            btnEditClient.Image = (Image)resources.GetObject("btnEditClient.Image");
            btnEditClient.ImageAlign = ContentAlignment.TopCenter;
            btnEditClient.Location = new Point(323, 12);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(67, 58);
            btnEditClient.TabIndex = 49;
            btnEditClient.Text = "Editar Registo";
            btnEditClient.TextAlign = ContentAlignment.BottomCenter;
            btnEditClient.UseVisualStyleBackColor = true;
            // 
            // tBoxProductName
            // 
            tBoxProductName.Location = new Point(12, 128);
            tBoxProductName.Name = "tBoxProductName";
            tBoxProductName.Size = new Size(232, 23);
            tBoxProductName.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 51;
            label2.Text = "Nome:";
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(160, 326);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(84, 29);
            btnSearch.TabIndex = 53;
            btnSearch.Text = "Pesquisar";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddClient
            // 
            btnAddClient.Image = Properties.Resources.add_FILL0_wght400_GRAD0_opsz24;
            btnAddClient.ImageAlign = ContentAlignment.TopCenter;
            btnAddClient.Location = new Point(250, 12);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(67, 58);
            btnAddClient.TabIndex = 54;
            btnAddClient.Text = "Novo Registo";
            btnAddClient.TextAlign = ContentAlignment.BottomCenter;
            btnAddClient.TextImageRelation = TextImageRelation.ImageAboveText;
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
            Controls.Add(btnRemoveClient);
            Controls.Add(btnEditClient);
            Controls.Add(dataGridClients);
            Name = "ClientForm";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridClients;
        private Button btnRemoveClient;
        private Button btnEditClient;
        private TextBox tBoxProductName;
        private Label label2;
        private Button btnSearch;
        private Button btnAddClient;
    }
}