

namespace AllService.Domain
{
    public class User: BaseEntity
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public int AddressesId { get; set; }
        public Address Address { get; set; }
        public UserEnum Type { get; set; }

    }
}
