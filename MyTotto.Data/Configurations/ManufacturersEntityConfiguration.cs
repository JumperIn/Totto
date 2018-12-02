using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using MyTotto.Data.Models;

namespace MyTotto.Data.Configurations
{
    class ManufacturersEntityConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.ToTable("Manufacturers");

            // Индекс на таблицу
            builder.HasIndex(x => x.Id).IsUnique();
            builder.HasKey(x => x.Id);

            builder.HasData(
               new Manufacturer()
               {
                   Id = 1,
                   Title = "ELIZAVECCA",
                   Url = "elizavecca"
               },
               new Manufacturer()
               {
                   Id = 2,
                   Title = "ESTHETIC HOUSE",
                   Url = "esthetic-house"
               },
               new Manufacturer()
               {
                   Id = 3,
                   Title = "KOELF",
                   Url = "koelf"
               },
               new Manufacturer()
               {
                   Id = 4,
                   Title = "THE SAEM",
                   Url = "the-saem"
               },
               new Manufacturer()
               {
                   Id = 5,
                   Title = "Innisfree",
                   Url = "innisfree"
               },
               new Manufacturer()
               {
                   Id = 6,
                   Title = "A'PIEU",
                   Url = "apieu"
               },
               new Manufacturer()
               {
                   Id = 7,
                   Title = "FARMSTAY",
                   Url = "farmstay"
               });
        }
    }
}