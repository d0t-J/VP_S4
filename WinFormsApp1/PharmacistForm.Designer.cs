namespace WinFormsApp1
{
    partial class PharmacistForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Panel_Parent = new Panel();
            Panel_LoginButton = new Panel();
            SplitPanel_Body = new SplitContainer();
            GroupBox_SearchBar = new GroupBox();
            TableLayout_Search = new TableLayoutPanel();
            DataGridView_Search = new DataGridView();
            TableLayout_SearchSection = new TableLayoutPanel();
            TextBox_Search = new TextBox();
            btn_Search = new Button();
            DropDown_Filter = new ComboBox();
            Panel_CartFooter = new Panel();
            Label_Total = new Label();
            btn_Sell = new Button();
            Panel_Cart = new Panel();
            TableLayout_CartItems = new TableLayoutPanel();
            Panel_ParentTeam = new Panel();
            TableLayout_TeamNames = new TableLayoutPanel();
            btn_Name3 = new Button();
            btn_Name2 = new Button();
            btn_Name1 = new Button();
            Panel_Header = new Panel();
            Label_Subtitle = new Label();
            Label_HeadTitle = new Label();
            Panel_Parent.SuspendLayout();
            Panel_LoginButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitPanel_Body).BeginInit();
            SplitPanel_Body.Panel1.SuspendLayout();
            SplitPanel_Body.Panel2.SuspendLayout();
            SplitPanel_Body.SuspendLayout();
            GroupBox_SearchBar.SuspendLayout();
            TableLayout_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Search).BeginInit();
            TableLayout_SearchSection.SuspendLayout();
            Panel_CartFooter.SuspendLayout();
            Panel_Cart.SuspendLayout();
            Panel_ParentTeam.SuspendLayout();
            TableLayout_TeamNames.SuspendLayout();
            Panel_Header.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_Parent
            // 
            Panel_Parent.BackColor = Color.WhiteSmoke;
            Panel_Parent.Controls.Add(Panel_LoginButton);
            Panel_Parent.Controls.Add(Panel_ParentTeam);
            Panel_Parent.Controls.Add(Panel_Header);
            Panel_Parent.Dock = DockStyle.Fill;
            Panel_Parent.Location = new Point(0, 0);
            Panel_Parent.Name = "Panel_Parent";
            Panel_Parent.Padding = new Padding(40, 10, 40, 20);
            Panel_Parent.Size = new Size(686, 406);
            Panel_Parent.TabIndex = 0;
            // 
            // Panel_LoginButton
            // 
            Panel_LoginButton.Controls.Add(SplitPanel_Body);
            Panel_LoginButton.Dock = DockStyle.Fill;
            Panel_LoginButton.Location = new Point(40, 87);
            Panel_LoginButton.Name = "Panel_LoginButton";
            Panel_LoginButton.Size = new Size(606, 238);
            Panel_LoginButton.TabIndex = 7;
            // 
            // SplitPanel_Body
            // 
            SplitPanel_Body.BackColor = Color.Gainsboro;
            SplitPanel_Body.Dock = DockStyle.Fill;
            SplitPanel_Body.Location = new Point(0, 0);
            SplitPanel_Body.Margin = new Padding(200);
            SplitPanel_Body.Name = "SplitPanel_Body";
            // 
            // SplitPanel_Body.Panel1
            // 
            SplitPanel_Body.Panel1.Controls.Add(GroupBox_SearchBar);
            SplitPanel_Body.Panel1.Padding = new Padding(15);
            // 
            // SplitPanel_Body.Panel2
            // 
            SplitPanel_Body.Panel2.Controls.Add(Panel_CartFooter);
            SplitPanel_Body.Panel2.Controls.Add(Panel_Cart);
            SplitPanel_Body.Panel2.Padding = new Padding(10);
            SplitPanel_Body.Size = new Size(606, 238);
            SplitPanel_Body.SplitterDistance = 404;
            SplitPanel_Body.TabIndex = 0;
            // 
            // GroupBox_SearchBar
            // 
            GroupBox_SearchBar.Controls.Add(TableLayout_Search);
            GroupBox_SearchBar.Controls.Add(TableLayout_SearchSection);
            GroupBox_SearchBar.Dock = DockStyle.Fill;
            GroupBox_SearchBar.Location = new Point(15, 15);
            GroupBox_SearchBar.Name = "GroupBox_SearchBar";
            GroupBox_SearchBar.Size = new Size(374, 208);
            GroupBox_SearchBar.TabIndex = 0;
            GroupBox_SearchBar.TabStop = false;
            GroupBox_SearchBar.Text = "Search Medicine";
            // 
            // TableLayout_Search
            // 
            TableLayout_Search.ColumnCount = 1;
            TableLayout_Search.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayout_Search.Controls.Add(DataGridView_Search, 0, 0);
            TableLayout_Search.Dock = DockStyle.Fill;
            TableLayout_Search.Location = new Point(3, 47);
            TableLayout_Search.Name = "TableLayout_Search";
            TableLayout_Search.RowCount = 1;
            TableLayout_Search.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayout_Search.Size = new Size(368, 158);
            TableLayout_Search.TabIndex = 1;
            // 
            // DataGridView_Search
            // 
            DataGridView_Search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Search.Dock = DockStyle.Fill;
            DataGridView_Search.Location = new Point(3, 3);
            DataGridView_Search.Name = "DataGridView_Search";
            DataGridView_Search.Size = new Size(362, 152);
            DataGridView_Search.TabIndex = 0;
            // 
            // TableLayout_SearchSection
            // 
            TableLayout_SearchSection.ColumnCount = 3;
            TableLayout_SearchSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.1259651F));
            TableLayout_SearchSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0514145F));
            TableLayout_SearchSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.5655518F));
            TableLayout_SearchSection.Controls.Add(TextBox_Search, 0, 0);
            TableLayout_SearchSection.Controls.Add(btn_Search, 2, 0);
            TableLayout_SearchSection.Controls.Add(DropDown_Filter, 1, 0);
            TableLayout_SearchSection.Dock = DockStyle.Top;
            TableLayout_SearchSection.Location = new Point(3, 19);
            TableLayout_SearchSection.Name = "TableLayout_SearchSection";
            TableLayout_SearchSection.RowCount = 1;
            TableLayout_SearchSection.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayout_SearchSection.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayout_SearchSection.Size = new Size(368, 28);
            TableLayout_SearchSection.TabIndex = 0;
            // 
            // TextBox_Search
            // 
            TextBox_Search.Dock = DockStyle.Fill;
            TextBox_Search.Location = new Point(3, 3);
            TextBox_Search.Name = "TextBox_Search";
            TextBox_Search.Size = new Size(212, 23);
            TextBox_Search.TabIndex = 0;
            TextBox_Search.Text = "Enter the name/category of medicine";
            // 
            // btn_Search
            // 
            btn_Search.Dock = DockStyle.Fill;
            btn_Search.Location = new Point(294, 3);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(71, 22);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            // 
            // DropDown_Filter
            // 
            DropDown_Filter.Dock = DockStyle.Fill;
            DropDown_Filter.DropDownStyle = ComboBoxStyle.DropDownList;
            DropDown_Filter.FormattingEnabled = true;
            DropDown_Filter.Location = new Point(221, 3);
            DropDown_Filter.Name = "DropDown_Filter";
            DropDown_Filter.Size = new Size(67, 23);
            DropDown_Filter.TabIndex = 3;
            // 
            // Panel_CartFooter
            // 
            Panel_CartFooter.BackColor = Color.Salmon;
            Panel_CartFooter.Controls.Add(Label_Total);
            Panel_CartFooter.Controls.Add(btn_Sell);
            Panel_CartFooter.Dock = DockStyle.Bottom;
            Panel_CartFooter.Location = new Point(10, 178);
            Panel_CartFooter.Margin = new Padding(10);
            Panel_CartFooter.Name = "Panel_CartFooter";
            Panel_CartFooter.Size = new Size(178, 50);
            Panel_CartFooter.TabIndex = 1;
            // 
            // Label_Total
            // 
            Label_Total.Location = new Point(0, 0);
            Label_Total.Name = "Label_Total";
            Label_Total.Size = new Size(94, 24);
            Label_Total.TabIndex = 0;
            Label_Total.Text = "Total: ";
            // 
            // btn_Sell
            // 
            btn_Sell.BackColor = Color.PaleGreen;
            btn_Sell.Dock = DockStyle.Bottom;
            btn_Sell.ForeColor = SystemColors.ActiveCaptionText;
            btn_Sell.Location = new Point(0, 27);
            btn_Sell.Name = "btn_Sell";
            btn_Sell.Size = new Size(178, 23);
            btn_Sell.TabIndex = 1;
            btn_Sell.Text = "Sell";
            btn_Sell.UseVisualStyleBackColor = false;
            // 
            // Panel_Cart
            // 
            Panel_Cart.AutoScroll = true;
            Panel_Cart.BackColor = Color.IndianRed;
            Panel_Cart.Controls.Add(TableLayout_CartItems);
            Panel_Cart.Dock = DockStyle.Fill;
            Panel_Cart.Location = new Point(10, 10);
            Panel_Cart.Margin = new Padding(10);
            Panel_Cart.Name = "Panel_Cart";
            Panel_Cart.Size = new Size(178, 218);
            Panel_Cart.TabIndex = 0;
            // 
            // TableLayout_CartItems
            // 
            TableLayout_CartItems.AutoSize = true;
            TableLayout_CartItems.ColumnCount = 1;
            TableLayout_CartItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayout_CartItems.Dock = DockStyle.Fill;
            TableLayout_CartItems.Location = new Point(0, 0);
            TableLayout_CartItems.Name = "TableLayout_CartItems";
            TableLayout_CartItems.RowCount = 2;
            TableLayout_CartItems.RowStyles.Add(new RowStyle(SizeType.Percent, 43.57798F));
            TableLayout_CartItems.RowStyles.Add(new RowStyle(SizeType.Percent, 56.42202F));
            TableLayout_CartItems.Size = new Size(178, 218);
            TableLayout_CartItems.TabIndex = 0;
            // 
            // Panel_ParentTeam
            // 
            Panel_ParentTeam.Controls.Add(TableLayout_TeamNames);
            Panel_ParentTeam.Dock = DockStyle.Bottom;
            Panel_ParentTeam.Location = new Point(40, 325);
            Panel_ParentTeam.Name = "Panel_ParentTeam";
            Panel_ParentTeam.Padding = new Padding(5, 5, 0, 5);
            Panel_ParentTeam.Size = new Size(606, 61);
            Panel_ParentTeam.TabIndex = 6;
            // 
            // TableLayout_TeamNames
            // 
            TableLayout_TeamNames.ColumnCount = 3;
            TableLayout_TeamNames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TableLayout_TeamNames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TableLayout_TeamNames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TableLayout_TeamNames.Controls.Add(btn_Name3, 2, 0);
            TableLayout_TeamNames.Controls.Add(btn_Name2, 1, 0);
            TableLayout_TeamNames.Controls.Add(btn_Name1, 0, 0);
            TableLayout_TeamNames.Dock = DockStyle.Fill;
            TableLayout_TeamNames.Location = new Point(5, 5);
            TableLayout_TeamNames.Name = "TableLayout_TeamNames";
            TableLayout_TeamNames.RowCount = 1;
            TableLayout_TeamNames.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayout_TeamNames.Size = new Size(601, 51);
            TableLayout_TeamNames.TabIndex = 0;
            // 
            // btn_Name3
            // 
            btn_Name3.BackColor = Color.SlateGray;
            btn_Name3.Dock = DockStyle.Fill;
            btn_Name3.Enabled = false;
            btn_Name3.Font = new Font("Segoe UI Emoji", 9.75F);
            btn_Name3.ForeColor = Color.White;
            btn_Name3.Location = new Point(403, 3);
            btn_Name3.Name = "btn_Name3";
            btn_Name3.Size = new Size(195, 45);
            btn_Name3.TabIndex = 3;
            btn_Name3.Text = "Tehreem Fatima\r\n2023-ag-9688\r\n";
            btn_Name3.UseVisualStyleBackColor = false;
            // 
            // btn_Name2
            // 
            btn_Name2.BackColor = Color.SlateGray;
            btn_Name2.Dock = DockStyle.Fill;
            btn_Name2.Enabled = false;
            btn_Name2.Font = new Font("Segoe UI Emoji", 9.75F);
            btn_Name2.ForeColor = Color.White;
            btn_Name2.Location = new Point(203, 3);
            btn_Name2.Name = "btn_Name2";
            btn_Name2.Size = new Size(194, 45);
            btn_Name2.TabIndex = 2;
            btn_Name2.Text = "Rukhsar Shahid\r\n2023-ag-9684";
            btn_Name2.UseVisualStyleBackColor = false;
            // 
            // btn_Name1
            // 
            btn_Name1.BackColor = Color.SlateGray;
            btn_Name1.Dock = DockStyle.Fill;
            btn_Name1.Enabled = false;
            btn_Name1.Font = new Font("Segoe UI Emoji", 9.75F);
            btn_Name1.ForeColor = Color.White;
            btn_Name1.Location = new Point(3, 3);
            btn_Name1.Name = "btn_Name1";
            btn_Name1.Size = new Size(194, 45);
            btn_Name1.TabIndex = 1;
            btn_Name1.Text = "Junaid Ahmad\r\n2023-ag-9557";
            btn_Name1.UseVisualStyleBackColor = false;
            // 
            // Panel_Header
            // 
            Panel_Header.AutoScroll = true;
            Panel_Header.AutoSize = true;
            Panel_Header.Controls.Add(Label_Subtitle);
            Panel_Header.Controls.Add(Label_HeadTitle);
            Panel_Header.Dock = DockStyle.Top;
            Panel_Header.Location = new Point(40, 10);
            Panel_Header.Margin = new Padding(5, 5, 5, 10);
            Panel_Header.Name = "Panel_Header";
            Panel_Header.Size = new Size(606, 77);
            Panel_Header.TabIndex = 0;
            // 
            // Label_Subtitle
            // 
            Label_Subtitle.BackColor = Color.FromArgb(44, 62, 80);
            Label_Subtitle.Dock = DockStyle.Top;
            Label_Subtitle.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            Label_Subtitle.ForeColor = Color.White;
            Label_Subtitle.Location = new Point(0, 46);
            Label_Subtitle.Name = "Label_Subtitle";
            Label_Subtitle.Size = new Size(606, 31);
            Label_Subtitle.TabIndex = 1;
            Label_Subtitle.Text = "Pharmacist View";
            Label_Subtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label_HeadTitle
            // 
            Label_HeadTitle.BackColor = Color.FromArgb(44, 62, 80);
            Label_HeadTitle.Dock = DockStyle.Top;
            Label_HeadTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Label_HeadTitle.ForeColor = SystemColors.ButtonHighlight;
            Label_HeadTitle.Location = new Point(0, 0);
            Label_HeadTitle.Name = "Label_HeadTitle";
            Label_HeadTitle.Padding = new Padding(0, 0, 0, 5);
            Label_HeadTitle.Size = new Size(606, 46);
            Label_HeadTitle.TabIndex = 0;
            Label_HeadTitle.Text = "PMS";
            Label_HeadTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PharmacistForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(686, 406);
            Controls.Add(Panel_Parent);
            Name = "PharmacistForm";
            Text = "PMS";
            Panel_Parent.ResumeLayout(false);
            Panel_Parent.PerformLayout();
            Panel_LoginButton.ResumeLayout(false);
            SplitPanel_Body.Panel1.ResumeLayout(false);
            SplitPanel_Body.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitPanel_Body).EndInit();
            SplitPanel_Body.ResumeLayout(false);
            GroupBox_SearchBar.ResumeLayout(false);
            TableLayout_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_Search).EndInit();
            TableLayout_SearchSection.ResumeLayout(false);
            TableLayout_SearchSection.PerformLayout();
            Panel_CartFooter.ResumeLayout(false);
            Panel_Cart.ResumeLayout(false);
            Panel_Cart.PerformLayout();
            Panel_ParentTeam.ResumeLayout(false);
            TableLayout_TeamNames.ResumeLayout(false);
            Panel_Header.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_Parent;
        private Panel Panel_Header;
        private Label Label_Subtitle;
        private Label Label_HeadTitle;
        private Panel Panel_ParentTeam;
        private Panel Panel_LoginButton;
        private Button btn_Name1;
        private Button btn_Name2;
        private Button btn_Name3;
        private TableLayoutPanel TableLayout_TeamNames;
        private SplitContainer SplitPanel_Body;
        private GroupBox GroupBox_SearchBar;
        private TableLayoutPanel TableLayout_SearchSection;
        private TextBox TextBox_Search;
        private Button btn_Search;
        private ComboBox DropDown_Filter;
        private TableLayoutPanel TableLayout_Search;
        private DataGridView DataGridView_Search;
        private Panel Panel_CartFooter;
        private Panel Panel_Cart;
        private TableLayoutPanel TableLayout_CartItems;
        private Button btn_Sell;
        private Label Label_Total;
    }
}
