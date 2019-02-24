using NUnit.Framework;
using Problems;
using System.Collections;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [TestFixture]
        public class MyTests
        {
            [TestCaseSource(typeof(MyDataClass), "TestCases")]
            public string DivideTest(string mystring)
            {
                Program p = new Program();
                string result = p.Prefix(mystring);
                return result;
            }
        }

        public class MyDataClass
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData("hello").Returns("5,1:hello");
                    yield return new TestCaseData("").Returns("0,0:");
                    yield return new TestCaseData("what  ... did you say??").Returns("23,5:what  ... did you say??");
                    yield return new TestCaseData(null).Returns(null);
                    yield return new TestCaseData(" Hello ").Returns("7,1: Hello ");
                    yield return new TestCaseData("    ").Returns("4,0:    ");
                }
            }  
        }
    }
}