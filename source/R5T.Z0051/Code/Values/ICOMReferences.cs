using System;

using R5T.T0131;
using R5T.T0206;


namespace R5T.Z0051
{
    [ValuesMarker]
    public partial interface ICOMReferences : IValuesMarker
    {
        /// <summary>
        /// Microsoft.Office.Interop.Excel, 1.9
        /// </summary>
        private static readonly Lazy<COMReference> zMicrosoft_Office_Interop_Excel = new Lazy<COMReference>(() => new COMReference
        {
            EmbedInteropTypes = true,
            Guid = Instances.GuidOperator.Parse("00020813-0000-0000-c000-000000000046"),
            Isolated = false,
            Lcid = 0,
            Name = "Microsoft.Office.Interop.Excel",
            Version_Major = 1,
            Version_Minor = 9,
            WrapperTool = "tlbimp",
        });
        /// <inheritdoc cref="ICOMReferences.zMicrosoft_Office_Interop_Excel"/>
        public COMReference Microsoft_Office_Interop_Excel => ICOMReferences.zMicrosoft_Office_Interop_Excel.Value;
    }
}
