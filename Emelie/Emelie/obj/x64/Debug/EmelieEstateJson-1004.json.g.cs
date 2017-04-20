// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "EmelieEstateJson.json"
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

namespace Emelie {
using __EmHtml__ = global::Emelie.EmelieEstateJson.Input.Html;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __EmFullInfo__ = global::Emelie.EmelieEstateJson.Input.FullInfo;
using __EmSaveTrig__ = global::Emelie.EmelieEstateJson.Input.SaveTrigger;
using __EmCommissi__ = global::Emelie.EmelieEstateJson.Input.Commission;
using __EmSalePric__ = global::Emelie.EmelieEstateJson.Input.SalePrice;
using __EmDate__ = global::Emelie.EmelieEstateJson.Input.Date;
using __EmAddress__ = global::Emelie.EmelieEstateJson.Input.Address;
using __EmName__ = global::Emelie.EmelieEstateJson.Input.Name;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __EmelieEs2__ = global::Emelie.EmelieEstateJson.Input;
using __EmelieEs1__ = global::Emelie.EmelieEstateJson.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __EmSchema__ = global::Emelie.EmelieEstateJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __EmelieEs__ = global::Emelie.EmelieEstateJson;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class EmelieEstateJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class EmelieEstateJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __EmSchema__ DefaultTemplate = new __EmSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public EmelieEstateJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public EmelieEstateJson(__EmSchema__ template) { Template = template; }
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
                InstanceType = typeof(__EmelieEs__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Emelie/EmelieEstateJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__EmelieEs__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__EmelieEs__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__EmelieEs__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__EmelieEs__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Address = Add<__TString__>("Address$");
                Address.DefaultValue = "";
                Address.Editable = true;
                Address.SetCustomAccessors((_p_) => { return ((__EmelieEs__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__EmelieEs__)_p_).__bf__Address__ = (System.String)_v_; }, false);
                Date = Add<__TString__>("Date$");
                Date.DefaultValue = "";
                Date.Editable = true;
                Date.SetCustomAccessors((_p_) => { return ((__EmelieEs__)_p_).__bf__Date__; }, (_p_, _v_) => { ((__EmelieEs__)_p_).__bf__Date__ = (System.String)_v_; }, false);
                SalePrice = Add<__TLong__>("SalePrice$");
                SalePrice.DefaultValue = 0L;
                SalePrice.Editable = true;
                SalePrice.SetCustomAccessors((_p_) => { return ((__EmelieEs__)_p_).__bf__SalePrice__; }, (_p_, _v_) => { ((__EmelieEs__)_p_).__bf__SalePrice__ = (System.Int64)_v_; }, false);
                Commission = Add<__TLong__>("Commission$");
                Commission.DefaultValue = 0L;
                Commission.Editable = true;
                Commission.SetCustomAccessors((_p_) => { return ((__EmelieEs__)_p_).__bf__Commission__; }, (_p_, _v_) => { ((__EmelieEs__)_p_).__bf__Commission__ = (System.Int64)_v_; }, false);
                SaveTrigger = Add<__TLong__>("SaveTrigger$");
                SaveTrigger.DefaultValue = 0L;
                SaveTrigger.Editable = true;
                SaveTrigger.SetCustomAccessors((_p_) => { return ((__EmelieEs__)_p_).__bf__SaveTrigger__; }, (_p_, _v_) => { ((__EmelieEs__)_p_).__bf__SaveTrigger__ = (System.Int64)_v_; }, false);
                SaveTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveTrigger() { App = (EmelieEstateJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((EmelieEstateJson)pup).Handle((Input.SaveTrigger)input); });
                FullInfo = Add<__TString__>("FullInfo", bind:"FullInfo");
                FullInfo.DefaultValue = "";
                FullInfo.SetCustomAccessors((_p_) => { return ((__EmelieEs__)_p_).__bf__FullInfo__; }, (_p_, _v_) => { ((__EmelieEs__)_p_).__bf__FullInfo__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __EmelieEs__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TString__ Address;
            public __TString__ Date;
            public __TLong__ SalePrice;
            public __TLong__ Commission;
            public __TLong__ SaveTrigger;
            public __TString__ FullInfo;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "EmelieEstateJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "EmelieEstateJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "EmelieEstateJson.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "EmelieEstateJson.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Address__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Address {
    #line 4 "EmelieEstateJson.json"
        get {
        #line hidden
            return Template.Address.Getter(this); }
        #line 4 "EmelieEstateJson.json"
        set {
        #line hidden
            Template.Address.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Date__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Date {
    #line 5 "EmelieEstateJson.json"
        get {
        #line hidden
            return Template.Date.Getter(this); }
        #line 5 "EmelieEstateJson.json"
        set {
        #line hidden
            Template.Date.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SalePrice__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SalePrice {
    #line 6 "EmelieEstateJson.json"
        get {
        #line hidden
            return Template.SalePrice.Getter(this); }
        #line 6 "EmelieEstateJson.json"
        set {
        #line hidden
            Template.SalePrice.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Commission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Commission {
    #line 7 "EmelieEstateJson.json"
        get {
        #line hidden
            return Template.Commission.Getter(this); }
        #line 7 "EmelieEstateJson.json"
        set {
        #line hidden
            Template.Commission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveTrigger {
    #line 8 "EmelieEstateJson.json"
        get {
        #line hidden
            return Template.SaveTrigger.Getter(this); }
        #line 8 "EmelieEstateJson.json"
        set {
        #line hidden
            Template.SaveTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FullInfo__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__EmelieEs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__EmelieEs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Address : Input<__EmelieEs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Date : Input<__EmelieEs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SalePrice : Input<__EmelieEs__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Commission : Input<__EmelieEs__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SaveTrigger : Input<__EmelieEs__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class FullInfo : Input<__EmelieEs__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
