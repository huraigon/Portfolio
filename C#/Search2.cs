using System;

class Search2
{
	static void Main()
	{
		int[] s = {4, 5, 2, 8, 7, 1, 9, 0, 99999};
		int N = s.Length-1;
		int d;
		Console.Write("Input search number: ");
		d = int.Parse(Console.ReadLine());
		s[N] = d;
		int i=0;
		while (s[i] != d)
			i++;
		if ( i == N){
			Console.WriteLine("I can't find: {0}", d);
		}else {
			Console.WriteLine("Found: {0} at index {1}", d, i);
		}
		return;
	}
}