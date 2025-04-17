﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList.Dal.Entities;

namespace ToDoList.Dal.Configurations
{
    public class ToDoItemConfiguration : IEntityTypeConfiguration<ToDoItem>
    {
        public void Configure(EntityTypeBuilder<ToDoItem> builder)
        {
            builder.HasKey(t => t.ToDoItemId);
            builder.Property(t => t.Title).IsRequired().HasMaxLength(100);
            builder.Property(t => t.Description).HasMaxLength(251);
            builder.Property(t => t.IsCompleted).IsRequired();
            builder.Property(t => t.CreatedAt).IsRequired();
        }



    }
}
