// // // Random dice = new Random();

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

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);
int x = 0;

foreach (char c in charMessage){
    if (c == 'o') {x++;}
}

string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");