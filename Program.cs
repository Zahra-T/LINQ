using System;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] numbers = {5, 3, 100, 8, 3, 25, 36, 154 , 14, 90};
            var check = numbers.Where(args => args==2).Any();
            var check2 = numbers.Any(a => a==2);
            var selectFirst = numbers.Where(a => a == 3).First();//age nabashe exception
            var selectFirstDefault = numbers.Where(a => a == 13).FirstOrDefault(); // age nabashe meghdar default
            var single = numbers.Where(a => a == 45).Single();//meghdar yeksan dashte bashe exception
            var singleOrDefault = numbers.Where(a => a == 45).SingleOrDefault(); //meghdar yeksan dashte bashe meghdar default miare.
            Console.WriteLine(selectFirst);


            string [] names = {"zahra", "rahim", "reza", "fatima", "hassan"};
            var hasI = names.Where(name => name.Contains('i') || name.Contains('I').ToArray();
            var startWithS = names.Where(name => name[0] == 's' || name[0] == 'S').ToArray();
            
             Person [] persons = {new Person(1, "rahim", "reazaee"), new Person(2, "hassan", "bagheri"), new Person(3, "maryam", "mirzaee")};
              Hoghoogh [] hoghooghs = {new Hoghoogh(1, 1000, 1000, 1000), new Hoghoogh(2, 2000, 3000, 1000), new Hoghoogh(3, 5000, 6000, 4000)};

            var max = persons.Join(hoghooghs,
            (p => p.ID),
            (h => h.ID),
            ((p, h) => new {
                ID = p.ID,
                sum = (h.dey + h.bahman + h.esfand)
            })).ToArray().Max(a => a.sum);
            
            Console.WriteLine(max.ToString());


        }

       
    }

    class Person{
           public int ID;
           public string name;
            public string lastName;

            public Person(int ID, string name, string lastName){
                    this.ID = ID;
                    this.name = name;
                    this.lastName = lastName;
            }
            
    }

    class Hoghoogh{
        public int ID;
        public int dey;
        public int bahman;
        public int esfand;

        public Hoghoogh(int ID, int dey, int bahman, int esfand){
            this.ID = ID;
            this.dey = dey;
            this.bahman = bahman;
            this.esfand = esfand;
        }
    }
}
