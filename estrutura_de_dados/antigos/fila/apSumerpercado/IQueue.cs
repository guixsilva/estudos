using System;
using System.Collections.Generic;

public interface IQueue<Tipo>
{
  void Enfileirar(Tipo elemento);
  Tipo Retirar();
  Tipo OInicio();
  Tipo OFim();
  int Tamanho {  get; }
  bool EstaVazia {  get; }
}
