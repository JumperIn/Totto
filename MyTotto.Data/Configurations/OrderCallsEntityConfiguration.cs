using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyTotto.Data.Models;

namespace MyTotto.Data.Configurations
{
    class OrderCallsEntityConfiguration : IEntityTypeConfiguration<OrderCall>
    {
        public void Configure(EntityTypeBuilder<OrderCall> builder)
        {
            builder.ToTable("OrderCalls");

            // Индекс на таблицу
            builder.HasIndex(x => x.Id).IsUnique();

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Created).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsCalled).HasDefaultValue(false);
        }
    }
}