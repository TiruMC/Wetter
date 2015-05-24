namespace _20150_03_04_Wetter
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stationenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anzeigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wetterstationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturDarstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tBoxAusgabe = new System.Windows.Forms.RichTextBox();
            this.cmbWetterstationen = new System.Windows.Forms.ComboBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stationenToolStripMenuItem,
            this.wetterstationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stationenToolStripMenuItem
            // 
            this.stationenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.anzeigeToolStripMenuItem});
            this.stationenToolStripMenuItem.Name = "stationenToolStripMenuItem";
            this.stationenToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.stationenToolStripMenuItem.Text = "Stationen";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Öffnen";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // anzeigeToolStripMenuItem
            // 
            this.anzeigeToolStripMenuItem.Name = "anzeigeToolStripMenuItem";
            this.anzeigeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.anzeigeToolStripMenuItem.Text = "Anzeige";
            this.anzeigeToolStripMenuItem.Click += new System.EventHandler(this.anzeigeToolStripMenuItem_Click);
            // 
            // wetterstationToolStripMenuItem
            // 
            this.wetterstationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ladenToolStripMenuItem,
            this.temperaturDarstellenToolStripMenuItem});
            this.wetterstationToolStripMenuItem.Name = "wetterstationToolStripMenuItem";
            this.wetterstationToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.wetterstationToolStripMenuItem.Text = "Wetterstation";
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ladenToolStripMenuItem.Text = "Öffnen";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
            // 
            // temperaturDarstellenToolStripMenuItem
            // 
            this.temperaturDarstellenToolStripMenuItem.Name = "temperaturDarstellenToolStripMenuItem";
            this.temperaturDarstellenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.temperaturDarstellenToolStripMenuItem.Text = "Darstellen";
            this.temperaturDarstellenToolStripMenuItem.Click += new System.EventHandler(this.temperaturDarstellenToolStripMenuItem_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbBrowser.Location = new System.Drawing.Point(0, 0);
            this.wbBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(15, 16);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScrollBarsEnabled = false;
            this.wbBrowser.Size = new System.Drawing.Size(815, 675);
            this.wbBrowser.TabIndex = 1;
            this.wbBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.wbBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(10, 26);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tBoxAusgabe);
            this.splitContainer1.Panel1.Controls.Add(this.cmbWetterstationen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.wbBrowser);
            this.splitContainer1.Size = new System.Drawing.Size(1224, 675);
            this.splitContainer1.SplitterDistance = 406;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 3;
            // 
            // tBoxAusgabe
            // 
            this.tBoxAusgabe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxAusgabe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tBoxAusgabe.Location = new System.Drawing.Point(0, 26);
            this.tBoxAusgabe.Name = "tBoxAusgabe";
            this.tBoxAusgabe.Size = new System.Drawing.Size(406, 649);
            this.tBoxAusgabe.TabIndex = 4;
            this.tBoxAusgabe.Text = "";
            // 
            // cmbWetterstationen
            // 
            this.cmbWetterstationen.FormattingEnabled = true;
            this.cmbWetterstationen.Location = new System.Drawing.Point(2, 0);
            this.cmbWetterstationen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbWetterstationen.Name = "cmbWetterstationen";
            this.cmbWetterstationen.Size = new System.Drawing.Size(401, 21);
            this.cmbWetterstationen.TabIndex = 3;
            this.cmbWetterstationen.SelectedIndexChanged += new System.EventHandler(this.cmbWetterstationen_SelectedIndexChanged);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.InitialDirectory = "c:\\users\\daniel\\desktop";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 701);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wetter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stationenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anzeigeToolStripMenuItem;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbWetterstationen;
        private System.Windows.Forms.ToolStripMenuItem wetterstationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaturDarstellenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.RichTextBox tBoxAusgabe;
    }
}

