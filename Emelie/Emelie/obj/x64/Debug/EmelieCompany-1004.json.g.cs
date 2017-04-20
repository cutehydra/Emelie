// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "EmelieCompany.json"
// Version: 1004
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
#pragma warning disable 0108
#pragma warning disable 1591

using __EmelieCo1__ = global::EmelieCompany.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __EmAddress__ = global::EmelieCompany.Input.Address;
using __EmName__ = global::EmelieCompany.Input.Name;
using __EmHtml__ = global::EmelieCompany.Input.Html;
using __EmelieCo2__ = global::EmelieCompany.Input;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TString__ = global::Starcounter.Templates.TString;
using __EmSchema__ = global::EmelieCompany.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __EmelieCo__ = global::EmelieCompany;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class EmelieCompany_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class EmelieCompany : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __EmSchema__ DefaultTemplate = new __EmSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public EmelieCompany() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public EmelieCompany(__EmSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __EmSchema__ Template { get { return (__EmSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__EmelieCo__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/EmelieCompanyJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__EmelieCo__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__EmelieCo__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__EmelieCo__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__EmelieCo__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Address = Add<__TString__>("Address");
                Address.DefaultValue = "";
                Address.SetCustomAccessors((_p_) => { return ((__EmelieCo__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__EmelieCo__)_p_).__bf__Address__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __EmelieCo__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TString__ Address;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "EmelieCompany.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "EmelieCompany.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "EmelieCompany.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "EmelieCompany.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Address__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Address {
    #line 4 "EmelieCompany.json"
        get {
        #line hidden
            return Template.Address.Getter(this); }
        #line 4 "EmelieCompany.json"
        set {
        #line hidden
            Template.Address.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__EmelieCo__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__EmelieCo__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Address : Input<__EmelieCo__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
#pragma warning restore 1591
#pragma warning restore 0108
