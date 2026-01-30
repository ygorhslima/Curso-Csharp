// See https://aka.ms/new-console-template for more information

using System.Text;

string Name = "joão";
int Age = 29;
string displayName = $"{Name} você tem {Age} anos";
Console.WriteLine(displayName);

/*Para acrescentar cadeias de caracteres em loops, especialmente quando você estiver trabalhando com grandes quantidades de texto, use um objeto System.Text.StringBuilder.
*/
var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";


var manyPhrases = new StringBuilder();
for(var i = 0; i < 20; i++)
{
    manyPhrases.Append(phrase);
}
Console.WriteLine(manyPhrases);

var message = """
    olá, esta é uma mensagem muito grande que precisa de muitas linhas para ficar bem mais organizado, muito massa, muito legal
    albalxbalkbcaklbclakbclabcklabcklbacklbaclkbaklcbkacbakcbalkcbalkcblacblkacblkbalxbalkbcaklbclakbclabcklabcklbacklbaclkbaklcbkacbakcbalkcbalkcblacblkacblkbalxbalkbcaklbclakbclabcklabcklbacklbaclkbaklcbkacbakcbalkcbalkcblacblkacblkbalxbalkbcaklbclakbclabcklabcklbacklbaclkbaklcbkacbakcbalkcbalkcblacblkacblkbalxbalkbcaklbclakbclabcklabcklbacklbaclkbaklcbkacbakcbalkcbalkcblacblkacblkbalxbalkbcaklbclakbclabcklabcklbacklbaclkbaklcbkacbakcbalkcbalkcblacblkacblk
""";


string[] vowels = ["a","e","i","o","u"];


