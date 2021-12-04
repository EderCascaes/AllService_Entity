

namespace AllService.Domain
{
    public class Contracted: BaseEntity
    {
        public int ContrtactorId { get; set; }
        public int ServiceProvaiderId { get; set; }
        public User User { get; set; }
        public int ContractedServiceId { get; set; }
        public long Number { get; set; }


    }
}
