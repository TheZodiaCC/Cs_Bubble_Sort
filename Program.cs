using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] tab = new int[20];
            int tmp;
            
            for(int i=0; i<tab.Length; i++)
            {
                tab[i] = random.Next(0, 50);
            }
            
            for(int i=0; i<tab.Length - 1; i++)
            {
                for(int j=0; j<tab.Length - 1; j++)
                {
                    if(tab[j]>tab[j + 1])
                    {
                        tmp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = tmp;
                    }
                }
            }

            foreach(int numb in tab)
            {
                Console.WriteLine(numb);
            }
        }
    }
}
