namespace Snake
{

    class Program
    {
        static void Main(string[] args)
        {

            Walls walls = new Walls(78, 24);
            walls.Draw();
            
            //HorizontalIine h1 = new HorizontalIine(0, 78, 0, '+');
            //h1.DrawPoint();
            //HorizontalIine h2 = new HorizontalIine(0, 78, 24, '+');
            //h2.DrawPoint();
            //VerticalLine v1 = new VerticalLine(0, 24, 0, '+');
            //v1.DrawPoint();
            //VerticalLine v2 = new VerticalLine(0, 24, 78, '+');
            //v2.DrawPoint();

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

            FoodCreater foodCreater = new FoodCreater(55, 20, '?');
            Point food = foodCreater.CreatFood();
            food.Draw();

            while (true)
            {

                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreater.CreatFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                
                Thread.Sleep(100);
                

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                
            }

            


            Console.SetCursorPosition(0, 25);






        }

    }
}