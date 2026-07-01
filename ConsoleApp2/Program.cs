// struct Point
// {
//     public int x { get; set; }
//     public int y { get; set; }
//
//     public Point(int x, int y)
//     {
//         this.x = x;
//         this.y = y;
//     }
//
//     public override string ToString()
//     {
//         return $"({x},{y})";
//     }
// }
//


// //exercise 1
// ArticleType type = default;
//
// Console.WriteLine("1.FOOD\n2.ELECTRONICS\n3.CLOTHERS ");
// Console.Write("Which type you: ");
// while (true)
// {
//     int value = int.Parse(Console.ReadLine());
//
//     if (value == (int)ArticleType.Food || value == (int)ArticleType.Electronics || value == (int)ArticleType.Clothing)
//     {
//         type = (ArticleType)value;
//         break;
//     }
//
//     Console.WriteLine("invalid input");
// }
//
// Article article = new Article();
// Console.Write("Title: ");
// article.Title = Console.ReadLine();
// Console.Write("Code: ");
// article.Code = int.Parse(Console.ReadLine());
// Console.Write("Price: ");
// article.Price = int.Parse(Console.ReadLine());
//
// Console.WriteLine(article.ToString());
// Console.WriteLine("Article Type: " + type.ToString());
//
// struct Article
// {
//     private string title;
//     private int code;
//     private int price;
//     
//     public string Title { get => title; set => title = value; }
//     
//     public int Code { get => code; set => code = value; }
//
//     public Article(string title, int code, int price)
//     {
//         this.title = title;
//         this.code = code;
//         this.price = price;
//     }
//     
//     public int Price
//     {
//         get => price;
//         set
//         {
//             if (value > 0) price = value;
//         }
//     }
//
//     public override string ToString()
//     {
//         return  $"Title: {title}, Price: {price}, Code: {code}";
//     }
// }
//
// enum ArticleType
// {
//     Food = 1,
//     Electronics,
//     Clothing
// }

// exercise 2
//
// Client client = new Client();
//
// Console.WriteLine("1.NORMAL\n2.VIP");
//
// Console.Write("Who are you: ");
//
// ClientType who = default;
//
// while (true)
// {
//     int value = int.Parse(Console.ReadLine());
//
//     if (value == (int)ClientType.NORMAL || value == (int)ClientType.VIP)
//     {
//         who = (ClientType)value;
//         break;
//     }
//
//     Console.WriteLine("Invalid client type");
// }
//
// Console.Write("Please enter your name: ");
// client.Name = Console.ReadLine();
//
// Console.Write("Please enter your surname: ");
// client.Surname = Console.ReadLine();
//
// Console.Write("Please enter your address: ");
// client.Address = Console.ReadLine();
//
// Console.Write("Please enter your phone number: ");
// client.Number_Phone = int.Parse(Console.ReadLine());
//
// Console.Write("Please enter your order counts: ");
// client.Order_Counts = int.Parse(Console.ReadLine());
//
// Console.Write("Please enter your orders sum: ");
// client.Orders_Sum = int.Parse(Console.ReadLine());
//
// Console.WriteLine(client.ToString());
// Console.WriteLine("For "+who.ToString());
// struct Client
// {
//     private string name;
//     private string surname;
//     private string address;
//     private int number_phone;
//     private int order_counts;
//     private int orders_sum;
//     
//     public string Name { get => name; set => name = value; }
//     public string Surname { get => surname; set => surname = value; }
//     public string Address { get => address; set => address = value; }
//
//     public Client(string name, string surname, string address, int number_phone, int order_counts, int orders_sum)
//     {
//         this.name = name;
//         this.surname = surname;
//         this.address = address;
//         this.number_phone = number_phone;
//         this.order_counts = order_counts;
//         this.orders_sum = orders_sum;   
//     }
//     
//     public int Number_Phone
//     {
//         get => number_phone;
//         set
//         {
//             if(value > 0) number_phone = value;
//         }
//     }
//
//     public int Order_Counts
//     {
//         get => order_counts;
//         set
//         {
//             if(value > 0) order_counts = value;
//
//         }
//     }
//
//     public int Orders_Sum
//     {
//         get => orders_sum;
//         set
//         {
//             if(value > 0) orders_sum = value;
//         }
//     }
//
//     public override string ToString()
//     {
//         return $"Name : {Name}\n Surname : {Surname}\n Address : {Address}\n Number phone : {Number_Phone}\n Order counts : {Order_Counts}\n Order sum : {Orders_Sum}  ";
//     }
// }
//
// enum ClientType
// {
//     NORMAL = 1,
//     VIP
// }

