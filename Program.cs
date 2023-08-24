namespace lesson08Cshap
{
    // linq to objiect
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("linq to obj");
            string[] a = { "vàng bá Sênh", "Bùi Minh Thành", "QUang Nhựt", "Đàm Quốc Dân" };
            /*select
             * from     1
             * where    2
             * group by 3
             * having   4
             * order by 5
             * 
             */
            IEnumerable<string> data = from dt in a select dt;
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("In ra những người có ký tự an");
            data = from dt in a where dt.Contains("an") select dt;
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}