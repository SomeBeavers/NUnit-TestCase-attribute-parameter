namespace EnumsHere;

[Flags]
public enum ReferencedEnum1
{
    Enum1
}

public class ClassWithEnum
{

    public enum InnerEnum
    {
        Enum1 = 2,

    }
}