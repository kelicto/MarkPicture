using System;

namespace KeLi.MarkPicture.App
{
    public class Program
    {
        public static void Main()
        {
            var art = MarkerService.GetKissArt(out var width, out var height);

            Console.Title = "ASCII Art";

            Console.WindowWidth = width;

            Console.WindowHeight = height;

            Console.BufferWidth = width;

            Console.BufferHeight = height;

            try
            {
                PictureMarker.ShowMarkPicture(art);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}