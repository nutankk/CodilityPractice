using System;
namespace CodilityPractice
{
    public class StringDemo
	{
		public string solution(string s)
		{
        char c = s[0];
        if (char.IsUpper(c)){ 
            return "upper";
        } else if (char.IsLower(c)) {  
            return "lower";
        } else if (char.IsNumber(c)) {  
            return "digit";
        } else {
            return "other";
        }
		}
	}
}
