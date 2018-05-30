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
            string appBaseDir = AppDomain.CurrentDomain.BaseDirectory;

            getImageBrowser.InitialDirectory = appBaseDir + getLocalImageDir();

            if (getImageBrowser.ShowDialog(this) == DialogResult.OK)
            {
                string fullNewPath = getImageBrowser.FileName;
                string fileName = Path.GetFileName(fullNewPath);
                string localPath = getLocalImageDir() + fileName;
                string fullLocalPath = appBaseDir + localPath;

                if (!File.Exists(fullLocalPath) || !FileCompare(fullLocalPath, fullNewPath))
                {
                    try
                    {
                        File.Copy(fullNewPath, fullLocalPath, false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error copying token image into local resources: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                image = fileName;
                loadImage();
                usingDefaultImage = false;
            }
        }

        private string getLocalImageDir()
        {
            string localPath = TokenData.TOKEN_IMAGE_BASE_DIR;

            if (playerType_rad.Checked)
            {
                localPath += TokenData.PLAYER_TOKENS_FOLDER;
            }
            else if (enemyType_rad.Checked)
            {
                localPath += TokenData.ENEMIES_TOKENS_FOLDER;
            }
            else
            {
                localPath += TokenData.NPC_TOKENS_FOLDER;
            }

            return localPath;
        }

        private void loadImage()
        {
            if (charPic.Image != null)
            {
                charPic.Image.Dispose();
                charPic.Image = null;
            }

            if (image == "") { return; }

            try
            {
                using (FileStream fStream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + getLocalImageDir() + image, FileMode.Open))
                {
                    charPic.Image = Bitmap.FromStream(fStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
                charPic.Image = null;
                image = "";
            }
        }

        private void setDefaultImage()
        {
            string imgDir = AppDomain.CurrentDomain.BaseDirectory + getLocalImageDir();

            try
            {
                string[] files = Directory.GetFiles(imgDir);
                List<string> imgFiles = new List<string>();
              

                foreach (string file in files)
                {
                    if (File.Exists(file) && TokenData.VALID_FILE_EXTENSIONS.Any(file.Contains))
                    {
                        imgFiles.Add(file);
                    }
                }

                if (imgFiles.Count > 0)
                {
                    Random rand = new Random();

                    image = Path.GetFileName(imgFiles[rand.Next(0, imgFiles.Count)]);
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
            else
            {
                image = "";
                loadImage();
            }
        }

        private void enemyType_rad_CheckedChanged(object sender, EventArgs e)
        {
            if (usingDefaultImage)
            {
                setDefaultImage();
            }
            else
            {
                image = "";
                loadImage();
            }
        }

        private void NPCtype_rad_CheckedChanged(object sender, EventArgs e)
        {
            if (usingDefaultImage)
            {
                setDefaultImage();
            }
            else
            {
                image = "";
                loadImage();
            }
        }

        // https://support.microsoft.com/en-us/help/320348/how-to-create-a-file-compare-function-in-visual-c
        private bool FileCompare(string file1, string file2)
        {
            int file1byte;
            int file2byte;
            FileStream fs1;
            FileStream fs2;

            // Determine if the same file was referenced two times.
            if (file1 == file2)
            {
                // Return true to indicate that the files are the same.
                return true;
            }

            // Open the two files.
            fs1 = new FileStream(file1, FileMode.Open);
            fs2 = new FileStream(file2, FileMode.Open);

            // Check the file sizes. If they are not the same, the files 
            // are not the same.
            if (fs1.Length != fs2.Length)
            {
                // Close the file
                fs1.Close();
                fs2.Close();

                // Return false to indicate files are different
                return false;
            }

            // Read and compare a byte from each file until either a
            // non-matching set of bytes is found or until the end of
            // file1 is reached.
            do
            {
                // Read one byte from each file.
                file1byte = fs1.ReadByte();
                file2byte = fs2.ReadByte();
            }
            while ((file1byte == file2byte) && (file1byte != -1));

            // Close the files.
            fs1.Close();
            fs2.Close();

            // Return the success of the comparison. "file1byte" is 
            // equal to "file2byte" at this point only if the files are 
            // the same.
            return ((file1byte - file2byte) == 0);
        }
    }
}
