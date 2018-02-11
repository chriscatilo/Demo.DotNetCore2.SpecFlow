using TechTalk.SpecFlow;
using Utils;
using Xunit;

namespace Specs.Utils
{
    [Binding]
    internal class ScenarioContextTestSteps
    {
        [Given(@"Baz is (.*)")]
        public void GivenBazIs(int value)
        {
            var featureArgs = SpecArgsFactory.CreateFeatureArgs<IFooFeatureArgs>();

            if (featureArgs.Baz != null)
            {
                return;
            }

            featureArgs.Baz = value;
        }

        [When(@"I set Foo to (.*)")]
        public void WhenISetFooTo(int value)
        {
            var scenarioArgs = SpecArgsFactory.CreateScenarioArgs<FooScenarioArgs>();
            scenarioArgs.Foo = value;
        }

        [When(@"I set Bar to (.*)")]
        public void WhenISetBarTo(int value)
        {
            var scenarioArgs = SpecArgsFactory.CreateScenarioArgs<FooScenarioArgs>();
            scenarioArgs.Bar = value;
        }

        [When(@"I set Qux to (.*)")]
        public void WhenISetQuxTo(int value)
        {
            var scenarioArgs = SpecArgsFactory.CreateScenarioArgs<FooScenarioArgs>();
            scenarioArgs.Qux = value;
        }

        [Then(@"Foo is (.*)")]
        public void ThenFooIs(int value)
        {
            var scenarioArgs = SpecArgsFactory.CreateScenarioArgs<FooScenarioArgs>();
            Assert.Equal(scenarioArgs.Foo, value);
        }

        [Then(@"Foo (has been|has not been) set")]
        public void ThenFooHasBeenSet(string condition)
        {
            var scenarioArgs = SpecArgsFactory.CreateScenarioArgs<FooScenarioArgs>();

            var hasBeenSet = scenarioArgs.HasBeenSet(args => args.Foo);

            Assert.Equal(hasBeenSet, condition.EqualsCaseInsensitive("has been"));
        }

        [Then(@"Bar is (.*)")]
        public void ThenBarIs(int value)
        {
            var scenarioArgs = SpecArgsFactory.CreateScenarioArgs<FooScenarioArgs>();
            Assert.Equal(scenarioArgs.Bar, value);
        }

        [Then(@"Bar (has been|has not been) set")]
        public void ThenBarHasBeenSet(string condition)
        {
            var scenarioArgs = SpecArgsFactory.CreateScenarioArgs<FooScenarioArgs>();

            var hasBeenSet = scenarioArgs.HasBeenSet<FooScenarioArgs, int?>(args => args.Bar);

            Assert.Equal(hasBeenSet, condition.EqualsCaseInsensitive("has been"));
        }

        [Then(@"Baz is (.*)")]
        public void ThenBazIs(int value)
        {
            var featureArgs = SpecArgsFactory.CreateFeatureArgs<IFooFeatureArgs>();
            Assert.Equal(featureArgs.Baz, value);
        }

        [Then(@"Baz (has been|has not been) set")]
        public void ThenBazHasBeenSet(string condition)
        {
            var featureArgs = SpecArgsFactory.CreateFeatureArgs<IFooFeatureArgs>();

            var hasBeenSet = featureArgs.HasBeenSet<IFooFeatureArgs, int?>(args => args.Baz);

            Assert.Equal(hasBeenSet, condition.EqualsCaseInsensitive("has been"));
        }

        [Then(@"Qux is (.*)")]
        public void ThenQuxIs(int value)
        {
            var scenarioArgs = SpecArgsFactory.CreateScenarioArgs<FooScenarioArgs>();
            Assert.Equal(scenarioArgs.Qux, value);
        }

        [Then(@"Qux (has been|has not been) set")]
        public void ThenQuxHasBeenSet(string condition)
        {
            var scenarioArgs = SpecArgsFactory.CreateScenarioArgs<FooScenarioArgs>();

            var hasBeenSet = scenarioArgs.HasBeenSet<FooScenarioArgs, int?>(args => args.Qux);

            Assert.Equal(hasBeenSet, condition.EqualsCaseInsensitive("has been"));
        }

        [Then(@"Norf (has been|has not been) set")]
        public void ThenNorfHasBeenSet(string condition)
        {
            var featureArgs = SpecArgsFactory.CreateFeatureArgs<IFooFeatureArgs>();

            var hasBeenSet = featureArgs.HasBeenSet<IFooFeatureArgs, string>(args => args.Norf);

            Assert.Equal(hasBeenSet, condition.EqualsCaseInsensitive("has been"));
        }
    }
}