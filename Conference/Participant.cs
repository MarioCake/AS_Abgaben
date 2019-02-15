namespace Conference
{
    public class Participant
    {
        public string Name { get; private set; }
        public string Street { get; private set; }
        public string PostalCode { get; private set; }
        public string City { get; private set; }
        public string Status { get; private set; }

        public Participant(string name, string street, string postalCode, string city, string status)
        {
            Name = name;
            Street = street;
            PostalCode = postalCode;
            City = city;
            Status = status;
        }

        public void Pay(Registration registration)
        {
            registration.PayBy(this);
        }
    }
}
