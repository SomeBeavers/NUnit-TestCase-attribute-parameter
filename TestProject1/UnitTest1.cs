using System;
using EnumsHere;
using NUnit.Framework;

namespace TestProject1
{
    public sealed class AnalysisFeedbackArgs
    {
        public enum Type
        {
            Success,
            Failed
        }
    }

    public class Tests
    {
        public const Class1.InnerClass NullableInnerClass = default;

        [TestCase(AnalysisFeedbackArgs.Type.Success)] // NUnit.IncorrectArgumentType (false positive)
        [TestCase(AnalysisFeedbackArgs.Type.Failed)] // NUnit.IncorrectArgumentType (false positive)
        public void Test(AnalysisFeedbackArgs.Type feedbackType)
        {
            Console.WriteLine(feedbackType);
        }


        [TestCase(ReferencedEnum1.Enum1)]
        [TestCase(AnalysisFeedbackArgs.Type.Failed)]
        public void Test2(object s)
        {
        }

        [TestCase(ClassWithEnum.InnerEnum.Enum1)]
        [TestCase(AnalysisFeedbackArgs.Type.Failed)]
        public void Test3(ClassWithEnum.InnerEnum ic)
        {
        }

        [TestCase(NullableInnerClass)]
        public void Test4(Class2 myClass2)
        {
            //myClass2 = NullableInnerClass;
        }

        [TestCase(NullableInnerClass)]
        public void Test5(int myClass2)
        {
            //myClass2 = NullableInnerClass;
        }

        [TestCase(typeof(Class1.InnerClass2))]
        public void Test5(string o)
        {
        }

        [TestCase(typeof(Class1.InnerClass2))]
        public void Test6(Type o)
        {
        }


    }
}