using Demo;
using Specs.Utils;

namespace Specs.Models
{
    public interface ISalutationTestContext : ISpecArgs<ISalutationTestContext>
    { 
        string Title { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        SayHello SalutationCreated { get; set; }
    }
}
