// ========== Created by Thomas Beck @ 2017 ========== \\
// ========== This is SpecFlow Testing 2017 ========== \\
// ========== SpecFlow Testing @via NCrunch ========== \\

using DoTheCounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace CounterTest
{
    [Binding]
    public class CounterSteps
    {
        Converter _myConverter;
        int _myInput;
        private string _result;

        [Given(@"I have a converter")]
        public void GivenIHaveAConverter()
        {
            _myConverter = new Converter();
        }
        
        [Given(@"I have a number of (.*)")]
        public void GivenIHaveANumberOf(int input)
        {
           _myInput = input;
        }
        
        [When(@"I call convert")]
        public void WhenICallConvert()
        {
            _result = _myConverter.Translate(_myInput);
            
        }
        
        [Then(@"the result should be '(.*)'")]
        public void ThenTheResultShouldBe(string output)
        {
            Assert.AreEqual(output, _result);
        }
    }
}
