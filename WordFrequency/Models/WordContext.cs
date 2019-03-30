using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WordFrequency.Models
{
    public class WordContext : DbContext
    {
        public DbSet<Word> Words { get; set; }
    }
}