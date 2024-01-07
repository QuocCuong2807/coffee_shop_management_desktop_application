namespace QuanlyCoffee
{
    partial class Management
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
            this.tabFood = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlGroupBtn = new System.Windows.Forms.Panel();
            this.btnRemoveFood = new System.Windows.Forms.Button();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panelDataFood = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewFood = new System.Windows.Forms.DataGridView();
            this.tabFoodCategory = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewFoodCategory = new System.Windows.Forms.DataGridView();
            this.tcMangement = new System.Windows.Forms.TabControl();
            this.tabTable = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.updateTable = new System.Windows.Forms.Button();
            this.btnRemoveTable = new System.Windows.Forms.Button();
            this.txbTableName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.tabFood.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlGroupBtn.SuspendLayout();
            this.panelDataFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).BeginInit();
            this.tabFoodCategory.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodCategory)).BeginInit();
            this.tcMangement.SuspendLayout();
            this.tabTable.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFood
            // 
            this.tabFood.Controls.Add(this.panel5);
            this.tabFood.Controls.Add(this.panelDataFood);
            this.tabFood.Location = new System.Drawing.Point(4, 25);
            this.tabFood.Name = "tabFood";
            this.tabFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabFood.Size = new System.Drawing.Size(884, 519);
            this.tabFood.TabIndex = 2;
            this.tabFood.Text = "Danh sách món ăn";
            this.tabFood.UseVisualStyleBackColor = true;
            this.tabFood.Click += new System.EventHandler(this.tabFood_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pnlGroupBtn);
            this.panel5.Location = new System.Drawing.Point(391, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(487, 509);
            this.panel5.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.numericPrice);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(16, 151);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(458, 52);
            this.panel7.TabIndex = 6;
            // 
            // numericPrice
            // 
            this.numericPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPrice.Location = new System.Drawing.Point(128, 9);
            this.numericPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPrice.Minimum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(201, 35);
            this.numericPrice.TabIndex = 1;
            this.numericPrice.Value = new decimal(new int[] {
            22000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbCategory);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(16, 77);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(458, 57);
            this.panel8.TabIndex = 5;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(125, 9);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(303, 33);
            this.cbCategory.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh mục:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbFoodName);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(16, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(458, 59);
            this.panel6.TabIndex = 4;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFoodName.Location = new System.Drawing.Point(126, 11);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(305, 30);
            this.txbFoodName.TabIndex = 1;
            this.txbFoodName.TextChanged += new System.EventHandler(this.txbFoodName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên món:";
            // 
            // pnlGroupBtn
            // 
            this.pnlGroupBtn.Controls.Add(this.btnRemoveFood);
            this.pnlGroupBtn.Controls.Add(this.btnUpdateFood);
            this.pnlGroupBtn.Controls.Add(this.btnView);
            this.pnlGroupBtn.Controls.Add(this.btnAddFood);
            this.pnlGroupBtn.Location = new System.Drawing.Point(16, 224);
            this.pnlGroupBtn.Name = "pnlGroupBtn";
            this.pnlGroupBtn.Size = new System.Drawing.Size(458, 142);
            this.pnlGroupBtn.TabIndex = 3;
            // 
            // btnRemoveFood
            // 
            this.btnRemoveFood.BackColor = System.Drawing.Color.White;
            this.btnRemoveFood.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFood.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveFood.Location = new System.Drawing.Point(302, 3);
            this.btnRemoveFood.Name = "btnRemoveFood";
            this.btnRemoveFood.Size = new System.Drawing.Size(129, 55);
            this.btnRemoveFood.TabIndex = 4;
            this.btnRemoveFood.Text = "Xoá món ăn";
            this.btnRemoveFood.UseVisualStyleBackColor = false;
            this.btnRemoveFood.Click += new System.EventHandler(this.btnRemoveFood_Click);
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.BackColor = System.Drawing.Color.White;
            this.btnUpdateFood.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFood.ForeColor = System.Drawing.Color.Gold;
            this.btnUpdateFood.Location = new System.Drawing.Point(6, 76);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(129, 55);
            this.btnUpdateFood.TabIndex = 5;
            this.btnUpdateFood.Text = "Cập nhật ";
            this.btnUpdateFood.UseVisualStyleBackColor = false;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Blue;
            this.btnView.Location = new System.Drawing.Point(302, 76);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(129, 55);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "Refresh";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.White;
            this.btnAddFood.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAddFood.Location = new System.Drawing.Point(6, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(129, 55);
            this.btnAddFood.TabIndex = 3;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panelDataFood
            // 
            this.panelDataFood.Controls.Add(this.label9);
            this.panelDataFood.Controls.Add(this.dataGridViewFood);
            this.panelDataFood.Location = new System.Drawing.Point(7, 7);
            this.panelDataFood.Name = "panelDataFood";
            this.panelDataFood.Size = new System.Drawing.Size(378, 509);
            this.panelDataFood.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Danh sách món ăn";
            // 
            // dataGridViewFood
            // 
            this.dataGridViewFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFood.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewFood.Name = "dataGridViewFood";
            this.dataGridViewFood.RowHeadersWidth = 51;
            this.dataGridViewFood.RowTemplate.Height = 24;
            this.dataGridViewFood.Size = new System.Drawing.Size(372, 454);
            this.dataGridViewFood.TabIndex = 0;
            // 
            // tabFoodCategory
            // 
            this.tabFoodCategory.Controls.Add(this.panel4);
            this.tabFoodCategory.Controls.Add(this.panel3);
            this.tabFoodCategory.Location = new System.Drawing.Point(4, 25);
            this.tabFoodCategory.Name = "tabFoodCategory";
            this.tabFoodCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabFoodCategory.Size = new System.Drawing.Size(884, 519);
            this.tabFoodCategory.TabIndex = 1;
            this.tabFoodCategory.Text = "Danh mục thực phẩm";
            this.tabFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnUpdateCategory);
            this.panel4.Controls.Add(this.btnRemoveCategory);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txbCategoryName);
            this.panel4.Controls.Add(this.btnAddCategory);
            this.panel4.Location = new System.Drawing.Point(425, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 176);
            this.panel4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên danh mục:";
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoryName.Location = new System.Drawing.Point(8, 55);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(436, 30);
            this.txbCategoryName.TabIndex = 1;
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.BackColor = System.Drawing.Color.White;
            this.btnRemoveCategory.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCategory.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveCategory.Location = new System.Drawing.Point(161, 103);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(129, 55);
            this.btnRemoveCategory.TabIndex = 4;
            this.btnRemoveCategory.Text = "Xoá ";
            this.btnRemoveCategory.UseVisualStyleBackColor = false;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.White;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.Gold;
            this.btnUpdateCategory.Location = new System.Drawing.Point(315, 103);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(129, 55);
            this.btnUpdateCategory.TabIndex = 5;
            this.btnUpdateCategory.Text = "Cập nhật ";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.White;
            this.btnAddCategory.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAddCategory.Location = new System.Drawing.Point(8, 103);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(129, 55);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "Thêm mới";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dataGridViewFoodCategory);
            this.panel3.Location = new System.Drawing.Point(3, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 507);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Danh mục thực phẩm";
            // 
            // dataGridViewFoodCategory
            // 
            this.dataGridViewFoodCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoodCategory.Location = new System.Drawing.Point(0, 55);
            this.dataGridViewFoodCategory.Name = "dataGridViewFoodCategory";
            this.dataGridViewFoodCategory.RowHeadersWidth = 51;
            this.dataGridViewFoodCategory.RowTemplate.Height = 24;
            this.dataGridViewFoodCategory.Size = new System.Drawing.Size(416, 452);
            this.dataGridViewFoodCategory.TabIndex = 0;
            // 
            // tcMangement
            // 
            this.tcMangement.Controls.Add(this.tabFoodCategory);
            this.tcMangement.Controls.Add(this.tabFood);
            this.tcMangement.Controls.Add(this.tabTable);
            this.tcMangement.Location = new System.Drawing.Point(4, 13);
            this.tcMangement.Name = "tcMangement";
            this.tcMangement.SelectedIndex = 0;
            this.tcMangement.Size = new System.Drawing.Size(892, 548);
            this.tcMangement.TabIndex = 0;
            // 
            // tabTable
            // 
            this.tabTable.Controls.Add(this.panel2);
            this.tabTable.Controls.Add(this.panel1);
            this.tabTable.Location = new System.Drawing.Point(4, 25);
            this.tabTable.Name = "tabTable";
            this.tabTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTable.Size = new System.Drawing.Size(884, 519);
            this.tabTable.TabIndex = 3;
            this.tabTable.Text = "Quản lý bàn ăn";
            this.tabTable.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Location = new System.Drawing.Point(362, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 495);
            this.panel2.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.updateTable);
            this.panel10.Controls.Add(this.btnRemoveTable);
            this.panel10.Controls.Add(this.txbTableName);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.btnAddTable);
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(510, 250);
            this.panel10.TabIndex = 0;
            // 
            // updateTable
            // 
            this.updateTable.BackColor = System.Drawing.Color.White;
            this.updateTable.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTable.ForeColor = System.Drawing.Color.Gold;
            this.updateTable.Location = new System.Drawing.Point(366, 113);
            this.updateTable.Name = "updateTable";
            this.updateTable.Size = new System.Drawing.Size(129, 55);
            this.updateTable.TabIndex = 5;
            this.updateTable.Text = "Cập nhật";
            this.updateTable.UseVisualStyleBackColor = false;
            this.updateTable.Click += new System.EventHandler(this.updateTable_Click);
            // 
            // btnRemoveTable
            // 
            this.btnRemoveTable.BackColor = System.Drawing.Color.White;
            this.btnRemoveTable.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTable.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveTable.Location = new System.Drawing.Point(190, 113);
            this.btnRemoveTable.Name = "btnRemoveTable";
            this.btnRemoveTable.Size = new System.Drawing.Size(129, 55);
            this.btnRemoveTable.TabIndex = 4;
            this.btnRemoveTable.Text = "Xoá bàn";
            this.btnRemoveTable.UseVisualStyleBackColor = false;
            this.btnRemoveTable.Click += new System.EventHandler(this.btnRemoveTable_Click);
            // 
            // txbTableName
            // 
            this.txbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTableName.Location = new System.Drawing.Point(17, 62);
            this.txbTableName.Name = "txbTableName";
            this.txbTableName.Size = new System.Drawing.Size(478, 30);
            this.txbTableName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên bàn:";
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.White;
            this.btnAddTable.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAddTable.Location = new System.Drawing.Point(17, 113);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(129, 55);
            this.btnAddTable.TabIndex = 3;
            this.btnAddTable.Text = "Thêm bàn ";
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridViewTable);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 492);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Danh sách bàn ăn";
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(4, 65);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowHeadersWidth = 51;
            this.dataGridViewTable.RowTemplate.Height = 24;
            this.dataGridViewTable.Size = new System.Drawing.Size(347, 424);
            this.dataGridViewTable.TabIndex = 0;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.tcMangement);
            this.Name = "Management";
            this.Text = "Management";
            this.tabFood.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlGroupBtn.ResumeLayout(false);
            this.panelDataFood.ResumeLayout(false);
            this.panelDataFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).EndInit();
            this.tabFoodCategory.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodCategory)).EndInit();
            this.tcMangement.ResumeLayout(false);
            this.tabTable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabFood;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlGroupBtn;
        private System.Windows.Forms.Button btnRemoveFood;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panelDataFood;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewFood;
        private System.Windows.Forms.TabPage tabFoodCategory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCategoryName;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewFoodCategory;
        private System.Windows.Forms.TabControl tcMangement;
        private System.Windows.Forms.TabPage tabTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button updateTable;
        private System.Windows.Forms.Button btnRemoveTable;
        private System.Windows.Forms.TextBox txbTableName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Label label7;
    }
}