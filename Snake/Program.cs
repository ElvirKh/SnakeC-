namespace Snake
{

    class Program
    {
        static void Main(string[] args)
        {

            HorizontalIine h1 = new HorizontalIine(0, 78, 0, '+');
            h1.DrawPoint();
            HorizontalIine h2 = new HorizontalIine(0, 78, 24, '+');
            h2.DrawPoint();
            VerticalLine v1 = new VerticalLine(0, 24, 0, '+');
            v1.DrawPoint();
            VerticalLine v2 = new VerticalLine(0, 24, 78, '+');
            v2.DrawPoint();

            Point p1 = new Point(2, 3, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.DrawPoint();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();


            Console.SetCursorPosition(0, 25);




        }

    }
}