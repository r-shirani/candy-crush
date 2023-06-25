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
    public partial class SignInForm : Form
    {
        DataBase dataBase = new DataBase();
        public SignInForm()
        {
            InitializeComponent();
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool findUser = false;
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            foreach(var p in dataBase.AllPlayers)
            {
                if(p.Username==username && p.Password==password)
                {
                    findUser = true;
                    MessageBox.Show("Signed in Successfuly", "signed in", MessageBoxButtons.OK);
                    CandyCrushGame candyCrushGame = new CandyCrushGame();
                    this.Close();
                    candyCrushGame.ShowDialog();
                    break;
                }
            }
            if(findUser==false)
            {
                MessageBox.Show("wrong user name or password\nplease try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
