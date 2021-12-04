

namespace AllService.Domain
{
    public class ContractedService: BaseEntity
    {
        public int ContrtactorId { get; set; }
        public int ServiceProvaiderId { get; set; }
        public User User { get; set; }
        public string EvaluationId { get; set; }
        public string DescriptionServiceId { get; set; }
        public DescriptionService DescriptionService { get; set; }


    }
}
