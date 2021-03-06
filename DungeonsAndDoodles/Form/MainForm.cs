﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DungeonsAndDoodles
{
    [Serializable]
    public struct SavedGameState
    {
        public List<Dictionary<string, string>> ActiveTokens { get; set; }
        public Dictionary<string, string> MapSettings { get; set; }
    }

    public partial class MainForm : Form
    {
        public static readonly Color ACTIVE_TOKEN_LIST_COLOR_ONE = Color.PeachPuff;
        public static readonly Color ACTIVE_TOKEN_LIST_COLOR_TWO = Color.White;

        private MapControl mapControl;
        private GameState gameState;
        private int savedSplitterPos;
        private bool savedSnapState = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            gameState = new GameState();

            mapControl = new MapControl(gameState);
            this.mainSplitContainer.Panel1.Controls.Add(mapControl);
            mapControl.Dock = DockStyle.Fill;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            // Open map tab by default
            rightPanelTabControl.SelectedIndex = 2;

            shiftGridUpBtn.Text = char.ConvertFromUtf32(0x2191);
            shiftGridLeftBtn.Text = char.ConvertFromUtf32(0x2190);
            shiftGridRightBtn.Text = char.ConvertFromUtf32(0x2192);
            shiftGridDownBtn.Text = char.ConvertFromUtf32(0x2193);



            gridThicknessSlider.Minimum = 1;
            gridThicknessSlider.Maximum = MapControl.MAX_GRID_THICKNESS;

            gridScaleSlider.Minimum = MapControl.MIN_GRID_SCALE_FACTOR;
            gridScaleSlider.Maximum = MapControl.MAX_GRID_SCALE_FACTOR;
            gridScaleSlider.Value = gridScaleSlider.Minimum;
            mapControl.GridScale = gridScaleSlider.Value;

            savedSplitterPos = mainSplitContainer.SplitterDistance;
            snapTokensToGridCheckbox.CheckState = mapControl.TokenSnapToGrid ? CheckState.Checked : CheckState.Unchecked;

            gameState.TokenLibrary.TokenAddedRemovedEvent += TokenLibrary_TokenAddedRemovedEvent;
            gameState.ActiveTokens.MapTokenAddedRemovedEvent += ActiveTokens_MapTokenAddedRemovedEvent;

            loadFonts();

            loadTokenLibraryFiles();

			mainSplitContainer.SplitterDistance = 410;
        }

        private void loadFonts()
        {
            try
            {
                gameState.FontCollection = new PrivateFontCollection();
                gameState.FontCollection.AddFontFile("Resource\\zrnic_rg.ttf");
                gameState.MapFontFamily = new FontFamily("Zrnic Rg", gameState.FontCollection);
                gameState.MapLabelsFont = new Font(gameState.MapFontFamily, 12, FontStyle.Regular);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading fonts: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gameState.FontCollection = null;
                gameState.MapFontFamily = null;
                gameState.MapLabelsFont = null;
            }
        }

        // Collapses right pannel
        private void mainSplitContainer_DoubleClick(object sender, EventArgs e)
        {
            int closedPos = mainSplitContainer.Width - mainSplitContainer.SplitterWidth;

			
            if (mainSplitContainer.SplitterDistance >= closedPos)
            {
                mainSplitContainer.SplitterDistance = mainSplitContainer.Width - savedSplitterPos;
            }
            else
            {
                savedSplitterPos = mainSplitContainer.Width - mainSplitContainer.SplitterDistance;
                mainSplitContainer.SplitterDistance = mainSplitContainer.Width - mainSplitContainer.SplitterWidth;
            }
        }

        private void loadMapBackgroundBtn_Click(object sender, EventArgs e)
        {
            string initialDir = AppDomain.CurrentDomain.BaseDirectory + MapControl.MAP_BACKGROUND_DIR;
            openMapImageDialog.InitialDirectory = initialDir;

            if (openMapImageDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openMapImageDialog.FileName;
                string fileName = Path.GetFileName(filePath);
                string localPath = initialDir + "\\" + fileName;
                
                if (!File.Exists(localPath))
                {
                    try
                    {
                        File.Copy(filePath, localPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error copying background image into resources: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                gameState.MapImageFile = fileName;
                mapControl.UpdateBackground();
            }
        }

        private void zoomInBtn_Click(object sender, EventArgs e)
        {
            if (mapControl.IsUpdating) { return; }

            mapControl.ZoomIn();
        }

        private void zoomOutBtn_Click(object sender, EventArgs e)
        {
            if (mapControl.IsUpdating) { return; }

            mapControl.ZoomOut();
        }

        private void mainSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        private void gridScaleSlider_Scroll(object sender, EventArgs e)
        {
            mapControl.GridScale = gridScaleSlider.Value;
        }

        private void gridAlphaSlider_Scroll(object sender, EventArgs e)
        {
            mapControl.GridTransparency = 255 - gridAlphaSlider.Value;
        }

        private void gridThicknessSlider_Scroll(object sender, EventArgs e)
        {
            mapControl.GridThickness = gridThicknessSlider.Value;
        }

        private void gridHorzOffset_Scroll(object sender, EventArgs e)
        {
            // mapControl.GridHorizontalOffset = (float)gridHorzOffset.Value / 10.0f;
        }

        private void gridVertOffsetSlider_Scroll(object sender, EventArgs e)
        {
            // mapControl.GridVerticalOffset = (float)gridVertOffsetSlider.Value / 10.0f;
        }

        private void rollDiceBtn_Click(object sender, EventArgs e)
        {
            int numDice = (int)NumberOfDiceUpDown.Value;
            int numSides = (int)NumberOfSidesUpDown.Value;
            String output = "";

            Random rnd = new Random();

			output += rnd.Next(1, numSides + 1);

            for (int i = numDice - 1; i > 0; i--)
                output += ",  " + rnd.Next(1, numSides + 1);

            output.Trim();

            Console.WriteLine(output);
            diceRollOutputLabel.Text = output;
        }

        private void centerViewBtn_Click(object sender, EventArgs e)
        {
            mapControl.CenterViewOnMap();
        }

        private void resetViewBtn_Click(object sender, EventArgs e)
        {
            mapControl.ZoomFactor = 1.0f;
            mapControl.CenterViewOnMap();
        }

        private void shiftGridLeftBtn_Click(object sender, EventArgs e)
        {
            mapControl.GridHorizontalOffset -= MapControl.GRID_SHIFT_STEP;
        }

        private void shiftGridUpBtn_Click(object sender, EventArgs e)
        {
            mapControl.GridVerticalOffset -= MapControl.GRID_SHIFT_STEP;
        }

        private void shiftGridRightBtn_Click(object sender, EventArgs e)
        {
            mapControl.GridHorizontalOffset += MapControl.GRID_SHIFT_STEP;
        }

        private void shiftGridDownBtn_Click(object sender, EventArgs e)
        {
            mapControl.GridVerticalOffset += MapControl.GRID_SHIFT_STEP;
        }

        private void resetGridPosBtn_Click(object sender, EventArgs e)
        {
            mapControl.GridHorizontalOffset = 0.0f;
            mapControl.GridVerticalOffset = 0.0f;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void snapTokensToGridCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            mapControl.TokenSnapToGrid = (snapTokensToGridCheckbox.CheckState == CheckState.Checked);
        }

        private void newTokenBtn_Click(object sender, EventArgs e)
        {
            EditTokenForm charForm = new EditTokenForm(gameState);
            DialogResult result = charForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                TokenData newData = charForm.GetTokenData();
                newData.CurrentHP = newData.MaxHP;
                gameState.TokenLibrary.Add(ref newData);

                newData.SaveToLibrary();
            }
        }

        private void editLibTokenBtn_Click(object sender, EventArgs e)
        {
            int curSelectedIndex = tokenLibList.SelectedIndex;

            if (curSelectedIndex < 0)
            {
                MessageBox.Show("No token selected.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TokenData tokenData = gameState.TokenLibrary[(string)tokenLibList.SelectedItem];

            EditTokenForm charForm = new EditTokenForm(gameState);
            charForm.SetTokenData(ref tokenData);
            DialogResult result = charForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                tokenData = charForm.GetTokenData();
                tokenData.CurrentHP = tokenData.MaxHP;
                gameState.TokenLibrary[tokenData.Name] = tokenData;

                tokenData.SaveToLibrary();
            }
        }

        private void placeTokenOnMapBtn_Click(object sender, EventArgs e)
        {
            int curSelectedIndex = tokenLibList.SelectedIndex;

            if (curSelectedIndex < 0)
            {
                MessageBox.Show("No token selected.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TokenData selectedToken = gameState.TokenLibrary[(string)tokenLibList.SelectedItem];

            MapToken newToken = new MapToken(mapControl, ref selectedToken, mapControl.ViewPosition);

            // Make sure token is within the map bounds
            newToken.Position = newToken.Position;

            gameState.ActiveTokens.Add(newToken);     
        }

        // This event is automatically called whenever a token is added or removed from the token library
        private void TokenLibrary_TokenAddedRemovedEvent(object sender, TokenAddedRemovedEventArgs a)
        {
            refreshTokenLibList();
        }

        private void refreshTokenLibList()
        {
            string selectedToken = null;

            if (tokenLibList.SelectedIndex >= 0)
            {
                selectedToken = (string)tokenLibList.SelectedItem;
            }

            tokenLibList.Items.Clear();

            var enumerator = gameState.TokenLibrary.GetEnumerator();

            List<string> filteredList = new List<string>();

            while (enumerator.MoveNext())
            {
                TokenData token = enumerator.Current;

                if (token.TokenType == TokenType.Player && libPlayerFilterCheck.Checked)
                {
                    filteredList.Add(token.Name);
                }
                else if (token.TokenType == TokenType.Enemy && libEnemyFilterCheck.Checked)
                {
                    filteredList.Add(token.Name);
                }
                else if (token.TokenType == TokenType.NPC && libNonplayerFilterCheck.Checked)
                {
                    filteredList.Add(token.Name);
                }
            }

            // Sort list of names
            filteredList.Sort();

            // Add each name to lib list
            foreach (string item in filteredList)
            {
                tokenLibList.Items.Add(item);
            }

            tokenLibList.SelectedItem = selectedToken;
        }

        private void libPlayerFilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            refreshTokenLibList();
        }

        private void libEnemyFilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            refreshTokenLibList();
        }

        private void libNonplayerFilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            refreshTokenLibList();
        }

        private void tokenLibList_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    e.IsInputKey = true;
                    break;
            }
        }

        private void tokenLibList_DoubleClick(object sender, EventArgs e)
        {
            placeTokenOnMapBtn_Click(sender, e);
        }

        private void tokenLibList_KeyDown(object sender, KeyEventArgs e)
        {
            int curSelectedIndex = tokenLibList.SelectedIndex;

            // No token selected
            if (curSelectedIndex < 0)
            {
                return;
            }

            TokenData selectedToken = gameState.TokenLibrary[(string)tokenLibList.SelectedItem];

            switch (e.KeyCode)
            {
                case Keys.Delete:
                    DialogResult ans = MessageBox.Show("Are you sure you want to delete the token \"" + selectedToken.Name + "\"?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (ans == DialogResult.Yes)
                    {
                        gameState.TokenLibrary.Remove(ref selectedToken);
                        selectedToken.DeleteFileFromLibrary();

                        refreshTokenLibList();
                    }
                    break;
            }
        }

        private void ActiveTokens_MapTokenAddedRemovedEvent(object sender, MapTokenAddedRemovedEventArgs a)
        {
            refreshActiveTokenList();
        }

        private void refreshActiveTokenList()
        {
            activeTokenFlowPanel.Controls.Clear();

            int counter = 0;

            foreach (MapToken token in gameState.ActiveTokens)
            {
                bool add = false;

                if (token.TokenType == TokenType.Player && activeTokPlayerFilterCheck.Checked)
                {
                    add = true;
                }
                else if (token.TokenType == TokenType.Enemy && activeTokEnemyFilterCheck.Checked)
                {
                    add = true;
                }
                else if (token.TokenType == TokenType.NPC && activeTokNonPlayerFilterCheck.Checked)
                {
                    add = true;
                }

                if (add)
                {
                    if (counter % 2 == 1)
                    {
                        token.Control.DefaultBackColor = ACTIVE_TOKEN_LIST_COLOR_ONE;
                    }
                    else
                    {
                        token.Control.DefaultBackColor = ACTIVE_TOKEN_LIST_COLOR_TWO;
                    }

                    activeTokenFlowPanel.Controls.Add(token.Control);


                    counter++;
                }
            }
        }

        private void activeTokPlayerFilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            refreshActiveTokenList();
        }

        private void activeTokEnemyFilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            refreshActiveTokenList();
        }

        private void activeTokNonPlayerFilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            refreshActiveTokenList();
        }

        private void actTokLocateBtn_Click(object sender, EventArgs e)
        {
            foreach (TokenListItemControl ctrl in activeTokenFlowPanel.Controls)
            {
                if (ctrl.Selected)
                {
                    MapToken mapToken = ctrl.MapToken;
                    mapControl.ViewPosition = mapToken.Position;
                    return;
                }
            }

            MessageBox.Show("No token selected.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void actTokEditBtn_Click(object sender, EventArgs e)
        {
            foreach (TokenListItemControl ctrl in activeTokenFlowPanel.Controls)
            {
                if (ctrl.Selected)
                {
                    MapToken mapToken = ctrl.MapToken;
                    TokenData tokenData = mapToken.GetTokenData();

                    EditTokenForm charForm = new EditTokenForm(gameState);
                    charForm.SetTokenData(ref tokenData);
                    DialogResult result = charForm.ShowDialog(this);

                    if (result == DialogResult.OK)
                    {
                        tokenData = charForm.GetTokenData();
                        mapToken.SetTokenData(ref tokenData);
                    }

                    return;
                }
            }

            MessageBox.Show("No token selected.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void actTokRemoveBtn_Click(object sender, EventArgs e)
        {
            List<TokenListItemControl> selectedCtrls = new List<TokenListItemControl>();

            foreach (TokenListItemControl ctrl in activeTokenFlowPanel.Controls)
            {
                if (ctrl.Selected)
                {
                    selectedCtrls.Add(ctrl);
                }
            }

            if (selectedCtrls.Count == 0)
            {
                MessageBox.Show("No tokens selected.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (TokenListItemControl ctrl in selectedCtrls)
            {
                gameState.ActiveTokens.Remove(ctrl.MapToken);
            }
        }

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void rightPanelSplitContainer_Panel2_Paint(object sender, PaintEventArgs e)
		{

		}

        private void gridScaleSlider_MouseDown(object sender, MouseEventArgs e)
        {
            // Save snap state and disable snapping while the grid scale is being adjusted
            savedSnapState = mapControl.TokenSnapToGrid;
            mapControl.TokenSnapToGrid = false;
        }

        private void gridScaleSlider_MouseUp(object sender, MouseEventArgs e)
        {
            // Restore snap state
            mapControl.TokenSnapToGrid = savedSnapState;
        }

        private void testTokenListItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestTokenListItemForm testForm = new TestTokenListItemForm(mapControl);
            testForm.ShowDialog(this);
        }
		

		private void ToggleLineColorButton_Click(object sender, EventArgs e)
		{
			if (mapControl.GridLineColor == Color.Black)
				mapControl.GridLineColor = Color.White;
			else
				mapControl.GridLineColor = Color.Black;

		}

		private void viewGroupBox_Enter(object sender, EventArgs e)
		{

		}

        private void selectAllActiveTokensBtn_Click(object sender, EventArgs e)
        {
            foreach (TokenListItemControl ctrl in activeTokenFlowPanel.Controls)
            {
                ctrl.Selected = true;
            }
        }

        private void deselectAllActiveTokensBtn_Click(object sender, EventArgs e)
        {
            foreach (TokenListItemControl ctrl in activeTokenFlowPanel.Controls)
            {
                ctrl.Selected = false;
            }
        }

        private void loadTokenLibraryFiles()
        {
            string[] files;

            try
            {
                files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + TokenData.TOKEN_LIBRARY_FOLDER);
            }
            catch (DirectoryNotFoundException e)
            {
                // Token library folder not found
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + TokenData.TOKEN_LIBRARY_FOLDER);
                return;
            }

            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".token")
                {
                    try
                    {
                        TokenData loadedToken = TokenData.LoadFromFile(file);
                        gameState.TokenLibrary.Add(ref loadedToken);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error loading token from file: " + file);
                    }
                }
            }
        }

        private void ExportTokenButton_Click(object sender, EventArgs e)
        {
            int curSelectedIndex = tokenLibList.SelectedIndex;

            // No token selected
            if (curSelectedIndex < 0)
            {
                MessageBox.Show("No token selected.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TokenData selectedToken = gameState.TokenLibrary[(string)tokenLibList.SelectedItem];

            exportTokenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (exportTokenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    selectedToken.SaveToFile(exportTokenFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting token: " + ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TokenImportButton_Click(object sender, EventArgs e)
        {
            importTokenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (importTokenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filePaths = importTokenFileDialog.FileNames;

                foreach (string filePath in filePaths)
                {
                    try
                    {
                        TokenData loadedData = TokenData.LoadFromFile(filePath);
                        string localPath = AppDomain.CurrentDomain.BaseDirectory + TokenData.TOKEN_LIBRARY_FOLDER + loadedData.Name + ".token";

                        if (File.Exists(localPath))
                        {
                            if (MessageBox.Show("A token named " + loadedData.Name + " already exists in the current library. Overwrite?", "Overwrite existing token?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            {
                                continue;
                            }
                        }

                        File.Copy(filePath, localPath, true);

                        if (gameState.TokenLibrary.Contains(loadedData.Name))
                        {
                            gameState.TokenLibrary[loadedData.Name] = loadedData;
                        }
                        else
                        {
                            gameState.TokenLibrary.Add(ref loadedData);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading token file: " + Path.GetFileName(filePath) + "\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveGameState(string filePath)
        {
            SavedGameState saveState = new SavedGameState();
            saveState.ActiveTokens = new List<Dictionary<string, string>>();
            saveState.MapSettings = new Dictionary<string, string>();

            mapControl.SaveStateToDict(saveState.MapSettings);

            foreach (MapToken mapToken in gameState.ActiveTokens)
            {
                saveState.ActiveTokens.Add(mapToken.ToDictionary());
            }

            using (FileStream outputFile = File.OpenWrite(filePath))
            {
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(outputFile, saveState);
            }

            gameState.SavedStateFilePath = filePath;

        }

        private void loadGameState(string filePath)
        {
            SavedGameState savedState;

            using (FileStream inputFile = File.OpenRead(filePath))
            {
                BinaryFormatter bf = new BinaryFormatter();

                savedState = (SavedGameState)bf.Deserialize(inputFile);
            }

            mapControl.LoadStateFromDict(savedState.MapSettings);

            gameState.ActiveTokens.Clear();

            foreach (var tokDict in savedState.ActiveTokens)
            {
                MapToken newTok = MapToken.FromDictionary(tokDict, mapControl);
                gameState.ActiveTokens.Add(newTok);
            }

            snapTokensToGridCheckbox.Checked = mapControl.TokenSnapToGrid;
            gridAlphaSlider.Value = 255 - mapControl.GridTransparency;
            gridScaleSlider.Value = mapControl.GridScale;
            gridThicknessSlider.Value = mapControl.GridThickness;

            gameState.SavedStateFilePath = filePath;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveGameStateDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    saveGameState(saveGameStateDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving game: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadGameStateDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    loadGameState(loadGameStateDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading game: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(gameState.SavedStateFilePath))
            {
                saveAsToolStripMenuItem_Click(sender, e);
                return;
            }

            try
            {
                saveGameState(gameState.SavedStateFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving game: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the current map?\n" +
                "Any unsaved changes will be lost.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gameState.SavedStateFilePath = null;

                mapControl.Reset();

                snapTokensToGridCheckbox.Checked = mapControl.TokenSnapToGrid;
                gridAlphaSlider.Value = 255 - mapControl.GridTransparency;
                gridScaleSlider.Value = mapControl.GridScale;
                gridThicknessSlider.Value = mapControl.GridThickness;
            }
        }

        private void toggleSidePanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainSplitContainer.Panel2Collapsed = !mainSplitContainer.Panel2Collapsed;
        }

		private void MapPanel_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
