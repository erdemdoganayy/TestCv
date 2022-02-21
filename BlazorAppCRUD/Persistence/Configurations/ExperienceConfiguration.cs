﻿using BlazorAppCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorAppCRUD.Persistence.Configurations
{
    public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.HasKey(e => e.ExperienceId);

            builder.Property(t => t.ExperienceCompanyName)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
