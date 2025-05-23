using System;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius: ");
            int radius = int.Parse(Console.ReadLine());
            int size = 2 * (radius + 1);

            // ---------- TODO ----------
            for (int i = 0; i < size; i++)
            {
                if (i == 0) //첫 줄
                {
                    for (int j = 0; j < size; j++) { Console.Write(" "); }
                    for (int j = 0; j < size; j++)
                    {
                        if (j == size / 3 || j == (size / 3) * 2) { Console.Write("*"); }
                        else { Console.Write(" "); }
                    }
                    Console.WriteLine();
                }
                else if (i == 1 || i == size - 1) //C의 위/아래 변 부분
                {
                    Console.Write(" ");
                    for (int j = 0; j < size - 2; j++) { Console.Write("*"); }
                    Console.Write(" ");
                    for (int j = 0; j < size; j++)
                    {
                        if (j == size / 3 || j == (size / 3) * 2) { Console.Write("*"); }
                        else { Console.Write(" "); }
                    }
                    Console.WriteLine();
                }
                else if (i == size / 3 || i == (size / 3) * 2) //#의 가로줄 부분
                {
                    Console.Write("*");
                    for (int j = 0; j < (size - 1); j++) { Console.Write(" "); }
                    for (int j = 0; j < size; j++) { Console.Write("*"); }
                    Console.WriteLine();
                }
                else //그 외
                {
                    Console.Write("*");
                    for (int j = 0; j < (size - 1); j++) { Console.Write(" "); }
                    for (int j = 0; j < size; j++)
                    {
                        if (j == size / 3 || j == (size / 3) * 2) { Console.Write("*"); }
                        else { Console.Write(" "); }
                    }
                    Console.WriteLine();
                }
            }
            // --------------------
        }

        // calculate the distance between (x1, y1) and (x2, y2)
        static double SqrDistance2D(double x1, double y1, double x2, double y2)
        {
            return Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
        }

        // Checks if two values a and b are within a given distance.
        // |a - b| < distance
        static bool IsClose(double a, double b, double distance)
        {
            return Math.Abs(a - b) < distance;
        }
    }
}


/* example output
Enter the radius: 
>> 5
                *   *   
  *********     *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
  *********     *   *   

*/

/* example output (CHALLANGE)
Enter the radius: 
>> 5
                *   *  
      *         *   *  
   *     *      *   *  
  *                    
           ************
               *   *   
 *             *   *   
               *   *   
           ************
  *                    
   *     *    *   *    
      *       *   *    

*/
