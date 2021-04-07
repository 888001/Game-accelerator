using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoBoundaries.MyControl
{
    public partial class MyGameList : UserControl
    {
        [Category("GameCode"), Description("SerialCode")]
        public string GameCode 
        {
            get;set;
        }

        [Category("GameName"), Description("GameName")]
        public string GameName 
        {
            get { return lbProgramName.Text; }
            set { lbProgramName.Text = value; }
        }

        public Image Image 
        {
            get { return panel_GameIco.BackgroundImage; }
            set { panel_GameIco.BackgroundImage = value; }
        }
        public MyGameList()
        {
            InitializeComponent();
        }

        private void MyGameList_MouseEnter(object sender, EventArgs e)
        {
            skinPanel1.BorderColor = Color.White;
        }

        private void MyGameList_MouseLeave(object sender, EventArgs e)
        {
            skinPanel1.BorderColor = Color.Transparent;
        }

        private void lbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //MainFrm.mygames.Remove(GameCode);
                //MySetting.Default.MyGamesRecord.Remove(GameCode);
                //MySetting.Default.Save();
            }
            catch 
            { 

            }

        }
    }
}
