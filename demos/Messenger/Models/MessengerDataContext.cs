using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.SqlServer;
using Microsoft.Framework.OptionsModel;
using Messenger.Models;

namespace Messenger.Models
{
	public class MessengerDataContext : DbContext
	{
		public MessengerDataContext(IServiceProvider serviceProvider, IOptionsAccessor<MessengerDbContextOptions> optionsAccessor)
                    : base(serviceProvider, optionsAccessor.Options)
		{
			Database.EnsureCreated();
		}

		public DbSet<Message> Messages {get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Message>().Key(m => m.Id);

            base.OnModelCreating(builder);
        }
	}

	public class MessengerDbContextOptions : DbContextOptions
    {
    }
}