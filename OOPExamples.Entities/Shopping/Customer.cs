namespace OOPExamples.Entities.Shopping
{
    /// <summary>
    /// موجودیت مشتری
    /// </summary>
    public class Customer
    {

        // OOP
        // Pilar 
        // Abstraction
        // Encapsulation
        // Inheritance
        // Polymorphism


        public int ID { get { return SadrTools.Utility.Utility.GetRandomNumber(); } }

        public string Name { get; set; }

        public string Telephone { get; set; }


        public Customer(string name, string telephone)
        {
            Name = name;
            Telephone = telephone;
        }

        public override string ToString()
        {
            var type = (this is ForeignCustomer) ? "Foreign : " :
                       (this is VIPCustomer) ? "VIP : " : "Normal !";

            return $"{type} {Name}";
        }
    }
}
