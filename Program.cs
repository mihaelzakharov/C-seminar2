 Console.WriteLine("Начало работы по семинару2");
 // напишите программу, котрорая принимает на вход трехзнач. число и удаляет вторую цифру этого числа

 int CutNumber(int number)
 {
    int firstInt =  number / 10;
    int secondInt = number % 10;
    int maxInt = firstInt;

    if(firstInt < secondInt)
        maxInt = secondInt;
    return maxInt;
     
 }

 int number1 = new Random().Next(10, 100);
int result = CutNumber(number1);
 Console.WriteLine(result);