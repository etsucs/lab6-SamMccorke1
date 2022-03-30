
/**       
 *--------------------------------------------------------------------
 * 	   File name: {Lab6}
 * 	Project name: {ShowCharacter}
 *--------------------------------------------------------------------
 * Author’s name and email:	 {Samuel McCorkel, mccorkels@etsu.edu}				
 *          Course-Section: {CSCI-1250-002}
 *           Creation Date:	 {3/24/2022}		
 * -------------------------------------------------------------------
 */ 
///////method1//////////
Console.WriteLine("Enter a word: ");
string word = Console.ReadLine();

Console.WriteLine("Enter a number for the location: ");
var num = Convert.ToInt32(Console.ReadLine());

ShowCharacter(word, num);

static void ShowCharacter(string str, int num)
{
    System.Console.WriteLine($"Character {num} in {str} is {str[num-1]}");
}


////////Method2//////////

Console.WriteLine("What is the wholesale price: ");
int wholeSale = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The Markup Precent Is: ");
int markup = Convert.ToInt32(Console.ReadLine());

double finalSale = wholeSale * (markup/100) + wholeSale;
 //RetailPrice(finaleSale);

 static void RetailPrice(double finaleSale)
{
    Console.WriteLine($"Your final is {finaleSale}");
//return finalSale;
}






//////Method3/////////

for(int i = 80; i <= 100; i++)
{
    Console.WriteLine(Celsius(i));
}


static double Celsius(double FTemp)
{
var cTemp = (5.0/9.0) * (FTemp - 32);
return cTemp;

}

////////method4///////////
int n, s, m=0, flag=0;    
 Console.Write("Enter the Number to check Prime: ");    
 n = int.Parse(Console.ReadLine());  
 m=n/2;    
 for(s = 2; s <= m; s++)    
  {    
  if(n % s == 0)    
   {    
   Console.Write("Number is not Prime.");    
    flag=1;    
  break;    
      }    
     }    
 if (flag==0)   
 { 
 Console.Write("Number is Prime.");  
 }         