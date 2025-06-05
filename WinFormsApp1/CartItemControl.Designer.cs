namespace WinFormsApp1
{
    partial class CartItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label_Name = new Label();
            Label_Category = new Label();
            Label_Qty = new Label();
            btn_Add = new Button();
            btn_Remove = new Button();
            btn_DeleteAll = new Button();
            TableLayout_Item = new TableLayoutPanel();
            Label_Subtotal = new Label();
            TableLayout_Item.SuspendLayout();
            SuspendLayout();
            // 
            // Label_Name
            // 
            Label_Name.AutoSize = true;
            Label_Name.Dock = DockStyle.Fill;
            Label_Name.Location = new Point(3, 0);
            Label_Name.Name = "Label_Name";
            Label_Name.Size = new Size(118, 31);
            Label_Name.TabIndex = 0;
            Label_Name.Text = "Name";
            Label_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label_Category
            // 
            Label_Category.AutoSize = true;
            Label_Category.Dock = DockStyle.Fill;
            Label_Category.Location = new Point(127, 0);
            Label_Category.Name = "Label_Category";
            Label_Category.Size = new Size(145, 31);
            Label_Category.TabIndex = 1;
            Label_Category.Text = "Category";
            Label_Category.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label_Qty
            // 
            Label_Qty.AutoSize = true;
            Label_Qty.Dock = DockStyle.Fill;
            Label_Qty.Location = new Point(310, 0);
            Label_Qty.Name = "Label_Qty";
            Label_Qty.Size = new Size(41, 31);
            Label_Qty.TabIndex = 2;
            Label_Qty.Text = "Qty";
            Label_Qty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(278, 3);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(26, 23);
            btn_Add.TabIndex = 3;
            btn_Add.Text = "➕";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Remove
            // 
            btn_Remove.Location = new Point(357, 3);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(26, 23);
            btn_Remove.TabIndex = 4;
            btn_Remove.Text = "➖";
            btn_Remove.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteAll
            // 
            btn_DeleteAll.Dock = DockStyle.Fill;
            btn_DeleteAll.Location = new Point(446, 3);
            btn_DeleteAll.Name = "btn_DeleteAll";
            btn_DeleteAll.Size = new Size(49, 25);
            btn_DeleteAll.TabIndex = 5;
            btn_DeleteAll.Text = "✖️";
            btn_DeleteAll.UseVisualStyleBackColor = true;
            // 
            // TableLayout_Item
            // 
            TableLayout_Item.ColumnCount = 7;
            TableLayout_Item.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.9116459F));
            TableLayout_Item.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.93574F));
            TableLayout_Item.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.19992161F));
            TableLayout_Item.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.599884F));
            TableLayout_Item.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.201001F));
            TableLayout_Item.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.9998589F));
            TableLayout_Item.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 53F));
            TableLayout_Item.Controls.Add(Label_Subtotal, 5, 0);
            TableLayout_Item.Controls.Add(Label_Name, 0, 0);
            TableLayout_Item.Controls.Add(Label_Category, 1, 0);
            TableLayout_Item.Controls.Add(btn_Remove, 4, 0);
            TableLayout_Item.Controls.Add(btn_Add, 2, 0);
            TableLayout_Item.Controls.Add(Label_Qty, 3, 0);
            TableLayout_Item.Controls.Add(btn_DeleteAll, 6, 0);
            TableLayout_Item.Dock = DockStyle.Fill;
            TableLayout_Item.Location = new Point(0, 0);
            TableLayout_Item.Name = "TableLayout_Item";
            TableLayout_Item.RowCount = 1;
            TableLayout_Item.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayout_Item.Size = new Size(498, 31);
            TableLayout_Item.TabIndex = 6;
            // 
            // Label_Subtotal
            // 
            Label_Subtotal.AutoSize = true;
            Label_Subtotal.Dock = DockStyle.Fill;
            Label_Subtotal.Location = new Point(389, 0);
            Label_Subtotal.Name = "Label_Subtotal";
            Label_Subtotal.Size = new Size(51, 31);
            Label_Subtotal.TabIndex = 6;
            Label_Subtotal.Text = "Subtotal";
            Label_Subtotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CartItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayout_Item);
            Name = "CartItemControl";
            Size = new Size(498, 31);
            TableLayout_Item.ResumeLayout(false);
            TableLayout_Item.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Label_Name;
        private Label Label_Category;
        private Label Label_Qty;
        private Button btn_Add;
        private Button btn_Remove;
        private Button btn_DeleteAll;
        private TableLayoutPanel TableLayout_Item;
        private Label Label_Subtotal;
    }
}
