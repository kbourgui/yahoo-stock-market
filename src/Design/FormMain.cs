using System;
using System.Drawing;
using System.Windows.Forms;
using Stock.Design.Forms.Controls;
using Stock.Design.Forms.Functions;

namespace Stock.Design
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

             FormLoader.LoadForm(new MarketDataForm(), this, true,Splitter_Main);
        }

        protected override void OnResize(EventArgs ea)
        {
            base.OnResize(ea);
            Splitter_Main.Width = ClientSize.Width;
        }
    }
}
