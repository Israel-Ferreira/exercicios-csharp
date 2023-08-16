// See https://aka.ms/new-console-template for more information

using System.Text;

namespace Exerc8;

public class Program
{
    async static Task Main()
    {
        Console.WriteLine("Hello, World!");
        
        Console.Write("\nQual é o seu nome?: ");
        string nome = Console.ReadLine()!;

        Console.Write("\nQual é o seu email?: ");
        string email = Console.ReadLine()!;

        Console.Write("\nQual é o seu telefone?: ");
        string telefone = Console.ReadLine()!;

        Console.Write("\nDigite o seu RG: ");
        string rg =  Console.ReadLine()!;
        
        string nomeArquivo =  "personal-info.txt";
        
        if(File.Exists(nomeArquivo))
        {
            File.Delete(nomeArquivo);
        }
        
        using(FileStream fs = new FileStream(nomeArquivo, FileMode.CreateNew, FileAccess.ReadWrite))
        {
            string content =  $"Nome: {nome}\nEmail: {email}\nRG: {rg}\nTelefone: {telefone}";
            byte[] contentEncoded  = EncodeValue(content);

            await fs.WriteAsync(contentEncoded, 0, contentEncoded.Length);	
        }
        
    }
    
    
    static byte[] EncodeValue(string  strValue)
    {
        return new UTF8Encoding(true).GetBytes(strValue);
    }
}