// exercise 3
// RequestItem req = new RequestItem();
//
// Console.Write("Enter the goods:");
// req.Goods = Console.ReadLine();
// Console.Write("Enter the goods_count:");
// req.Goods_count = int.Parse(Console.ReadLine());
//
// Console.WriteLine(req.ToString());
//
//
// struct RequestItem
// {
//     private string goods;
//     private int goods_count;
//     
//     public  RequestItem(string goods, int goods_count)
//     {
//         this.goods = goods;
//         this.goods_count = goods_count;
//     }
//     
//     public string Goods { get => goods; set => goods = value; }
//
//     public int Goods_count
//     {
//         get => goods_count;
//         set
//         {
//             if(value > 0) goods_count = value;
//         }
//     }
//
//     public override string ToString()
//     {
//         return $"{Goods}-{Goods_count}";
//     }
// }

// exercise 4

// Request request = new Request();
//
// PayType payType = default;
//
// int value = default;
//
// Console.WriteLine("1.CASH\n2.CARD");
// while (true)
// {
//     Console.Write("Your choice:");
//     value = int.Parse(Console.ReadLine());
//     if (value == (int)PayType.CARD || value == (int)PayType.CASH ) 
//     {
//         payType = (PayType)value;
//         break;
//     }
//
//     Console.WriteLine("invalid input");
// }
//
// Console.Write("Enter the code of products you want to buy: ");
// request.Code_order = int.Parse(Console.ReadLine());
// Console.Write("Enter the username: ");
// request.Username = Console.ReadLine();
// Console.Write("Enter the day: ");
// request.Day = int.Parse(Console.ReadLine());
// Console.Write("Enter the month: ");
// request.Month = int.Parse(Console.ReadLine());
// Console.Write("Enter the year: ");
// request.Year = int.Parse(Console.ReadLine());
// Console.Write("Enter the product counts: ");
// int count = default;
//
// while (true)
// {
//     count = int.Parse(Console.ReadLine());
//     if(count > 0) break;
//     
//     Console.WriteLine("invalid input");
// }
//
// request.Products = new string[count];
//
// for (int i = 0; i < count; i++)
// {
//     Console.Write("Enter product name: ");
//     request.Products[i] = Console.ReadLine();
// }
//
// Console.Write("Enter the sum products: ");
// request.Sum_products = int.Parse(Console.ReadLine());
//
// Console.WriteLine(request.ToString());
// Console.WriteLine("Type of payment:"+payType.ToString());
//
// struct Request
// {
//     private int code_order;
//     private string username;
//     private int day;
//     private int month;
//     private int year;
//     private string[] products;
//     private int sum_products;
//
//     public Request(int code_order, string username, int day, int month, int year, string[] products)
//     {
//         this.code_order = code_order;
//         this.username = username;
//         this.day = day;
//         this.month = month;
//         this.year = year;
//         this.products = products;
//         this.sum_products = 0;
//     }
//
//     public int Code_order
//     {
//         get => code_order;
//         set
//         {
//             if(value > 0) code_order = value;
//         }
//     }
//
//     public string Username
//     {
//         get => username;
//         set
//         {
//             if(value.Length > 0) username = value;
//         }
//     }
//
//     public int Day
//     {
//         get => day;
//         set
//         {
//             if(value > 0) day = value;
//         }
//     }
//
//     public int Month
//     {
//         get => month;
//         set
//         {
//             if(value > 0) month = value;
//         }
//     }
//
//     public int Year
//     {
//         get => year;
//         set
//         {
//             if(value > 0) year = value;
//         }
//     }
//
//     public string[] Products
//     {
//         get => products;
//         set
//         {
//             if(value.Length > 0) products = value;
//         }
//     }
//     
//     public int Sum_products
//     {
//         get => sum_products;
//         set
//         {
//             if(value > 0) sum_products = value;
//         }
//     }
//
//     public override string ToString()
//     {
//         return $"Code : {Code_order}, Username : {Username}, DateTime : {Day}-{Month}-{Year},  Products :{string.Join(", ", Products)}, Sum Products : {Sum_products}";
//     }
// }
//
// enum PayType
// {
//     CASH = 1,
//     CARD
// }

