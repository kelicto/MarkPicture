using System;
using System.Threading;

using static System.DateTime;

namespace KeLi.MarkPicture.App
{
    public class PictureMarker
    {
        public static void ShowMarkPicture(char[] art)
        {
            MarkerService.SetMarkPicture(art, true);


            for (var i = 0; i < 3; i++)
            {
                Console.Clear();

                Console.Title = "ASCII Art";

               var d1 = Console.WindowWidth;

               var d2 = Console.WindowHeight;

               var d3 = Console.BufferWidth;

               var d4 = Console.BufferHeight ;

                MarkerService.SetMarkPicture(art);

                var seed = new Random((int)(Now.Ticks & 0xffffffffL) | (int)(Now.Ticks >> 32)).Next(10) * 100;

                Thread.Sleep(seed);
            }
        }
    }
}