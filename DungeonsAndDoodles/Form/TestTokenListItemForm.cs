using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonsAndDoodles
{
    public partial class TestTokenListItemForm : Form
    {
        private MapControl mapCtrl;

        public TestTokenListItemForm(MapControl mapCtrl)
        {
            InitializeComponent();

            this.mapCtrl = mapCtrl;
        }

        private void addCtrlBtn_Click(object sender, EventArgs e)
        {
            TokenData tokData = new TokenData("Cornealeous Pumpernickle III", TokenType.Player);
            tokData.MaxHP = 100;
            tokData.CurrentHP = 9;
            MapToken mapTok = new MapToken(mapCtrl, ref tokData, new PointF(0, 0));
            TokenListItemControl listCtrl = new TokenListItemControl(mapTok);

            testFlowContainer.Controls.Add(listCtrl);
        }

        private void TestTokenListItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
