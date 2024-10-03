#region task1
//int num = 371;
//int subNum1 = num % 10;
//int subNum2 = ((num - subNum1) % 100) / 10;
//int subNum3 = num / 100;
//int sum = subNum1 + subNum2 + subNum3;

//if (sum % 2 == 0)
//{
//    Console.WriteLine("cutdur");
//}
//        else
//{
//    Console.WriteLine("tekdir");
//};
#endregion










#region task2
//int number = 4786;
//int subNumber1 = number / 1000;
//int subNumber2 = (number % 1000) / 100;
//int subnumber3 = ((number % 1000) % 100) / 10;
//int subNumber4 = ((number % 1000) % 100) % 10;
//int numAvarege = (subNumber1 + subNumber2 + subnumber3 + subNumber4) / 4;
//Console.WriteLine(numAvarege);
#endregion



#region task3
//int number = 372;
//int subNum1 = number / 100;
//int subNum2 = (number / 10) % 10;
//int subNum3 = number % 10;
//int sumSubNumbers = subNum1 + subNum2 + subNum3;
//if (sumSubNumbers % 3 == 0 && sumSubNumbers % 5 == 0)
//{
//    Console.WriteLine("sumSubNumbers can divide by 3 and 5");
//}
//else
//{
//    Console.WriteLine("sumSubNumbers can't divide by 3 and 5");
//}
#endregion




#region task4_way1
//float gpa = 78.4f;
//switch (gpa)
//{
//    case > 90:Console.WriteLine("A");
//        break;
//    case > 80:Console.WriteLine("B");
//        break;
//    case > 50 and <= 80:Console.WriteLine("C");
//        break;
//    default:Console.WriteLine("F");
//        break;

//}
#endregion





#region task4_way2
//float gpa2 = 60.5f;
//switch (gpa2)
//{
//    case float m when (m > 90):
//        console.writeline("a");
//        break;
//    case float m when (m > 80):
//        console.writeline("b");
//        break;

//    case float m when (m > 60):
//        console.writeline("c");
//        break;
//    case float m when (m > 50):
//        console.writeline("f");
//        break;
//    default:
//        console.write("mission impossible");
//        break;


//}
#endregion


#region task4_way3
//using System.Diagnostics;

//float gpa3 = 50.9f; 
//string message = gpa3 switch
//{
//    >= 51 =>"student have passed  exam",
//    <= 51=>"Student havent passed exam"
//};
//Console.WriteLine(message);
#endregion














#region task5
//int a = 8;
//int b = 3;
//int sum=0;
//if(a%2==0 && b % 2 == 0)
//{
//    sum = a + b;
//}
//else
//{
//    sum = a - b;
//}
//Console.WriteLine(sum);
#endregion


#region task6
//int salary = 3000;
//int credit = 20000;
//int annualsalary = salary * 12;

//if (credit > (annualsalary * 60) / 100)
//{
//    Console.WriteLine("Unsuccessful");
//}
//else
//{
//    Console.WriteLine("Successful");
//}
#endregion
