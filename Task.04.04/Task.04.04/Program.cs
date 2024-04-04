using System.Reflection.Metadata;
using Task._04._04.Models;

namespace Task._04._04
{

    internal record StudentRecord()
    {
        public string Name { get; set; }
        public string Surname { get; set; } 
        public byte Age { get; set; }   
        public string Group { get; set; }   
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parriot ali = new Parriot();    
            Shark acula = new Shark();
            Eagle sahin = new Eagle();  
            //ali.Eat();
            //acula.Eat();
            //sahin.Fly();
            //ali.Fly();
            Animal[] animals = {ali, acula,sahin};
            foreach (Animal item in animals)
            {
                item.Eat();
            }
            
            //StudentRecord st1 = new StudentRecord()
            //{
            //    Name = "Orkhan",
            //    Surname = "Gurbanli",
            //    Age = 20,
            //    Group="AB106"
            //};
            //StudentRecord st2 = new StudentRecord()
            //{
            //    Name = "James",
            //    Surname = "Bond",
            //     Age = 20,
            //    Group = "AB106"
            //};
            //Console.WriteLine(st1 == st2);


            //(int, string) A = (1, "Salam");
            //   Console.WriteLine(A.Item1);


            //(string, string, int) B = ("Orxan","Qurbanli",20);
            //Console.WriteLine(B);
  

            //(int, string,string,bool) C = (2, "Code","Academy",true);
            //Console.WriteLine(C);
        }
    }

    
}