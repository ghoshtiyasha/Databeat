
using System;
using System.Linq;
using System.Collections.Generic;

class Program{

	static void Main(string[] args){

		Console.WriteLine("Enter the input");
		string ip= Console.ReadLine();


		Dictionary<char, int> dict= ip.Replace(" ", string.Empty).GroupBy(c=>c).ToDictionary(gr=>gr.Key, gr=>gr.Count());
		foreach (var item in dict.Keys){

			
			 Console.WriteLine(item + " => " + dict[item]);


		} 
		Console.ReadKey();

	}
}