// exercise 5
//
// Student student = new Student();
// Console.Write("Enter name: ");
// student.Name = Console.ReadLine();
// Console.Write("Enter surname: ");
// student.Surname = Console.ReadLine();
// Console.Write("Enter patronymic: ");
// student.Patronymic = Console.ReadLine();
// Console.Write("Enter group: ");
// student.Group = int.Parse(Console.ReadLine());
// Console.Write("Enter age: ");
// student.Age = int.Parse(Console.ReadLine());
//
// student.Grade = new int[3][];
//
// student.Grade[0] = new int[0];
// student.Grade[1] = new int[0];
// student.Grade[2] = new int[0];
//
// student.getGrade(0,3);
// student.getGrade(1,3);
// student.getGrade(2,3);
//
// Console.WriteLine(student.ToString());
//
//  struct Student
//  {
//      private string name;
//      private string surname;
//      private string patronymic;
//      private int group;
//      private int age;
//      private int[][] grade;
//
//      public Student(string name, string surname, string patronymic, int group, int age, int[][] grade)
//      {
//          this.name = name;
//          this.surname = surname;
//          this.patronymic = patronymic;
//          this.group = group;
//          this.age = age;
//          this.grade = grade;
//      }
//      
//      public string Name
//      {
//          get => name;
//          set
//          {
//              if(value.Length > 0) name = value;
//          }
//      }
//
//      public string Surname
//      {
//          get => surname;
//          set
//          {
//              if(value.Length > 0) surname = value;
//          }
//      }
//
//      public string Patronymic
//      {
//          get => patronymic;
//          set
//          {
//              if(value.Length > 0) patronymic = value;
//          }
//      }
//
//      public int Group
//      {
//          get => group;
//          set
//          {
//              if(value > 0) group = value;
//          }
//      }
//
//      public int Age
//      {
//          get => age;
//          set
//          {
//              if(value > 0) age = value;
//          }
//      }
//
//      public int[][] Grade
//      {
//          get => grade;
//          set
//          {
//              if(value.Length > 0) grade = value;
//          }
//      }
//
//      public void getGrade(int subject,int grade_m )
//      {
//          int[] temp = new int[grade[subject].Length + 1];
//
//          for (int i = 0; i < grade[subject].Length; i++)
//          {
//              temp[i] =  grade[subject][i];
//          }
//
//          temp[temp.Length - 1] = grade_m;
//          grade[subject] = temp;
//          
//      }
//
//      public double getAvarage()
//      {
//          double sum = 0;
//          int count = 0;
//          for (int i = 0; i < grade.Length; i++)
//          {
//              for (int j = 0; j < grade[i].Length; j++)
//              {
//                  sum += grade[i][j];
//                  count++;
//              }
//          }
//
//          return sum / count;
//      }
//
//      public void show()
//      {
//          for (int i = 0; i < grade.Length; i++)
//          {
//              for (int j = 0; j < grade[i].Length; j++)
//              {
//                  Console.WriteLine(grade[i][j]);
//              }
//          }
//      }
//
//      public override string ToString()
//      {
//          return $"Name: {Name},Surname: {Surname},Patronymic: {Patronymic},Group: {Group},Age: {Age}\nProgramming: {string.Join(" ", Grade[0])}\nAdministration: {string.Join(" ", Grade[1])}\nDesign: {string.Join(" ", Grade[2])}\nAverage: {getAvarage()}";
//      }
//  }