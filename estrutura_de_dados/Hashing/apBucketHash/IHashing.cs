using System;
using System.Collections.Generic;

public interface IHashing<T> where T : IRegistro<T>, new()
{
  bool Incluir(T novoDado);
  bool Excluir(T novoDado);
  bool Existe(T novoDado, out int onde);
  List<string> Conteudo();
}

