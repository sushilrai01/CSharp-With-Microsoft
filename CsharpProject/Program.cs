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

// for (int i = 1; i <= 100; i++)
// {
//     if(i % 3 == 0 && i % 5 ==0){
//         Console.WriteLine(i + "- FizzBuzz");
//     }

//     else if (i % 5 == 0){
//         Console.WriteLine(i + "- Buzz");
//     }
//     else if(i % 3 == 0){
//         Console.WriteLine(i + "- Fizz");
//     }
//     else
//         Console.WriteLine(i);
// }

//--------------------------------------______while & do-while loop______---------------
// Random random = new Random();
// int current = 0;

// do{
//     current = random.Next(1,11);
//     if(current >=8) continue;
//     Console.WriteLine(current);
// } while(current != 7);

// while(current !=7){
//     Console.WriteLine( current);
//     current = random.Next(1,11);
// }
// Console.WriteLine($"Last number: {current}");
//---------------------------------------------
// for (int i = 0; i<10; i++){
//     if (i ==5 || i ==2) continue;
//     Console.WriteLine( i);
// }

//--------------------------___________Role playing game battle challenge______-------------
// Random random = new Random();   
// int heroHealth = 20;
// int monsterHealth = 20; 
// int damage ;

// do{
//     Console.WriteLine("");
//     damage = random.Next(1, 10);
//     monsterHealth = monsterHealth-damage;
//     Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");

//     if(monsterHealth < 0) continue;

//     damage = random.Next(1, 10);
//     heroHealth = heroHealth-damage;
//     Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");

//     Console.WriteLine("");
// } while(heroHealth > 0 && monsterHealth > 0);

// if(heroHealth > monsterHealth) Console.WriteLine("Hero Wins!");
// else if(monsterHealth > heroHealth) Console.WriteLine("Monster wins!");
// else Console.WriteLine("Draw x.");

//--------------------------___________Role playing game battle challenge______-------------
// string? readResult;
// Console.WriteLine("Enter a string:");
// do
// {
//     readResult = Console.ReadLine();
// } while (readResult == null);
//-------valid entry---------
// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);

//__________________________----Code project 1 - write code that validates integer input----____________________
// string? readResult;
// int numericValue = 0;
// bool validEntry = false;

// Console.WriteLine("Enter a number between 5 and 10:");

// do{
//     readResult = Console.ReadLine();
//     validEntry = int.TryParse(readResult, out numericValue);
//     if(validEntry)
//     {
//         if(numericValue > 5 && numericValue < 10){
//              break; 
//         }   
//         else
//         {
//             Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
//             validEntry = false;
//         }
//     }
//     else
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again!");
//     }

// } while(validEntry == false);

// Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
//__________________________----Code project 1 - write code that validates integer input----____________________

//__________________________----Code project 2 - write code that validates string input----____________________
// string? readResult;
// string role = "";
// bool validEntry = false;

// Console.WriteLine("Enter your role name(Administrator, Manager, or User):");
// do{
//     readResult = Console.ReadLine();

//     if(readResult != null){
//         role = readResult.Trim();
//         role = role.ToLower();  
//     }

//     if(role == "administrator"  || role == "manager" || role == "user"){
//         validEntry = true;  
//     }
//     else
//     {
//          Console.WriteLine($"The role name that you entered, \"{role}\" is not valid.");
//     }

// } while(validEntry == false);

// Console.WriteLine($"Your input value ({role}) has been accepted.");
//__________________________----Code project 2 - write code that validates string input----____________________

//__________________________----Code project 3 - Write code that processes the contents of a string array----____________________
// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int periodLocation = 0;
// string myString = "";

// for(int i = 0; i< myStrings.Length; i++)
// {
//     myString = myStrings[i];
//     periodLocation = myString.IndexOf(".");

//     string mySentence;

//     while(periodLocation != -1){
//         mySentence = myString.Remove(periodLocation);
//         myString = myString.Substring(periodLocation + 1);
//         myString = myString.TrimStart();
//         periodLocation = myString.IndexOf(".");
//         Console.WriteLine(mySentence);
//     }

//     mySentence = myString.Trim();
//     Console.WriteLine(mySentence);
// }
//__________________________----Code project 3 - Write code that processes the contents of a string array----____________________
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");