// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Emelie_MainCompany_Json.json"
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
using __Emelie_M2__ = global::Emelie.Emelie_MainCompany_Json.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __EmTotalHom__ = global::Emelie.Emelie_MainCompany_Json.Input.TotalHomesSold;
using __EmDeleteCo__ = global::Emelie.Emelie_MainCompany_Json.Input.DeleteCompanyTrigger;
using __EmCancelTr__ = global::Emelie.Emelie_MainCompany_Json.Input.CancelTrigger;
using __EmAddNewCo__ = global::Emelie.Emelie_MainCompany_Json.Input.AddNewCompanyTrigger;
using __EmInfo__ = global::Emelie.Emelie_MainCompany_Json.Input.Info;
using __EmSaveTrig__ = global::Emelie.Emelie_MainCompany_Json.Input.SaveTrigger;
using __EmName__ = global::Emelie.Emelie_MainCompany_Json.Input.Name;
using __EmHtml__ = global::Emelie.Emelie_MainCompany_Json.Input.Html;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __Emelie_M1__ = global::Emelie.Emelie_MainCompany_Json.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;
using __TString__ = global::Starcounter.Templates.TString;
using __EmSchema__ = global::Emelie.Emelie_MainCompany_Json.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Emelie_M__ = global::Emelie.Emelie_MainCompany_Json;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class Emelie_MainCompany_Json_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class Emelie_MainCompany_Json : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __EmSchema__ DefaultTemplate = new __EmSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Emelie_MainCompany_Json() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Emelie_MainCompany_Json(__EmSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __EmSchema__ Template { get { return (__EmSchema__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new MainCompany Data { get { return (MainCompany)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Emelie_M__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Emelie/Emelie_MainCompany_Html.html";
                Html.SetCustomAccessors((_p_) => { return ((__Emelie_M__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Emelie_M__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Emelie_M__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Emelie_M__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Companies = Add<__TArray__>("Companies");
                Companies.SetCustomAccessors((_p_) => { return ((__Emelie_M__)_p_).__bf__Companies__; }, (_p_, _v_) => { ((__Emelie_M__)_p_).__bf__Companies__ = (__Arr__)_v_; }, false);
                SaveTrigger = Add<__TLong__>("SaveTrigger$");
                SaveTrigger.DefaultValue = 0L;
                SaveTrigger.Editable = true;
                SaveTrigger.SetCustomAccessors((_p_) => { return ((__Emelie_M__)_p_).__bf__SaveTrigger__; }, (_p_, _v_) => { ((__Emelie_M__)_p_).__bf__SaveTrigger__ = (System.Int64)_v_; }, false);
                SaveTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveTrigger() { App = (Emelie_MainCompany_Json)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((Emelie_MainCompany_Json)pup).Handle((Input.SaveTrigger)input); });
                Info = Add<__TString__>("Info", bind:"Info");
                Info.DefaultValue = "";
                Info.SetCustomAccessors((_p_) => { return ((__Emelie_M__)_p_).__bf__Info__; }, (_p_, _v_) => { ((__Emelie_M__)_p_).__bf__Info__ = (System.String)_v_; }, false);
                AddNewCompanyTrigger = Add<__TLong__>("AddNewCompanyTrigger$");
                AddNewCompanyTrigger.DefaultValue = 0L;
                AddNewCompanyTrigger.Editable = true;
                AddNewCompanyTrigger.SetCustomAccessors((_p_) => { return ((__Emelie_M__)_p_).__bf__AddNewCompanyTrigger__; }, (_p_, _v_) => { ((__Emelie_M__)_p_).__bf__AddNewCompanyTrigger__ = (System.Int64)_v_; }, false);
                AddNewCompanyTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddNewCompanyTrigger() { App = (Emelie_MainCompany_Json)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((Emelie_MainCompany_Json)pup).Handle((Input.AddNewCompanyTrigger)input); });
                CancelTrigger = Add<__TLong__>("CancelTrigger$");
                CancelTrigger.DefaultValue = 0L;
                CancelTrigger.Editable = true;
                CancelTrigger.SetCustomAccessors((_p_) => { return ((__Emelie_M__)_p_).__bf__CancelTrigger__; }, (_p_, _v_) => { ((__Emelie_M__)_p_).__bf__CancelTrigger__ = (System.Int64)_v_; }, false);
                CancelTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.CancelTrigger() { App = (Emelie_MainCompany_Json)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((Emelie_MainCompany_Json)pup).Handle((Input.CancelTrigger)input); });
                DeleteCompanyTrigger = Add<__TLong__>("DeleteCompanyTrigger$");
                DeleteCompanyTrigger.DefaultValue = 0L;
                DeleteCompanyTrigger.Editable = true;
                DeleteCompanyTrigger.SetCustomAccessors((_p_) => { return ((__Emelie_M__)_p_).__bf__DeleteCompanyTrigger__; }, (_p_, _v_) => { ((__Emelie_M__)_p_).__bf__DeleteCompanyTrigger__ = (System.Int64)_v_; }, false);
                DeleteCompanyTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.DeleteCompanyTrigger() { App = (Emelie_MainCompany_Json)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((Emelie_MainCompany_Json)pup).Handle((Input.DeleteCompanyTrigger)input); });
                TotalHomesSold = Add<__TLong__>("TotalHomesSold");
                TotalHomesSold.DefaultValue = 0L;
                TotalHomesSold.SetCustomAccessors((_p_) => { return ((__Emelie_M__)_p_).__bf__TotalHomesSold__; }, (_p_, _v_) => { ((__Emelie_M__)_p_).__bf__TotalHomesSold__ = (System.Int64)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Emelie_M__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TArray__ Companies;
            public __TLong__ SaveTrigger;
            public __TString__ Info;
            public __TLong__ AddNewCompanyTrigger;
            public __TLong__ CancelTrigger;
            public __TLong__ DeleteCompanyTrigger;
            public __TLong__ TotalHomesSold;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "Emelie_MainCompany_Json.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "Emelie_MainCompany_Json.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "Emelie_MainCompany_Json.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "Emelie_MainCompany_Json.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Companies__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Companies {
    #line 4 "Emelie_MainCompany_Json.json"
        get {
        #line hidden
            return Template.Companies.Getter(this); }
        #line 4 "Emelie_MainCompany_Json.json"
        set {
        #line hidden
            Template.Companies.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveTrigger {
    #line 5 "Emelie_MainCompany_Json.json"
        get {
        #line hidden
            return Template.SaveTrigger.Getter(this); }
        #line 5 "Emelie_MainCompany_Json.json"
        set {
        #line hidden
            Template.SaveTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Info__;
    #line default
    #line hidden
    private System.Int64 __bf__AddNewCompanyTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddNewCompanyTrigger {
    #line 7 "Emelie_MainCompany_Json.json"
        get {
        #line hidden
            return Template.AddNewCompanyTrigger.Getter(this); }
        #line 7 "Emelie_MainCompany_Json.json"
        set {
        #line hidden
            Template.AddNewCompanyTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__CancelTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CancelTrigger {
    #line 8 "Emelie_MainCompany_Json.json"
        get {
        #line hidden
            return Template.CancelTrigger.Getter(this); }
        #line 8 "Emelie_MainCompany_Json.json"
        set {
        #line hidden
            Template.CancelTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__DeleteCompanyTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 DeleteCompanyTrigger {
    #line 9 "Emelie_MainCompany_Json.json"
        get {
        #line hidden
            return Template.DeleteCompanyTrigger.Getter(this); }
        #line 9 "Emelie_MainCompany_Json.json"
        set {
        #line hidden
            Template.DeleteCompanyTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TotalHomesSold__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TotalHomesSold {
    #line 10 "Emelie_MainCompany_Json.json"
        get {
        #line hidden
            return Template.TotalHomesSold.Getter(this); }
        #line 10 "Emelie_MainCompany_Json.json"
        set {
        #line hidden
            Template.TotalHomesSold.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Emelie_M__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Emelie_M__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveTrigger : Input<__Emelie_M__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Info : Input<__Emelie_M__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddNewCompanyTrigger : Input<__Emelie_M__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class CancelTrigger : Input<__Emelie_M__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class DeleteCompanyTrigger : Input<__Emelie_M__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class TotalHomesSold : Input<__Emelie_M__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
