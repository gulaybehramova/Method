using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method1
            Console.WriteLine("Text daxil edin: ");
            string soz = Console.ReadLine();
            Index(soz, 'a');

            //Method2
            int number = 34;
            Kokalti(number);

            //Method3
            int reqem = 324;
            ReqemCem(reqem);

            //Method4
            int[] sira = { 24, 35, 72, 51 };
            int large = sira[0];
            EnBoyukEded(sira, large);

            //Method5
            int[] elementler = { 7, 9, -33, -25, -12, 80 };
            MusbetQaytar(elementler);


        }
        #region Method1
        static void Index(string soz, char symbols)
        {
            for (int i = 0; i < soz.Length; i++)
            {
                if (soz[i] == symbols)
                    Console.WriteLine(soz + " sozunde " + symbols + " simvolu " + i + " indeksinde yerlesir");
            }
        }
        #endregion


        #region Method2
        static void Kokalti(int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (i * i > number)
                {
                    Console.WriteLine("ededin en yaxin asagi kokaltisi" + (i - 1));
                    return;
                }
            }
        }
        #endregion


        #region Method3
        static int ReqemCem(int reqem)
        {
            int reqem1;
            int sum = 0;
            while (reqem > 0)
            {
                reqem1 = reqem % 10;
                sum = sum + reqem1;
                reqem = (reqem - reqem1) / 10;
            }
            Console.WriteLine(sum);
            return sum;
        }

        //#endregion



        #region Method4
        static void EnBoyukEded(int[] sira, int large)
        {
            for (int i = 0; i < sira.Length; i++)
            {
                if (large < sira[i])
                {
                    large = sira[i];
                }
            }
            Console.WriteLine(large);
        }
        #endregion


        #region Method5
        static void MusbetQaytar(int[] elementler)
        {
            for (int i = 0; i < elementler.Length; i++)
            {
                if (elementler[i] < 0)
                {
                    elementler[i] = elementler[i] * (-1);
                }
                Console.WriteLine(elementler[i]);
            }
        }
        #endregion
    }
}