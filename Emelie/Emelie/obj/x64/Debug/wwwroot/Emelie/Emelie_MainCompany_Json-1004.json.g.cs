// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "wwwroot\Emelie\Emelie_MainCompany_Json.json"
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

namespace Emelie.wwwroot.Emelie {
using __Emelie_M__ = global::Emelie.wwwroot.Emelie.Emelie_MainCompany_Json;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __EmSchema__ = global::Emelie.wwwroot.Emelie.Emelie_MainCompany_Json.JsonByExample.Schema;
using __Emelie_M1__ = global::Emelie.wwwroot.Emelie.Emelie_MainCompany_Json.JsonByExample;
using __Emelie_M2__ = global::Emelie.wwwroot.Emelie.Emelie_MainCompany_Json.Input;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;

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
            }
            public override object CreateInstance(s.Json parent) { return new __Emelie_M__(this) { Parent = parent }; }
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
    }
    #line default
}
#line default

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class Emelie_MainCompany_Json_json : s::TemplateAttribute {
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
