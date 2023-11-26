using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace linq
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>() ;
            for(int i = 0; i <=100; i++)
            {
                ints.Add(i);
            }

            //1
            List<int> odds = ints.Where(i=> i % 2 == 1).ToList();
            
            //2
            List<int> squaredInts = ints.Select(i => i*i).ToList();
            
            //3
            int sum = ints.Sum();
            
            //4
            List<Person> people = new List<Person>();
            
            //5
            for (int i = 0; i <20; i++)
            {
                people.Add(new Person());
            }
            
            //6
            List<string> olderThenTwenty = people.Where(i => i.Age > 20).Select(m => m.Name).ToList();
            
            //7
            var anonymousObjs = people.Where(i => i.Age > 20).OrderBy(m => m.Name).Select(m => new { Name = "newName", Age = 12 }).ToList();
            
            //8
            int a = Penultimate<int>(ints);

        }

        //8
        public static T Penultimate<T>(this IEnumerable<T> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            IList<T> list = source as IList<T> ?? source.ToList();

            if (list.Count < 2)
            {
                throw new InvalidOperationException("Sequence contains fewer than two elements.");
            }

            return list[list.Count - 2];
        }
    }
}