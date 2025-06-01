using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Dicionario : IComparable<Dicionario>
    {

    string palavra, dica;
    int tamanhoVetor = 15;
    bool[] acertou;

    public string Palavra { 
        get => palavra;
        set
        {
            if(value != "")
            {
                palavra = value.PadRight(tamanhoVetor, ' ').Substring(0, tamanhoVetor);
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
        Palavra = linhaDeDados.Substring(0, tamanhoVetor);
        Dica = linhaDeDados.Substring(tamanhoVetor);
        acertou = new bool[tamanhoVetor];
    }

    public Dicionario(string palavra, string dica)
    {
        acertou = new bool[tamanhoVetor];
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



    public bool Tentativa(char letra)
    {
        bool tentativa = false;
        char[] letras = Palavra.TrimEnd().ToCharArray();

        for (int i = 0; i < letras.Length; i++)
        {
            if (letras[i] == letra)
            {
                tentativa = true;
                Acertou[i] = true;
            } 
        }

        return tentativa;
    }

    public bool FimDeGame()
    {
        int tamanhoPalavra = Palavra.TrimEnd().Length;

        for (int i = 0; i < tamanhoPalavra; i++)
        {
            if (Acertou[i] == false)
            {
                return false;
            }
        }

        for (int i = 0; i < acertou.Length; i++)
        {
            acertou[i] = false;
        }

        return true;
    }
}

