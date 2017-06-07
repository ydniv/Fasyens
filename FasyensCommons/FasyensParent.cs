using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasyens.Commons
{
    public class FasyensParent
    {
        public long Id { get; set; } = 0;
        public string CreatedBy { get; set; } = "";
        public DateTime CreatedDate { get; set; } = DateTime.Today;
        public string UpdatedBy { get; set; } = "";
        public DateTime UpdatedDate { get; set; } = DateTime.Today;
    }
}
