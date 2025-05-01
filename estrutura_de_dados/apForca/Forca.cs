using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class DicionarioForca :IComparable<DicionarioForca>, IRegistro
    {
        const int tamanhoPalavra = 30;
        const int inicioPalavra = 0;
        const int inicioDica = tamanhoPalavra;

        string palavra, dica;

        public string Palavra
        {
            get => palavra;
            set
            {
                if(value != "")
                {
                    palavra = value.PadRight(tamanhoPalavra, ' ').Substring(0, tamanhoPalavra);
                }
                else
                {
                    throw new Exception("Palavra vazio é inválido.");
                }
            }
        }

        public string Dica
        {
            get => dica;
            set
            {
                if(value != "")
                {
                    dica = value;
                }
            }
        }

        public DicionarioForca(string linhaDeDados)
        {
            Palavra = linhaDeDados.Substring(inicioPalavra, tamanhoPalavra);
            Dica = linhaDeDados.Substring(inicioDica);
        }


        public DicionarioForca(string palavra, string dica)
        {
            Palavra = palavra;
            Dica = dica;
        }

    public int CompareTo(DicionarioForca other)
    {
        return this.palavra.CompareTo(other.palavra);
    }

    public override string ToString()
    {
        return palavra + " " + dica;
    }

    public string FormatoDeArquivo()
    {
        return $"{palavra}{dica}";
    }
}
