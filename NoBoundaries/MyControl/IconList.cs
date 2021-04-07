using NoBoundaries.Common;
using NoBoundaries.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoBoundaries.MyControl
{
    public partial class IconList : UserControl
    {
        [Category("gameCode"), Description("SerialCode")]
        public string gameCode;

        [Category("GameName"), Description("游戏名称")]
        public string GameName 
        {
            get { return this.lbGameName.Text; }
            set { this.lbGameName.Text = value; }
        }

        [Category("Image"), Description("游戏图标")]
        public Image Image 
        {
            get { return this.panel_Icon.BackgroundImage; }
            set { this.panel_Icon.BackgroundImage = value; }
        }


        public IconList()
        {
            InitializeComponent();
        }

        private void panel_Icon_MouseEnter(object sender, EventArgs e)
        {
            skinPanel1.BorderColor = Color.White;
        }

        private void panel_Icon_MouseLeave(object sender, EventArgs e)
        {
            skinPanel1.BorderColor = Color.Transparent;
        }

        private void panel_Icon_Click(object sender, EventArgs e)
        {
            try
            {
                var game = Game.Find(Game._.SerialCode == gameCode);
                if (game != null)
                {
                    MainFrm.CurrentGame = game;
                    MySetting.Default.MyGamesRecord = game.SerialCode;
                    MySetting.Default.Save();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
