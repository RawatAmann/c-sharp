using System;  
  public class PalindromeExample  
  {  
    public static void Main(string[] args)  
      {  
          int num,rev,sum=0,temp;    
          Console.Write("Enter the number: ");   
          num = int.Parse(Console.ReadLine());  
          temp = num;      
          while(num>0)      
          {      
          rev = num%10;      
          sum = (sum*10)+rev;      
          num = num/10;      
          }      
          if(temp==sum)      
          Console.Write("Yay! the given number is Palindrome.");      
          else      
          Console.Write("Oops! the given number is not Palindrome.");     
    }  
  }