using Demo;
using Specs.Models;
using TechTalk.SpecFlow;
using Xunit;

namespace Specs.Steps
{
    [Binding]
    public class DemoSteps : TestRunSteps<ISalutationTestContext>
    {
        [Given(@"my title is (.*)")]
        public void GivenMyTitle(string title)
        {
            TestContext.Title = title;
        }
        
        [Given(@"my first name is (.*)")]
        public void GivenMyFirstName(string firstName)
        {
            TestContext.FirstName = firstName;
        }
        
        [Given(@"my last name is (.*)")]
        public void GivenMyLastName(string lastName)
        {
            TestContext.LastName = lastName;
        }
        
        [When(@"someone greets me")]
        public void WhenSomeoneGreetsMe()
        {
            TestContext.SalutationCreated =
                new SayHello(TestContext.Title, TestContext.FirstName, TestContext.LastName);
        }
        
        [Then(@"they say (.*)")]
        public void ThenTheySay(string expected)
        {
            var actual = TestContext.SalutationCreated.Salutation();

            Assert.Equal(expected, actual);
        }
    }
}
