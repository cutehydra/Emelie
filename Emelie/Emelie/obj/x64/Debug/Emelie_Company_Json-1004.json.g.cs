// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Emelie_Company_Json.json"
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
using __EmStreet__ = global::Emelie.Emelie_Company_Json.Input.Street;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __EmNameInfo__ = global::Emelie.Emelie_Company_Json.Input.NameInfo;
using __EmTrend__ = global::Emelie.Emelie_Company_Json.Input.Trend;
using __EmCommissi__ = global::Emelie.Emelie_Company_Json.Input.Commission;
using __EmHomesSol__ = global::Emelie.Emelie_Company_Json.Input.HomesSold;
using __EmCountry__ = global::Emelie.Emelie_Company_Json.Input.Country;
using __EmCity__ = global::Emelie.Emelie_Company_Json.Input.City;
using __EmZipCode__ = global::Emelie.Emelie_Company_Json.Input.ZipCode;
using __EmNumber__ = global::Emelie.Emelie_Company_Json.Input.Number;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __EmHtml__ = global::Emelie.Emelie_Company_Json.Input.Html;
using __Emelie_C2__ = global::Emelie.Emelie_Company_Json.Input;
using __Emelie_C1__ = global::Emelie.Emelie_Company_Json.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __EmSchema__ = global::Emelie.Emelie_Company_Json.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Emelie_C__ = global::Emelie.Emelie_Company_Json;
using __EmCompanyN__ = global::Emelie.Emelie_Company_Json.Input.CompanyName;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class Emelie_Company_Json_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class Emelie_Company_Json : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __EmSchema__ DefaultTemplate = new __EmSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Emelie_Company_Json() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Emelie_Company_Json(__EmSchema__ template) { Template = template; }
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
                InstanceType = typeof(__Emelie_C__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Emelie/Emelie_Company_Html.html";
                Html.SetCustomAccessors((_p_) => { return ((__Emelie_C__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Emelie_C__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                CompanyName = Add<__TString__>("CompanyName$");
                CompanyName.DefaultValue = "";
                CompanyName.Editable = true;
                CompanyName.SetCustomAccessors((_p_) => { return ((__Emelie_C__)_p_).__bf__CompanyName__; }, (_p_, _v_) => { ((__Emelie_C__)_p_).__bf__CompanyName__ = (System.String)_v_; }, false);
                Street = Add<__TString__>("Street$");
                Street.DefaultValue = "";
                Street.Editable = true;
                Street.SetCustomAccessors((_p_) => { return ((__Emelie_C__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__Emelie_C__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                Number = Add<__TLong__>("Number$");
                Number.DefaultValue = 0L;
                Number.Editable = true;
                Number.SetCustomAccessors((_p_) => { return ((__Emelie_C__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__Emelie_C__)_p_).__bf__Number__ = (System.Int64)_v_; }, false);
                ZipCode = Add<__TLong__>("ZipCode$");
                ZipCode.DefaultValue = 0L;
                ZipCode.Editable = true;
                ZipCode.SetCustomAccessors((_p_) => { return ((__Emelie_C__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__Emelie_C__)_p_).__bf__ZipCode__ = (System.Int64)_v_; }, false);
                City = Add<__TString__>("City$");
                City.DefaultValue = "";
                City.Editable = true;
                City.SetCustomAccessors((_p_) => { return ((__Emelie_C__)_p_).__bf__City__; }, (_p_, _v_) => { ((__Emelie_C__)_p_).__bf__City__ = (System.String)_v_; }, false);
                Country = Add<__TString__>("Country$");
                Country.DefaultValue = "";
                Country.Editable = true;
                Country.SetCustomAccessors((_p_) => { return ((__Emelie_C__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__Emelie_C__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                HomesSold = Add<__TLong__>("HomesSold");
                HomesSold.DefaultValue = 0L;
                HomesSold.SetCustomAccessors((_p_) => { return ((__Emelie_C__)_p_).__bf__HomesSold__; }, (_p_, _v_) => { ((__Emelie_C__)_p_).__bf__HomesSold__ = (System.Int64)_v_; }, false);
                Commission = Add<__TLong__>("Commission");
                Commission.DefaultValue = 0L;
                Commission.SetCustomAccessors((_p_) => { return ((__Emelie_C__)_p_).__bf__Commission__; }, (_p_, _v_) => { ((__Emelie_C__)_p_).__bf__Commission__ = (System.Int64)_v_; }, false);
                Trend = Add<__TLong__>("Trend");
                Trend.DefaultValue = 0L;
                Trend.SetCustomAccessors((_p_) => { return ((__Emelie_C__)_p_).__bf__Trend__; }, (_p_, _v_) => { ((__Emelie_C__)_p_).__bf__Trend__ = (System.Int64)_v_; }, false);
                NameInfo = Add<__TString__>("NameInfo", bind:"NameInfo");
                NameInfo.DefaultValue = "";
                NameInfo.SetCustomAccessors((_p_) => { return ((__Emelie_C__)_p_).__bf__NameInfo__; }, (_p_, _v_) => { ((__Emelie_C__)_p_).__bf__NameInfo__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Emelie_C__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ CompanyName;
            public __TString__ Street;
            public __TLong__ Number;
            public __TLong__ ZipCode;
            public __TString__ City;
            public __TString__ Country;
            public __TLong__ HomesSold;
            public __TLong__ Commission;
            public __TLong__ Trend;
            public __TString__ NameInfo;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "Emelie_Company_Json.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "Emelie_Company_Json.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__CompanyName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String CompanyName {
    #line 3 "Emelie_Company_Json.json"
        get {
        #line hidden
            return Template.CompanyName.Getter(this); }
        #line 3 "Emelie_Company_Json.json"
        set {
        #line hidden
            Template.CompanyName.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Street__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Street {
    #line 4 "Emelie_Company_Json.json"
        get {
        #line hidden
            return Template.Street.Getter(this); }
        #line 4 "Emelie_Company_Json.json"
        set {
        #line hidden
            Template.Street.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Number__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Number {
    #line 5 "Emelie_Company_Json.json"
        get {
        #line hidden
            return Template.Number.Getter(this); }
        #line 5 "Emelie_Company_Json.json"
        set {
        #line hidden
            Template.Number.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__ZipCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 ZipCode {
    #line 6 "Emelie_Company_Json.json"
        get {
        #line hidden
            return Template.ZipCode.Getter(this); }
        #line 6 "Emelie_Company_Json.json"
        set {
        #line hidden
            Template.ZipCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__City__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String City {
    #line 7 "Emelie_Company_Json.json"
        get {
        #line hidden
            return Template.City.Getter(this); }
        #line 7 "Emelie_Company_Json.json"
        set {
        #line hidden
            Template.City.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Country__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Country {
    #line 8 "Emelie_Company_Json.json"
        get {
        #line hidden
            return Template.Country.Getter(this); }
        #line 8 "Emelie_Company_Json.json"
        set {
        #line hidden
            Template.Country.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__HomesSold__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 HomesSold {
    #line 9 "Emelie_Company_Json.json"
        get {
        #line hidden
            return Template.HomesSold.Getter(this); }
        #line 9 "Emelie_Company_Json.json"
        set {
        #line hidden
            Template.HomesSold.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Commission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Commission {
    #line 10 "Emelie_Company_Json.json"
        get {
        #line hidden
            return Template.Commission.Getter(this); }
        #line 10 "Emelie_Company_Json.json"
        set {
        #line hidden
            Template.Commission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Trend__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Trend {
    #line 11 "Emelie_Company_Json.json"
        get {
        #line hidden
            return Template.Trend.Getter(this); }
        #line 11 "Emelie_Company_Json.json"
        set {
        #line hidden
            Template.Trend.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NameInfo__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Emelie_C__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CompanyName : Input<__Emelie_C__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Street : Input<__Emelie_C__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Number : Input<__Emelie_C__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class ZipCode : Input<__Emelie_C__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class City : Input<__Emelie_C__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Country : Input<__Emelie_C__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HomesSold : Input<__Emelie_C__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Commission : Input<__Emelie_C__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Trend : Input<__Emelie_C__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class NameInfo : Input<__Emelie_C__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
