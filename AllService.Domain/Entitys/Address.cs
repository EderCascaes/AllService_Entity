
namespace AllService.Domain
{
    public class Address : BaseEntity
    {
        public string PublicPlace { get; set; }
        public string District { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }

    }
}
