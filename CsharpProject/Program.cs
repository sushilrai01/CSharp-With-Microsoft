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
// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
// Console.WriteLine($"char : {sizeof(int)} to {char.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// int[] data;
// data = new int[3];
// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

/////////-----------
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);
//TryParse()
// string value = "10o2";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// Console.WriteLine($"Measurement (w/ offset): {50 + result}");
//____________________________combining string array values as strings and as integers challenge________________
// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// decimal number = 0;
// decimal sum = 0;
// bool isNumber = false;
// string str;
// string message = "";
// for (int i = 0; i < values.Length; i++)
// {
//     str = values[i];
//     isNumber = decimal.TryParse(str, out number);
//     if (isNumber)
//     {
//         sum += number;
//     }
//     else
//     {
//         message += str;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {sum}");

//
// int value1 = 12;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// //Convert.ToInt32() rounds up the way you would expect.
// int result1 = Convert.ToInt32((decimal)value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// decimal result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
// // float res = (float)value2;
// // Console.WriteLine(res);

//__________Array Methods: sort,reverse, clear, resize
// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
//_______________array: clear_______
// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0]}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0].ToLower()}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
//____________________Array.Resize_________________________
// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

//_______________________ String to char array_______________
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// string newArray = new string(valueArray);
// Console.WriteLine(newArray);
// // 
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);
// //split
// string[] items = result.Split(',');
// Console.WriteLine(items);
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

//_________________Write code to reverse each word in a message_______________
// string pangram = "The quick brown fox jumps over the lazy dog";
// string reverseMsg = "";

// Console.WriteLine(pangram);
// string[] itemString = pangram.Split();

// foreach (string item in itemString)
// {
//     char[] chars = item.ToCharArray();
//     Array.Reverse(chars);
//     string msg = new string(chars);
//     reverseMsg += msg + " ";
// }

// Console.WriteLine(reverseMsg);

//_______________ ____________challenge to parse a string of orders, sort the orders and tag possible errors _______________
// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// String[] orderArray = orderStream.Split(',');
// Array.Sort(orderArray);
// string resultjoin = string.Join(",", orderArray);
// Console.WriteLine(resultjoin);

// foreach (string order in orderArray)
// {
//     int stringLength = order.Length;

//     if (stringLength == 4)
//         Console.WriteLine(order);
//     else
//         Console.WriteLine($"{order} - Error");
// }

//_______________string formatting basics____________
//________________ composite formatting________________
// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);
// //__________String interpolation________________
// decimal prices = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {prices:C} (Save {discount:C})");
// //___The N numeric format specifier makes numbers more readable
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");
// Console.WriteLine($"Measurement: {measurement:N4} units");//precison
// //Formatting Percentages
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P3}");
// //Combining all....
// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
// yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);

// print a receipt using string interpolation
// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");
//______________Formatting strings by adding whitespace before or after____________________
// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12));
// Console.WriteLine(input.PadRight(12));
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);
//________________------challenge to apply string interpolation to a form letter_____________________
// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);

//___________________Use the string's IndexOf() and Substring() helper methods_________________
// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);
// openingPosition += 1;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?";

// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span>");

// openingPosition += 6;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));
//_______________________________LastIndexOf()__________________________
// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length)); //OUTPUT: -set of parentheses-

//__________
// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }
//___________________Work with different types of symbol sets: ---IndexOfAny()----_____________
// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 6;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition: {message.Substring(openingPosition)}");
//______________________________________________________________________________
//______________________________________________________________________________

// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// char[] openSymbols = { '[', '{', '(' };
// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
//     if (openingPosition == -1) break;
//     string currentSymbol = message.Substring(openingPosition, 1);
//     char matchingSymbol = ' ';
//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;

//         case "{":
//             matchingSymbol = '}';
//             break;
//     }

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }
//_____________________________Remove() and Replace() methods____________________________________
// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// Console.WriteLine(message);
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);
//_______________________________Challenge to extract, replace, and remove data from an input string_______________________________
// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// string spanOpen = "<span>";
// string spanClose = "</span>";

// int openingPositionSpan = input.IndexOf(spanOpen);
// openingPositionSpan += spanOpen.Length;

// int closingPositionSpan = input.IndexOf(spanClose);
// int length = closingPositionSpan - openingPositionSpan;

// quantity = input.Substring(openingPositionSpan, length);

// output = input;
// const string divOpen = "<div>";
// const string divClose = "</div>";

// int divStart = output.IndexOf(divOpen);
// int divStartLength = divOpen.Length;
// // Console.WriteLine(divStartLength);
// // Console.WriteLine(divStart);
// output = output.Remove(divStart, divStartLength);
// Console.WriteLine("_______________");

// int divEnd = output.IndexOf(divClose);
// int divEndLenth = divClose.Length;
// // Console.WriteLine(divEnd);
// // Console.WriteLine(divEndLenth);
// output = output.Remove(divEnd, divEndLenth);

