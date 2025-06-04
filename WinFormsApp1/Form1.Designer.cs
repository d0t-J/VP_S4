namespace WinFormsApp1
{
    partial class Form1
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
            ParentContainer = new Panel();
            loginButtonPanel = new Panel();
            teamParentPanel = new Panel();
            teamNamesTablePanel = new TableLayoutPanel();
            btn_Name3 = new Button();
            btn_Name2 = new Button();
            btn_Name1 = new Button();
            headerPanel = new Panel();
            subtitleLabel = new Label();
            titleLabel = new Label();
            ParentContainer.SuspendLayout();
            teamParentPanel.SuspendLayout();
            teamNamesTablePanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ParentContainer
            // 
            ParentContainer.BackColor = Color.WhiteSmoke;
            ParentContainer.Controls.Add(loginButtonPanel);
            ParentContainer.Controls.Add(teamParentPanel);
            ParentContainer.Controls.Add(headerPanel);
            ParentContainer.Dock = DockStyle.Fill;
            ParentContainer.Location = new Point(0, 0);
            ParentContainer.Name = "ParentContainer";
            ParentContainer.Padding = new Padding(40, 10, 40, 20);
            ParentContainer.Size = new Size(686, 406);
            ParentContainer.TabIndex = 0;
            // 
            // loginButtonPanel
            // 
            loginButtonPanel.Dock = DockStyle.Fill;
            loginButtonPanel.Location = new Point(40, 87);
            loginButtonPanel.Name = "loginButtonPanel";
            loginButtonPanel.Size = new Size(606, 238);
            loginButtonPanel.TabIndex = 7;
            // 
            // teamParentPanel
            // 
            teamParentPanel.Controls.Add(teamNamesTablePanel);
            teamParentPanel.Dock = DockStyle.Bottom;
            teamParentPanel.Location = new Point(40, 325);
            teamParentPanel.Name = "teamParentPanel";
            teamParentPanel.Padding = new Padding(5, 5, 0, 5);
            teamParentPanel.Size = new Size(606, 61);
            teamParentPanel.TabIndex = 6;
            // 
            // teamNamesTablePanel
            // 
            teamNamesTablePanel.ColumnCount = 3;
            teamNamesTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            teamNamesTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            teamNamesTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            teamNamesTablePanel.Controls.Add(btn_Name3, 2, 0);
            teamNamesTablePanel.Controls.Add(btn_Name2, 1, 0);
            teamNamesTablePanel.Controls.Add(btn_Name1, 0, 0);
            teamNamesTablePanel.Dock = DockStyle.Fill;
            teamNamesTablePanel.Location = new Point(5, 5);
            teamNamesTablePanel.Name = "teamNamesTablePanel";
            teamNamesTablePanel.RowCount = 1;
            teamNamesTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            teamNamesTablePanel.Size = new Size(601, 51);
            teamNamesTablePanel.TabIndex = 0;
            // 
            // btn_Name3
            // 
            btn_Name3.BackColor = Color.SlateGray;
            btn_Name3.Dock = DockStyle.Fill;
            btn_Name3.Enabled = false;
            btn_Name3.Font = new Font("Segoe UI", 8.25F);
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

            btn_Name2.Font = new Font("Segoe UI", 8.25F);

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

            btn_Name1.Font = new Font("Segoe UI", 8.25F);

            btn_Name1.Font = new Font("Segoe UI Emoji", 9.75F);
            btn_Name1.ForeColor = Color.White;
            btn_Name1.Location = new Point(3, 3);
            btn_Name1.Name = "btn_Name1";
            btn_Name1.Size = new Size(194, 45);
            btn_Name1.TabIndex = 1;
            btn_Name1.Text = "Junaid Ahmad\r\n2023-ag-9557";
            btn_Name1.UseVisualStyleBackColor = false;
            // 
            // headerPanel
            // 
            headerPanel.AutoScroll = true;
            headerPanel.AutoSize = true;
            headerPanel.Controls.Add(subtitleLabel);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(40, 10);
            headerPanel.Margin = new Padding(5, 5, 5, 10);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(606, 77);
            headerPanel.TabIndex = 0;
            // 
            // subtitleLabel
            // 
            subtitleLabel.BackColor = Color.FromArgb(44, 62, 80);
            subtitleLabel.Dock = DockStyle.Top;
            subtitleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            subtitleLabel.ForeColor = Color.White;
            subtitleLabel.Location = new Point(0, 46);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(606, 31);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Pharmacist View";
            subtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.FromArgb(44, 62, 80);
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.ForeColor = SystemColors.ButtonHighlight;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Padding = new Padding(0, 0, 0, 5);
            titleLabel.Size = new Size(606, 46);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "PMS";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(686, 406);
            Controls.Add(ParentContainer);
            Name = "Form1";
            Text = "PMS";
            Load += Form1_Load;
            ParentContainer.ResumeLayout(false);
            ParentContainer.PerformLayout();
            teamParentPanel.ResumeLayout(false);
            teamNamesTablePanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ParentContainer;
        private Panel headerPanel;
        private Label subtitleLabel;
        private Label titleLabel;
        private Panel teamParentPanel;
        private Panel loginButtonPanel;
        private Button btn_Name1;
        private Button btn_Name2;
        private Button btn_Name3;
        private TableLayoutPanel teamNamesTablePanel;
    }
}
