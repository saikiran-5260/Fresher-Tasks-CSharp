
int[][] myArr = new int[5][];
myArr[0] = new int[3] { 10,20,30};
myArr[1] = new int[5] {40,50,60,70,80 };
myArr[2] = new int[2] { 90,100};
myArr[3] = new int[4] { 110,120,130,140 };
myArr[4] = new int[8] { 150, 160, 170, 180,190,200,210,220 };

for (int i = 0; i < 5; i++)
{
    for(int j =0;j< myArr[i].Length; j++)
    {
        Console.Write(myArr[i][j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}