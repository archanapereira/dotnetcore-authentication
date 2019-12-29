﻿using Microsoft.EntityFrameworkCore;

using MyBookApplication.Models;

namespace MyBookApplication.Data
{
    public class BookDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }
    }
}