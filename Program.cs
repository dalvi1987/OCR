using System;
using System.IO;
using Tesseract;

namespace OCR
{
    class Program
    {
        static void Main(string[] args)
        {
            doOCR();
            Console.ReadLine();

        }

        public static void doOCR()
        {
            using (var engine = new TesseractEngine(@"C:\Users\Shekhar\source\repos\OCR\tessdata", "eng", EngineMode.Default))
            {
                using (var img = Pix.LoadFromFile(@"C:\Shekhar\Passport_1.PNG"))
                {
                    var page = engine.Process(img);
                    var result = page.GetText();
                    Console.WriteLine(result);
                }
            }
        }
    }
}
