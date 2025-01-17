//class Program
//{
//    public static void Main()
//    {
//CSharp kiểu mới KHÔNG CẦN TẠO HÀM MAIN
//1. LINQ là gì?
//LINQ (Language Integrated Query) là một tính năng mạnh mẽ trong C# (và .NET Framework)
//cho phép truy vấn dữ liệu từ nhiều nguồn khác nhau (như Collections, SQL Database, XML, v.v.)
//theo cách thức ngắn gọn, dễ đọc và kiểu mạnh (type-safe).
//LINQ giúp kết hợp ngôn ngữ lập trình C# với các câu truy vấn tương tự SQL ngay trong code.

//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//2. Cách sử dụng LINQ
//B1: Lấy nguồn dữ liệu: FROM (Từ 1 cái nguồn dữ liệu nào đó)
//B2: Lọc dữ liệu: WHERE (Lọc dữ liệu theo 1 điều kiện nào đó)
//B3: Chọn dữ liệu: SELECT (Chọn ra những dữ liệu nào đó)
//Đây là 1 CÂU CÓ THỂ ĐƯỢC PHỎNG VẤN NHEN
//câu truy vấn LINQ
//var evenNumbers2 = from n in numbers where n % 2 == 0 select n;
//Ta đang dùng Query Syntax (from, where, select)


//var evenNumbers = numbers.Where(x => x % 2 == 0);//to list để chuyển từ IEnumerable sang List
//Ta đang dùng Method Syntax (Where(Lamda Expression))
//Ngoài Where , LINQ còn có nhiều phương thức khác như Select, OrderBy, GroupBy, Join, v.v.

//Bản chất kiểu dữ liệu khi sử dụng LINQ là IEnumerable
//Nên có thể sử dụng ToList() để chuyển về List -> dễ dàng chỉnh sửa, thêm, xóa phần tử
//Thế nên khi sử dụng LINQ, ta không nên chuyển về List để đảm bảo tính toàn vẹn của dữ liệu
//Console.WriteLine("Các số chẵn trong mảng numbers là:");
//foreach (var item in evenNumbers)
//{
//    Console.WriteLine(item);
//}
//Linq còn có nhiều kiểu khác ngoài Linq to Object như:
//Linq to SQL, Linq to XML, Linq to Entity Framework, Linq to Dataset, Linq to JSON, v.v.
//Ta sẽ học trọng tâm vào Linq to Entity Framework 
//}
//}
using System.Text;
using LINQ;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1500 },
            new Product { Id = 2, Name = "Smartphone", Price = 1200 },
            new Product { Id = 3, Name = "Tablet", Price = 1800 },
            new Product { Id = 4, Name = "Headphones", Price = 200 },
            new Product { Id = 5, Name = "Smartwatch", Price = 300 }
        };
        var danhSach = from p in products where p.Price > 1000 select p;
        Console.WriteLine(danhSach.FirstOrDefault().Name);
        //foreach (var item in danhSach)
        //{
        //    Console.WriteLine(item.Name);
        //}

        //Cách viết Lamda Expression
        var product = products.OrderByDescending(p => p.Price!).FirstOrDefault();
        //tới khúc đó không thể . thêm được method nào nữa vì sau FirstOrDefault là phần tử cuối cùng rồi
        //First() trả về phần tử đầu tiên, nếu không có phần tử nào thì sẽ báo lỗi
        //FirstOrDefault() trả về phần tử đầu tiên, nếu không có phần tử nào thì trả về null để check null
        //Console.WriteLine(product!.Name);//để dấu ! để bỏ qua lỗi null (không khuyến khích)
        if (product == null)
        {
            return;//sau này sẽ follow theo flow code này
        }
        Console.WriteLine(product.Name);

        List<string> animals = new List<string> { "Cat", "Dog", "Elephant", "Deer", "Cheetah", "Dolphin" };

        // Nhóm động vật theo chữ cái đầu tiên
        var groupedAnimals = from animal in animals
                             group animal by animal[0] into animalGroup
                             orderby animalGroup.Key//Key là animal[0]
                             select animalGroup;

    }
}