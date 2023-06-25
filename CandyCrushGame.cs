using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace candy_crush
{
    public partial class CandyCrushGame : Form
    {
        CandyType candy1 = new CandyType();
        CandyType candy2 = new CandyType();
        CandyType candy3 = new CandyType();
        CandyType candy4 = new CandyType();
        CandyType candy5 = new CandyType();
        CandyType candy6 = new CandyType();
        CandyType candy7 = new CandyType();
        Button[,] allButtons = new Button[7, 7];
        internal static class buttons
        {
            static public Button b1 = new Button();
            static public Button b2 = new Button();
            static public bool isb1Full = false;
            static public bool isb2Full = false;
        }
        public CandyCrushGame()
        {
            InitializeComponent();
        }

        private void CandyCrushGame_Load(object sender, EventArgs e)
        {
            //******************************************
            candy1.Name = "candy1";
            candy1.Score = 10;
            candy2.Name = "candy2";
            candy2.Score = 10;
            candy3.Name = "candy3";
            candy3.Score = 20;
            candy4.Name = "candy4";
            candy4.Score = 30;
            candy5.Name = "candy5";
            candy5.Score = 30;
            candy6.Name = "candy6";
            candy6.Score = 40;
            candy7.Name = "candy7";
            candy7.Score = 50;
            //*******************************************
            allButtons[0, 0] = button00;
            allButtons[0, 1] = button01;
            allButtons[0, 2] = button02;
            allButtons[0, 3] = button03;
            allButtons[0, 4] = button04;
            allButtons[0, 5] = button05;
            allButtons[0, 6] = button06;
            allButtons[1, 0] = button10;
            allButtons[1, 1] = button11;
            allButtons[1, 2] = button12;
            allButtons[1, 3] = button13;
            allButtons[1, 4] = button14;
            allButtons[1, 5] = button15;
            allButtons[1, 6] = button16;
            allButtons[2, 0] = button20;
            allButtons[2, 1] = button21;
            allButtons[2, 2] = button22;
            allButtons[2, 3] = button23;
            allButtons[2, 4] = button24;
            allButtons[2, 5] = button25;
            allButtons[2, 6] = button26;
            allButtons[3, 0] = button30;
            allButtons[3, 1] = button31;
            allButtons[3, 2] = button32;
            allButtons[3, 3] = button33;
            allButtons[3, 4] = button34;
            allButtons[3, 5] = button35;
            allButtons[3, 6] = button36;
            allButtons[4, 0] = button40;
            allButtons[4, 1] = button41;
            allButtons[4, 2] = button42;
            allButtons[4, 3] = button43;
            allButtons[4, 4] = button44;
            allButtons[4, 5] = button45;
            allButtons[4, 6] = button46;
            allButtons[5, 0] = button50;
            allButtons[5, 1] = button51;
            allButtons[5, 2] = button52;
            allButtons[5, 3] = button53;
            allButtons[5, 4] = button54;
            allButtons[5, 5] = button55;
            allButtons[5, 6] = button56;
            allButtons[6, 0] = button60;
            allButtons[6, 1] = button61;
            allButtons[6, 2] = button62;
            allButtons[6, 3] = button63;
            allButtons[6, 4] = button64;
            allButtons[6, 5] = button65;
            allButtons[6, 6] = button66;
            //*****************************************
            CandyType.LoadGame(allButtons, candy1box.Image, candy2box.Image, candy3box.Image, candy4box.Image, candy5box.Image, candy6box.Image, candy7box.Image);
        }

        private void candy5_Click(object sender, EventArgs e)
        {

        }

        private void candy5Score_Click(object sender, EventArgs e)
        {

        }

        private void button06_Click(object sender, EventArgs e)
        {

        }

        private void candy1box_Click(object sender, EventArgs e)
        {

        }

        private void button00_Click(object sender, EventArgs e)
        {

        }
        private void Buttons_Click(object sender, EventArgs e)
        {

            if (!buttons.isb1Full)
            {
                buttons.b1 = sender as Button;
                buttons.isb1Full = true;
            }
            else if (!buttons.isb2Full)
            {
                buttons.b2 = sender as Button;
                CandyType.MoveButtons(buttons.b1, buttons.b2, buttons.b1.BackgroundImage, buttons.b2.BackgroundImage);
                this.PlayerScore.Text =Convert.ToString( CandyType.CheckMatrix(allButtons,candy1box.Image, candy2box.Image, candy3box.Image, candy4box.Image, candy5box.Image, candy6box.Image, candy7box.Image,PlayerScore.Text));
                if (Convert.ToInt32(PlayerScore.Text) >=500)
                {
                    WinForm winForm = new WinForm();
                    this.Close();
                    winForm.ShowDialog();
                    Close();
                }
                //********************************
                buttons.isb1Full = false;
                buttons.isb2Full = false;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult=MessageBox.Show("Do you want to leave the game without saving?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dialogResult==DialogResult.Yes)
                this.Close();
        }

        private void noMoveBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to reload the candies?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if( dialogResult==DialogResult.Yes)
                CandyType.LoadGame(allButtons, candy1box.Image, candy2box.Image, candy3box.Image, candy4box.Image, candy5box.Image, candy6box.Image, candy7box.Image);
        }

        private void PlayerScore_Click(object sender, EventArgs e)
        {

        }
    }
}
