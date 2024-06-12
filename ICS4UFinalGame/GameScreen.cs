using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS4UFinalGame
{
    public partial class GameScreen : UserControl
    {
        Rectangle Player = new Rectangle((1178 / 2), (744 / 2), 20, 20);
        Rectangle Area = new Rectangle((1178 / 2), (744 / 2), 1178, 744);

        Image saloon1 = Properties.Resources.saloon1;
        Image cowboy = Properties.Resources.cowboy;

        bool aDown = false;
        bool dDown = false;
        bool wDown = false;
        bool sDown = false;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(cowboy, Player);
            e.Graphics.DrawImage(saloon1, Area);    
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
            }
        }
    }
}
