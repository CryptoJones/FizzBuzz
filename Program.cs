// See https://aka.ms/new-console-template for more information
for (int i = 1; i < 101; i++)
{	
#if DEBUG
	if (i % 3 == 0) { Console.WriteLine(i + " Fizz"); }
	if (i % 5 == 0) { Console.WriteLine(i + " Buzz"); }
#else
	if (i % 3 == 0) { Console.WriteLine("Fizz"); }
	if (i % 5 == 0) { Console.WriteLine("Buzz"); }
#endif
}
