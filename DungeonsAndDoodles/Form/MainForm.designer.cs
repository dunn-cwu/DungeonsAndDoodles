namespace DungeonsAndDoodles
{
    partial class MainForm
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.rightPanelSplitContainer = new System.Windows.Forms.SplitContainer();
            this.rightPanelTabControl = new System.Windows.Forms.TabControl();
            this.activeTokensTabPage = new System.Windows.Forms.TabPage();
            this.ActiveTokensPanel = new System.Windows.Forms.Panel();
            this.activeTokenFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.actTokRemoveBtn = new System.Windows.Forms.Button();
            this.actTokEditBtn = new System.Windows.Forms.Button();
            this.snapTokensToGridCheckbox = new System.Windows.Forms.CheckBox();
            this.actTokLocateBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.activeTokEnemyFilterCheck = new System.Windows.Forms.CheckBox();
            this.activeTokNonPlayerFilterCheck = new System.Windows.Forms.CheckBox();
            this.activeTokPlayerFilterCheck = new System.Windows.Forms.CheckBox();
            this.tokenLibraryTabPage = new System.Windows.Forms.TabPage();
            this.LibraryPanel = new System.Windows.Forms.Panel();
            this.ExportTokenButton = new System.Windows.Forms.Button();
            this.tokenLibList = new System.Windows.Forms.ListBox();
            this.TokenImportButton = new System.Windows.Forms.Button();
            this.newLibTokenBtn = new System.Windows.Forms.Button();
            this.editLibTokenBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.libEnemyFilterCheck = new System.Windows.Forms.CheckBox();
            this.libNonplayerFilterCheck = new System.Windows.Forms.CheckBox();
            this.libPlayerFilterCheck = new System.Windows.Forms.CheckBox();
            this.placeTokenOnMapBtn = new System.Windows.Forms.Button();
            this.mapTabPage = new System.Windows.Forms.TabPage();
            this.MapPanel = new System.Windows.Forms.Panel();
            this.loadMapBackgroundBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ToggleLineColorButton = new System.Windows.Forms.Button();
            this.shiftGridRightBtn = new System.Windows.Forms.Button();
            this.shiftGridLeftBtn = new System.Windows.Forms.Button();
            this.shiftGridDownBtn = new System.Windows.Forms.Button();
            this.shiftGridUpBtn = new System.Windows.Forms.Button();
            this.resetGridPosBtn = new System.Windows.Forms.Button();
            this.gridScaleSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.gridAlphaSlider = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.gridThicknessSlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.viewGroupBox = new System.Windows.Forms.GroupBox();
            this.resetViewBtn = new System.Windows.Forms.Button();
            this.centerViewBtn = new System.Windows.Forms.Button();
            this.zoomInBtn = new System.Windows.Forms.Button();
            this.zoomOutBtn = new System.Windows.Forms.Button();
            this.diceRollOutputLabel = new System.Windows.Forms.Label();
            this.rollDiceBtn = new System.Windows.Forms.Button();
            this.NumberOfSidesLabel = new System.Windows.Forms.Label();
            this.NumberOfDiceLabel = new System.Windows.Forms.Label();
            this.NumberOfSidesUpDown = new System.Windows.Forms.NumericUpDown();
            this.NumberOfDiceUpDown = new System.Windows.Forms.NumericUpDown();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testTokenListItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMapImageDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPanelSplitContainer)).BeginInit();
            this.rightPanelSplitContainer.Panel1.SuspendLayout();
            this.rightPanelSplitContainer.Panel2.SuspendLayout();
            this.rightPanelSplitContainer.SuspendLayout();
            this.rightPanelTabControl.SuspendLayout();
            this.activeTokensTabPage.SuspendLayout();
            this.ActiveTokensPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tokenLibraryTabPage.SuspendLayout();
            this.LibraryPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mapTabPage.SuspendLayout();
            this.MapPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridScaleSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlphaSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridThicknessSlider)).BeginInit();
            this.viewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfSidesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDiceUpDown)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSplitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.rightPanelSplitContainer);
            this.mainSplitContainer.Panel2MinSize = 340;
            this.mainSplitContainer.Size = new System.Drawing.Size(797, 566);
            this.mainSplitContainer.SplitterDistance = 446;
            this.mainSplitContainer.SplitterWidth = 6;
            this.mainSplitContainer.TabIndex = 1;
            this.mainSplitContainer.TabStop = false;
            this.mainSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.mainSplitContainer_SplitterMoved);
            this.mainSplitContainer.DoubleClick += new System.EventHandler(this.mainSplitContainer_DoubleClick);
            // 
            // rightPanelSplitContainer
            // 
            this.rightPanelSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanelSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.rightPanelSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.rightPanelSplitContainer.Name = "rightPanelSplitContainer";
            this.rightPanelSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // rightPanelSplitContainer.Panel1
            // 
            this.rightPanelSplitContainer.Panel1.Controls.Add(this.rightPanelTabControl);
            // 
            // rightPanelSplitContainer.Panel2
            // 
            this.rightPanelSplitContainer.Panel2.Controls.Add(this.diceRollOutputLabel);
            this.rightPanelSplitContainer.Panel2.Controls.Add(this.rollDiceBtn);
            this.rightPanelSplitContainer.Panel2.Controls.Add(this.NumberOfSidesLabel);
            this.rightPanelSplitContainer.Panel2.Controls.Add(this.NumberOfDiceLabel);
            this.rightPanelSplitContainer.Panel2.Controls.Add(this.NumberOfSidesUpDown);
            this.rightPanelSplitContainer.Panel2.Controls.Add(this.NumberOfDiceUpDown);
            this.rightPanelSplitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rightPanelSplitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanelSplitContainer_Panel2_Paint);
            this.rightPanelSplitContainer.Size = new System.Drawing.Size(343, 564);
            this.rightPanelSplitContainer.SplitterDistance = 440;
            this.rightPanelSplitContainer.TabIndex = 0;
            // 
            // rightPanelTabControl
            // 
            this.rightPanelTabControl.Controls.Add(this.activeTokensTabPage);
            this.rightPanelTabControl.Controls.Add(this.tokenLibraryTabPage);
            this.rightPanelTabControl.Controls.Add(this.mapTabPage);
            this.rightPanelTabControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rightPanelTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanelTabControl.Location = new System.Drawing.Point(0, 0);
            this.rightPanelTabControl.Name = "rightPanelTabControl";
            this.rightPanelTabControl.SelectedIndex = 0;
            this.rightPanelTabControl.Size = new System.Drawing.Size(343, 440);
            this.rightPanelTabControl.TabIndex = 0;
            // 
            // activeTokensTabPage
            // 
            this.activeTokensTabPage.Controls.Add(this.ActiveTokensPanel);
            this.activeTokensTabPage.Location = new System.Drawing.Point(4, 22);
            this.activeTokensTabPage.Name = "activeTokensTabPage";
            this.activeTokensTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.activeTokensTabPage.Size = new System.Drawing.Size(335, 414);
            this.activeTokensTabPage.TabIndex = 0;
            this.activeTokensTabPage.Text = "Active Tokens";
            this.activeTokensTabPage.UseVisualStyleBackColor = true;
            // 
            // ActiveTokensPanel
            // 
            this.ActiveTokensPanel.AutoScroll = true;
            this.ActiveTokensPanel.Controls.Add(this.activeTokenFlowPanel);
            this.ActiveTokensPanel.Controls.Add(this.actTokRemoveBtn);
            this.ActiveTokensPanel.Controls.Add(this.actTokEditBtn);
            this.ActiveTokensPanel.Controls.Add(this.snapTokensToGridCheckbox);
            this.ActiveTokensPanel.Controls.Add(this.actTokLocateBtn);
            this.ActiveTokensPanel.Controls.Add(this.groupBox3);
            this.ActiveTokensPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveTokensPanel.Location = new System.Drawing.Point(3, 3);
            this.ActiveTokensPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ActiveTokensPanel.Name = "ActiveTokensPanel";
            this.ActiveTokensPanel.Size = new System.Drawing.Size(329, 408);
            this.ActiveTokensPanel.TabIndex = 0;
            // 
            // activeTokenFlowPanel
            // 
            this.activeTokenFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeTokenFlowPanel.AutoScroll = true;
            this.activeTokenFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activeTokenFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.activeTokenFlowPanel.Location = new System.Drawing.Point(13, 82);
            this.activeTokenFlowPanel.Name = "activeTokenFlowPanel";
            this.activeTokenFlowPanel.Size = new System.Drawing.Size(310, 268);
            this.activeTokenFlowPanel.TabIndex = 7;
            this.activeTokenFlowPanel.WrapContents = false;
            // 
            // actTokRemoveBtn
            // 
            this.actTokRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.actTokRemoveBtn.Location = new System.Drawing.Point(170, 356);
            this.actTokRemoveBtn.Name = "actTokRemoveBtn";
            this.actTokRemoveBtn.Size = new System.Drawing.Size(64, 23);
            this.actTokRemoveBtn.TabIndex = 6;
            this.actTokRemoveBtn.Text = "Remove";
            this.actTokRemoveBtn.UseVisualStyleBackColor = true;
            this.actTokRemoveBtn.Click += new System.EventHandler(this.actTokRemoveBtn_Click);
            // 
            // actTokEditBtn
            // 
            this.actTokEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.actTokEditBtn.Location = new System.Drawing.Point(98, 356);
            this.actTokEditBtn.Name = "actTokEditBtn";
            this.actTokEditBtn.Size = new System.Drawing.Size(64, 23);
            this.actTokEditBtn.TabIndex = 5;
            this.actTokEditBtn.Text = "Edit ...";
            this.actTokEditBtn.UseVisualStyleBackColor = true;
            // 
            // snapTokensToGridCheckbox
            // 
            this.snapTokensToGridCheckbox.AutoSize = true;
            this.snapTokensToGridCheckbox.Location = new System.Drawing.Point(16, 6);
            this.snapTokensToGridCheckbox.Name = "snapTokensToGridCheckbox";
            this.snapTokensToGridCheckbox.Size = new System.Drawing.Size(124, 17);
            this.snapTokensToGridCheckbox.TabIndex = 0;
            this.snapTokensToGridCheckbox.Text = "Snap Tokens to Grid";
            this.snapTokensToGridCheckbox.UseVisualStyleBackColor = true;
            this.snapTokensToGridCheckbox.CheckedChanged += new System.EventHandler(this.snapTokensToGridCheckbox_CheckedChanged);
            // 
            // actTokLocateBtn
            // 
            this.actTokLocateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.actTokLocateBtn.Location = new System.Drawing.Point(29, 356);
            this.actTokLocateBtn.Name = "actTokLocateBtn";
            this.actTokLocateBtn.Size = new System.Drawing.Size(64, 23);
            this.actTokLocateBtn.TabIndex = 4;
            this.actTokLocateBtn.Text = "Locate";
            this.actTokLocateBtn.UseVisualStyleBackColor = true;
            this.actTokLocateBtn.Click += new System.EventHandler(this.actTokLocateBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.activeTokEnemyFilterCheck);
            this.groupBox3.Controls.Add(this.activeTokNonPlayerFilterCheck);
            this.groupBox3.Controls.Add(this.activeTokPlayerFilterCheck);
            this.groupBox3.Location = new System.Drawing.Point(14, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 47);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter";
            // 
            // activeTokEnemyFilterCheck
            // 
            this.activeTokEnemyFilterCheck.AutoSize = true;
            this.activeTokEnemyFilterCheck.Checked = true;
            this.activeTokEnemyFilterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeTokEnemyFilterCheck.Location = new System.Drawing.Point(60, 19);
            this.activeTokEnemyFilterCheck.Name = "activeTokEnemyFilterCheck";
            this.activeTokEnemyFilterCheck.Size = new System.Drawing.Size(58, 17);
            this.activeTokEnemyFilterCheck.TabIndex = 2;
            this.activeTokEnemyFilterCheck.Text = "Enemy";
            this.activeTokEnemyFilterCheck.UseVisualStyleBackColor = true;
            this.activeTokEnemyFilterCheck.CheckedChanged += new System.EventHandler(this.activeTokEnemyFilterCheck_CheckedChanged);
            // 
            // activeTokNonPlayerFilterCheck
            // 
            this.activeTokNonPlayerFilterCheck.AutoSize = true;
            this.activeTokNonPlayerFilterCheck.Checked = true;
            this.activeTokNonPlayerFilterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeTokNonPlayerFilterCheck.Location = new System.Drawing.Point(121, 19);
            this.activeTokNonPlayerFilterCheck.Name = "activeTokNonPlayerFilterCheck";
            this.activeTokNonPlayerFilterCheck.Size = new System.Drawing.Size(77, 17);
            this.activeTokNonPlayerFilterCheck.TabIndex = 1;
            this.activeTokNonPlayerFilterCheck.Text = "Non-player";
            this.activeTokNonPlayerFilterCheck.UseVisualStyleBackColor = true;
            this.activeTokNonPlayerFilterCheck.CheckedChanged += new System.EventHandler(this.activeTokNonPlayerFilterCheck_CheckedChanged);
            // 
            // activeTokPlayerFilterCheck
            // 
            this.activeTokPlayerFilterCheck.AutoSize = true;
            this.activeTokPlayerFilterCheck.Checked = true;
            this.activeTokPlayerFilterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeTokPlayerFilterCheck.Location = new System.Drawing.Point(6, 19);
            this.activeTokPlayerFilterCheck.Name = "activeTokPlayerFilterCheck";
            this.activeTokPlayerFilterCheck.Size = new System.Drawing.Size(55, 17);
            this.activeTokPlayerFilterCheck.TabIndex = 0;
            this.activeTokPlayerFilterCheck.Text = "Player";
            this.activeTokPlayerFilterCheck.UseVisualStyleBackColor = true;
            this.activeTokPlayerFilterCheck.CheckedChanged += new System.EventHandler(this.activeTokPlayerFilterCheck_CheckedChanged);
            // 
            // tokenLibraryTabPage
            // 
            this.tokenLibraryTabPage.Controls.Add(this.LibraryPanel);
            this.tokenLibraryTabPage.Location = new System.Drawing.Point(4, 22);
            this.tokenLibraryTabPage.Name = "tokenLibraryTabPage";
            this.tokenLibraryTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tokenLibraryTabPage.Size = new System.Drawing.Size(335, 414);
            this.tokenLibraryTabPage.TabIndex = 1;
            this.tokenLibraryTabPage.Text = "Token Library";
            this.tokenLibraryTabPage.UseVisualStyleBackColor = true;
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.AutoScroll = true;
            this.LibraryPanel.Controls.Add(this.ExportTokenButton);
            this.LibraryPanel.Controls.Add(this.tokenLibList);
            this.LibraryPanel.Controls.Add(this.TokenImportButton);
            this.LibraryPanel.Controls.Add(this.newLibTokenBtn);
            this.LibraryPanel.Controls.Add(this.editLibTokenBtn);
            this.LibraryPanel.Controls.Add(this.groupBox2);
            this.LibraryPanel.Controls.Add(this.placeTokenOnMapBtn);
            this.LibraryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibraryPanel.Location = new System.Drawing.Point(3, 3);
            this.LibraryPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Size = new System.Drawing.Size(329, 408);
            this.LibraryPanel.TabIndex = 0;
            // 
            // ExportTokenButton
            // 
            this.ExportTokenButton.Location = new System.Drawing.Point(114, 374);
            this.ExportTokenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExportTokenButton.Name = "ExportTokenButton";
            this.ExportTokenButton.Size = new System.Drawing.Size(97, 23);
            this.ExportTokenButton.TabIndex = 10;
            this.ExportTokenButton.Text = "Export Token";
            this.ExportTokenButton.UseVisualStyleBackColor = true;
            // 
            // tokenLibList
            // 
            this.tokenLibList.FormattingEnabled = true;
            this.tokenLibList.Location = new System.Drawing.Point(7, 62);
            this.tokenLibList.Name = "tokenLibList";
            this.tokenLibList.Size = new System.Drawing.Size(204, 277);
            this.tokenLibList.TabIndex = 2;
            this.tokenLibList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tokenLibList_KeyDown);
            this.tokenLibList.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tokenLibList_PreviewKeyDown);
            // 
            // TokenImportButton
            // 
            this.TokenImportButton.Location = new System.Drawing.Point(7, 374);
            this.TokenImportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TokenImportButton.Name = "TokenImportButton";
            this.TokenImportButton.Size = new System.Drawing.Size(92, 23);
            this.TokenImportButton.TabIndex = 9;
            this.TokenImportButton.Text = "Import Token";
            this.TokenImportButton.UseVisualStyleBackColor = true;
            // 
            // newLibTokenBtn
            // 
            this.newLibTokenBtn.Location = new System.Drawing.Point(147, 346);
            this.newLibTokenBtn.Name = "newLibTokenBtn";
            this.newLibTokenBtn.Size = new System.Drawing.Size(64, 23);
            this.newLibTokenBtn.TabIndex = 0;
            this.newLibTokenBtn.Text = "New ...";
            this.newLibTokenBtn.UseVisualStyleBackColor = true;
            this.newLibTokenBtn.Click += new System.EventHandler(this.newTokenBtn_Click);
            // 
            // editLibTokenBtn
            // 
            this.editLibTokenBtn.Location = new System.Drawing.Point(77, 346);
            this.editLibTokenBtn.Name = "editLibTokenBtn";
            this.editLibTokenBtn.Size = new System.Drawing.Size(64, 23);
            this.editLibTokenBtn.TabIndex = 4;
            this.editLibTokenBtn.Text = "Edit ...";
            this.editLibTokenBtn.UseVisualStyleBackColor = true;
            this.editLibTokenBtn.Click += new System.EventHandler(this.editLibTokenBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.libEnemyFilterCheck);
            this.groupBox2.Controls.Add(this.libNonplayerFilterCheck);
            this.groupBox2.Controls.Add(this.libPlayerFilterCheck);
            this.groupBox2.Location = new System.Drawing.Point(7, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // libEnemyFilterCheck
            // 
            this.libEnemyFilterCheck.AutoSize = true;
            this.libEnemyFilterCheck.Checked = true;
            this.libEnemyFilterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.libEnemyFilterCheck.Location = new System.Drawing.Point(61, 19);
            this.libEnemyFilterCheck.Name = "libEnemyFilterCheck";
            this.libEnemyFilterCheck.Size = new System.Drawing.Size(58, 17);
            this.libEnemyFilterCheck.TabIndex = 2;
            this.libEnemyFilterCheck.Text = "Enemy";
            this.libEnemyFilterCheck.UseVisualStyleBackColor = true;
            this.libEnemyFilterCheck.CheckedChanged += new System.EventHandler(this.libEnemyFilterCheck_CheckedChanged);
            // 
            // libNonplayerFilterCheck
            // 
            this.libNonplayerFilterCheck.AutoSize = true;
            this.libNonplayerFilterCheck.Checked = true;
            this.libNonplayerFilterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.libNonplayerFilterCheck.Location = new System.Drawing.Point(121, 19);
            this.libNonplayerFilterCheck.Name = "libNonplayerFilterCheck";
            this.libNonplayerFilterCheck.Size = new System.Drawing.Size(77, 17);
            this.libNonplayerFilterCheck.TabIndex = 1;
            this.libNonplayerFilterCheck.Text = "Non-player";
            this.libNonplayerFilterCheck.UseVisualStyleBackColor = true;
            this.libNonplayerFilterCheck.CheckedChanged += new System.EventHandler(this.libNonplayerFilterCheck_CheckedChanged);
            // 
            // libPlayerFilterCheck
            // 
            this.libPlayerFilterCheck.AutoSize = true;
            this.libPlayerFilterCheck.Checked = true;
            this.libPlayerFilterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.libPlayerFilterCheck.Location = new System.Drawing.Point(6, 19);
            this.libPlayerFilterCheck.Name = "libPlayerFilterCheck";
            this.libPlayerFilterCheck.Size = new System.Drawing.Size(55, 17);
            this.libPlayerFilterCheck.TabIndex = 0;
            this.libPlayerFilterCheck.Text = "Player";
            this.libPlayerFilterCheck.UseVisualStyleBackColor = true;
            this.libPlayerFilterCheck.CheckedChanged += new System.EventHandler(this.libPlayerFilterCheck_CheckedChanged);
            // 
            // placeTokenOnMapBtn
            // 
            this.placeTokenOnMapBtn.Location = new System.Drawing.Point(7, 346);
            this.placeTokenOnMapBtn.Name = "placeTokenOnMapBtn";
            this.placeTokenOnMapBtn.Size = new System.Drawing.Size(64, 23);
            this.placeTokenOnMapBtn.TabIndex = 3;
            this.placeTokenOnMapBtn.Text = "<- Place";
            this.placeTokenOnMapBtn.UseVisualStyleBackColor = true;
            this.placeTokenOnMapBtn.Click += new System.EventHandler(this.placeTokenOnMapBtn_Click);
            // 
            // mapTabPage
            // 
            this.mapTabPage.Controls.Add(this.MapPanel);
            this.mapTabPage.Location = new System.Drawing.Point(4, 22);
            this.mapTabPage.Name = "mapTabPage";
            this.mapTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.mapTabPage.Size = new System.Drawing.Size(335, 414);
            this.mapTabPage.TabIndex = 2;
            this.mapTabPage.Text = "Map";
            this.mapTabPage.UseVisualStyleBackColor = true;
            // 
            // MapPanel
            // 
            this.MapPanel.AutoScroll = true;
            this.MapPanel.Controls.Add(this.loadMapBackgroundBtn);
            this.MapPanel.Controls.Add(this.groupBox1);
            this.MapPanel.Controls.Add(this.viewGroupBox);
            this.MapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapPanel.Location = new System.Drawing.Point(3, 3);
            this.MapPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MapPanel.Name = "MapPanel";
            this.MapPanel.Size = new System.Drawing.Size(329, 408);
            this.MapPanel.TabIndex = 0;
            // 
            // loadMapBackgroundBtn
            // 
            this.loadMapBackgroundBtn.Location = new System.Drawing.Point(6, 11);
            this.loadMapBackgroundBtn.Name = "loadMapBackgroundBtn";
            this.loadMapBackgroundBtn.Size = new System.Drawing.Size(195, 26);
            this.loadMapBackgroundBtn.TabIndex = 0;
            this.loadMapBackgroundBtn.Text = "Load Map Background";
            this.loadMapBackgroundBtn.UseVisualStyleBackColor = true;
            this.loadMapBackgroundBtn.Click += new System.EventHandler(this.loadMapBackgroundBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ToggleLineColorButton);
            this.groupBox1.Controls.Add(this.shiftGridRightBtn);
            this.groupBox1.Controls.Add(this.shiftGridLeftBtn);
            this.groupBox1.Controls.Add(this.shiftGridDownBtn);
            this.groupBox1.Controls.Add(this.shiftGridUpBtn);
            this.groupBox1.Controls.Add(this.resetGridPosBtn);
            this.groupBox1.Controls.Add(this.gridScaleSlider);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gridAlphaSlider);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gridThicknessSlider);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 323);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grid Settings";
            // 
            // ToggleLineColorButton
            // 
            this.ToggleLineColorButton.Location = new System.Drawing.Point(9, 279);
            this.ToggleLineColorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToggleLineColorButton.Name = "ToggleLineColorButton";
            this.ToggleLineColorButton.Size = new System.Drawing.Size(120, 23);
            this.ToggleLineColorButton.TabIndex = 19;
            this.ToggleLineColorButton.Text = "Toggle Line Color";
            this.ToggleLineColorButton.UseVisualStyleBackColor = true;
            this.ToggleLineColorButton.Click += new System.EventHandler(this.ToggleLineColorButton_Click);
            // 
            // shiftGridRightBtn
            // 
            this.shiftGridRightBtn.Location = new System.Drawing.Point(118, 52);
            this.shiftGridRightBtn.Name = "shiftGridRightBtn";
            this.shiftGridRightBtn.Size = new System.Drawing.Size(30, 30);
            this.shiftGridRightBtn.TabIndex = 19;
            this.shiftGridRightBtn.Text = "->";
            this.shiftGridRightBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.shiftGridRightBtn.UseVisualStyleBackColor = true;
            this.shiftGridRightBtn.Click += new System.EventHandler(this.shiftGridRightBtn_Click);
            // 
            // shiftGridLeftBtn
            // 
            this.shiftGridLeftBtn.Location = new System.Drawing.Point(46, 52);
            this.shiftGridLeftBtn.Name = "shiftGridLeftBtn";
            this.shiftGridLeftBtn.Size = new System.Drawing.Size(30, 30);
            this.shiftGridLeftBtn.TabIndex = 15;
            this.shiftGridLeftBtn.Text = "<-";
            this.shiftGridLeftBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shiftGridLeftBtn.UseVisualStyleBackColor = true;
            this.shiftGridLeftBtn.Click += new System.EventHandler(this.shiftGridLeftBtn_Click);
            // 
            // shiftGridDownBtn
            // 
            this.shiftGridDownBtn.Location = new System.Drawing.Point(82, 88);
            this.shiftGridDownBtn.Name = "shiftGridDownBtn";
            this.shiftGridDownBtn.Size = new System.Drawing.Size(30, 30);
            this.shiftGridDownBtn.TabIndex = 17;
            this.shiftGridDownBtn.Text = "\\/";
            this.shiftGridDownBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.shiftGridDownBtn.UseVisualStyleBackColor = true;
            this.shiftGridDownBtn.Click += new System.EventHandler(this.shiftGridDownBtn_Click);
            // 
            // shiftGridUpBtn
            // 
            this.shiftGridUpBtn.Location = new System.Drawing.Point(82, 16);
            this.shiftGridUpBtn.Name = "shiftGridUpBtn";
            this.shiftGridUpBtn.Size = new System.Drawing.Size(30, 30);
            this.shiftGridUpBtn.TabIndex = 16;
            this.shiftGridUpBtn.Text = "/\\";
            this.shiftGridUpBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.shiftGridUpBtn.UseVisualStyleBackColor = true;
            this.shiftGridUpBtn.Click += new System.EventHandler(this.shiftGridUpBtn_Click);
            // 
            // resetGridPosBtn
            // 
            this.resetGridPosBtn.Location = new System.Drawing.Point(82, 52);
            this.resetGridPosBtn.Name = "resetGridPosBtn";
            this.resetGridPosBtn.Size = new System.Drawing.Size(30, 30);
            this.resetGridPosBtn.TabIndex = 15;
            this.resetGridPosBtn.Text = "-";
            this.resetGridPosBtn.UseVisualStyleBackColor = true;
            this.resetGridPosBtn.Click += new System.EventHandler(this.resetGridPosBtn_Click);
            // 
            // gridScaleSlider
            // 
            this.gridScaleSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridScaleSlider.AutoSize = false;
            this.gridScaleSlider.Location = new System.Drawing.Point(9, 242);
            this.gridScaleSlider.Minimum = 2;
            this.gridScaleSlider.Name = "gridScaleSlider";
            this.gridScaleSlider.Size = new System.Drawing.Size(198, 32);
            this.gridScaleSlider.TabIndex = 7;
            this.gridScaleSlider.Value = 2;
            this.gridScaleSlider.Scroll += new System.EventHandler(this.gridScaleSlider_Scroll);
            this.gridScaleSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridScaleSlider_MouseDown);
            this.gridScaleSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridScaleSlider_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Grid/Token Scale";
            // 
            // gridAlphaSlider
            // 
            this.gridAlphaSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAlphaSlider.AutoSize = false;
            this.gridAlphaSlider.Location = new System.Drawing.Point(9, 188);
            this.gridAlphaSlider.Maximum = 255;
            this.gridAlphaSlider.Name = "gridAlphaSlider";
            this.gridAlphaSlider.Size = new System.Drawing.Size(198, 31);
            this.gridAlphaSlider.TabIndex = 9;
            this.gridAlphaSlider.Scroll += new System.EventHandler(this.gridAlphaSlider_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Line Transparency";
            // 
            // gridThicknessSlider
            // 
            this.gridThicknessSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridThicknessSlider.AutoSize = false;
            this.gridThicknessSlider.Location = new System.Drawing.Point(9, 137);
            this.gridThicknessSlider.Maximum = 6;
            this.gridThicknessSlider.Minimum = 1;
            this.gridThicknessSlider.Name = "gridThicknessSlider";
            this.gridThicknessSlider.Size = new System.Drawing.Size(198, 32);
            this.gridThicknessSlider.TabIndex = 11;
            this.gridThicknessSlider.Value = 1;
            this.gridThicknessSlider.Scroll += new System.EventHandler(this.gridThicknessSlider_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Line Thickness";
            // 
            // viewGroupBox
            // 
            this.viewGroupBox.AutoSize = true;
            this.viewGroupBox.Controls.Add(this.resetViewBtn);
            this.viewGroupBox.Controls.Add(this.centerViewBtn);
            this.viewGroupBox.Controls.Add(this.zoomInBtn);
            this.viewGroupBox.Controls.Add(this.zoomOutBtn);
            this.viewGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewGroupBox.Location = new System.Drawing.Point(6, 45);
            this.viewGroupBox.Name = "viewGroupBox";
            this.viewGroupBox.Size = new System.Drawing.Size(221, 92);
            this.viewGroupBox.TabIndex = 17;
            this.viewGroupBox.TabStop = false;
            this.viewGroupBox.Text = "View Settings";
            this.viewGroupBox.Enter += new System.EventHandler(this.viewGroupBox_Enter);
            // 
            // resetViewBtn
            // 
            this.resetViewBtn.Location = new System.Drawing.Point(110, 48);
            this.resetViewBtn.Name = "resetViewBtn";
            this.resetViewBtn.Size = new System.Drawing.Size(85, 23);
            this.resetViewBtn.TabIndex = 4;
            this.resetViewBtn.Text = "Reset";
            this.resetViewBtn.UseVisualStyleBackColor = true;
            this.resetViewBtn.Click += new System.EventHandler(this.resetViewBtn_Click);
            // 
            // centerViewBtn
            // 
            this.centerViewBtn.Location = new System.Drawing.Point(110, 19);
            this.centerViewBtn.Name = "centerViewBtn";
            this.centerViewBtn.Size = new System.Drawing.Size(85, 23);
            this.centerViewBtn.TabIndex = 3;
            this.centerViewBtn.Text = "Center";
            this.centerViewBtn.UseVisualStyleBackColor = true;
            this.centerViewBtn.Click += new System.EventHandler(this.centerViewBtn_Click);
            // 
            // zoomInBtn
            // 
            this.zoomInBtn.Location = new System.Drawing.Point(6, 19);
            this.zoomInBtn.Name = "zoomInBtn";
            this.zoomInBtn.Size = new System.Drawing.Size(85, 23);
            this.zoomInBtn.TabIndex = 1;
            this.zoomInBtn.Text = "Zoom In";
            this.zoomInBtn.UseVisualStyleBackColor = true;
            this.zoomInBtn.Click += new System.EventHandler(this.zoomInBtn_Click);
            // 
            // zoomOutBtn
            // 
            this.zoomOutBtn.Location = new System.Drawing.Point(6, 48);
            this.zoomOutBtn.Name = "zoomOutBtn";
            this.zoomOutBtn.Size = new System.Drawing.Size(85, 23);
            this.zoomOutBtn.TabIndex = 2;
            this.zoomOutBtn.Text = "Zoom Out";
            this.zoomOutBtn.UseVisualStyleBackColor = true;
            this.zoomOutBtn.Click += new System.EventHandler(this.zoomOutBtn_Click);
            // 
            // diceRollOutputLabel
            // 
            this.diceRollOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diceRollOutputLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.diceRollOutputLabel.Location = new System.Drawing.Point(7, 11);
            this.diceRollOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diceRollOutputLabel.Name = "diceRollOutputLabel";
            this.diceRollOutputLabel.Size = new System.Drawing.Size(227, 19);
            this.diceRollOutputLabel.TabIndex = 0;
            this.diceRollOutputLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // rollDiceBtn
            // 
            this.rollDiceBtn.Location = new System.Drawing.Point(179, 40);
            this.rollDiceBtn.Name = "rollDiceBtn";
            this.rollDiceBtn.Size = new System.Drawing.Size(54, 48);
            this.rollDiceBtn.TabIndex = 5;
            this.rollDiceBtn.Text = "Roll";
            this.rollDiceBtn.UseVisualStyleBackColor = true;
            this.rollDiceBtn.Click += new System.EventHandler(this.rollDiceBtn_Click);
            // 
            // NumberOfSidesLabel
            // 
            this.NumberOfSidesLabel.AutoSize = true;
            this.NumberOfSidesLabel.Location = new System.Drawing.Point(10, 70);
            this.NumberOfSidesLabel.Name = "NumberOfSidesLabel";
            this.NumberOfSidesLabel.Size = new System.Drawing.Size(85, 13);
            this.NumberOfSidesLabel.TabIndex = 4;
            this.NumberOfSidesLabel.Text = "Number of Sides";
            // 
            // NumberOfDiceLabel
            // 
            this.NumberOfDiceLabel.AutoSize = true;
            this.NumberOfDiceLabel.Location = new System.Drawing.Point(10, 42);
            this.NumberOfDiceLabel.Name = "NumberOfDiceLabel";
            this.NumberOfDiceLabel.Size = new System.Drawing.Size(81, 13);
            this.NumberOfDiceLabel.TabIndex = 3;
            this.NumberOfDiceLabel.Text = "Number of Dice";
            // 
            // NumberOfSidesUpDown
            // 
            this.NumberOfSidesUpDown.Location = new System.Drawing.Point(104, 68);
            this.NumberOfSidesUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfSidesUpDown.Name = "NumberOfSidesUpDown";
            this.NumberOfSidesUpDown.Size = new System.Drawing.Size(64, 20);
            this.NumberOfSidesUpDown.TabIndex = 1;
            this.NumberOfSidesUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // NumberOfDiceUpDown
            // 
            this.NumberOfDiceUpDown.Location = new System.Drawing.Point(104, 40);
            this.NumberOfDiceUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumberOfDiceUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfDiceUpDown.Name = "NumberOfDiceUpDown";
            this.NumberOfDiceUpDown.Size = new System.Drawing.Size(64, 20);
            this.NumberOfDiceUpDown.TabIndex = 0;
            this.NumberOfDiceUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testTokenListItemToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(797, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.openToolStripMenuItem.Text = "Open ...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.saveAsToolStripMenuItem.Text = "Save As ...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // testTokenListItemToolStripMenuItem
            // 
            this.testTokenListItemToolStripMenuItem.Name = "testTokenListItemToolStripMenuItem";
            this.testTokenListItemToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.testTokenListItemToolStripMenuItem.Text = "Test Token List Item";
            this.testTokenListItemToolStripMenuItem.Click += new System.EventHandler(this.testTokenListItemToolStripMenuItem_Click);
            // 
            // openMapImageDialog
            // 
            this.openMapImageDialog.Filter = "Image|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            this.openMapImageDialog.RestoreDirectory = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 590);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 597);
            this.Name = "MainForm";
            this.Text = "Dungeons And Doodles";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.rightPanelSplitContainer.Panel1.ResumeLayout(false);
            this.rightPanelSplitContainer.Panel2.ResumeLayout(false);
            this.rightPanelSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPanelSplitContainer)).EndInit();
            this.rightPanelSplitContainer.ResumeLayout(false);
            this.rightPanelTabControl.ResumeLayout(false);
            this.activeTokensTabPage.ResumeLayout(false);
            this.ActiveTokensPanel.ResumeLayout(false);
            this.ActiveTokensPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tokenLibraryTabPage.ResumeLayout(false);
            this.LibraryPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.mapTabPage.ResumeLayout(false);
            this.MapPanel.ResumeLayout(false);
            this.MapPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridScaleSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlphaSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridThicknessSlider)).EndInit();
            this.viewGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfSidesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDiceUpDown)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl rightPanelTabControl;
        private System.Windows.Forms.TabPage activeTokensTabPage;
        private System.Windows.Forms.TabPage tokenLibraryTabPage;
        private System.Windows.Forms.TabPage mapTabPage;
        private System.Windows.Forms.Button loadMapBackgroundBtn;
        private System.Windows.Forms.Button zoomOutBtn;
        private System.Windows.Forms.Button zoomInBtn;
        private System.Windows.Forms.TrackBar gridScaleSlider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar gridAlphaSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar gridThicknessSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openMapImageDialog;
        private System.Windows.Forms.Button newLibTokenBtn;
        private System.Windows.Forms.SplitContainer rightPanelSplitContainer;
        private System.Windows.Forms.NumericUpDown NumberOfSidesUpDown;
        private System.Windows.Forms.NumericUpDown NumberOfDiceUpDown;
        private System.Windows.Forms.Button rollDiceBtn;
        private System.Windows.Forms.Label NumberOfSidesLabel;
        private System.Windows.Forms.Label NumberOfDiceLabel;
        private System.Windows.Forms.GroupBox viewGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetViewBtn;
        private System.Windows.Forms.Button centerViewBtn;
        private System.Windows.Forms.Button shiftGridRightBtn;
        private System.Windows.Forms.Button shiftGridLeftBtn;
        private System.Windows.Forms.Button shiftGridDownBtn;
        private System.Windows.Forms.Button shiftGridUpBtn;
        private System.Windows.Forms.Button resetGridPosBtn;
        private System.Windows.Forms.CheckBox snapTokensToGridCheckbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox libEnemyFilterCheck;
        private System.Windows.Forms.CheckBox libNonplayerFilterCheck;
        private System.Windows.Forms.CheckBox libPlayerFilterCheck;
        private System.Windows.Forms.Button editLibTokenBtn;
        private System.Windows.Forms.Button placeTokenOnMapBtn;
        private System.Windows.Forms.ListBox tokenLibList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox activeTokEnemyFilterCheck;
        private System.Windows.Forms.CheckBox activeTokNonPlayerFilterCheck;
        private System.Windows.Forms.CheckBox activeTokPlayerFilterCheck;
        private System.Windows.Forms.Button actTokRemoveBtn;
        private System.Windows.Forms.Button actTokEditBtn;
        private System.Windows.Forms.Button actTokLocateBtn;
		private System.Windows.Forms.Label diceRollOutputLabel;
		private System.Windows.Forms.Button ExportTokenButton;
		private System.Windows.Forms.Button TokenImportButton;
        private System.Windows.Forms.ToolStripMenuItem testTokenListItemToolStripMenuItem;
		private System.Windows.Forms.Button ToggleLineColorButton;
		private System.Windows.Forms.Panel ActiveTokensPanel;
		private System.Windows.Forms.Panel LibraryPanel;
		private System.Windows.Forms.Panel MapPanel;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.FlowLayoutPanel activeTokenFlowPanel;
    }
}