// output = output.Replace("&trade;", "&reg;");

// Console.WriteLine(quantity);
// Console.WriteLine($"Output: {output}");

//       _______________________________________________________________________
//  _______________________________MEthods in C# ___________________________________
//       _______________________________________________________________________

// int[] a = { 1, 2, 3, 4, 5 };

// Console.WriteLine("Contents of Array:");
// PrintArray();
// //method
// void PrintArray()
// {
//     foreach (int x in a)
//     {
//         Console.Write($"{x} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Before calling a method");
// SayHello();
// Console.WriteLine("After calling a method");
// //method

// void SayHello()
// {
//     Console.WriteLine("Hello World!");
// }
// //________--Random Numbers--____________
// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

// void DisplayRandomNumbers()
// {
//     Random random = new Random();

//     for (int i = 0; i < 5; i++)
//     {
//         Console.Write($"{random.Next(1, 100)} ");
//     }

//     Console.WriteLine();
// }

//_______________________Identify duplicated code & Create reusable methods__________________________
// using System;

// int[] times = { 90, 800, 1200, 1600, 2000 };
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");
// DisplayTime(times); //function /method

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     AdjustTimes();

// }
// else
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();

// }

// Console.WriteLine("New Medicine Schedule:");
// DisplayTime(times);

// //----------------Function
// void DisplayTime(int[] times)
// {
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }

//     Console.WriteLine();
// }

// void AdjustTimes()
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++)
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }
//_______________________Identify duplicated code & Create reusable methods__________________________
//   _____________________________________________________________________________________________

// //______________________ Checking... whether an IPv4 address is valid or invalid!!__________________________
// using System.Xml.Serialization;

// string ipv4Input = "107.031.255.205";
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;
// ValidateLength();
// ValidateZeroes();
// ValidateRange();

// if (validLength && validZeroes && validRange)
// {
//     Console.WriteLine($"ip is a valid IPv4 address");
// }
// else
// {
//     Console.WriteLine($"ip is an invalid IPv4 address");
// }

// void ValidateLength()
// {
//     string[] address = ipv4Input.Split('.');
//     validLength = address.Length == 4;
// }

// void ValidateRange()
// {
//     string[] address = ipv4Input.Split(".", StringSplitOptions.RemoveEmptyEntries);
//     int number = 0;
//     bool validNo = false;
//     foreach (string str in address)
//     {
//         validNo = int.TryParse(str, out number);
//         if (validNo && number > 0 && number < 255)
//         {
//             validRange = true;
//         }
//         else
//         {
//             Console.WriteLine("Greater no.");
//             validRange = false;
//             return; //_________________The return statement terminates execution of the________
//                     //_________________method and returns control to the method caller_________
//         }
//         // Console.WriteLine("111 " + str);
//     }
// }

// void ValidateZeroes()
// {
//     string[] address = ipv4Input.Split(".");
//     validZeroes = true;
//     foreach (string number in address)
//     {
//         if (number.Length > 1 && number.StartsWith("0"))
//         {
//             Console.WriteLine("Starts with zero'0'");
//             validZeroes = false;
//             return;
//         }
//     }
// }
//______________________ CHECKED... whether an IPv4 address is valid or invalid!! __________________________
//_____________________________________________________________________________________________________________
//______________________ Challenge To Create A Reusable Method that Prints A Player's Fortune !___________________

// Random random = new Random();
// int luck = random.Next(100);

// string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
// string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
// string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
// string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };
// Console.WriteLine(luck);
// FortuneTeller();

// luck = random.Next(100);
// Console.WriteLine($"Luck: {luck}");
// FortuneTeller();

// void FortuneTeller()
// {
//     Console.WriteLine("A fortune teller whispers the following words:");
//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++)
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }
//     Console.WriteLine("\n-------------------");
// }
//_____________________________________________________________________________________________________________
//________________________________Create a method with parameters_________________________________________
int[] schedule = { 800, 1200, 1600, 2000 };

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}

DisplayAdjustedTimes(schedule, 6, -6);

string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };
//______________________________--- Understand method scope ----_____________________
DisplayStudents(students);
DisplayStudents(new string[] { "Robert", "Vanya" });

void DisplayStudents(string[] students)
{
    foreach (string student in students)
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}

//______________________________-Parameters passed by value and passed by reference_____________________
//__________VALUE________________
int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}
//___________REFERENCE________________
int[] array = { 1, 2, 3, 4, 5 };

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array)
{
    foreach (int a in array)
    {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
    Console.WriteLine("cleared!!");
}

//________________-Test with strings___________
// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// SetHealth(status, false);
// Console.WriteLine($"End: {status}");

// void SetHealth(string status, bool isHealthy)
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }
//____________ overwrite the global status variable with the new string value.________
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}