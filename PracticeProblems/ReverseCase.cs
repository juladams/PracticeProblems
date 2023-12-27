using System;
using System.CodeDom;

namespace PracticeProblems
{

	internal class ReverseCase
	{
		public string reverseCase(string s)
		{
			char[] c = s.ToCharArray();

			for(int i = 0; i < c.Length; i++)
			{
				if (c[i] >= 'a' && c[i] <= 'z')
					c[i] = (char)(c[i] - 32);
				else if (c[i] >= 'A' && c[i] <= 'Z')
					c[i] = (char)(c[i] + 32);
			}
			return new string(c);
		}
	}
}
