using System;
using System.Collections.Generic;

namespace JohanBos.Models
{
    public class Employer
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Labels { get; set; }
        public DateTime Started { get; set; }
        public DateTime? Ended { get; set; }
        public string Reference { get; set; }
    }
}
