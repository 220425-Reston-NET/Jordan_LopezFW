using System.Collections;

public class Collections
{
int[]_numbersArray = new int[5];

List<int> _numbersList = new List<int>();

HashSet<int> _numberHash = new HashSet<int>();

Dictionary<string, int> _personAge = new Dictionary<string, int>();


ArrayList _numbersArrayList = new ArrayList();

public async void CollectionMain()    
{
    Console.WriteLine("===Array Demo===");
_numbersArray[0] = 3;
_numbersArray[1] = 10;
_numbersArray[2] = 100;

    Console.WriteLine(_numbersArray[0]);
    Console.WriteLine(_numbersArray[1]);
    Console.WriteLine(_numbersArray[2]);
    Console.WriteLine(_numbersArray[3]);
    Console.WriteLine(_numbersArray[4]);



    foreach(int elemant in _numbersArray)
    {
        Console.WriteLine(elemant);
    }

    for (int i = 0; i < _numbersList.Count; i++)
    {
        Console.WriteLine(_numbersList[i]);

    }
    int i2 =0;
    while (i2 < _numbersList.Count)
        i2++;
    {
            
   Console.WriteLine(_numbersList[12]);
            i2++;
    }
    Console.WriteLine("===Hash Demo===");
    _numberHash.Add(3);
    _numberHash.Add(10);
    _numberHash.Add(100);
    _numberHash.Add(100);
    
    foreach (int element in _numberHash)
    {
        Console.WriteLine(element);
    }
    
    Console.WriteLine("===Dictionary Demo===");
    _personAge.Add("Chadel", 26);
    _personAge.Add("Troy", 31);
    _personAge.Add("Maaz", 24);

    Console.WriteLine(_personAge["Troy"]);

    Console.WriteLine("===ArrayList Demo===");
    _numbersArrayList.Add("Hello");
    _numbersArrayList.Add(10);
    _numbersArrayList.Add(12.03);
    _numbersArrayList.Add(true);

    foreach (object item in _numbersArrayList)
        {
        Console.WriteLine(item);
        }

   }
}