



using MyProject;
Console.WriteLine("Enter the number of Students");
int st = Convert.ToInt32(Console.ReadLine());

do
{
    Marks marks = new Marks();
    marks.ReadingDetails();

    Physics p = new Physics();
    p.Total();

    Chemistry c = new Chemistry();
    c.Total();

    Mathematics m = new Mathematics();
    m.Total();
    st--;
    Marks.total = 0;
} while (st > 0);
