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
			this.deselectAllActiveTokensBtn = new System.Windows.Forms.Button();
			this.selectAllActiveTokensBtn = new System.Windows.Forms.Button();
			this.activeTokenFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.actTokRemoveBtn = new System.Windows.Forms.Button();
			this.actTokEditBtn = new System.Windows.Forms.Button();
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
			this.snapTokensToGridCheckbox = new System.Windows.Forms.CheckBox();
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
			this.toggleSidePanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openMapImageDialog = new System.Windows.Forms.OpenFileDialog();
			this.exportTokenFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.importTokenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveGameStateDialog = new System.Windows.Forms.SaveFileDialog();
			this.loadGameStateDialog = new System.Windows.Forms.OpenFileDialog();
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
			this.mainSplitContainer.Cursor = System.Windows.Forms.Cursors.Default;
			this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.mainSplitContainer.IsSplitterFixed = true;
			this.mainSplitContainer.Location = new System.Drawing.Point(0, 29);
			this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mainSplitContainer.Name = "mainSplitContainer";
			// 
			// mainSplitContainer.Panel2
			// 
			this.mainSplitContainer.Panel2.Controls.Add(this.rightPanelSplitContainer);
			this.mainSplitContainer.Panel2MinSize = 340;
			this.mainSplitContainer.Size = new System.Drawing.Size(1063, 697);
			this.mainSplitContainer.SplitterDistance = 673;
			this.mainSplitContainer.SplitterWidth = 8;
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
			this.rightPanelSplitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
			this.rightPanelSplitContainer.Panel2.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.rightPanelSplitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanelSplitContainer_Panel2_Paint);
			this.rightPanelSplitContainer.Size = new System.Drawing.Size(380, 695);
			this.rightPanelSplitContainer.SplitterDistance = 590;
			this.rightPanelSplitContainer.SplitterWidth = 5;
			this.rightPanelSplitContainer.TabIndex = 0;
			// 
			// rightPanelTabControl
			// 
			this.rightPanelTabControl.Controls.Add(this.activeTokensTabPage);
			this.rightPanelTabControl.Controls.Add(this.tokenLibraryTabPage);
			this.rightPanelTabControl.Controls.Add(this.mapTabPage);
			this.rightPanelTabControl.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.rightPanelTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rightPanelTabControl.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.rightPanelTabControl.Location = new System.Drawing.Point(0, 0);
			this.rightPanelTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rightPanelTabControl.Name = "rightPanelTabControl";
			this.rightPanelTabControl.SelectedIndex = 0;
			this.rightPanelTabControl.Size = new System.Drawing.Size(380, 590);
			this.rightPanelTabControl.TabIndex = 0;
			// 
			// activeTokensTabPage
			// 
			this.activeTokensTabPage.Controls.Add(this.ActiveTokensPanel);
			this.activeTokensTabPage.Location = new System.Drawing.Point(4, 28);
			this.activeTokensTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.activeTokensTabPage.Name = "activeTokensTabPage";
			this.activeTokensTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.activeTokensTabPage.Size = new System.Drawing.Size(372, 558);
			this.activeTokensTabPage.TabIndex = 0;
			this.activeTokensTabPage.Text = "Tokens In Play";
			this.activeTokensTabPage.UseVisualStyleBackColor = true;
			// 
			// ActiveTokensPanel
			// 
			this.ActiveTokensPanel.AutoScroll = true;
			this.ActiveTokensPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
			this.ActiveTokensPanel.Controls.Add(this.deselectAllActiveTokensBtn);
			this.ActiveTokensPanel.Controls.Add(this.selectAllActiveTokensBtn);
			this.ActiveTokensPanel.Controls.Add(this.activeTokenFlowPanel);
			this.ActiveTokensPanel.Controls.Add(this.actTokRemoveBtn);
			this.ActiveTokensPanel.Controls.Add(this.actTokEditBtn);
			this.ActiveTokensPanel.Controls.Add(this.actTokLocateBtn);
			this.ActiveTokensPanel.Controls.Add(this.groupBox3);
			this.ActiveTokensPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ActiveTokensPanel.Location = new System.Drawing.Point(4, 4);
			this.ActiveTokensPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ActiveTokensPanel.Name = "ActiveTokensPanel";
			this.ActiveTokensPanel.Size = new System.Drawing.Size(364, 550);
			this.ActiveTokensPanel.TabIndex = 0;
			// 
			// deselectAllActiveTokensBtn
			// 
			this.deselectAllActiveTokensBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.deselectAllActiveTokensBtn.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.deselectAllActiveTokensBtn.Location = new System.Drawing.Point(247, 497);
			this.deselectAllActiveTokensBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.deselectAllActiveTokensBtn.Name = "deselectAllActiveTokensBtn";
			this.deselectAllActiveTokensBtn.Size = new System.Drawing.Size(215, 28);
			this.deselectAllActiveTokensBtn.TabIndex = 9;
			this.deselectAllActiveTokensBtn.Text = "Deselect All";
			this.deselectAllActiveTokensBtn.UseVisualStyleBackColor = true;
			this.deselectAllActiveTokensBtn.Click += new System.EventHandler(this.deselectAllActiveTokensBtn_Click);
			// 
			// selectAllActiveTokensBtn
			// 
			this.selectAllActiveTokensBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.selectAllActiveTokensBtn.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.selectAllActiveTokensBtn.Location = new System.Drawing.Point(20, 497);
			this.selectAllActiveTokensBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.selectAllActiveTokensBtn.Name = "selectAllActiveTokensBtn";
			this.selectAllActiveTokensBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.selectAllActiveTokensBtn.Size = new System.Drawing.Size(215, 28);
			this.selectAllActiveTokensBtn.TabIndex = 8;
			this.selectAllActiveTokensBtn.Text = "Select All";
			this.selectAllActiveTokensBtn.UseVisualStyleBackColor = true;
			this.selectAllActiveTokensBtn.Click += new System.EventHandler(this.selectAllActiveTokensBtn_Click);
			// 
			// activeTokenFlowPanel
			// 
			this.activeTokenFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.activeTokenFlowPanel.AutoScroll = true;
			this.activeTokenFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.activeTokenFlowPanel.Location = new System.Drawing.Point(20, 75);
			this.activeTokenFlowPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.activeTokenFlowPanel.Name = "activeTokenFlowPanel";
			this.activeTokenFlowPanel.Size = new System.Drawing.Size(422, 383);
			this.activeTokenFlowPanel.TabIndex = 7;
			this.activeTokenFlowPanel.WrapContents = false;
			// 
			// actTokRemoveBtn
			// 
			this.actTokRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.actTokRemoveBtn.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.actTokRemoveBtn.Location = new System.Drawing.Point(327, 465);
			this.actTokRemoveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.actTokRemoveBtn.Name = "actTokRemoveBtn";
			this.actTokRemoveBtn.Size = new System.Drawing.Size(133, 28);
			this.actTokRemoveBtn.TabIndex = 6;
			this.actTokRemoveBtn.Text = "Remove";
			this.actTokRemoveBtn.UseVisualStyleBackColor = true;
			this.actTokRemoveBtn.Click += new System.EventHandler(this.actTokRemoveBtn_Click);
			// 
			// actTokEditBtn
			// 
			this.actTokEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.actTokEditBtn.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.actTokEditBtn.Location = new System.Drawing.Point(173, 465);
			this.actTokEditBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.actTokEditBtn.Name = "actTokEditBtn";
			this.actTokEditBtn.Size = new System.Drawing.Size(133, 28);
			this.actTokEditBtn.TabIndex = 5;
			this.actTokEditBtn.Text = "Edit ...";
			this.actTokEditBtn.UseVisualStyleBackColor = true;
			this.actTokEditBtn.Click += new System.EventHandler(this.actTokEditBtn_Click);
			// 
			// actTokLocateBtn
			// 
			this.actTokLocateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.actTokLocateBtn.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.actTokLocateBtn.Location = new System.Drawing.Point(20, 465);
			this.actTokLocateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.actTokLocateBtn.Name = "actTokLocateBtn";
			this.actTokLocateBtn.Size = new System.Drawing.Size(133, 28);
			this.actTokLocateBtn.TabIndex = 4;
			this.actTokLocateBtn.Text = "Locate";
			this.actTokLocateBtn.UseVisualStyleBackColor = true;
			this.actTokLocateBtn.Click += new System.EventHandler(this.actTokLocateBtn_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.activeTokEnemyFilterCheck);
			this.groupBox3.Controls.Add(this.activeTokNonPlayerFilterCheck);
			this.groupBox3.Controls.Add(this.activeTokPlayerFilterCheck);
			this.groupBox3.Location = new System.Drawing.Point(20, 7);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Size = new System.Drawing.Size(320, 58);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Filter";
			// 
			// activeTokEnemyFilterCheck
			// 
			this.activeTokEnemyFilterCheck.AutoSize = true;
			this.activeTokEnemyFilterCheck.Checked = true;
			this.activeTokEnemyFilterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.activeTokEnemyFilterCheck.Location = new System.Drawing.Point(97, 23);
			this.activeTokEnemyFilterCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.activeTokEnemyFilterCheck.Name = "activeTokEnemyFilterCheck";
			this.activeTokEnemyFilterCheck.Size = new System.Drawing.Size(83, 25);
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
			this.activeTokNonPlayerFilterCheck.Location = new System.Drawing.Point(192, 23);
			this.activeTokNonPlayerFilterCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.activeTokNonPlayerFilterCheck.Name = "activeTokNonPlayerFilterCheck";
			this.activeTokNonPlayerFilterCheck.Size = new System.Drawing.Size(116, 25);
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
			this.activeTokPlayerFilterCheck.Location = new System.Drawing.Point(8, 23);
			this.activeTokPlayerFilterCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.activeTokPlayerFilterCheck.Name = "activeTokPlayerFilterCheck";
			this.activeTokPlayerFilterCheck.Size = new System.Drawing.Size(78, 25);
			this.activeTokPlayerFilterCheck.TabIndex = 0;
			this.activeTokPlayerFilterCheck.Text = "Player";
			this.activeTokPlayerFilterCheck.UseVisualStyleBackColor = true;
			this.activeTokPlayerFilterCheck.CheckedChanged += new System.EventHandler(this.activeTokPlayerFilterCheck_CheckedChanged);
			// 
			// tokenLibraryTabPage
			// 
			this.tokenLibraryTabPage.Controls.Add(this.LibraryPanel);
			this.tokenLibraryTabPage.Location = new System.Drawing.Point(4, 28);
			this.tokenLibraryTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tokenLibraryTabPage.Name = "tokenLibraryTabPage";
			this.tokenLibraryTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tokenLibraryTabPage.Size = new System.Drawing.Size(372, 558);
			this.tokenLibraryTabPage.TabIndex = 1;
			this.tokenLibraryTabPage.Text = "Tokens In Storage";
			this.tokenLibraryTabPage.UseVisualStyleBackColor = true;
			// 
			// LibraryPanel
			// 
			this.LibraryPanel.AutoScroll = true;
			this.LibraryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(206)))), ((int)(((byte)(161)))));
			this.LibraryPanel.Controls.Add(this.ExportTokenButton);
			this.LibraryPanel.Controls.Add(this.tokenLibList);
			this.LibraryPanel.Controls.Add(this.TokenImportButton);
			this.LibraryPanel.Controls.Add(this.newLibTokenBtn);
			this.LibraryPanel.Controls.Add(this.editLibTokenBtn);
			this.LibraryPanel.Controls.Add(this.groupBox2);
			this.LibraryPanel.Controls.Add(this.placeTokenOnMapBtn);
			this.LibraryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LibraryPanel.Location = new System.Drawing.Point(4, 4);
			this.LibraryPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.LibraryPanel.Name = "LibraryPanel";
			this.LibraryPanel.Size = new System.Drawing.Size(364, 550);
			this.LibraryPanel.TabIndex = 0;
			// 
			// ExportTokenButton
			// 
			this.ExportTokenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ExportTokenButton.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.ExportTokenButton.Location = new System.Drawing.Point(247, 497);
			this.ExportTokenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ExportTokenButton.Name = "ExportTokenButton";
			this.ExportTokenButton.Size = new System.Drawing.Size(215, 28);
			this.ExportTokenButton.TabIndex = 10;
			this.ExportTokenButton.Text = "Export Token ...";
			this.ExportTokenButton.UseVisualStyleBackColor = true;
			this.ExportTokenButton.Click += new System.EventHandler(this.ExportTokenButton_Click);
			// 
			// tokenLibList
			// 
			this.tokenLibList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tokenLibList.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tokenLibList.FormattingEnabled = true;
			this.tokenLibList.IntegralHeight = false;
			this.tokenLibList.ItemHeight = 23;
			this.tokenLibList.Location = new System.Drawing.Point(20, 75);
			this.tokenLibList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tokenLibList.Name = "tokenLibList";
			this.tokenLibList.Size = new System.Drawing.Size(320, 382);
			this.tokenLibList.Sorted = true;
			this.tokenLibList.TabIndex = 2;
			this.tokenLibList.DoubleClick += new System.EventHandler(this.tokenLibList_DoubleClick);
			this.tokenLibList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tokenLibList_KeyDown);
			this.tokenLibList.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tokenLibList_PreviewKeyDown);
			// 
			// TokenImportButton
			// 
			this.TokenImportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.TokenImportButton.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.TokenImportButton.Location = new System.Drawing.Point(20, 497);
			this.TokenImportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TokenImportButton.Name = "TokenImportButton";
			this.TokenImportButton.Size = new System.Drawing.Size(215, 28);
			this.TokenImportButton.TabIndex = 9;
			this.TokenImportButton.Text = "Import Token(s) ...";
			this.TokenImportButton.UseVisualStyleBackColor = true;
			this.TokenImportButton.Click += new System.EventHandler(this.TokenImportButton_Click);
			// 
			// newLibTokenBtn
			// 
			this.newLibTokenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.newLibTokenBtn.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newLibTokenBtn.ForeColor = System.Drawing.Color.Green;
			this.newLibTokenBtn.Location = new System.Drawing.Point(327, 465);
			this.newLibTokenBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.newLibTokenBtn.Name = "newLibTokenBtn";
			this.newLibTokenBtn.Size = new System.Drawing.Size(133, 28);
			this.newLibTokenBtn.TabIndex = 0;
			this.newLibTokenBtn.Text = "New ...";
			this.newLibTokenBtn.UseVisualStyleBackColor = true;
			this.newLibTokenBtn.Click += new System.EventHandler(this.newTokenBtn_Click);
			// 
			// editLibTokenBtn
			// 
			this.editLibTokenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.editLibTokenBtn.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.editLibTokenBtn.Location = new System.Drawing.Point(173, 465);
			this.editLibTokenBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.editLibTokenBtn.Name = "editLibTokenBtn";
			this.editLibTokenBtn.Size = new System.Drawing.Size(133, 28);
			this.editLibTokenBtn.TabIndex = 4;
			this.editLibTokenBtn.Text = "Edit ...";
			this.editLibTokenBtn.UseVisualStyleBackColor = true;
			this.editLibTokenBtn.Click += new System.EventHandler(this.editLibTokenBtn_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.libEnemyFilterCheck);
			this.groupBox2.Controls.Add(this.libNonplayerFilterCheck);
			this.groupBox2.Controls.Add(this.libPlayerFilterCheck);
			this.groupBox2.Location = new System.Drawing.Point(20, 7);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Size = new System.Drawing.Size(320, 58);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Filter";
			// 
			// libEnemyFilterCheck
			// 
			this.libEnemyFilterCheck.AutoSize = true;
			this.libEnemyFilterCheck.Checked = true;
			this.libEnemyFilterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.libEnemyFilterCheck.Location = new System.Drawing.Point(97, 23);
			this.libEnemyFilterCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.libEnemyFilterCheck.Name = "libEnemyFilterCheck";
			this.libEnemyFilterCheck.Size = new System.Drawing.Size(83, 25);
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
			this.libNonplayerFilterCheck.Location = new System.Drawing.Point(192, 23);
			this.libNonplayerFilterCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.libNonplayerFilterCheck.Name = "libNonplayerFilterCheck";
			this.libNonplayerFilterCheck.Size = new System.Drawing.Size(116, 25);
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
			this.libPlayerFilterCheck.Location = new System.Drawing.Point(8, 23);
			this.libPlayerFilterCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.libPlayerFilterCheck.Name = "libPlayerFilterCheck";
			this.libPlayerFilterCheck.Size = new System.Drawing.Size(78, 25);
			this.libPlayerFilterCheck.TabIndex = 0;
			this.libPlayerFilterCheck.Text = "Player";
			this.libPlayerFilterCheck.UseVisualStyleBackColor = true;
			this.libPlayerFilterCheck.CheckedChanged += new System.EventHandler(this.libPlayerFilterCheck_CheckedChanged);
			// 
			// placeTokenOnMapBtn
			// 
			this.placeTokenOnMapBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.placeTokenOnMapBtn.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.placeTokenOnMapBtn.Location = new System.Drawing.Point(20, 465);
			this.placeTokenOnMapBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.placeTokenOnMapBtn.Name = "placeTokenOnMapBtn";
			this.placeTokenOnMapBtn.Size = new System.Drawing.Size(133, 28);
			this.placeTokenOnMapBtn.TabIndex = 3;
			this.placeTokenOnMapBtn.Text = "◀ Place";
			this.placeTokenOnMapBtn.UseVisualStyleBackColor = true;
			this.placeTokenOnMapBtn.Click += new System.EventHandler(this.placeTokenOnMapBtn_Click);
			// 
			// mapTabPage
			// 
			this.mapTabPage.Controls.Add(this.MapPanel);
			this.mapTabPage.Location = new System.Drawing.Point(4, 28);
			this.mapTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mapTabPage.Name = "mapTabPage";
			this.mapTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mapTabPage.Size = new System.Drawing.Size(372, 558);
			this.mapTabPage.TabIndex = 2;
			this.mapTabPage.Text = "Map Settings";
			this.mapTabPage.UseVisualStyleBackColor = true;
			// 
			// MapPanel
			// 
			this.MapPanel.AutoScroll = true;
			this.MapPanel.BackColor = System.Drawing.Color.Thistle;
			this.MapPanel.Controls.Add(this.loadMapBackgroundBtn);
			this.MapPanel.Controls.Add(this.groupBox1);
			this.MapPanel.Controls.Add(this.viewGroupBox);
			this.MapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MapPanel.Location = new System.Drawing.Point(4, 4);
			this.MapPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MapPanel.Name = "MapPanel";
			this.MapPanel.Size = new System.Drawing.Size(364, 550);
			this.MapPanel.TabIndex = 0;
			this.MapPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MapPanel_Paint);
			// 
			// loadMapBackgroundBtn
			// 
			this.loadMapBackgroundBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.loadMapBackgroundBtn.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Bold);
			this.loadMapBackgroundBtn.Location = new System.Drawing.Point(20, 16);
			this.loadMapBackgroundBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.loadMapBackgroundBtn.Name = "loadMapBackgroundBtn";
			this.loadMapBackgroundBtn.Size = new System.Drawing.Size(267, 32);
			this.loadMapBackgroundBtn.TabIndex = 0;
			this.loadMapBackgroundBtn.Text = "Load Map Background";
			this.loadMapBackgroundBtn.UseVisualStyleBackColor = true;
			this.loadMapBackgroundBtn.Click += new System.EventHandler(this.loadMapBackgroundBtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox1.Controls.Add(this.snapTokensToGridCheckbox);
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
			this.groupBox1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox1.Location = new System.Drawing.Point(20, 174);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(267, 468);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Grid Settings";
			// 
			// snapTokensToGridCheckbox
			// 
			this.snapTokensToGridCheckbox.AutoSize = true;
			this.snapTokensToGridCheckbox.Location = new System.Drawing.Point(12, 437);
			this.snapTokensToGridCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.snapTokensToGridCheckbox.Name = "snapTokensToGridCheckbox";
			this.snapTokensToGridCheckbox.Size = new System.Drawing.Size(195, 25);
			this.snapTokensToGridCheckbox.TabIndex = 20;
			this.snapTokensToGridCheckbox.Text = "Snap Tokens to Grid";
			this.snapTokensToGridCheckbox.UseVisualStyleBackColor = true;
			this.snapTokensToGridCheckbox.CheckedChanged += new System.EventHandler(this.snapTokensToGridCheckbox_CheckedChanged);
			// 
			// ToggleLineColorButton
			// 
			this.ToggleLineColorButton.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.ToggleLineColorButton.Location = new System.Drawing.Point(12, 386);
			this.ToggleLineColorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ToggleLineColorButton.Name = "ToggleLineColorButton";
			this.ToggleLineColorButton.Size = new System.Drawing.Size(160, 28);
			this.ToggleLineColorButton.TabIndex = 19;
			this.ToggleLineColorButton.Text = "Toggle Line Color";
			this.ToggleLineColorButton.UseVisualStyleBackColor = true;
			this.ToggleLineColorButton.Click += new System.EventHandler(this.ToggleLineColorButton_Click);
			// 
			// shiftGridRightBtn
			// 
			this.shiftGridRightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.shiftGridRightBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.shiftGridRightBtn.Location = new System.Drawing.Point(245, 74);
			this.shiftGridRightBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.shiftGridRightBtn.Name = "shiftGridRightBtn";
			this.shiftGridRightBtn.Size = new System.Drawing.Size(40, 37);
			this.shiftGridRightBtn.TabIndex = 19;
			this.shiftGridRightBtn.Text = "▶";
			this.shiftGridRightBtn.UseVisualStyleBackColor = true;
			this.shiftGridRightBtn.Click += new System.EventHandler(this.shiftGridRightBtn_Click);
			// 
			// shiftGridLeftBtn
			// 
			this.shiftGridLeftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.shiftGridLeftBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.shiftGridLeftBtn.Location = new System.Drawing.Point(152, 73);
			this.shiftGridLeftBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.shiftGridLeftBtn.Name = "shiftGridLeftBtn";
			this.shiftGridLeftBtn.Size = new System.Drawing.Size(40, 37);
			this.shiftGridLeftBtn.TabIndex = 15;
			this.shiftGridLeftBtn.Text = "◀";
			this.shiftGridLeftBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.shiftGridLeftBtn.UseVisualStyleBackColor = true;
			this.shiftGridLeftBtn.Click += new System.EventHandler(this.shiftGridLeftBtn_Click);
			// 
			// shiftGridDownBtn
			// 
			this.shiftGridDownBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.shiftGridDownBtn.Location = new System.Drawing.Point(200, 116);
			this.shiftGridDownBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.shiftGridDownBtn.Name = "shiftGridDownBtn";
			this.shiftGridDownBtn.Size = new System.Drawing.Size(40, 37);
			this.shiftGridDownBtn.TabIndex = 17;
			this.shiftGridDownBtn.Text = "▼";
			this.shiftGridDownBtn.UseVisualStyleBackColor = true;
			this.shiftGridDownBtn.Click += new System.EventHandler(this.shiftGridDownBtn_Click);
			// 
			// shiftGridUpBtn
			// 
			this.shiftGridUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.shiftGridUpBtn.Location = new System.Drawing.Point(200, 27);
			this.shiftGridUpBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.shiftGridUpBtn.Name = "shiftGridUpBtn";
			this.shiftGridUpBtn.Size = new System.Drawing.Size(40, 37);
			this.shiftGridUpBtn.TabIndex = 16;
			this.shiftGridUpBtn.Text = "▲";
			this.shiftGridUpBtn.UseVisualStyleBackColor = true;
			this.shiftGridUpBtn.Click += new System.EventHandler(this.shiftGridUpBtn_Click);
			// 
			// resetGridPosBtn
			// 
			this.resetGridPosBtn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetGridPosBtn.Location = new System.Drawing.Point(200, 71);
			this.resetGridPosBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.resetGridPosBtn.Name = "resetGridPosBtn";
			this.resetGridPosBtn.Size = new System.Drawing.Size(40, 37);
			this.resetGridPosBtn.TabIndex = 15;
			this.resetGridPosBtn.Text = "↺";
			this.resetGridPosBtn.UseVisualStyleBackColor = true;
			this.resetGridPosBtn.Click += new System.EventHandler(this.resetGridPosBtn_Click);
			// 
			// gridScaleSlider
			// 
			this.gridScaleSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridScaleSlider.AutoSize = false;
			this.gridScaleSlider.Location = new System.Drawing.Point(8, 330);
			this.gridScaleSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gridScaleSlider.Minimum = 2;
			this.gridScaleSlider.Name = "gridScaleSlider";
			this.gridScaleSlider.Size = new System.Drawing.Size(251, 39);
			this.gridScaleSlider.TabIndex = 7;
			this.gridScaleSlider.Value = 2;
			this.gridScaleSlider.Scroll += new System.EventHandler(this.gridScaleSlider_Scroll);
			this.gridScaleSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridScaleSlider_MouseDown);
			this.gridScaleSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridScaleSlider_MouseUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.label1.Location = new System.Drawing.Point(8, 308);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 21);
			this.label1.TabIndex = 8;
			this.label1.Text = "Grid/Token Scale";
			// 
			// gridAlphaSlider
			// 
			this.gridAlphaSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridAlphaSlider.AutoSize = false;
			this.gridAlphaSlider.Location = new System.Drawing.Point(8, 266);
			this.gridAlphaSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gridAlphaSlider.Maximum = 255;
			this.gridAlphaSlider.Name = "gridAlphaSlider";
			this.gridAlphaSlider.Size = new System.Drawing.Size(251, 38);
			this.gridAlphaSlider.TabIndex = 9;
			this.gridAlphaSlider.Scroll += new System.EventHandler(this.gridAlphaSlider_Scroll);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.label2.Location = new System.Drawing.Point(8, 244);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 21);
			this.label2.TabIndex = 10;
			this.label2.Text = "Line Transparency";
			// 
			// gridThicknessSlider
			// 
			this.gridThicknessSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridThicknessSlider.AutoSize = false;
			this.gridThicknessSlider.Location = new System.Drawing.Point(8, 201);
			this.gridThicknessSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gridThicknessSlider.Maximum = 6;
			this.gridThicknessSlider.Minimum = 1;
			this.gridThicknessSlider.Name = "gridThicknessSlider";
			this.gridThicknessSlider.Size = new System.Drawing.Size(251, 39);
			this.gridThicknessSlider.TabIndex = 11;
			this.gridThicknessSlider.Value = 1;
			this.gridThicknessSlider.Scroll += new System.EventHandler(this.gridThicknessSlider_Scroll);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.label3.Location = new System.Drawing.Point(8, 178);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 21);
			this.label3.TabIndex = 12;
			this.label3.Text = "Line Thickness";
			// 
			// viewGroupBox
			// 
			this.viewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.viewGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.viewGroupBox.Controls.Add(this.resetViewBtn);
			this.viewGroupBox.Controls.Add(this.centerViewBtn);
			this.viewGroupBox.Controls.Add(this.zoomInBtn);
			this.viewGroupBox.Controls.Add(this.zoomOutBtn);
			this.viewGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.viewGroupBox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
			this.viewGroupBox.Location = new System.Drawing.Point(20, 55);
			this.viewGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.viewGroupBox.Name = "viewGroupBox";
			this.viewGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.viewGroupBox.Size = new System.Drawing.Size(267, 113);
			this.viewGroupBox.TabIndex = 17;
			this.viewGroupBox.TabStop = false;
			this.viewGroupBox.Text = "View Settings";
			this.viewGroupBox.Enter += new System.EventHandler(this.viewGroupBox_Enter);
			// 
			// resetViewBtn
			// 
			this.resetViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.resetViewBtn.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.resetViewBtn.Location = new System.Drawing.Point(99, 59);
			this.resetViewBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.resetViewBtn.Name = "resetViewBtn";
			this.resetViewBtn.Size = new System.Drawing.Size(160, 28);
			this.resetViewBtn.TabIndex = 4;
			this.resetViewBtn.Text = "Reset";
			this.resetViewBtn.UseVisualStyleBackColor = true;
			this.resetViewBtn.Click += new System.EventHandler(this.resetViewBtn_Click);
			// 
			// centerViewBtn
			// 
			this.centerViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.centerViewBtn.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.centerViewBtn.Location = new System.Drawing.Point(99, 23);
			this.centerViewBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.centerViewBtn.Name = "centerViewBtn";
			this.centerViewBtn.Size = new System.Drawing.Size(160, 28);
			this.centerViewBtn.TabIndex = 3;
			this.centerViewBtn.Text = "Center";
			this.centerViewBtn.UseVisualStyleBackColor = true;
			this.centerViewBtn.Click += new System.EventHandler(this.centerViewBtn_Click);
			// 
			// zoomInBtn
			// 
			this.zoomInBtn.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.zoomInBtn.Location = new System.Drawing.Point(8, 23);
			this.zoomInBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.zoomInBtn.Name = "zoomInBtn";
			this.zoomInBtn.Size = new System.Drawing.Size(160, 28);
			this.zoomInBtn.TabIndex = 1;
			this.zoomInBtn.Text = "Zoom In";
			this.zoomInBtn.UseVisualStyleBackColor = true;
			this.zoomInBtn.Click += new System.EventHandler(this.zoomInBtn_Click);
			// 
			// zoomOutBtn
			// 
			this.zoomOutBtn.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.zoomOutBtn.Location = new System.Drawing.Point(8, 59);
			this.zoomOutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.zoomOutBtn.Name = "zoomOutBtn";
			this.zoomOutBtn.Size = new System.Drawing.Size(160, 28);
			this.zoomOutBtn.TabIndex = 2;
			this.zoomOutBtn.Text = "Zoom Out";
			this.zoomOutBtn.UseVisualStyleBackColor = true;
			this.zoomOutBtn.Click += new System.EventHandler(this.zoomOutBtn_Click);
			// 
			// diceRollOutputLabel
			// 
			this.diceRollOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.diceRollOutputLabel.Cursor = System.Windows.Forms.Cursors.Default;
			this.diceRollOutputLabel.Location = new System.Drawing.Point(9, 10);
			this.diceRollOutputLabel.Name = "diceRollOutputLabel";
			this.diceRollOutputLabel.Size = new System.Drawing.Size(479, 23);
			this.diceRollOutputLabel.TabIndex = 0;
			this.diceRollOutputLabel.Click += new System.EventHandler(this.label4_Click);
			// 
			// rollDiceBtn
			// 
			this.rollDiceBtn.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.rollDiceBtn.Location = new System.Drawing.Point(417, 41);
			this.rollDiceBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rollDiceBtn.Name = "rollDiceBtn";
			this.rollDiceBtn.Size = new System.Drawing.Size(72, 64);
			this.rollDiceBtn.TabIndex = 5;
			this.rollDiceBtn.Text = "Roll";
			this.rollDiceBtn.UseVisualStyleBackColor = true;
			this.rollDiceBtn.Click += new System.EventHandler(this.rollDiceBtn_Click);
			// 
			// NumberOfSidesLabel
			// 
			this.NumberOfSidesLabel.AutoSize = true;
			this.NumberOfSidesLabel.Location = new System.Drawing.Point(184, 79);
			this.NumberOfSidesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NumberOfSidesLabel.Name = "NumberOfSidesLabel";
			this.NumberOfSidesLabel.Size = new System.Drawing.Size(132, 21);
			this.NumberOfSidesLabel.TabIndex = 4;
			this.NumberOfSidesLabel.Text = "Number of Sides";
			// 
			// NumberOfDiceLabel
			// 
			this.NumberOfDiceLabel.AutoSize = true;
			this.NumberOfDiceLabel.Location = new System.Drawing.Point(188, 43);
			this.NumberOfDiceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NumberOfDiceLabel.Name = "NumberOfDiceLabel";
			this.NumberOfDiceLabel.Size = new System.Drawing.Size(127, 21);
			this.NumberOfDiceLabel.TabIndex = 3;
			this.NumberOfDiceLabel.Text = "Number of Dice";
			// 
			// NumberOfSidesUpDown
			// 
			this.NumberOfSidesUpDown.Location = new System.Drawing.Point(324, 76);
			this.NumberOfSidesUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.NumberOfSidesUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumberOfSidesUpDown.Name = "NumberOfSidesUpDown";
			this.NumberOfSidesUpDown.Size = new System.Drawing.Size(85, 27);
			this.NumberOfSidesUpDown.TabIndex = 1;
			this.NumberOfSidesUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// NumberOfDiceUpDown
			// 
			this.NumberOfDiceUpDown.Location = new System.Drawing.Point(324, 41);
			this.NumberOfDiceUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
			this.NumberOfDiceUpDown.Size = new System.Drawing.Size(85, 27);
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
            this.toggleSidePanelToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.mainMenuStrip.Size = new System.Drawing.Size(1063, 29);
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
			this.fileToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.newToolStripMenuItem.Text = "Clear Current Map";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.openToolStripMenuItem.Text = "Open ...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.saveAsToolStripMenuItem.Text = "Save As ...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// toggleSidePanelToolStripMenuItem
			// 
			this.toggleSidePanelToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 9.75F);
			this.toggleSidePanelToolStripMenuItem.Name = "toggleSidePanelToolStripMenuItem";
			this.toggleSidePanelToolStripMenuItem.Size = new System.Drawing.Size(152, 25);
			this.toggleSidePanelToolStripMenuItem.Text = "Toggle Side Panel";
			this.toggleSidePanelToolStripMenuItem.Click += new System.EventHandler(this.toggleSidePanelToolStripMenuItem_Click);
			// 
			// openMapImageDialog
			// 
			this.openMapImageDialog.Filter = "Image|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
			this.openMapImageDialog.RestoreDirectory = true;
			this.openMapImageDialog.Title = "Select Map Background Image";
			// 
			// exportTokenFileDialog
			// 
			this.exportTokenFileDialog.Filter = "Token File|*.token";
			this.exportTokenFileDialog.RestoreDirectory = true;
			this.exportTokenFileDialog.Title = "Export Token to File ...";
			// 
			// importTokenFileDialog
			// 
			this.importTokenFileDialog.Filter = "Token File|*.token";
			this.importTokenFileDialog.Multiselect = true;
			this.importTokenFileDialog.RestoreDirectory = true;
			this.importTokenFileDialog.Title = "Import External Token ...";
			// 
			// saveGameStateDialog
			// 
			this.saveGameStateDialog.Filter = "Game State File|*.dgs";
			this.saveGameStateDialog.RestoreDirectory = true;
			this.saveGameStateDialog.Title = "Save Current Game ...";
			// 
			// loadGameStateDialog
			// 
			this.loadGameStateDialog.Filter = "Game State File|*.dgs";
			this.loadGameStateDialog.RestoreDirectory = true;
			this.loadGameStateDialog.Title = "Load Previous Game ...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1063, 726);
			this.Controls.Add(this.mainSplitContainer);
			this.Controls.Add(this.mainMenuStrip);
			this.MainMenuStrip = this.mainMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MinimumSize = new System.Drawing.Size(1061, 728);
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
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.tokenLibraryTabPage.ResumeLayout(false);
			this.LibraryPanel.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.mapTabPage.ResumeLayout(false);
			this.MapPanel.ResumeLayout(false);
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
		private System.Windows.Forms.Button ToggleLineColorButton;
		private System.Windows.Forms.Panel ActiveTokensPanel;
		private System.Windows.Forms.Panel LibraryPanel;
		private System.Windows.Forms.Panel MapPanel;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.FlowLayoutPanel activeTokenFlowPanel;
        private System.Windows.Forms.Button deselectAllActiveTokensBtn;
        private System.Windows.Forms.Button selectAllActiveTokensBtn;
        private System.Windows.Forms.SaveFileDialog exportTokenFileDialog;
        private System.Windows.Forms.OpenFileDialog importTokenFileDialog;
        private System.Windows.Forms.SaveFileDialog saveGameStateDialog;
        private System.Windows.Forms.OpenFileDialog loadGameStateDialog;
        private System.Windows.Forms.ToolStripMenuItem toggleSidePanelToolStripMenuItem;
        private System.Windows.Forms.CheckBox snapTokensToGridCheckbox;
    }
}

