﻿// Decompiled with JetBrains decompiler
// Type: Yachasoft.Sri.Xsd.Contratos.Factura_1_0_0.facturaDetalleDetAdicional
// Assembly: Yachasoft.Sri.Xsd, Version=1.1.5.0, Culture=neutral, PublicKeyToken=null
// MVID: F09EA61F-E573-4F61-BA4F-32EF8FF0528A
// Assembly location: C:\Users\Joseph\.nuget\packages\infoware.sri.xsds\1.1.5\lib\net5.0\Yachasoft.Sri.Xsd.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Yachasoft.Sri.Xsd.Contratos.Factura_1_0_0
{
  [GeneratedCode("xsd", "4.8.3928.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  [Serializable]
  public class facturaDetalleDetAdicional
  {
    private string nombreField;
    private string valorField;

    [XmlAttribute]
    public string nombre
    {
      get => this.nombreField;
      set => this.nombreField = value;
    }

    [XmlAttribute]
    public string valor
    {
      get => this.valorField;
      set => this.valorField = value;
    }
  }
}
