﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 12/25/2017 3:37:53 PM
namespace LightSwitchApplication.Implementation
{
    
    /// <summary>
    /// There are no comments for ApplicationData in the schema.
    /// </summary>
    public partial class ApplicationData : global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext
    {
        /// <summary>
        /// Initialize a new ApplicationData object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public ApplicationData(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
        }
        partial void OnContextCreated();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private const string ModelPart0 = @"<edmx:Edmx Version=""1.0"" xmlns:edmx=""http://schemas.microsoft.com/ado/2007/06/edmx""><edmx:DataServices xmlns:m=""http://schemas.microsoft.com/ado/2007/08/dataservices/metadata"" m:DataServiceVersion=""1.0"" m:MaxDataServiceVersion=""3.0""><Schema Namespace=""LightSwitchApplication"" Alias=""Self"" xmlns=""http://schemas.microsoft.com/ado/2008/09/edm""><EntityContainer Name=""ApplicationData"" m:IsDefaultEntityContainer=""true""><FunctionImport Name=""Microsoft_LightSwitch_GetCanInformation"" ReturnType=""Edm.String"" m:HttpMethod=""GET""><Parameter Name=""dataServiceMembers"" Type=""Edm.String"" Mode=""In"" /></FunctionImport></EntityContainer></Schema></edmx:DataServices></edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static string GetConcatenatedEdmxString()
            {
                return string.Concat(ModelPart0);
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            public static global::Microsoft.Data.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel LoadModelFromString()
            {
                string edmxToParse = GetConcatenatedEdmxString();
                global::System.Xml.XmlReader reader = CreateXmlReader(edmxToParse);
                try
                {
                    return global::Microsoft.Data.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
}
