﻿// Decompiled with JetBrains decompiler
// Type: Yachasoft.Sri.Xsd.Contratos.NotaDebito_1_0_0.pagos
// Assembly: Yachasoft.Sri.Xsd, Version=1.1.5.0, Culture=neutral, PublicKeyToken=null
// MVID: F09EA61F-E573-4F61-BA4F-32EF8FF0528A
// Assembly location: C:\Users\Joseph\.nuget\packages\infoware.sri.xsds\1.1.5\lib\net5.0\Yachasoft.Sri.Xsd.dll

using System.Xml.Serialization;

namespace Yachasoft.Sri.Xsd.Contratos.NotaDebito_1_0_0
{
  [XmlRoot(ElementName = "pagos")]
  public class pagos
  {
    private Yachasoft.Sri.Xsd.Contratos.NotaDebito_1_0_0.pago[] pagoField;

    [XmlElement(ElementName = "pago", IsNullable = false)]
    public Yachasoft.Sri.Xsd.Contratos.NotaDebito_1_0_0.pago[] pago
    {
      get => this.pagoField;
      set => this.pagoField = value;
    }
  }
}
