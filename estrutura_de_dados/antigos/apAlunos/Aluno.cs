using System;
using System.IO;

public class Aluno : IComparable<Aluno>
{
    string ra;
    string nome;
    int curso;
    double media;

    // propriedades

    public string Ra    // Propriedade do atributo ra
    {
       get => ra;           // acessador get (getter)
       set => ra = value.PadLeft(5, '0');   // acessador set (setter)
    }

    public string Nome
    {
        get     // get => nome;    
        {
            return nome;
        }
        set
        {
            if (value.Length > 30)
               value = value.Substring(0,30); // pega apenas 30 caracteres
            else
              value = value.PadRight(30, ' ');  // preenche nome com 30 caracteres 

            nome = value;
        }
    }

    public int Curso    // Propriedade da variável curso
    {
        get { return curso; }
        set { 
                if (value <= 0)
                    throw new Exception("Código de curso inválido!");
                    
                curso = value; 
            }
    }

    public double Media      // Propriedade da variável media
    {
        get => media;
        set
        {   
            if (value < 0 || value > 10)
                throw new Exception("Média inválida!");
            
            media = value;
        }    
    }

// construtores
    public Aluno (string ra)
    {
        this.Ra = ra;
    }

    public Aluno (string ra, string nome, int curso, double media)
    {
        this.Ra = ra;
        this.Nome = nome;
        this.Curso = curso;
        this.Media = media;
    }

    public int CompareTo(Aluno outro)
    {
        return this.Ra.CompareTo(outro.Ra);
    }

    public override string ToString()
    {
        return Ra+" "+Nome+" "+Curso+" "+Media; 
    }

}