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
        }
    }
}
