namespace OOPExamples.Entities.Shopping
{
    public sealed class ForeignCustomer : VIPCustomer
    {
        public string CountryName { get; set; }

        public ForeignCustomer(string name,
                               string telephone,
                               EnMembershipCard membershipCard = EnMembershipCard.Silver,
                               string countryName = "Germany") : base(name,telephone,membershipCard)
        {

            CountryName = countryName;
        }
    }


    // cannot derive from sealed type 'ForeignCustomer'
    //public class Child : ForeignCustomer{ }
}
