﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class FilaVaziaException : Exception
{
  public FilaVaziaException(string erro) : base(erro)
  {
  }
}

