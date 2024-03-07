// Challenge 1
bool amProgrammer = true;
double Age = 27.9;
List<string> Names = new List<string>();
Names.Add("Monica");
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0");
string MyName = "MyName";

// Challenge 2
List<int> Numbers = new List<int>() {2, 3, 6, 7, 1, 5};
for(int i = Numbers.Count - 1; i >= 0; i--)
{
    Console.WriteLine(Numbers[i]);
}

// Challenge 3
List<int> MoreNumbers = new List<int>() {12, 7, 10, -3, 9};
foreach(int num in MoreNumbers)
{
    Console.WriteLine(num);
}

// Challenge 4
List<int> EvenMoreNumbers = new List<int> {3, 6, 9, 12, 14};
for(int i = 0; i < EvenMoreNumbers.Count; i++)
{
    if(EvenMoreNumbers[i] % 3 == 0)
    {
        EvenMoreNumbers[i] = 0;
    }
}

// Challenge 5
// Les chaînes de caractères en C# sont immuables
// Vous devez créer une nouvelle chaîne avec le caractère modifié
string MyString = "superduberawesome";
MyString = MyString.Remove(7, 1).Insert(7, "p");
Console.WriteLine(MyString);

// Challenge 6
Random rand = new Random();
int randomNum = rand.Next(13); // 0 à 12 inclus
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}
