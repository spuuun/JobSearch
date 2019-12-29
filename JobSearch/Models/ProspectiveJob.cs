using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class ProspectiveJob
    {
        public int JobId { get; set; }
        public string CompanyName { get; set; }
        public string PositionTitle { get; set; }
        public DateTime AppliedOnDate { get; set; }
    }
}
