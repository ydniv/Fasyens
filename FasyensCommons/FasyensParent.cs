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
        public string Name { get; set; } = "";
        public string ProductDescription { get; set; } = "";
        public Decimal PriceBeforeDiscount { get; set; } = 0;
        public Decimal PriceAfterDiscount { get; set; } = 0;
        public int seen { get; set; } = 0;
        public long CategoryId { get; set; } = 0;
        public byte[] ImageURL { get; set; }
    }
}
