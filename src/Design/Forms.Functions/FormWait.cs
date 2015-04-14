using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Stock.Design.Forms.Functions
{
    /// <summary>
    /// Allows a progress indicator to pop up, blocking the user from
    /// doing anything (except possibly canceling the operation).
    /// To use you MUST MUST MUST call SetupAndShow, then call Finish in
    ///// a finally block. You may call ShowProgress any number of times
    /// in between. If you allow cancellation, then you must trap errors,
    /// as a cancellation will throw an exception.
    /// </summary>
    public partial class FormWait : Form, IMessageFilter
    {
        const int WM_PAINT = 0x000F, WM_NCACTIVATE = 0x086;
        private const int WS_SYSMENU = 0x80000;

        private Form caller;
        private DateTime showTime; //time when form should show, UTC
        private Cursor priorCursor = Cursors.Default;
        private bool allowCancel; //controls whether a manual close should cause an exception
        private bool pleaseAbort; //set when user presses cancel
        private bool isFinishing = false;
        // private GifAnimation gifImage = null;
        private Action _action;
        private Func<object> _function;

        public Exception workerException;
        public object functionResult;

        private BackgroundWorker BG;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }


        public FormWait(Form parent, object action)
        {
            InitializeComponent();

            BG = new BackgroundWorker();
            BG.DoWork += new DoWorkEventHandler(BG_DoWork);
            BG.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BG_RunWorkerCompleted);

            caller = parent;

            if (action.GetType() == typeof(Action))
                _action = (Action)action;
            else
                _function = (Func<object>)action;

            if (!caller.Visible)
                this.StartPosition = FormStartPosition.CenterScreen;
            else
                this.Location = new Point(caller.PointToScreen(caller.Location).X + (caller.Size.Width - Size.Width) / 2,
                     caller.PointToScreen(caller.Location).Y + (caller.Size.Height - Size.Height) / 2);

            if (!BG.IsBusy)
            {
                BG.RunWorkerAsync();
                this.SetupAndShow(caller, "", false, false);
            }
        }

        void BG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BG.Dispose();
            this.Close();
            //  this.Finish();
        }

        void BG_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (_action != null)
                    _action();

                else if (_function != null)
                    functionResult = _function();
            }
            catch (Exception ex)
            {
                workerException = ex;
                // throw ex;
            }
        }

        /// <summary>
        /// Setup the form.
        /// </summary>
        /// <param name="msg1">the message describing the work being done</param>
        /// <param name="delayedDisplay">if true, the form is only shown if
        /// the operation takes longer than a half-second</param>
        public void SetupAndShow(Form caller, string msg1,
            bool delayedDisplay, bool allowCancel)
        {
            if (caller == null)
            {
                if (Application.OpenForms.Count == 0) return;
                caller = Application.OpenForms[0];
            }
            this.allowCancel = allowCancel;
            eCancel.Visible = allowCancel;
            this.caller = caller;
            if (delayedDisplay)
                showTime = DateTime.UtcNow.AddSeconds(0.5);
            else
            {
                showTime = DateTime.MinValue;
                ShowProgress(0, null);
            }
            priorCursor = caller.Cursor;
            caller.Cursor = Cursors.WaitCursor;
            Application.AddMessageFilter(this);
        }

        /// <summary>
        /// Update progress bar and labels. If enough time has passed,
        /// make form visible. Call DoEvents, and if form is canceled,
        /// throw Exception.
        /// </summary>
        /// <param name="percent">a number between 0 and 1</param>
        /// <param name="displayValue"></param>
        public void ShowProgress(double percent, string displayValue)
        {
            //show/paint form
            if (!this.Visible && showTime < DateTime.UtcNow)
            {
                this.ShowDialog();
                Cursor = Cursors.WaitCursor;
                if (eCancel.Visible) eCancel.Focus();
            }

            //allow some events to occur during the work, but only those
            //that deal with the cancel button
            Application.DoEvents();
            if (pleaseAbort)
            {
                Application.RemoveMessageFilter(this);

                this.Hide();
                throw new Exception("Operation canceled");
            }
        }

        //returns true if a message should be filtered out
        public bool PreFilterMessage(ref Message m)
        {
            bool isgoodtype = m.Msg == WM_PAINT;
            bool allowed = isgoodtype ||
                (Visible && (m.HWnd == this.Handle || m.HWnd == eCancel.Handle));
            return !allowed;
        }

        private void eCancel_Click(object sender, EventArgs e)
        {
            pleaseAbort = true;
        }

        /// <summary>
        /// Finish form - hides, unless there are errors, in which case it
        /// shows it as a dialog and waits for OK pressed
        /// </summary>
        public void Finish()
        {
            if (!isFinishing)
            {
                isFinishing = true;
                Application.DoEvents(); //this clears the event queue of unwanted clicks
                Hide();
                Application.RemoveMessageFilter(this);
                Dispose();
                caller.Cursor = priorCursor;

                caller.Refresh();
            }
        }

    }


}