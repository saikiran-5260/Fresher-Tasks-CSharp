class BoxingAndUnbxing
{
    static void Main()
    {
        float F = 3.14f;
        object s = F;
        Console.WriteLine(F + "\t" + s);

        F = 6.79f;
        Console.WriteLine(F + "\t" + s);


        object s2 = F;
        float s3 = (float)s2;
        Console.WriteLine(s2 + "\t" + s3);

        s3 = 7.85f;
        object obj = s3;
        Console.WriteLine(s3 + "\t" + obj);

        s3 = 9.87f;
        Console.WriteLine(s3 + "\t" + obj);

        Nullable<int> firstInt = null;

        int? secondInt = null;


        var integer = 10;
        var string_s = "sai kiran";
        integer = 90;
        Console.WriteLine($"integer:{integer} , string: {string_s}");

        dynamic doub = 20;



    }
}