using System;


namespace Nancy.Simple
{
	public static class SetupCheck
	{

		public static string SayHello(string name)
		{
			return "Hello " + name;
		}

        static void Main(string[] args)
        {
            Console.WriteLine(SetupCheck.SayHello("World"));
        }
    }

}

