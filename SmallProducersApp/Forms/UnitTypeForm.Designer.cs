namespace SmallProducersApp.Forms
{
    partial class UnitTypeForm
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
            btnRemoveUnit = new Button();
            unitDataGrid = new DataGridView();
            btnAddUnit = new Button();
            tBoxUnitName = new TextBox();
            tBoxUnitNumber = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)unitDataGrid).BeginInit();
            SuspendLayout();
            // 
            // btnRemoveUnit
            // 
            btnRemoveUnit.Location = new Point(3, 594);
            btnRemoveUnit.Name = "btnRemoveUnit";
            btnRemoveUnit.Size = new Size(64, 32);
            btnRemoveUnit.TabIndex = 13;
            btnRemoveUnit.Text = "Remover";
            btnRemoveUnit.UseVisualStyleBackColor = true;
            // 
            // unitDataGrid
            // 
            unitDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            unitDataGrid.Location = new Point(1, 153);
            unitDataGrid.Name = "unitDataGrid";
            unitDataGrid.RowTemplate.Height = 25;
            unitDataGrid.Size = new Size(340, 438);
            unitDataGrid.TabIndex = 12;
            // 
            // btnAddUnit
            // 
            btnAddUnit.Location = new Point(12, 12);
            btnAddUnit.Name = "btnAddUnit";
            btnAddUnit.Size = new Size(66, 50);
            btnAddUnit.TabIndex = 11;
            btnAddUnit.Text = "Adicionar";
            btnAddUnit.UseVisualStyleBackColor = true;
            btnAddUnit.Click += btnAddUnit_Click;
            // 
            // tBoxUnitName
            // 
            tBoxUnitName.Location = new Point(124, 105);
            tBoxUnitName.Name = "tBoxUnitName";
            tBoxUnitName.Size = new Size(159, 23);
            tBoxUnitName.TabIndex = 10;
            // 
            // tBoxUnitNumber
            // 
            tBoxUnitNumber.Location = new Point(124, 76);
            tBoxUnitNumber.Name = "tBoxUnitNumber";
            tBoxUnitNumber.Size = new Size(45, 23);
            tBoxUnitNumber.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 108);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 8;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 79);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 7;
            label1.Text = "Código:";
            // 
            // UnitTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 629);
            Controls.Add(btnRemoveUnit);
            Controls.Add(unitDataGrid);
            Controls.Add(btnAddUnit);
            Controls.Add(tBoxUnitName);
            Controls.Add(tBoxUnitNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UnitTypeForm";
            Text = "Unidades";
            ((System.ComponentModel.ISupportInitialize)unitDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemoveUnit;
        private DataGridView unitDataGrid;
        private Button btnAddUnit;
        private TextBox tBoxUnitName;
        private TextBox tBoxUnitNumber;
        private Label label2;
        private Label label1;
    }
}