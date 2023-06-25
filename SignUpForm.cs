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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            bool findUsreName = false;
            DataBase dataBase = new DataBase();
            if (dataBase.AllPlayers != null)
            {
                foreach (var p in dataBase.AllPlayers)
                {
                    if (p.Username == usernameBox.Text)//If username hadn't repeated
                    {
                        MessageBox.Show("this username has already taken\nplease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        findUsreName = true;
                        break;
                    }
                }
            }
            if (findUsreName == false)
            {

                string username = usernameBox.Text;
                string password = passwordBox.Text;
                Player player = new Player(username, password);
                player.PlayerCode();
                if (passwordBox.Text.Length < 8)
                    MessageBox.Show("your password must be atleast8 character", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    dataBase.AllPlayers.Add(player);
                    dataBase.SaveChanges();
                    MessageBox.Show("signed in successfuly", "signed in", MessageBoxButtons.OK);
                    CandyCrushGame candyCrushGame = new CandyCrushGame();
                    this.Close();
                    candyCrushGame.ShowDialog();

                }
                
            }
        }
    }
}
