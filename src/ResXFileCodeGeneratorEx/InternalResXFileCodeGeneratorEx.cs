using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TextTemplating.VSHost;

namespace DMKSoftware.CodeGenerators
{
    [Guid("AC0A9CFD-1B0A-4e4a-86A1-AB7854A33E23")]
    [Description("Extended ResX Internal File Code Generator")]
    [ComVisible(true)]
    //[CodeGeneratorRegistration(typeof(ResXFileCodeGeneratorEx), "ResXFileCodeGeneratorEx", VSConstants.UICONTEXT.CSharpProject_string, GeneratorRegKeyName = ".doml")]
    //[CodeGeneratorRegistration(typeof(ResXFileCodeGeneratorEx), "ResXFileCodeGeneratorEx", VSConstants.UICONTEXT.CSharpProject_string, GeneratesDesignTimeSource = true)]
    //[CodeGeneratorRegistration(typeof(ResXFileCodeGeneratorEx), "ResXFileCodeGeneratorEx", vsContextGuids.vsContextGuidVCSEditor, GeneratesDesignTimeSource = true)]
    //[ProvideObject(typeof(ResXFileCodeGeneratorEx))]
    [ProvideCodeGenerator(typeof(DMKSoftware.CodeGenerators.InternalResXFileCodeGeneratorEx), "InternalResXFileCodeGeneratorEx", "", true)]
    [ProvideCodeGeneratorExtension("InternalResXFileCodeGeneratorEx", ".resx", ProjectSystem = ProvideCodeGeneratorAttribute.CSharpProjectGuid)]
    [ProvideCodeGeneratorExtension("InternalResXFileCodeGeneratorEx", ".resx", ProjectSystem = ProvideCodeGeneratorAttribute.VisualBasicProjectGuid)]
    public class InternalResXFileCodeGeneratorEx : BaseResXFileCodeGeneratorEx
    {
        /// <summary>
        /// Initializes a new instance of the InternalResXFileCodeGeneratorEx class.
        /// </summary>
        public InternalResXFileCodeGeneratorEx()
        {
        }

        /// <summary>
        /// Gets the boolean flag indicating whether the internal class is generated.
        /// </summary>
        protected override bool GenerateInternalClass
        {
            get
            {
                return true;
            }
        }
    }
}