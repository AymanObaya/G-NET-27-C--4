namespace ASSIGNMENT_SESSION_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region QUESTION 01

            //(A)
            //string productList = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList += "PROD-" + i + ",";
            //}

            /*
            immuImmutable type meaning its contents cannot be changed after creation. 
            every time change or operation to string must create new object
            that make more Memory allocations and more time
            */

            //(b)

            //StringBuilder sb = new StringBuilder();

            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append("PROD-" + i + ",");
            //}





            //(c)
            //var Watch01 = System.Diagnostics.Stopwatch.StartNew();
            //string productList = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList += "PROD-" + i + ",";
            //}
            //Watch01.Stop();

            //Console.WriteLine($"string Time    :{Watch01.ElapsedMilliseconds}");



            //var Watch02 = System.Diagnostics.Stopwatch.StartNew();
            //StringBuilder sb = new StringBuilder();

            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append("PROD-" + i + ",");
            //}
            //Watch02.Stop();

            //Console.WriteLine($"string Time    :{Watch02.ElapsedMilliseconds}"); 
            #endregion

            #region QUESTION 2
            //double price = 0.00;
            //int age;
            //int dayOfWeek;
            //bool hasStudentID;
            //StringBuilder breakdown = new StringBuilder();

            //Console.WriteLine("Enter your age:");
            //int.TryParse(Console.ReadLine(), out age);

            //Console.WriteLine("Enter the day of the week (1-7, where 6 = Fri, 7 = Sat):");
            //int.TryParse(Console.ReadLine(), out dayOfWeek);

            //Console.WriteLine("Do you have a student ID? (1 = yes , 0 = no):");
            //hasStudentID = Console.ReadLine() == "1";

            //if (age <= 0  dayOfWeek <= 0  dayOfWeek > 7)
            //{
            //    Console.WriteLine("Invalid input. Age or day of week are invalid.");
            //    return;
            //}
            //else
            //{
            //    // Calculate base price based on age
            //    if (age < 5)
            //    {
            //        price = 0.00;
            //        breakdown.AppendLine("Age < 5: Free");
            //    }
            //    else if (age >= 5 && age <= 12)
            //    {
            //        price = 30.00;
            //        breakdown.AppendLine("Age 5 - 12: 30 LE");
            //    }
            //    else if (age >= 13 && age <= 59)
            //    {
            //        price = 50.00;
            //        breakdown.AppendLine("Age 13 - 59: 50 LE");
            //    }
            //    else
            //    {
            //        price = 25.00;
            //        breakdown.AppendLine("Age 60 +: 25 LE");
            //    }

            //    // Add weekend surcharge if applicable
            //    if ( (dayOfWeek == 6 || dayOfWeek == 7) && price > 0.00)
            //    {
            //       price += 10.00;
            //       breakdown.AppendLine("Weekend surcharge: +10 LE");
            //    }

            //    // Apply student discount if applicable
            //    if (hasStudentID && price > 0.00)
            //    {
            //        double discount = price * 0.20;
            //        price -= discount;
            //        breakdown.AppendLine($"Student discount -20%: {discount} LE");
            //    }
            //}

            //Console.WriteLine($"\nFinal Price: {price} LE");
            //Console.WriteLine($"\nPrice Breakdown: \n{breakdown}"); 
            #endregion

            #region QUESTION 3
            //Traditional switch statement:
            //string fileExtension = ".doc";
            //string fileType;
            //switch (fileExtension)
            //{
            //    case ".pdf":
            //        fileType = "PDF Document";
            //        break;
            //    case ".docx":
            //    case ".doc":
            //        fileType = "Word Document";
            //        break;
            //    case ".xlsx":
            //    case ".xls":
            //        fileType = "Excel Spreadsheet";
            //        break;
            //    case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileType = "Image File";
            //        break;
            //    default:
            //        fileType = "Unknown File Type";
            //        break;
            //}
            //Console.WriteLine(fileType);

            //Switch expression:
            //string fileExtension = ".pdf";
            //string fileType;
            //fileType = fileExtension switch
            //{
            //    ".pdf" => "PDF Document",
            //    ".docx" or ".doc" => "Word Document",
            //    ".xlsx" or ".xls" => "Excel Spreadsheet",
            //    ".jpg" or ".png" or ".gif" => "Image File",
            //    _ => "Unknown File Type"
            //};
            //Console.WriteLine(fileType);

            #endregion

            #region QUESTION 4
            //int temperature = 35;
            //string weatherAdvice = temperature < 0 ? "Freezing! Stay indoors." :
            //                       temperature < 15 ? "Cold. Wear a jacket." :
            //                       temperature < 25 ? "Pleasant weather." :
            //                       temperature < 35 ? "Warm. Stay hydrated." :
            //                                          "Hot! Avoid sun exposure";
            //Console.WriteLine(weatherAdvice);
            /* 
             * Use ternary operators when:
                The logic is simple and short
                You’re assigning a value based on a small number of conditions
                Not recommended nested ternaery

             * Use if / else when:
                There are multiple conditions
                The logic might grow or change
                Readability and maintainability matter
                no problem when make nested if / else
            */
            #endregion

            #region QUESTION 5
            //int attempts = 0;
            //string password;
            //bool hasUppercase = false;
            //bool hasDigit = false;
            //bool hasWhitespace = false;
            //bool passwordAccepted = false;

            //Console.WriteLine("Enter a password:");
            //password = Console.ReadLine() ?? "";


            //do
            //{

            //    if (password.Length >= 8)
            //    {
            //        //iterate through characters to check for uppercase, digit, and whitespace
            //        foreach (char c in password)
            //        {
            //            if (char.IsUpper(c))
            //            {
            //                hasUppercase = true;
            //            }
            //            if (char.IsDigit(c))
            //            {
            //                hasDigit = true;
            //            }
            //            if (char.IsWhiteSpace(c))
            //            {
            //                hasWhitespace = true;
            //            }
            //        }

            //        //validate conditions and provide feedback
            //        if (hasUppercase && hasDigit && !hasWhitespace)
            //        {
            //            //if all conditions met, accept password and break loop
            //            passwordAccepted = true;
            //            break;
            //        }
            //        else
            //        {
            //            //if any conditions are violated, inform user and increment attempts
            //            if (!hasUppercase)
            //            {
            //                Console.WriteLine("Password must contain at least one uppercase letter.");
            //            }
            //            if (!hasDigit)
            //            {
            //                Console.WriteLine("Password must contain at least one digit.");
            //            }
            //            if (hasWhitespace)
            //            {
            //                Console.WriteLine("Password must not contain spaces.");
            //            }

            //            //reset the flags for the next attempt
            //            hasUppercase = false;
            //            hasDigit = false;
            //            hasWhitespace = false;

            //            attempts++;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Password must be at least 8 characters long.");
            //        attempts++;
            //    }

            //    Console.WriteLine("\nEnter another password: ");
            //    password = Console.ReadLine() ?? "";

            //} while (attempts < 5);

            ////check if attempts exceeded limit
            //if (passwordAccepted)
            //{
            //    Console.WriteLine("Password accepted!");
            //}
            //else
            //{
            //    Console.WriteLine("Account locked.");
            //} 
            #endregion

            #region QUESTION 6
            ////            int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };

            ////            //(a)find and display all failing scores
            ////            StringBuilder failingScores = new StringBuilder("Failing scores (below 50): ");

            ////            for (int i = 0; i < scores.Length; i++)
            ////            {
            ////                if (scores[i] < 50)
            ////                {
            ////                    failingScores.Append(scores[i] + " ");
            ////                }
            ////            }
            ////            Console.WriteLine(failingScores.ToString());

            ////            //(b)find the first score above 90 and stop searching immediately
            ////            for (int i = 0; i < scores.Length; i++)
            ////            {
            ////                if (scores[i] > 90)
            ////                {
            ////                    Console.WriteLine("First score above 90: " + scores[i]);
            ////                    break;
            ////                }
            ////            }

            ////           // (c)calculate the class average, excluding any scores below 40
            ////            int total = 0;
            ////        int count = 0;
            ////        int average = 0;
            ////            for (int i = 0; i<scores.Length; i++)
            ////            {
            ////                if (scores[i] >= 40)
            ////                {
            ////                    total += scores[i];
            ////                    count++;
            ////                }
            ////}
            ////average = total / count;
            ////Console.WriteLine("Class average (excluding scores below 40): " + average);


            //////(d)count how many students scored in each grade range
            ////            int countA = 0;
            ////int countB = 0;
            ////int countC = 0;
            ////int countD = 0;
            ////int countF = 0;

            ////foreach (int score in scores)
            ////{
            ////    if (score >= 90 && score <= 100)
            ////    {
            ////        countA++;
            ////    }
            ////    else if (score >= 80 && score <= 89)
            ////    {
            ////        countB++;
            ////    }
            ////    else if (score >= 70 && score <= 79)
            ////    {
            ////        countC++;
            ////    }
            ////    else if (score >= 60 && score <= 69)
            ////    {
            ////        countD++;
            ////    }
            ////    else
            ////    {
            ////        countF++;
            ////    }
            ////}

            ////Console.WriteLine($"Grade Range Count:\nA: {countA}\nB: {countB}\nC: {countC}\nD: {countD}\nF: {countF}"); 
            #endregion
        }
    }
}
