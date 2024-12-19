//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Script
{
    using System;
    using System.Xml;
    using System.Xml.Schema;
    using System.Collections.Generic;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.CheckpointFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Ext.CheckpointLogicOperators;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Ext.CheckpointRules;
    using HP.ST.Ext.CheckpointRules.ArrayCheckpoints;
    
    
    public partial class WorkFlowScript
    {
        
        private void set_StServiceCallActivity4_checkpoints(STActivityBase activity)
        {
            VTDPropertyInfoBase stracturalOutputEnvelope = new VTDPropertyInfoBase("OutputEnvelope", "/*[local-name(.)=\'Envelope\'][1]");
            IList<VTDPropertyInfoBase> stracturalPropsInfo = new List<VTDPropertyInfoBase>();
            CpValObj ExpectedSchema = new CpValObj("<?xml version=\"1.0\" encoding=\"utf-16\"?><xs:schema xmlns=\"http://schemas.xmlsoap.o" +
                    "rg/soap/envelope/\" xmlns:vtd=\"hp.visual_test_designer\" elementFormDefault=\"quali" +
                    "fied\" targetNamespace=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xs=\"http" +
                    "://www.w3.org/2001/XMLSchema\"><xs:import schemaLocation=\"EmbeddedResources/HPFli" +
                    "ghts_\\webServices\\HPFlights_\\_3.xsd\" namespace=\"HP.SOAQ.SampleApp/Imports\" /><xs" +
                    ":attribute name=\"fullName\" type=\"xs:string\" /><xs:attribute name=\"group\" type=\"x" +
                    "s:string\" /><xs:attribute name=\"serialize\" type=\"xs:string\" /><xs:attribute name" +
                    "=\"argType\" type=\"xs:string\" /><xs:element name=\"Envelope\" type=\"Envelope\" /><xs:" +
                    "complexType name=\"Envelope\"><xs:sequence><xs:element minOccurs=\"0\" ref=\"Header\" " +
                    "/><xs:element minOccurs=\"1\" ref=\"Body\" /></xs:sequence><xs:anyAttribute processC" +
                    "ontents=\"lax\" /></xs:complexType><xs:element name=\"Header\" type=\"Header\" /><xs:c" +
                    "omplexType name=\"Header\"><xs:sequence xmlns=\"\"><xs:any minOccurs=\"0\" maxOccurs=\"" +
                    "unbounded\" processContents=\"lax\" /></xs:sequence><xs:anyAttribute processContent" +
                    "s=\"lax\" /></xs:complexType><xs:element name=\"Body\" type=\"Body\" /><xs:complexType" +
                    " name=\"Body\"><xs:sequence xmlns=\"\"><xs:element xmlns:q1=\"HP.SOAQ.SampleApp\" ref=" +
                    "\"q1:CreateFlightOrderResponse\" /></xs:sequence><xs:anyAttribute namespace=\"##any" +
                    "\" processContents=\"lax\"><xs:annotation><xs:documentation>Prose in the spec does " +
                    "not specify that attributes are allowed on the Body element</xs:documentation></" +
                    "xs:annotation></xs:anyAttribute></xs:complexType><xs:attribute name=\"mustUnderst" +
                    "and\"><xs:simpleType><xs:restriction base=\"xs:boolean\"><xs:pattern value=\"0|1\" />" +
                    "</xs:restriction></xs:simpleType></xs:attribute><xs:attribute name=\"actor\" type=" +
                    "\"xs:anyURI\" /><xs:simpleType name=\"encodingStyle\"><xs:annotation><xs:documentati" +
                    "on>\'encodingStyle\' indicates any canonicalization conventions followed in the co" +
                    "ntents of the containing element.  For example, the value \'http://schemas.xmlsoa" +
                    "p.org/soap/encoding/\' indicates the pattern described in SOAP specification</xs:" +
                    "documentation></xs:annotation><xs:list itemType=\"xs:anyURI\" /></xs:simpleType><x" +
                    "s:attribute name=\"encodingStyle\" type=\"encodingStyle\" /><xs:attributeGroup name=" +
                    "\"encodingStyle\"><xs:attribute ref=\"encodingStyle\" /></xs:attributeGroup><xs:elem" +
                    "ent name=\"Fault\" type=\"Fault\" /><xs:complexType name=\"Fault\" final=\"extension\"><" +
                    "xs:annotation><xs:documentation>Fault reporting structure</xs:documentation></xs" +
                    ":annotation><xs:sequence><xs:element name=\"faultcode\" type=\"xs:QName\" /><xs:elem" +
                    "ent name=\"faultstring\" type=\"xs:string\" /><xs:element minOccurs=\"0\" name=\"faulta" +
                    "ctor\" type=\"xs:anyURI\" /><xs:element minOccurs=\"0\" name=\"detail\" type=\"detail\" /" +
                    "></xs:sequence></xs:complexType><xs:complexType name=\"detail\"><xs:sequence><xs:a" +
                    "ny minOccurs=\"0\" maxOccurs=\"unbounded\" namespace=\"##any\" processContents=\"lax\" /" +
                    "></xs:sequence><xs:anyAttribute namespace=\"##any\" processContents=\"lax\" /></xs:c" +
                    "omplexType></xs:schema>", XmlTypeCode.None);
            stracturalPropsInfo.Add(stracturalOutputEnvelope);
            BaseCPRule StracturalRule = new StracturalRule(activity, ExpectedSchema, stracturalPropsInfo);
            activity.AddCheckpointRule(StracturalRule);

        }
        
        private void set_StServiceCallActivity8_checkpoints(STActivityBase activity)
        {
            // Checkpoint 1
            IVTDGetter actualValueGetter1 = new VTDXPathGetter(new VTDPropertyInfoBase("OutputEnvelope", "/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='Fault'][1]/*[local-name(.)='faultcode'][1]"), XmlTypeCode.String, false);
            IVTDSetter actualValueSetter1 = new VTDCheckpointSetter(XmlTypeCode.String);
            BindDirection actualBindDirection1 = new BindDirection(_flow.StServiceCallActivity8, actualValueGetter1, actualValueSetter1);
            CpValObj valueActualObject1 = new CpValObj(actualBindDirection1, XmlTypeCode.String, false);
            CpValObj valueExpectedObject1 = new CpValObj("s:Client", XmlTypeCode.String);
            ValueCPRule cpRule1 = new ValueCPRule(valueActualObject1, valueExpectedObject1, StringCP.EqualTo, "=", false);
            activity.AddCheckpointRule(cpRule1);

            // Checkpoint 2
            IVTDGetter actualValueGetter2 = new VTDXPathGetter(new VTDPropertyInfoBase("OutputEnvelope", "/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='Fault'][1]/*[local-name(.)='faultstring'][1]"), XmlTypeCode.String, false);
            IVTDSetter actualValueSetter2 = new VTDCheckpointSetter(XmlTypeCode.String);
            BindDirection actualBindDirection2 = new BindDirection(_flow.StServiceCallActivity8, actualValueGetter2, actualValueSetter2);
            CpValObj valueActualObject2 = new CpValObj(actualBindDirection2, XmlTypeCode.String, false);
            CpValObj valueExpectedObject2 = new CpValObj("ERROR: A flight date must be specified. It should be at least 24 hours from now.", XmlTypeCode.String);
            ValueCPRule cpRule2 = new ValueCPRule(valueActualObject2, valueExpectedObject2, StringCP.EqualTo, "=", false);
            activity.AddCheckpointRule(cpRule2);

            VTDPropertyInfoBase stracturalOutputEnvelope = new VTDPropertyInfoBase("OutputEnvelope", "/*[local-name(.)=\'Envelope\'][1]");
            IList<VTDPropertyInfoBase> stracturalPropsInfo = new List<VTDPropertyInfoBase>();
            CpValObj ExpectedSchema = new CpValObj("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<xs:schema xmlns:tns=\"http://schemas.xml" +
                    "soap.org/soap/envelope/\" targetNamespace=\"http://schemas.xmlsoap.org/soap/envelo" +
                    "pe/\" xmlns:xs=\"http://www.w3.org/2001/XMLSchema\">\r\n  <xs:element name=\"Envelope\"" +
                    " type=\"tns:Envelope\" />\r\n  <xs:complexType name=\"Envelope\">\r\n    <xs:sequence>\r\n" +
                    "      <xs:element minOccurs=\"0\" ref=\"tns:Header\" />\r\n      <xs:element minOccurs" +
                    "=\"1\" ref=\"tns:Body\" />\r\n    </xs:sequence>\r\n    <xs:anyAttribute processContents" +
                    "=\"lax\" />\r\n  </xs:complexType>\r\n  <xs:element name=\"Header\" type=\"tns:Header\" />" +
                    "\r\n  <xs:complexType name=\"Header\">\r\n    <xs:sequence>\r\n      <xs:any minOccurs=\"" +
                    "0\" maxOccurs=\"unbounded\" processContents=\"lax\" />\r\n    </xs:sequence>\r\n    <xs:a" +
                    "nyAttribute processContents=\"lax\" />\r\n  </xs:complexType>\r\n  <xs:element name=\"B" +
                    "ody\" type=\"tns:Body\" />\r\n  <xs:complexType name=\"Body\">\r\n    <xs:sequence>\r\n    " +
                    "  <xs:element ref=\"tns:Fault\" />\r\n    </xs:sequence>\r\n    <xs:anyAttribute names" +
                    "pace=\"##any\" processContents=\"lax\">\r\n      <xs:annotation>\r\n        <xs:document" +
                    "ation>Prose in the spec does not specify that attributes are allowed on the Body" +
                    " element</xs:documentation>\r\n      </xs:annotation>\r\n    </xs:anyAttribute>\r\n  <" +
                    "/xs:complexType>\r\n  <xs:attribute name=\"mustUnderstand\">\r\n    <xs:simpleType>\r\n " +
                    "     <xs:restriction base=\"xs:boolean\">\r\n        <xs:pattern value=\"0|1\" />\r\n   " +
                    "   </xs:restriction>\r\n    </xs:simpleType>\r\n  </xs:attribute>\r\n  <xs:attribute n" +
                    "ame=\"actor\" type=\"xs:anyURI\" />\r\n  <xs:simpleType name=\"encodingStyle\">\r\n    <xs" +
                    ":annotation>\r\n      <xs:documentation>\'encodingStyle\' indicates any canonicaliza" +
                    "tion conventions followed in the contents of the containing element.  For exampl" +
                    "e, the value \'http://schemas.xmlsoap.org/soap/encoding/\' indicates the pattern d" +
                    "escribed in SOAP specification</xs:documentation>\r\n    </xs:annotation>\r\n    <xs" +
                    ":list itemType=\"xs:anyURI\" />\r\n  </xs:simpleType>\r\n  <xs:attribute name=\"encodin" +
                    "gStyle\" type=\"tns:encodingStyle\" />\r\n  <xs:attributeGroup name=\"encodingStyle\">\r" +
                    "\n    <xs:attribute ref=\"tns:encodingStyle\" />\r\n  </xs:attributeGroup>\r\n  <xs:ele" +
                    "ment name=\"Fault\" type=\"tns:Fault\" />\r\n  <xs:complexType name=\"Fault\" final=\"ext" +
                    "ension\">\r\n    <xs:annotation>\r\n      <xs:documentation>Fault reporting structure" +
                    "</xs:documentation>\r\n    </xs:annotation>\r\n    <xs:sequence>\r\n      <xs:element " +
                    "name=\"faultcode\" type=\"xs:string\" />\r\n      <xs:element name=\"faultstring\" type=" +
                    "\"xs:string\" />\r\n      <xs:element minOccurs=\"0\" name=\"faultactor\" type=\"xs:anyUR" +
                    "I\" />\r\n      <xs:element minOccurs=\"0\" name=\"detail\" type=\"tns:detail\" />\r\n    <" +
                    "/xs:sequence>\r\n  </xs:complexType>\r\n  <xs:complexType name=\"detail\">\r\n    <xs:se" +
                    "quence>\r\n      <xs:any minOccurs=\"0\" maxOccurs=\"unbounded\" namespace=\"##any\" pro" +
                    "cessContents=\"lax\" />\r\n    </xs:sequence>\r\n    <xs:anyAttribute namespace=\"##any" +
                    "\" processContents=\"lax\" />\r\n  </xs:complexType>\r\n</xs:schema>", XmlTypeCode.None);
            stracturalPropsInfo.Add(stracturalOutputEnvelope);
            BaseCPRule StracturalRule = new StracturalRule(activity, ExpectedSchema, stracturalPropsInfo);
            activity.AddCheckpointRule(StracturalRule);

        }
    }
}