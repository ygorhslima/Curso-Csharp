string[] words = [
                // index from start     index from end
    "first",    // 0                    ^10
    "second",   // 1                    ^9
    "third",    // 2                    ^8
    "fourth",   // 3                    ^7
    "fifth",    // 4                    ^6
    "sixth",    // 5                    ^5
    "seventh",  // 6                    ^4
    "eighth",   // 7                    ^3
    "ninth",    // 8                    ^2
    "tenth"     // 9                    ^1
];              // 10 (or words.Length) ^0

Console.WriteLine($"The last word is < {words[^1]}"); // nesse caso está sendo procurado o último [^1]

/*O código a seguir cria um subintervalo com as palavras "segundo", "terceiro" e "quarto". Ele inclui words[1] até words[3]. O elemento words[4] não está no intervalo.
*/
string[] secondThirdFourth = words[1..4];
/*foreach (var word in secondThirdFourth)
{
    Console.WriteLine($"{word}");
}*/

string[] lastTwo = words[^2..^0];

foreach (var word in lastTwo)
{
    Console.WriteLine($"{word}");
}

string[] allWords = words[..]; // contains "first" through "tenth".
string[] firstPhrase = words[..4]; // contains "first" through "fourth"
string[] lastPhrase = words[6..]; // contains "seventh", "eight", "ninth" and "tenth"

// < first >< second >< third >< fourth >< fifth >< sixth >< seventh >< eighth >< ninth >< tenth >
foreach (var word in allWords)
    Console.Write($"< {word} >"); 
Console.WriteLine();

// < first >< second >< third >< fourth >
foreach (var word in firstPhrase)
    Console.Write($"< {word} >"); 
Console.WriteLine();

// < seventh >< eighth >< ninth >< tenth >
foreach (var word in lastPhrase)
    Console.Write($"< {word} >"); 
Console.WriteLine();

int[][] jagged = 
[
   [0, 1, 2, 3, 4, 5, 6, 7, 8, 9],
   [10,11,12,13,14,15,16,17,18,19],
   [20,21,22,23,24,25,26,27,28,29],
   [30,31,32,33,34,35,36,37,38,39],
   [40,41,42,43,44,45,46,47,48,49],
   [50,51,52,53,54,55,56,57,58,59],
   [60,61,62,63,64,65,66,67,68,69],
   [70,71,72,73,74,75,76,77,78,79],
   [80,81,82,83,84,85,86,87,88,89],
   [90,91,92,93,94,95,96,97,98,99],
];

var selectedRows = jagged[3..^3];

foreach (var row in selectedRows)
{
    var selectedColumns = row[2..^2];
    foreach (var cell in selectedColumns)
    {
        Console.Write($"{cell}, ");
    }
    Console.WriteLine();
}