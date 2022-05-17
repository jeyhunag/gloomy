using System;

namespace aszx
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;
            
            while (isContinue)
            {
                Console.WriteLine("Yasinizi daxil edin");
                int yas = Convert.ToInt32(Console.ReadLine());                
                if (yas>18)
                {
                    isContinue = true;
                    
                }
                if (yas<18)
                {
                    isContinue = false;
                    Console.WriteLine("Sizin yasiniz azdi qeydiyyatdan kece bilmediniz");
                }
                Console.WriteLine("Balinizi daxil edin");
                int bal = Convert.ToInt32(Console.ReadLine());
                if (bal>50)
                {
                    isContinue = true;
                    Console.WriteLine("Tebrik edirik qeydiyyatdan kecdiniz");
                }
                if (bal<50)
                {
                    isContinue = false;
                    Console.WriteLine("Teesuf edirik baliniz yeterli deyil");
                }
            }
                
            
        }
    }
}
