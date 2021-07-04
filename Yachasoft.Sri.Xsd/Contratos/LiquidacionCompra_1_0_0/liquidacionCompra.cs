﻿// Decompiled with JetBrains decompiler
// Type: Yachasoft.Sri.Xsd.Contratos.LiquidacionCompra_1_0_0.liquidacionCompra
// Assembly: Yachasoft.Sri.Xsd, Version=1.1.5.0, Culture=neutral, PublicKeyToken=null
// MVID: F09EA61F-E573-4F61-BA4F-32EF8FF0528A
// Assembly location: C:\Users\Joseph\.nuget\packages\infoware.sri.xsds\1.1.5\lib\net5.0\Yachasoft.Sri.Xsd.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Yachasoft.Sri.Xsd.Contratos.LiquidacionCompra_1_0_0
{
  [GeneratedCode("xsd", "4.8.3928.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  [XmlRoot(IsNullable = false, Namespace = "")]
  [Serializable]
  public class liquidacionCompra
  {
    private infoTributaria infoTributariaField;
    private liquidacionCompraInfoLiquidacionCompra infoLiquidacionCompraField;
    private liquidacionCompraDetalle[] detallesField;
    private reembolsosReembolsoDetalle[] reembolsosField;
    private tipoNegociable tipoNegociableField;
    private maquinaFiscal maquinaFiscalField;
    private liquidacionCompraCampoAdicional[] infoAdicionalField;
    private SignatureType signatureField;
    private liquidacionCompraID idField;
    private bool idFieldSpecified;
    private string versionField;

    public infoTributaria infoTributaria
    {
      get => this.infoTributariaField;
      set => this.infoTributariaField = value;
    }

    public liquidacionCompraInfoLiquidacionCompra infoLiquidacionCompra
    {
      get => this.infoLiquidacionCompraField;
      set => this.infoLiquidacionCompraField = value;
    }

    [XmlArrayItem("detalle", IsNullable = false)]
    public liquidacionCompraDetalle[] detalles
    {
      get => this.detallesField;
      set => this.detallesField = value;
    }

    [XmlArrayItem("reembolsoDetalle", IsNullable = false)]
    public reembolsosReembolsoDetalle[] reembolsos
    {
      get => this.reembolsosField;
      set => this.reembolsosField = value;
    }

    public tipoNegociable tipoNegociable
    {
      get => this.tipoNegociableField;
      set => this.tipoNegociableField = value;
    }

    public maquinaFiscal maquinaFiscal
    {
      get => this.maquinaFiscalField;
      set => this.maquinaFiscalField = value;
    }

    [XmlArrayItem("campoAdicional", IsNullable = false)]
    public liquidacionCompraCampoAdicional[] infoAdicional
    {
      get => this.infoAdicionalField;
      set => this.infoAdicionalField = value;
    }

    [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public SignatureType Signature
    {
      get => this.signatureField;
      set => this.signatureField = value;
    }

    [XmlAttribute]
    public liquidacionCompraID id
    {
      get => this.idField;
      set => this.idField = value;
    }

    [XmlIgnore]
    public bool idSpecified
    {
      get => this.idFieldSpecified;
      set => this.idFieldSpecified = value;
    }

    [XmlAttribute]
    public string version
    {
      get => this.versionField;
      set => this.versionField = value;
    }
  }
}
