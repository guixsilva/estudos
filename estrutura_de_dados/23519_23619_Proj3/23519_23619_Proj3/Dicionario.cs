using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Dicionario : IComparable<Dicionario>
    {

    string palavra, dica;
    int tamanhoPalavra = 15;
    bool[] acertou;

    public string Palavra { 
        get => palavra;
        set
        {
            if(value != "")
            {
                palavra = value.PadRight(tamanhoPalavra, ' ').Substring(0, tamanhoPalavra);
            }
            else
            {
                throw new Exception("Palavra não pode estar vazia.");
            }
        }
    }
    public string Dica { 
        get => dica; 
        set{
                if (value != "")
                {
                    dica = value;
                }
        }
    }

    public bool[] Acertou 
    { 
        get => acertou; 
    }

    public Dicionario(string linhaDeDados)
    {
        Palavra = linhaDeDados.Substring(0, tamanhoPalavra);
        Dica = linhaDeDados.Substring(tamanhoPalavra);
        acertou = new bool[tamanhoPalavra];
    }

    public Dicionario(string palavra, string dica)
    {
        acertou = new bool[tamanhoPalavra];
        Palavra = palavra;
        Dica = dica;
    }


    public int CompareTo(Dicionario? other)
    {
        return palavra.CompareTo(other.palavra);
    }

    public override string ToString()
    {
        return $"{palavra}{dica}";
    }

    public string FormatoDeArquivo()
    {
        return $"{palavra}{dica}";
    }



    bool Tentativa(char letra)
    {
        
        return false;
    }
}

