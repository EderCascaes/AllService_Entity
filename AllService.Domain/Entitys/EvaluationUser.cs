

namespace AllService.Domain
{
    public class EvaluationUser
    {
        public int ContrtactorId { get; set; }
        public int ServiceProvaiderId { get; set; }
        public User User { get; set; }
        public int ContractedServiceId { get; set; }
        public ContractedService ContractedService { get; set; }
        public EvaluationEnum Evaluation { get; set; }

    }
}
