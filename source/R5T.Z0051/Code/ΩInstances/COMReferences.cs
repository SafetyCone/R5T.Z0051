using System;


namespace R5T.Z0051
{
    public class COMReferences : ICOMReferences
    {
        #region Infrastructure

        public static ICOMReferences Instance { get; } = new COMReferences();


        private COMReferences()
        {
        }

        #endregion
    }
}
