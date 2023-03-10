using System;

namespace Lab5_Creating_Exceptions
{
    internal class Program
    {
        static void Main()
        {

            //One object with positive radius
            Circle RadPos = new Circle(1.25);
            Console.WriteLine($"{RadPos} \nArea: {RadPos.Area}");

            //One object with negative radius
            try

            {

                Circle RadNeg = new Circle(-1.25);

            }

            catch (InvalidRadiusException IREx)

            {

                Console.WriteLine(IREx.Message);

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }

            //One object with radius of zero

            try

            {

                Circle NoRad = new Circle(0);

            }

            catch (InvalidRadiusException IREx)

            {

                Console.WriteLine(IREx.Message);

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }

        }
    }
}
