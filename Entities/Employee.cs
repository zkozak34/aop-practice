namespace Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Add(int id, string firstName, string lastName)
        {
            //Console.WriteLine("Method body start!");
            //Console.WriteLine($"\t {"Id", -15} : {id}");
            //Console.WriteLine($"\t {"FirstName", -15} : {firstName}");
            //Console.WriteLine($"\t {"LastName", -15} : {lastName}");
            //Console.WriteLine("Method body stop!");
            Console.WriteLine("Added.");
        }
    }
}