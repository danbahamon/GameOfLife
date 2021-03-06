
namespace GameOfLife
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.millisecondsIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wrapAroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighborsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moldModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.PlayBtn = new System.Windows.Forms.ToolStripButton();
            this.PauseBtn = new System.Windows.Forms.ToolStripButton();
            this.NextBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.livingCells = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aliveColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoldModeText = new System.Windows.Forms.ToolStripStatusLabel();
            this.graphicsPanel1 = new GameOfLife.GraphicsPanel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(221, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomizeToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.randomizeToolStripMenuItem.Text = "Randomize";
            this.randomizeToolStripMenuItem.Click += new System.EventHandler(this.randomizeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomSeedToolStripMenuItem,
            this.millisecondsIntervalToolStripMenuItem,
            this.wrapAroundToolStripMenuItem,
            this.mapSizeToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.cellColorToolStripMenuItem,
            this.resetSettingsToolStripMenuItem,
            this.reloadSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // randomSeedToolStripMenuItem
            // 
            this.randomSeedToolStripMenuItem.Name = "randomSeedToolStripMenuItem";
            this.randomSeedToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.randomSeedToolStripMenuItem.Text = "Random Seed";
            this.randomSeedToolStripMenuItem.Click += new System.EventHandler(this.randomSeedToolStripMenuItem_Click);
            // 
            // millisecondsIntervalToolStripMenuItem
            // 
            this.millisecondsIntervalToolStripMenuItem.Name = "millisecondsIntervalToolStripMenuItem";
            this.millisecondsIntervalToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.millisecondsIntervalToolStripMenuItem.Text = "Milliseconds Interval";
            this.millisecondsIntervalToolStripMenuItem.Click += new System.EventHandler(this.millisecondsIntervalToolStripMenuItem_Click);
            // 
            // wrapAroundToolStripMenuItem
            // 
            this.wrapAroundToolStripMenuItem.Name = "wrapAroundToolStripMenuItem";
            this.wrapAroundToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.wrapAroundToolStripMenuItem.Text = "Wrap around";
            this.wrapAroundToolStripMenuItem.Click += new System.EventHandler(this.wrapAroundToolStripMenuItem_Click);
            // 
            // mapSizeToolStripMenuItem
            // 
            this.mapSizeToolStripMenuItem.Name = "mapSizeToolStripMenuItem";
            this.mapSizeToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.mapSizeToolStripMenuItem.Text = "Map Size";
            this.mapSizeToolStripMenuItem.Click += new System.EventHandler(this.mapSizeToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // cellColorToolStripMenuItem
            // 
            this.cellColorToolStripMenuItem.Name = "cellColorToolStripMenuItem";
            this.cellColorToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.cellColorToolStripMenuItem.Text = "Cell Color";
            this.cellColorToolStripMenuItem.Click += new System.EventHandler(this.cellColorToolStripMenuItem_Click);
            // 
            // resetSettingsToolStripMenuItem
            // 
            this.resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            this.resetSettingsToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.resetSettingsToolStripMenuItem.Text = "Reset Settings";
            this.resetSettingsToolStripMenuItem.Click += new System.EventHandler(this.resetSettingsToolStripMenuItem_Click);
            // 
            // reloadSettingsToolStripMenuItem
            // 
            this.reloadSettingsToolStripMenuItem.Name = "reloadSettingsToolStripMenuItem";
            this.reloadSettingsToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.reloadSettingsToolStripMenuItem.Text = "Reload Settings";
            this.reloadSettingsToolStripMenuItem.Click += new System.EventHandler(this.reloadSettingsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hUDToolStripMenuItem,
            this.neighborsToolStripMenuItem,
            this.gridToolStripMenuItem,
            this.moldModeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // hUDToolStripMenuItem
            // 
            this.hUDToolStripMenuItem.CheckOnClick = true;
            this.hUDToolStripMenuItem.Name = "hUDToolStripMenuItem";
            this.hUDToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.hUDToolStripMenuItem.Text = "HUD";
            this.hUDToolStripMenuItem.CheckedChanged += new System.EventHandler(this.hUDToolStripMenuItem_CheckedChanged);
            // 
            // neighborsToolStripMenuItem
            // 
            this.neighborsToolStripMenuItem.CheckOnClick = true;
            this.neighborsToolStripMenuItem.Name = "neighborsToolStripMenuItem";
            this.neighborsToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.neighborsToolStripMenuItem.Text = "Neighbors";
            this.neighborsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.neighborsToolStripMenuItem_CheckedChanged);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Checked = true;
            this.gridToolStripMenuItem.CheckOnClick = true;
            this.gridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.gridToolStripMenuItem.Text = "Grid";
            this.gridToolStripMenuItem.CheckedChanged += new System.EventHandler(this.gridToolStripMenuItem_CheckedChanged);
            // 
            // moldModeToolStripMenuItem
            // 
            this.moldModeToolStripMenuItem.CheckOnClick = true;
            this.moldModeToolStripMenuItem.Name = "moldModeToolStripMenuItem";
            this.moldModeToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.moldModeToolStripMenuItem.Text = "Mold Mode";
            this.moldModeToolStripMenuItem.CheckedChanged += new System.EventHandler(this.moldModeToolStripMenuItem_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator7,
            this.PlayBtn,
            this.PauseBtn,
            this.NextBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // PlayBtn
            // 
            this.PlayBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PlayBtn.Image = global::GameOfLife.Properties.Resources.PlayBtn2;
            this.PlayBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(29, 24);
            this.PlayBtn.Text = "Play";
            this.PlayBtn.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PauseBtn.Image = global::GameOfLife.Properties.Resources.PauseBtn;
            this.PauseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(29, 24);
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextBtn.Image = global::GameOfLife.Properties.Resources.NextBtn;
            this.NextBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(29, 24);
            this.NextBtn.Text = "Next Generation";
            this.NextBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations,
            this.livingCells,
            this.MoldModeText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(764, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(114, 20);
            this.toolStripStatusLabelGenerations.Text = "Generations = 0";
            // 
            // livingCells
            // 
            this.livingCells.Name = "livingCells";
            this.livingCells.Size = new System.Drawing.Size(109, 20);
            this.livingCells.Text = "Living Cells = 0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem1,
            this.aliveColorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 52);
            // 
            // backgroundColorToolStripMenuItem1
            // 
            this.backgroundColorToolStripMenuItem1.Name = "backgroundColorToolStripMenuItem1";
            this.backgroundColorToolStripMenuItem1.Size = new System.Drawing.Size(160, 24);
            this.backgroundColorToolStripMenuItem1.Text = "Toggle Grid";
            this.backgroundColorToolStripMenuItem1.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem1_Click);
            // 
            // aliveColorToolStripMenuItem
            // 
            this.aliveColorToolStripMenuItem.Name = "aliveColorToolStripMenuItem";
            this.aliveColorToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.aliveColorToolStripMenuItem.Text = "Toggle HUD";
            this.aliveColorToolStripMenuItem.Click += new System.EventHandler(this.aliveColorToolStripMenuItem_Click);
            // 
            // MoldModeText
            // 
            this.MoldModeText.Name = "MoldModeText";
            this.MoldModeText.Size = new System.Drawing.Size(28, 20);
            this.MoldModeText.Text = "off";
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.Color.White;
            this.graphicsPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 55);
            this.graphicsPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(764, 344);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 425);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
        private System.Windows.Forms.ToolStripButton NextBtn;
        private System.Windows.Forms.ToolStripButton PlayBtn;
        private System.Windows.Forms.ToolStripButton PauseBtn;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel livingCells;
        private System.Windows.Forms.ToolStripMenuItem millisecondsIntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wrapAroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neighborsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aliveColorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moldModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel MoldModeText;
    }
}

