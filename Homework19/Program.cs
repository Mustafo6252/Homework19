
//// -------------------------------  Task 1  ----------------------------------
//
// using Homework19.Task1;
// var dayPropertie=new DayProperties();
// dayPropertie.GetInfo();

// // -------------------------------  Task 2  ----------------------------------
//
// int sum = 0;
// while (true)
// {
//     Console.Write("Enter word: ");
//     string word = Console.ReadLine();
//     
//     if(word=="end")
//     {
//         break;
//     }
//     else
//     {
//         sum++;
//     }
// }
// Console.WriteLine($"Result: {sum}");

// // -------------------------------  Task 3  ----------------------------------
//
// using Homework19.task3;
//
// var gauge=new Gauge();
// gauge.Increase();
// gauge.Increase();
// gauge.Increase();
// gauge.Increase();
// gauge.Decrease();
// gauge.Decrease();
// gauge.Increase();
// gauge.Increase();
// gauge.Increase();
// if (gauge.Full() is true)
// {
//     Console.WriteLine("value is: 5");
// }
// else
// {
//     Console.WriteLine("value is not 5 yet");
// }

// // -------------------------------  Task 4  ----------------------------------
//
// using Homework19.Task4;
//
// var counter=new Counter();
// counter.Increase();
// counter.Increase(5);
// counter.Decrease();
// counter.Decrease();
// counter.Decrease(3);
// counter.Decrease(-5);
// counter.Increase(9);
// counter.Decrease(3);
//
// counter.GetInfo();

// // -------------------------------  Task 4  ----------------------------------
//
// using Homework19.Task5;
//
// var terminal = new PaymentTerminal();
// PaymentCard card=new PaymentCard(5.00);
//
// Console.WriteLine("Initial card balance: " + card.GetBalance());
//
//
// bool lunchPaid = terminal.ProcessLunchPayment(card);
// Console.WriteLine("Lunch paid with card " + lunchPaid);
// Console.WriteLine("Card balance after attempt: " + card.GetBalance());
//
//
// terminal.AddMoneyToCard(card, 20.00);
// Console.WriteLine("Card balance after loading money: " + card.GetBalance());
//
//
// bool coffeePaid = terminal.ProcessCoffeePayment(card);
// Console.WriteLine("Coffee paid with card? " + coffeePaid);
// Console.WriteLine("Card balance now: " + card.GetBalance());
//
// double change = terminal.ProcessLunchPayment(15.00);
// Console.WriteLine("Cash change from lunch: " + change);
// Console.WriteLine("Money in register: " + terminal.GetMoney());
