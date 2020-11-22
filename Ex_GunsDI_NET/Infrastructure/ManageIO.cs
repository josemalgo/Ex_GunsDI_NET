using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_GunsDI_NET.Infrastructure
{
    class ManageIO
    {
		public string inString()
		{
			string input = string.Empty;
			try
			{
				input = Console.ReadLine();
			}
			catch (Exception e)
			{
				Console.WriteLine("Error!! El valor introduit no és vàlid!");
			}
			return input;
		}

		public int inInt()
		{
			int input = 0;
			try
			{
				input = int.Parse(this.inString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Error!! Has d'introduir un número!");
			}
			return input;
		}
	}
}
