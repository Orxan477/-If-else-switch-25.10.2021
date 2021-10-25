using System;

namespace _25._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Ayi daxil edin=");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("---------");
            #region If Else
            //if ((n >= 1 && n <= 2)||n==12)
            //{
            //    Console.WriteLine("Qis");
            //}
            //else if (n >= 3 && n <= 5)
            //{
            //    Console.WriteLine("Yaz");
            //}
            //else if (n >= 6 && n <= 8)
            //{
            //    Console.WriteLine("Yay");
            //}
            //else if (n >= 9 && n <= 11)
            //    Console.WriteLine("Payiz");
            //else
            //{
            //    Console.WriteLine("yoxdur");
            //}
            #endregion

            #region switch
            //switch (n)
            //{
            //case 12:
            //case 1:
            //case 2:
            //    Console.WriteLine("Qis");
            //    break;
            //case 3:
            //case 4:
            //case 5:
            //    Console.WriteLine("Yaz");
            //    break;
            //case 6:
            //case 7:
            //case 8:
            //    Console.WriteLine("Yay");
            //    break;
            //case 9:
            //case 10:
            //case 11:
            //    Console.WriteLine("Payiz");
            //    break;
            //default:
            //    Console.WriteLine("Yoxdur");
            //    break;                
            //}
            #endregion

            #region ededin muxtelif bolunenlerinin sayini tapin
            //while (true)
            //{
            //    try
            //    {
            //        int count = 2;
            //        Console.Write("Ededi daxil edin=");
            //        string input = Console.ReadLine();
            //        int n = int.Parse(input);
            //        for (int i = 2; i < n; i++)
            //        {
            //            if (n % i == 0)
            //            {
            //                count++;
            //            }
            //        }
            //        Console.WriteLine(count);
            //        break;
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("duzgun input verin");
            //    }
            //}
            #endregion

            #region Sade bolenlerin sayini tap
            while (true)
            {
                try
                {
                    int count = 1;
                    Console.Write("Ededi daxil edin=");
                    string input = Console.ReadLine();
                    int n = int.Parse(input);
                    for (int i = 2; i < n; i++)
                    {
                        while (n%i!=0)
                        {
                            if (n % i == 0)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    if ((i % j == i) && (i % j == 1))
                                    {
                                        count++;
                                        break;
                                    }
                                }
                            }
                            
                        }
                        Console.WriteLine("Count=" + count);
                        break;
                    }
                        
                    //if (count == 2)
                    //{
                    //    Console.WriteLine("Count=" + count);
                    //    break;
                    //}
                }
                catch (Exception)
                {

                    Console.WriteLine("duzgun input verin");
                }
            }
            #endregion
        }
    }
}
