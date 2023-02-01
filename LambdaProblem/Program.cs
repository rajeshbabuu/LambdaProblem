namespace LambdaProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<Person> listPersonlnCity = new List<Person>();
            LambdaDemo.AddRecords(listPersonlnCity);

            LambdaDemo.Retrieving_TopTwoRecord_ForAgels_LessThanSixty(listPersonlnCity);
            LambdaDemo.CheckingForTeenagerPerson(listPersonlnCity);
            LambdaDemo.AllPersonsAverageAge(listPersonlnCity);
            LambdaDemo.CheckNameExistOrNot(listPersonlnCity);
            Console.ReadKey();
        }
    }
}