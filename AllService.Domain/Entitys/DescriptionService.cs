
using System;

namespace AllService.Domain
{
    public class DescriptionService : BaseEntity
    {
        public string Description { get; set; }
        public DateTime StartDate  { get; set; }
        public DateTime EndDate  { get; set; }
        public decimal  Value{ get; set; }

    }
}
