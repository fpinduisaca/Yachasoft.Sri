﻿// Decompiled with JetBrains decompiler
// Type: Yachasoft.Sri.Xsd.Contratos.GuiaRemision_1_0_0.PGPDataType
// Assembly: Yachasoft.Sri.Xsd, Version=1.1.5.0, Culture=neutral, PublicKeyToken=null
// MVID: F09EA61F-E573-4F61-BA4F-32EF8FF0528A
// Assembly location: C:\Users\Joseph\.nuget\packages\infoware.sri.xsds\1.1.5\lib\net5.0\Yachasoft.Sri.Xsd.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Yachasoft.Sri.Xsd.Contratos.GuiaRemision_1_0_0
{
  [GeneratedCode("xsd", "4.8.3928.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
  [XmlRoot("PGPData", IsNullable = false, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
  [Serializable]
  public class PGPDataType
  {
    private object[] itemsField;
    private ItemsChoiceType1[] itemsElementNameField;

    [XmlAnyElement]
    [XmlElement("PGPKeyID", typeof (byte[]), DataType = "base64Binary")]
    [XmlElement("PGPKeyPacket", typeof (byte[]), DataType = "base64Binary")]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
      get => this.itemsField;
      set => this.itemsField = value;
    }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType1[] ItemsElementName
    {
      get => this.itemsElementNameField;
      set => this.itemsElementNameField = value;
    }
  }
}
