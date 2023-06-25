using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace candy_crush
{
    public class Player
    {
        public Player() { }
        public Player(string username,string password)
        {
            this.Username = username;
            this.Password = password;
            this.PlayerCode();
        }
        public int Id { get; set; }
        public string UnicCode { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public List<int> Records { get; set; }
        public int GameNumbers { get; set; }
        public List<string> Friends { get; set; }
        public int LossesNumbers { get; set; }
        public int WinsNumbers { get; set; } 
        //public List<Match> Matches { get; set; }
        //-------------------------------------------------
        public void PlayerCode()
        {
            string code = "";
            for(int i=0;i<10;++i)
            {
                Random random = new Random();
                char letter = (char)(random.Next(65,91));
                code+=letter;
                this.UnicCode = code;
            }
        }
        //--------------------------------------------------
        //match between 2 player function
        //--------------------------------------------------


    }
}
