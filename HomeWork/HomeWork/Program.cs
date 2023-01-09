

using HomeWork.Constans;
using HomeWork.Controller;
using HomeWork.Exceptions;
using ServiceLayer.Service;

#region Factorial
//try
//{

//    GetNumberFactorial();

//    static void GetNumberFactorial()
//    {
//        int fact = 1;
//        int num = -10;

//        if (num > 0)
//        {
//            for (int i = 1; i < num; i++)
//            {
//                fact = fact * i;

//            }

//            Console.WriteLine(fact);
//        }
//        else
//        {
//            throw new InvalidNumsException(Error.ErorMessage);

//        }

//    }
//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}
#endregion


PersonController person=new PersonController();

person.GetPersons();
