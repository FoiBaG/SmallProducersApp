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
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridClients).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridClients
            // 
            dataGridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClients.Location = new Point(253, 76);
            dataGridClients.Name = "dataGridClients";
            dataGridClients.RowTemplate.Height = 25;
            dataGridClients.Size = new Size(1005, 527);
            dataGridClients.TabIndex = 48;
            // 
            // btnRemoveClient
            // 
            btnRemoveClient.Image = (Image)resources.GetObject("btnRemoveClient.Image");
            btnRemoveClient.ImageAlign = ContentAlignment.TopCenter;
            btnRemoveClient.Location = new Point(399, 12);
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
            btnEditClient.Location = new Point(326, 12);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(67, 58);
            btnEditClient.TabIndex = 49;
            btnEditClient.Text = "Editar Registo";
            btnEditClient.TextAlign = ContentAlignment.BottomCenter;
            btnEditClient.UseVisualStyleBackColor = true;
            // 
            // tBoxProductName
            // 
            tBoxProductName.Location = new Point(6, 50);
            tBoxProductName.Name = "tBoxProductName";
            tBoxProductName.Size = new Size(227, 23);
            tBoxProductName.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 51;
            label2.Text = "Nome:";
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(149, 318);
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
            btnAddClient.Location = new Point(253, 12);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(67, 58);
            btnAddClient.TabIndex = 54;
            btnAddClient.Text = "Novo Registo";
            btnAddClient.TextAlign = ContentAlignment.BottomCenter;
            btnAddClient.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(tBoxProductName);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 353);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 615);
            Controls.Add(btnAddClient);
            Controls.Add(btnRemoveClient);
            Controls.Add(btnEditClient);
            Controls.Add(dataGridClients);
            Controls.Add(groupBox1);
            Name = "ClientForm";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridClients).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridClients;
        private Button btnRemoveClient;
        private Button btnEditClient;
        private TextBox tBoxProductName;
        private Label label2;
        private Button btnSearch;
        private Button btnAddClient;
        private GroupBox groupBox1;
    }
}