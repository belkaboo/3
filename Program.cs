// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).




/*bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);
if (!isParsedX || !isParsedY)
{
    Console.WriteLine("Error!");
    return;
}



int GetSection(int xInput, int yInput)
{
    int sectionNumber = 0;
    if (xInput > 0 & yInput > 0) sectionNumber = 1;
    if (xInput < 0 & yInput < 0) sectionNumber = 3;
    if (xInput > 0 & yInput < 0) sectionNumber = 4;
    if (xInput < 0 & yInput > 0) sectionNumber = 2;

    return sectionNumber;
}

int res = GetSection(x, y);
Console.WriteLine(res);


Console.WriteLine("input qurter number (from 1 to 4):  ");
bool isSquare = int.TryParse(Console.ReadLine(), out int square);

if (!isSquare)
{
    Console.WriteLine("Error. It's not a number of square");
    return;
}

void CoordinateRange (int squareNumber)
{
    if (squareNumber == 1) Console.WriteLine(" X > 0 & Y > 0");
    if (squareNumber == 2) Console.WriteLine(" X < 0 & Y > 0");
    if (squareNumber == 3) Console.WriteLine(" X < 0 & Y < 0");
    if (squareNumber == 4) Console.WriteLine(" X > 0 & Y < 0");

}

CoordinateRange(square);


Console.WriteLine("Input coordinate X to A  ");
bool isParsedx1 = int.TryParse(Console.ReadLine(), out int x1);
Console.WriteLine("Input coordinate Y to A  ");
bool isParsedy1 = int.TryParse(Console.ReadLine(), out int y1);
Console.WriteLine("Input coordinate X to B  ");
bool isParsedx2 = int.TryParse(Console.ReadLine(), out int x2);
Console.WriteLine("Input coordinate Y to B  ");
bool isParsedy2 = int.TryParse(Console.ReadLine(), out int y2);

if (!isParsedx1 || !isParsedx2 || !isParsedy1 || !isParsedy2)
{
    Console.WriteLine("Error!!");
    return;
}


double range = Math.Sqrt(Math.Pow((x2-x1),2)+ Math.Pow((y2-y1),2));

Console.WriteLine(range);
*/

Console.WriteLine("Input number = ");
int N = Convert.ToInt32(Console.ReadLine());

void SquareArray(int [] arr1, int size)
{
    int square = 1;
    for (int i = 0; i < size; i++)
    {
        
        arr1[i] = square * square;
        square++;
        
    }
    
}

void PrintArray(int[] array1)
{
    int count = array1.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();

}
int [] arr1 = new int [N];

SquareArray(arr1, N);
PrintArray(arr1);


