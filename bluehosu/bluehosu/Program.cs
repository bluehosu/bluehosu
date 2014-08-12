using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Program
	{

			
	static void Main(string[] args)
	{            
		int[] scores = { 80, 78, 60, 90, 100 };
		int sum = CalculateSum(scores);
		Console.WriteLine(sum);        
	}

	static int CalculateSum(int[] scoresArray)
	{
		int sum = 0;
		for (int i = 0; i < scoresArray.Length; i++)
		{
			sum += scoresArray[i];
		}
		return sum;
	}
	

}
}
