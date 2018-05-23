using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonsAndDoodles
{
    public partial class EditTokenForm : Form
    {
        public static readonly string TOKENS_BASE_DIR = "Resource\\Tokens\\";
        public static readonly string PLAYER_TOKENS_FOLDER = "Players\\";
        public static readonly string ENEMIES_TOKENS_FOLDER = "Baddies\\";
        public static readonly string NPC_TOKENS_FOLDER = "NPC\\";
        public static readonly string[] VALID_FILE_EXTENSIONS = new string[] { ".bmp", ".jpg", ".jpeg", ".png", ".tif", ".tiff"};

        private GameState gameState = null;
        private bool editingExistingToken = false;
        private string image = "";
        private bool usingDefaultImage = false;

        public EditTokenForm(GameState gameState)
        {
            InitializeComponent();

            this.gameState = gameState;
            setDefaultImage();
        }

        // Updates fields on form based on existing token data
        public void SetTokenData(ref TokenData data)
        {
            playerType_rad.Checked = false;
            enemyType_rad.Checked = false;
            NPCtype_rad.Checked = false;

            switch (data.TokenType)
            {
                case TokenType.Player:
                    playerType_rad.Checked = true;
                    break;
                case TokenType.Enemy:
                    enemyType_rad.Checked = true;
                    break;
                case TokenType.NPC:
                    NPCtype_rad.Checked = true;
                    break;
            }

            tokenNameBox.Text = data.Name;
            tokenHPBox.Value = data.MaxHP;
            tokenACBox.Value = data.ArmorClass;
            tokenStrBox.Value = data.Strength;
            tokenIntBox.Value = data.Intelligence;
            tokenDexBox.Value = data.Dexterity;
            tokenWisBox.Value = data.Wisdom;
            tokenConstBox.Value = data.Constitution;
            tokenChrBox.Value = data.Charisma;
            charNotesBox.Text = data.Notes;

            tokenNameBox.ReadOnly = true;

            playerType_rad.Enabled = false;
            enemyType_rad.Enabled = false;
            NPCtype_rad.Enabled = false;

            image = data.PictureFileName;
            usingDefaultImage = false;

            loadImage();

            editingExistingToken = true;
        }

        public TokenData GetTokenData()
        {
            TokenType tokenType = TokenType.Player;

            if (enemyType_rad.Checked) { tokenType = TokenType.Enemy; }
            else if (NPCtype_rad.Checked) { tokenType = TokenType.NPC; }

            TokenData data = new TokenData(tokenNameBox.Text, tokenType);
            data.MaxHP = (int)tokenHPBox.Value;
            data.ArmorClass = (int)tokenACBox.Value;
            data.Strength = (int)tokenStrBox.Value;
            data.Intelligence = (int)tokenIntBox.Value;
            data.Dexterity = (int)tokenDexBox.Value;
            data.Wisdom = (int)tokenWisBox.Value;
            data.Constitution = (int)tokenConstBox.Value;
            data.Charisma = (int)tokenChrBox.Value;
            data.Notes = charNotesBox.Text;
            data.PictureFileName = image;

            return data;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string tokenName = tokenNameBox.Text;

            // Make sure token name is a valid file name
            if (string.IsNullOrEmpty(tokenName) || tokenName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("Token name contains at least one invalid character. Please use only letters, spaces, or numbers for the token name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Make sure token name is a valid length
            if (tokenName.Length < 3 || tokenName.Length > 20)
            {
                MessageBox.Show("Please enter a valid token name (3-20 characters).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!editingExistingToken && gameState.TokenLibrary.Contains(tokenNameBox.Text))
            {
                MessageBox.Show("A token with that name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //when token objects have been made change this method
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void charPic_DoubleClick(object sender, EventArgs e)
        {
            getImageBrowser.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + TOKENS_BASE_DIR;

            if (getImageBrowser.ShowDialog(this) == DialogResult.OK)
            {
                image = getImageBrowser.FileName;
                loadImage();
                usingDefaultImage = false;
            }
        }

        private void loadImage()
        {
            if (charPic.Image != null)
            {
                charPic.Image.Dispose();
                charPic.Image = null;
            }

            if (image == "") { return; }

            charPic.Image = Bitmap.FromFile(image);
        }

        private void setDefaultImage()
        {
            string imgDir = TOKENS_BASE_DIR;

            if (playerType_rad.Checked)
            {
                imgDir += PLAYER_TOKENS_FOLDER;
            }
            else if (enemyType_rad.Checked)
            {
                imgDir += ENEMIES_TOKENS_FOLDER;
            }
            else
            {
                imgDir += NPC_TOKENS_FOLDER;
            }

            try
            {
                string[] files = Directory.GetFiles(imgDir);
                List<string> imgFiles = new List<string>();
              

                foreach (string file in files)
                {
                    if (File.Exists(file) && VALID_FILE_EXTENSIONS.Any(file.Contains))
                    {
                        imgFiles.Add(file);
                    }
                }

                if (imgFiles.Count > 0)
                {
                    Random rand = new Random();

                    image = imgFiles[rand.Next(0, imgFiles.Count)];
                    usingDefaultImage = true;
                }
                else
                {
                    usingDefaultImage = true;
                }
                
            }
            catch (Exception e)
            {
                usingDefaultImage = false;
            }

            loadImage();
        }

        private void playerType_rad_CheckedChanged(object sender, EventArgs e)
        {
            if (usingDefaultImage)
            {
                setDefaultImage();
            }
        }

        private void enemyType_rad_CheckedChanged(object sender, EventArgs e)
        {
            if (usingDefaultImage)
            {
                setDefaultImage();
            }
        }

        private void NPCtype_rad_CheckedChanged(object sender, EventArgs e)
        {
            if (usingDefaultImage)
            {
                setDefaultImage();
            }
        }
    }
}
