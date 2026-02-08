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

        }
    }
}
