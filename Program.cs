using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace uss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize( 80, 25 );

            //Отрисовка рамок
            HorizantalLine upLine = new HorizantalLine( 0, 78, 0, '+' );
            HorizantalLine downLine = new HorizantalLine( 0, 78, 24, '+' );
            VerticalLine leftLine = new VerticalLine( 0, 24, 0, '+' );
            VerticalLine rightLine = new VerticalLine( 0, 24, 78, '+' );
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();



            //Отрисовка точек 
            //Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake( p, 4, Direction.RIGHT );
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey( key.Key);
                }
            }    Thread.Sleep( 100 );
                 snake.Move();
          

            
            
            
            
            
            
            HorizantalLine line = new HorizantalLine(5, 10, 8, '+');
            line.Drow();



            
            
            Console.ReadLine();
        }

    }
}
