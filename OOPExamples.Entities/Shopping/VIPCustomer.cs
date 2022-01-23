namespace OOPExamples.Entities.Shopping
{
    public class VIPCustomer : Customer
    {
        public EnMembershipCard MembershipCard { get; set; }

        public VIPCustomer(string name,
                           string telephone,
                           EnMembershipCard membershipCard = EnMembershipCard.Blue) 
            : base(name, telephone)
        {
            MembershipCard = membershipCard;
        }
    }

}
