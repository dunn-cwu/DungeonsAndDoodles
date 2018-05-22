using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonsAndDoodles
{
    public partial class TokenListItemControl : UserControl
    {
        private static readonly Color SELECTED_COLOR = Color.FromArgb(255,255, 182, 48);

        private MapToken token;
        private bool selected = false;
        private bool healthEditMode = false;

        public new Color DefaultBackColor = Color.White;

        public TokenListItemControl(MapToken token)
        {
            InitializeComponent();

            this.token = token;

            UpdateData();
        }

        public bool Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                Refresh();
            }
        }

        public MapToken MapToken
        {
            get { return token; }
        }

        private void TokenListItemControl_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (selected)
                this.BackColor = SELECTED_COLOR;
            else
                this.BackColor = DefaultBackColor;

            base.OnPaintBackground(e);
        }

        private void HPPlus_Click(object sender, EventArgs e)
        {

            if (token.CurrentHP < token.MaxHP)
            {
                token.CurrentHP += 1;
            }
        }

        private void HPMinus_Click(object sender, EventArgs e)
        {

            if (token.CurrentHP > 0)
            {
                token.CurrentHP -= 1;
            }
        }

        private void HealthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HealthBox_Click(object sender, EventArgs e)
        {
            if (!healthEditMode)
            {
                healthEditMode = true;

                HealthBox.Text = token.CurrentHP.ToString();
                HealthBox.SelectAll();
            }
        }

        private void TokenListItemControl_MouseLeave(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void HealthBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {

                    int temp = Convert.ToInt32(HealthBox.Text);

                    TokenData data = token.GetTokenData();

                    if (temp >= 0 && temp <= data.MaxHP)
                    {
                        //UPDATE

                        token.CurrentHP = temp;
                    }
                }
                catch (Exception E)
                {
                }

                UpdateData();
            }
        }

        private void updateHealthBox()
        {
            if (!healthEditMode) { return; }

            HealthBox.DeselectAll();
            HPMinus.Select();
            healthEditMode = false;

            try
            {
                if (Convert.ToInt32(HealthBox.Text) >= 0 || Convert.ToInt32(HealthBox.Text) <= token.MaxHP) { }

                token.CurrentHP = Convert.ToInt32(HealthBox.Text);
                HealthBox.Text = token.CurrentHP + " / " + token.MaxHP;

                if (token.CurrentHP >= token.MaxHP / 3)
                {
                    HealthBox.BackColor = Color.Lime;
                }
                else if (token.CurrentHP >= token.MaxHP / 10)
                {
                    HealthBox.BackColor = Color.Orange;
                }
                else
                {
                    HealthBox.BackColor = Color.Red;
                }
            }


            catch (Exception a)
            {
                HealthBox.Text = token.CurrentHP + " / " + token.MaxHP;
            }
        }

        public void UpdateData()
        {
            TokenData data = token.GetTokenData();

            TokenName.Text = data.Name;

            acLabel.Text = "AC: " + data.ArmorClass;

            TokenStrength.Text = "STR: " + data.Strength;

            TokenDexterity.Text = "DEX: " + data.Dexterity;

            TokenConstitution.Text = "CON: " + data.Constitution;

            TokenIntelligence.Text = "INT: " + data.Intelligence;

            TokenWisdom.Text = "WIS: " + data.Wisdom;

            TokenCharisma.Text = "CHA: " + data.Charisma;

            HealthBox.Text = data.CurrentHP + " / " + data.MaxHP;

            if (data.CurrentHP >= data.MaxHP / 2)
            {
                HealthBox.BackColor = Color.Lime;
            }
            else if (data.CurrentHP >= data.MaxHP / 10)
            {
                HealthBox.BackColor = Color.Orange;
            }
            else
            {
                HealthBox.BackColor = Color.Red;
            }

            updateHealthBox();

            if (token.Image != null)
            {
                this.TokenImageBox.Image = token.Image;
            }
            else
            {
                this.TokenImageBox.Image = new Bitmap(1, 1);
            }

            this.Refresh();
        }

        private void TokenListItemControl_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void TokenImageBox_Click(object sender, EventArgs e)
        {
            Selected = !Selected;
        }

        private void TokenImageBox_DoubleClick(object sender, EventArgs e)
        {
            TokenData tokenData = token.GetTokenData();

            EditTokenForm charForm = new EditTokenForm(token.GameState);
            charForm.SetTokenData(ref tokenData);
            DialogResult result = charForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                tokenData = charForm.GetTokenData();
                token.SetTokenData(ref tokenData);
            }
        }
    }
}
