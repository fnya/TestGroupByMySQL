using System;
using System.Collections.Generic;

namespace TestGroupByMySQL.Models
{
    public partial class Result
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subj { get; set; }
        public int Point { get; set; }
    }
}