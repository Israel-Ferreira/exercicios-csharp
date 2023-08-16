// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

string phrase = Console.ReadLine()!;

string modifiedPhrase = SubstituirLetra(phrase, "A");

Console.WriteLine(modifiedPhrase);


string SubstituirLetra(string fraseAtual, string letra, string sep = " ")
{
    List<string> palavras = fraseAtual.Split(sep).ToList();
    
    List<String> variacoesLetra = new List<string>(){letra.ToUpper(), letra.ToLower()};

    List<string> palavrasMapeadas = palavras.Select(wrd =>
    {
        string[] letters =  wrd.ToCharArray().Select(c => c.ToString()).ToArray();
        var wrdModified = string.Join("", letters.Select(lt => variacoesLetra.Contains(lt) ? "&" : lt));
        return wrdModified;
    }).ToList();

    return  string.Join(sep, palavrasMapeadas);
}