namespace EnumsHere;

public class Class1
{
    public class InnerClass
    {

    }

    public class InnerClass2
    {
        public static explicit operator checked Class2(InnerClass2 ic)
        {
            return new Class2();
        }

        public static explicit operator Class2(InnerClass2 ic)
        {
            throw new NotImplementedException();
        }
    }
}

public class Class2
{
}

public class Class3
{
}