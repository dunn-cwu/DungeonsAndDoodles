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
        private MapToken token;

        bool healthEditMode = false;

        public TokenListItemControl(MapToken token)
        {
            InitializeComponent();

            this.token = token;

            UpdateData();
        }

        private void TokenListItemControl_Load(object sender, EventArgs e)
        {

        }



        private void label5_Click(object sender, EventArgs e)
        {

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
                //exit edit mode

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
        }

        private void TokenListItemControl_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
