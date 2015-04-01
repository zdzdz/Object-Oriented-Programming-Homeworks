

namespace BankAccounts.Customers
{
    public abstract class Customer
    {
        
        protected Customer() { }
        protected Customer(string name)
        {
            this.Name = name;
        }
        
        public string Name { get; set; }
        
        public override string ToString()
        {
            return string.Format("Name: " + this.Name);
        }

    }
}
