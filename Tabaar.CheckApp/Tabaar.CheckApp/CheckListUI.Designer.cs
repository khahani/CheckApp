namespace Tabaar.CheckApp
{
    partial class CheckListUI
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
            this.Checks = new System.Windows.Forms.ListView();
            this.Counter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CheckDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deliverer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CheckStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.TextBox();
            this.Schools = new System.Windows.Forms.ComboBox();
            this.CheckMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FeatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCheckoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.SearchResultCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.CheckMenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Checks
            // 
            this.Checks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Checks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Counter,
            this.StudentName,
            this.Number,
            this.CheckDate,
            this.Amount,
            this.Bank,
            this.Deliverer,
            this.CheckStatus});
            this.Checks.FullRowSelect = true;
            this.Checks.Location = new System.Drawing.Point(0, 67);
            this.Checks.MultiSelect = false;
            this.Checks.Name = "Checks";
            this.Checks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Checks.RightToLeftLayout = true;
            this.Checks.Size = new System.Drawing.Size(754, 420);
            this.Checks.TabIndex = 1;
            this.Checks.UseCompatibleStateImageBehavior = false;
            this.Checks.View = System.Windows.Forms.View.Details;
            this.Checks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Checks_MouseDoubleClick);
            // 
            // Counter
            // 
            this.Counter.Text = "ردیف";
            this.Counter.Width = 40;
            // 
            // StudentName
            // 
            this.StudentName.Text = "نام دانش آموز";
            this.StudentName.Width = 120;
            // 
            // Number
            // 
            this.Number.Text = "شماره چک";
            this.Number.Width = 120;
            // 
            // CheckDate
            // 
            this.CheckDate.Text = "تاریخ چک";
            this.CheckDate.Width = 100;
            // 
            // Amount
            // 
            this.Amount.Text = "مبلغ (ریال)";
            this.Amount.Width = 100;
            // 
            // Bank
            // 
            this.Bank.Text = "بانک";
            this.Bank.Width = 100;
            // 
            // Deliverer
            // 
            this.Deliverer.Text = "تحویل گیرنده";
            this.Deliverer.Width = 100;
            // 
            // CheckStatus
            // 
            this.CheckStatus.Text = "وضعیت";
            this.CheckStatus.Width = 100;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "جستجو:";
            // 
            // Filter
            // 
            this.Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Filter.Location = new System.Drawing.Point(492, 40);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(202, 21);
            this.Filter.TabIndex = 3;
            this.Filter.TextChanged += new System.EventHandler(this.LoadChecks_OnFilterChanges);
            // 
            // Schools
            // 
            this.Schools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Schools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Schools.FormattingEnabled = true;
            this.Schools.Location = new System.Drawing.Point(323, 40);
            this.Schools.Name = "Schools";
            this.Schools.Size = new System.Drawing.Size(164, 21);
            this.Schools.TabIndex = 4;
            this.Schools.SelectedIndexChanged += new System.EventHandler(this.LoadChecks_OnFilterChanges);
            // 
            // CheckMenuStrip
            // 
            this.CheckMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FeatureToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.CheckMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CheckMenuStrip.Name = "CheckMenuStrip";
            this.CheckMenuStrip.Size = new System.Drawing.Size(754, 24);
            this.CheckMenuStrip.TabIndex = 5;
            this.CheckMenuStrip.Text = "menuStrip1";
            // 
            // FeatureToolStripMenuItem
            // 
            this.FeatureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCheckoolStripMenuItem,
            this.PrintToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FeatureToolStripMenuItem.Name = "FeatureToolStripMenuItem";
            this.FeatureToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.FeatureToolStripMenuItem.Text = "امکانات";
            // 
            // AddCheckoolStripMenuItem
            // 
            this.AddCheckoolStripMenuItem.Image = global::Tabaar.CheckApp.Properties.Resources.New;
            this.AddCheckoolStripMenuItem.Name = "AddCheckoolStripMenuItem";
            this.AddCheckoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.AddCheckoolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.AddCheckoolStripMenuItem.Text = "افزودن چک";
            this.AddCheckoolStripMenuItem.Click += new System.EventHandler(this.AddCheckToolStripMenuItem_Click);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Image = global::Tabaar.CheckApp.Properties.Resources.Print;
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.PrintToolStripMenuItem.Text = "چاپ رسید";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = global::Tabaar.CheckApp.Properties.Resources.Cancel;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ExitToolStripMenuItem.Text = "خروج";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.HelpToolStripMenuItem.Text = "راهنما";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Image = global::Tabaar.CheckApp.Properties.Resources.About;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.AboutToolStripMenuItem.Text = "درباره...";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchResultCounter});
            this.StatusStrip.Location = new System.Drawing.Point(0, 465);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(754, 22);
            this.StatusStrip.TabIndex = 6;
            // 
            // SearchResultCounter
            // 
            this.SearchResultCounter.Name = "SearchResultCounter";
            this.SearchResultCounter.Size = new System.Drawing.Size(0, 17);
            // 
            // CheckListUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 487);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.Schools);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Checks);
            this.Controls.Add(this.CheckMenuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainMenuStrip = this.CheckMenuStrip;
            this.Name = "CheckListUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "چک های برگشتی - 94-95";
            this.Load += new System.EventHandler(this.CheckListUI_Load);
            this.CheckMenuStrip.ResumeLayout(false);
            this.CheckMenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Checks;
        private System.Windows.Forms.ColumnHeader StudentName;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader CheckDate;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Bank;
        private System.Windows.Forms.ColumnHeader Deliverer;
        private System.Windows.Forms.ColumnHeader CheckStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Filter;
        private System.Windows.Forms.ComboBox Schools;
        private System.Windows.Forms.MenuStrip CheckMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FeatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCheckoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Counter;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel SearchResultCounter;

    }
}