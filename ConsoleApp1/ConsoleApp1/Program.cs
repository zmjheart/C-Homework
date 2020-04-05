using System;	

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write(111);//输出一行 不换行
			Console.WriteLine("Hello C#");//输出一行 换行
			Console.ReadLine();//读入一行
			Console.Read();//读入一个字符

			String language = "张梦杰";
			Console.WriteLine("欢迎{0}{1}", language,language);
			Console.WriteLine("欢迎" + language);

			String course = Console.ReadLine();
			int a = int.Parse(Console.ReadLine());//手动转

			int grade = Console.Read();//注意：这个会自动转(ASCII码)
			Console.WriteLine("grade{0}", grade);

			//比较引用类型的字符串
			String xxxx = "abc";
			String yyyy = "abc";
			bool zzzz = xxxx == yyyy;
			Console.WriteLine(zzzz);


			Console.WriteLine(DateTime.Now.ToLongDateString());

		}
	}
}
