namespace System
{
    internal class RibbonControlEventArgs
    {
        private Action<object, Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs> groupBox1_Enter;
        private Action<object, RibbonControlEventArgs> groupBox1_Enter1;

        public RibbonControlEventArgs(Action<object, Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs> groupBox1_Enter)
        {
            this.groupBox1_Enter = groupBox1_Enter;
        }

        public RibbonControlEventArgs(Action<object, RibbonControlEventArgs> groupBox1_Enter1)
        {
            this.groupBox1_Enter1 = groupBox1_Enter1;
        }

       

        public Action<object, RibbonControlEventArgs> GroupBox1_Enter { get; }
    }
}