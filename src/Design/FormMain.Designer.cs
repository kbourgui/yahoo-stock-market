namespace Stock.Design
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Splitter_Main = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // Splitter_Main
            // 
            this.Splitter_Main.BackColor = System.Drawing.SystemColors.Control;
            this.Splitter_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Splitter_Main.Cursor = System.Windows.Forms.Cursors.Default;
            this.Splitter_Main.Location = new System.Drawing.Point(0, 0);
            this.Splitter_Main.Name = "Splitter_Main";
            this.Splitter_Main.Size = new System.Drawing.Size(1037, 715);
            this.Splitter_Main.TabIndex = 6;
            this.Splitter_Main.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 715);
            this.Controls.Add(this.Splitter_Main);
            this.Name = "FormMain";
            this.Text = "Yahoo Stock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter Splitter_Main;
    }
}

