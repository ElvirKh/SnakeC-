int x1 = 1;
int y1 = 3;
char symbol = '*';

Console.SetCursorPosition(x1, y1);
Console.WriteLine(symbol);

static void Draw(int x,int y, char symbol)
{
    Console.SetCursorPosition(x, y);
    Console.WriteLine(symbol);
}

Draw(1, 5, '#');