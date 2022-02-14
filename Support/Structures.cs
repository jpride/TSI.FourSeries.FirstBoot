namespace TSI.FourSeries.FirstBoot
{
    using System;
    using System.Collections.Generic;

    public class BootRecord
    {
        public ushort bootcount { get; set; }
    }

    public class BootRecordReadEventArgs : EventArgs
    {
        public ushort previousBootCount { get; set; }
        public ushort newBootCount { get; set; }

    }



}
