using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.SqlServer;
using Messenger.Models;

namespace Messenger.Models
{
	public class MessengerDataContext : DbContext
	{
		public DbSet<Message> Messages {get; set; }
	}

	public class MessengerDbContextOptions : DbContextOptions
    {
        public string DefaultAdminUserName { get; set; }

        public string DefaultAdminPassword { get; set; }
    }
}