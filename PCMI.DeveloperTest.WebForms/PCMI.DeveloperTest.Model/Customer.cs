using System.ComponentModel.DataAnnotations;

namespace PCMI.DeveloperTest.Model
{
    public class Customer
    {
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        [Display(Name = "Customer First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Customer Last Name")]
        public string LastName { get; set; }
    }
}
