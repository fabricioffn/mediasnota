using System;

namespace Mediasnota
{
    class Program
    {
        static void Main(string[] args)
        {
           int notas1 , notas2 ,  notas3 , notas4 ;
           float medias ;
           
            Console.WriteLine("digite suas 4 notas:");
            notas1 = Convert.ToInt16(Console.ReadLine());
            notas2 =  Convert.ToInt16(Console.ReadLine());
            notas3 = Convert.ToInt16(Console.ReadLine());
            notas4 = Convert.ToInt16(Console.ReadLine());

         medias =  notas1 + notas2 + notas3 + notas4  ;
         medias = medias / 4;

            if(medias > 6 ){
                Console.WriteLine("aprovado");
            }
             if (medias == 5 && medias <= 6)
            {
                Console.WriteLine("em recuperação");
            }
            else if(medias < 5)
            {
                Console.WriteLine("reprovado");
            }

        }
    }
}
