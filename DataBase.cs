using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace candy_crush
{
    internal class DataBase: DbContext
    {
        public static string constring = @"Data Source=(localdb)\MSSQLLocalDB;
Initial Catalog=.;
Integrated Security=True;
Connect Timeout=30;
Encript=False;
Trust Server Certificate=False;
Application Intent=ReadWrite;
Multi Subnet Failover=False";
        public DbSet<Player> AllPlayers { get; set; }
    }
}
