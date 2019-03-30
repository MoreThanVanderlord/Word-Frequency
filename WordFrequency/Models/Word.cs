using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordFrequency.Models
{
    public class Word
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int Frequency { get; set; }

        public int LearningRate { get; set; }
    }
}