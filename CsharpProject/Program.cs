﻿// // // Random dice = new Random();

// // // int roll1 = dice.Next(1, 7);
// // // int roll2 = dice.Next(1, 7);
// // // int roll3 = dice.Next(1, 7);

// // // int total = roll1 + roll2 + roll3;

// // // Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
// // // if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// // // {
// // //     Console.WriteLine("You rolled doubles! +2 bonus to total!");
// // //     total += 2;
// // // }
// //     string[] fraudulentOrderIDs = new string[3];

// //     fraudulentOrderIDs[0] = "A123";
// //     fraudulentOrderIDs[1] = "B456";
// //     fraudulentOrderIDs[2] = "C789";
// //     // fraudulentOrderIDs[3] = "D000";
// //     Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// //     Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// //     Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
// //     Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// // int[] ints = {1,2,4,5};
// // foreach (int i in ints){
// //     Console.WriteLine("" + i);
// // }

// string[] items = {"B123",
//                     "C234",
//                     "A345",
//                     "C15",
//                     "B177",
//                     "G3003",
//                     "C235",
//                     "B179"};
// foreach(var item in items)  {
//     if (item.StartsWith("B"))
//     {
//         Console.WriteLine("The name starts with 'B'!");
//     }
// }
// Random random = new Random();
// string[] orderIDs = new string[5];
// // Loop through each blank orderID
// for (int i = 0; i < orderIDs.Length; i++)
// {
//     // Get a random value that equates to ASCII letters A through E
//     int prefixValue = random.Next(65, 70);
//     // Convert the random value into a char, then a string
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     // Create a random number, pad with zeroes
//     Console.WriteLine(prefix);
//     string suffix = random.Next(1, 1000).ToString("000");
//     // Combine the prefix and suffix together, then assign to current OrderID
//     orderIDs[i] = prefix + suffix;
// }
// // Print out each orderID
// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

// string str = "The quick brown fox jumps over the lazy dog.";

// char[] charMessage = str.ToCharArray();
// Array.Reverse(charMessage);
// int x = 0;

// foreach (char c in charMessage){
//     if (c == 'o') {x++;}
// }

// string new_message = new String(charMessage);
// // print it out
// Console.WriteLine(new_message);
// Console.WriteLine($"'o' appears {x} times.");

// int saleAmount = 101;
// // int discount = saleAmount > 1000 ? 100 : 50;

// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// string permission = "Admin|Manager";
// int level = 53;

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// bool flag = true;
// int value=0;
// if(flag){
//     value = 10;
//     Console.WriteLine("Inside: " + value);
//     value +=10; 
//         Console.WriteLine("Inside1: " + value);

// }
// value +=10;
//     Console.WriteLine($"outside:  {value}");
// bool flag = true;
// int value = 100;

// if (flag)
// {
//     value = 11;
//     Console.WriteLine("Inside of code block: " + value);
// }
// Console.WriteLine("Outside of code block: " + value);

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// bool found = false; 
// foreach (int number in numbers)
// {
//     int total = 0;

//     total += number;

//     if (number == 42)
//     {
//        bool found = true;
//         if (found) 
//         {
//             Console.WriteLine("Set contains 42");

//         }
//     }

// }

// Console.WriteLine($"Total: {total}");

// --------------------------------------------Switch Statements..........................
// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel) 
// {
//     // case 100:
//     // title = "Junior Associate";
//     // break;
//     case 100:
//     case 200:
    //     title = "Senior Associate";
    //     break;
//     case 300:
    //     title = "Manager";
    //     break;
//     case 400:
    //     title = "Senior Manager";
    //     break;
//     default:
    //     title = "Associate";
    //     break;

// }

// Console.WriteLine($"{employeeName},{title}");
//------------------------------------------------------
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0]) {
//     case "01":
//         type = "Sweat Shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default: 
//         type = "other";
//         break;
// }

// switch (product[1]) {
//     case "BL": 
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default: 
//         color = "White";
//         break;
// }

// switch(product[2]){
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

//---------------------------------------------______For Loop______---------------------------------
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) {
//         Console.WriteLine("yooo");
//         break;
//         // Console.WriteLine("yoossssso");
//     }
// }
//--------------
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// foreach (var name in names)
// {
//     // Can't do this:
//     if (name == "David") name = "Sammy";
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++){
//  if (names[i] == "David") {
//         names[i] = "Sammy";
//     }
//     Console.WriteLine(names[i]);
// }
//        Console.WriteLine("[i]");

//    foreach(var name in names) {
       
//     Console.WriteLine(name);

//    }

//----------------_______FizzBuzz Challenge_____------

for (int i = 1; i <= 100; i++)
{
    if(i % 3 == 0 && i % 5 ==0){
        Console.WriteLine(i + "- FizzBuzz");
    }
   
    else if (i % 5 == 0){
        Console.WriteLine(i + "- Buzz");
    }
    else if(i % 3 == 0){
        Console.WriteLine(i + "- Fizz");
    }
    else
        Console.WriteLine(i);
}