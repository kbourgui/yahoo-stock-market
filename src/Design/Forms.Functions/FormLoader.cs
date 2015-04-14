using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Stock.Design.Forms.Functions
{
    public class FormLoader
    {
        public static void LoadForm(Form formToLoad, Form formParent, bool anchor, Splitter panelToAnchor=null)
        {
            if (anchor && panelToAnchor!=null && !panelToAnchor.Controls.Contains(formToLoad))
            {
                formToLoad.Dock = DockStyle.Fill;
                formToLoad.TopLevel = false;
                formToLoad.FormBorderStyle = FormBorderStyle.None;
                formToLoad.StartPosition = FormStartPosition.Manual;
                formToLoad.Location = new Point((formParent.Size.Width - formToLoad.Size.Width)/2 - 5, formParent.Bottom);
                formToLoad.BringToFront();
                formToLoad.Visible = true;

                panelToAnchor.Controls.Add(formToLoad);
            }
            else
            {
                formToLoad.ShowDialog();
            }
        }

        public static object ExecuteWaitAction(Form formOwner, object actOrFunc)
        {
            FormWait pf = null;
            try
            {
                try
                {
                    pf = new FormWait(formOwner, actOrFunc);

                    if (pf.workerException != null)
                        Trace.TraceError("An exception occured when trying to load data.", pf.workerException);

                }
                finally
                {
                    pf.Finish();
                }
            }
            catch (Exception ex)
            {
                //Note cancellation throws an exception
                MessageBox.Show(ex.Message);
            }

            if (pf != null) return pf.functionResult;
            return null;
        }
    }
}
