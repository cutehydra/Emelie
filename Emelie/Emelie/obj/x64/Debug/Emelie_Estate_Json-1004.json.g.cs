// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Emelie_Estate_Json.json"
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
using __EmEstateSt__ = global::Emelie.Emelie_Estate_Json.Input.EstateStreet;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __EmSeller__ = global::Emelie.Emelie_Estate_Json.Input.Seller;
using __EmEstateCo1__ = global::Emelie.Emelie_Estate_Json.Input.EstateCommission;
using __EmEstateSa__ = global::Emelie.Emelie_Estate_Json.Input.EstateSalePrice;
using __EmEstateDa__ = global::Emelie.Emelie_Estate_Json.Input.EstateDate;
using __EmEstateCo__ = global::Emelie.Emelie_Estate_Json.Input.EstateCountry;
using __EmEstateCi__ = global::Emelie.Emelie_Estate_Json.Input.EstateCity;
using __EmEstateZi__ = global::Emelie.Emelie_Estate_Json.Input.EstateZipCode;
using __EmEstateNu__ = global::Emelie.Emelie_Estate_Json.Input.EstateNumber;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __EmHtml__ = global::Emelie.Emelie_Estate_Json.Input.Html;
using __Emelie_E2__ = global::Emelie.Emelie_Estate_Json.Input;
using __Emelie_E1__ = global::Emelie.Emelie_Estate_Json.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __EmSchema__ = global::Emelie.Emelie_Estate_Json.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Emelie_E__ = global::Emelie.Emelie_Estate_Json;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class Emelie_Estate_Json_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class Emelie_Estate_Json : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __EmSchema__ DefaultTemplate = new __EmSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Emelie_Estate_Json() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Emelie_Estate_Json(__EmSchema__ template) { Template = template; }
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
                InstanceType = typeof(__Emelie_E__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Emelie/Emelie_Estate_Html.html";
                Html.SetCustomAccessors((_p_) => { return ((__Emelie_E__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Emelie_E__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                EstateStreet = Add<__TString__>("EstateStreet$");
                EstateStreet.DefaultValue = "";
                EstateStreet.Editable = true;
                EstateStreet.SetCustomAccessors((_p_) => { return ((__Emelie_E__)_p_).__bf__EstateStreet__; }, (_p_, _v_) => { ((__Emelie_E__)_p_).__bf__EstateStreet__ = (System.String)_v_; }, false);
                EstateNumber = Add<__TLong__>("EstateNumber$");
                EstateNumber.DefaultValue = 0L;
                EstateNumber.Editable = true;
                EstateNumber.SetCustomAccessors((_p_) => { return ((__Emelie_E__)_p_).__bf__EstateNumber__; }, (_p_, _v_) => { ((__Emelie_E__)_p_).__bf__EstateNumber__ = (System.Int64)_v_; }, false);
                EstateZipCode = Add<__TLong__>("EstateZipCode$");
                EstateZipCode.DefaultValue = 0L;
                EstateZipCode.Editable = true;
                EstateZipCode.SetCustomAccessors((_p_) => { return ((__Emelie_E__)_p_).__bf__EstateZipCode__; }, (_p_, _v_) => { ((__Emelie_E__)_p_).__bf__EstateZipCode__ = (System.Int64)_v_; }, false);
                EstateCity = Add<__TString__>("EstateCity$");
                EstateCity.DefaultValue = "";
                EstateCity.Editable = true;
                EstateCity.SetCustomAccessors((_p_) => { return ((__Emelie_E__)_p_).__bf__EstateCity__; }, (_p_, _v_) => { ((__Emelie_E__)_p_).__bf__EstateCity__ = (System.String)_v_; }, false);
                EstateCountry = Add<__TString__>("EstateCountry$");
                EstateCountry.DefaultValue = "";
                EstateCountry.Editable = true;
                EstateCountry.SetCustomAccessors((_p_) => { return ((__Emelie_E__)_p_).__bf__EstateCountry__; }, (_p_, _v_) => { ((__Emelie_E__)_p_).__bf__EstateCountry__ = (System.String)_v_; }, false);
                EstateDate = Add<__TString__>("EstateDate$");
                EstateDate.DefaultValue = "";
                EstateDate.Editable = true;
                EstateDate.SetCustomAccessors((_p_) => { return ((__Emelie_E__)_p_).__bf__EstateDate__; }, (_p_, _v_) => { ((__Emelie_E__)_p_).__bf__EstateDate__ = (System.String)_v_; }, false);
                EstateSalePrice = Add<__TLong__>("EstateSalePrice$");
                EstateSalePrice.DefaultValue = 0L;
                EstateSalePrice.Editable = true;
                EstateSalePrice.SetCustomAccessors((_p_) => { return ((__Emelie_E__)_p_).__bf__EstateSalePrice__; }, (_p_, _v_) => { ((__Emelie_E__)_p_).__bf__EstateSalePrice__ = (System.Int64)_v_; }, false);
                EstateCommission = Add<__TLong__>("EstateCommission$");
                EstateCommission.DefaultValue = 0L;
                EstateCommission.Editable = true;
                EstateCommission.SetCustomAccessors((_p_) => { return ((__Emelie_E__)_p_).__bf__EstateCommission__; }, (_p_, _v_) => { ((__Emelie_E__)_p_).__bf__EstateCommission__ = (System.Int64)_v_; }, false);
                Seller = Add<__TString__>("Seller");
                Seller.DefaultValue = "";
                Seller.SetCustomAccessors((_p_) => { return ((__Emelie_E__)_p_).__bf__Seller__; }, (_p_, _v_) => { ((__Emelie_E__)_p_).__bf__Seller__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Emelie_E__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ EstateStreet;
            public __TLong__ EstateNumber;
            public __TLong__ EstateZipCode;
            public __TString__ EstateCity;
            public __TString__ EstateCountry;
            public __TString__ EstateDate;
            public __TLong__ EstateSalePrice;
            public __TLong__ EstateCommission;
            public __TString__ Seller;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "Emelie_Estate_Json.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "Emelie_Estate_Json.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__EstateStreet__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String EstateStreet {
    #line 3 "Emelie_Estate_Json.json"
        get {
        #line hidden
            return Template.EstateStreet.Getter(this); }
        #line 3 "Emelie_Estate_Json.json"
        set {
        #line hidden
            Template.EstateStreet.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__EstateNumber__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 EstateNumber {
    #line 4 "Emelie_Estate_Json.json"
        get {
        #line hidden
            return Template.EstateNumber.Getter(this); }
        #line 4 "Emelie_Estate_Json.json"
        set {
        #line hidden
            Template.EstateNumber.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__EstateZipCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 EstateZipCode {
    #line 5 "Emelie_Estate_Json.json"
        get {
        #line hidden
            return Template.EstateZipCode.Getter(this); }
        #line 5 "Emelie_Estate_Json.json"
        set {
        #line hidden
            Template.EstateZipCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__EstateCity__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String EstateCity {
    #line 6 "Emelie_Estate_Json.json"
        get {
        #line hidden
            return Template.EstateCity.Getter(this); }
        #line 6 "Emelie_Estate_Json.json"
        set {
        #line hidden
            Template.EstateCity.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__EstateCountry__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String EstateCountry {
    #line 7 "Emelie_Estate_Json.json"
        get {
        #line hidden
            return Template.EstateCountry.Getter(this); }
        #line 7 "Emelie_Estate_Json.json"
        set {
        #line hidden
            Template.EstateCountry.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__EstateDate__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String EstateDate {
    #line 8 "Emelie_Estate_Json.json"
        get {
        #line hidden
            return Template.EstateDate.Getter(this); }
        #line 8 "Emelie_Estate_Json.json"
        set {
        #line hidden
            Template.EstateDate.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__EstateSalePrice__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 EstateSalePrice {
    #line 9 "Emelie_Estate_Json.json"
        get {
        #line hidden
            return Template.EstateSalePrice.Getter(this); }
        #line 9 "Emelie_Estate_Json.json"
        set {
        #line hidden
            Template.EstateSalePrice.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__EstateCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 EstateCommission {
    #line 10 "Emelie_Estate_Json.json"
        get {
        #line hidden
            return Template.EstateCommission.Getter(this); }
        #line 10 "Emelie_Estate_Json.json"
        set {
        #line hidden
            Template.EstateCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Seller__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Seller {
    #line 11 "Emelie_Estate_Json.json"
        get {
        #line hidden
            return Template.Seller.Getter(this); }
        #line 11 "Emelie_Estate_Json.json"
        set {
        #line hidden
            Template.Seller.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Emelie_E__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class EstateStreet : Input<__Emelie_E__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class EstateNumber : Input<__Emelie_E__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class EstateZipCode : Input<__Emelie_E__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class EstateCity : Input<__Emelie_E__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class EstateCountry : Input<__Emelie_E__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class EstateDate : Input<__Emelie_E__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class EstateSalePrice : Input<__Emelie_E__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class EstateCommission : Input<__Emelie_E__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Seller : Input<__Emelie_E__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
