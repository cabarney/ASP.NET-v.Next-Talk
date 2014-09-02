using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.SqlServer;
using Messenger.Models;

namespace Messenger
{
	public class MessengerDataContext : DbContext
	{
		public DbSet<Message> Messages {get; set; }

		protected override void OnConfiguring(DbContextOptions builder)
	    {
	        builder.UseSqlServer(@"Server=(localdb)\v11.0;Database=Messenger;Trusted_Connection=True;");
	    }

	}
}