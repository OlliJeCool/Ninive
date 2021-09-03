using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ninive.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Producer { get; set; }
        public string Contributor { get; set; }
        public DateTime ContributionTime { get; set; }
    }
}
