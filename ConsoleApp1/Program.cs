using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Parminder
{
    class Program
    {
        static void Main(string[] args)
        {
			string line = "Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine.";
			string[] words = line.split(' ');
			string word = "";
			int cntr = 0;
			foreach(string sword in words){
				if(s.Length > cntr)
				{
					word =sword;
					cntr = sword.length;
				}
			}
			
			Console.WriteLine("the longest word is"+word);
		}
	}
}
