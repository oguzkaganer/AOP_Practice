namespace Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Add(int id, string firstname, string lastname)
        {
            //Id = id;
            //FirstName = ad;
            //LastName = soyad;
            //Console.WriteLine("Method body start!");
            //Console.WriteLine($"\t {"Id",-10} : {Id}");
            //Console.WriteLine($"\t {"FirstName",-10} : {FirstName}");
            //Console.WriteLine($"\t {"LastName",-10} : {LastName}");
            //Console.WriteLine("Method body end!");

            //if (id == null || firstname == null || lastname == null)
            //    throw new ArgumentNullException();

            Console.WriteLine("Added");
        }

        public virtual void Update(int id, string firstname, string lastname)
        {
            //if (id == null || firstname == null || lastname == null)
            //    throw new ArgumentNullException();

            Console.WriteLine("Updated");
        }
    }
}