namespace evetool
{
    partial class ssoLogin
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
            this.ssoLoginPage = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // ssoLoginPage
            // 
            this.ssoLoginPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssoLoginPage.Location = new System.Drawing.Point(0, 0);
            this.ssoLoginPage.MinimumSize = new System.Drawing.Size(20, 20);
            this.ssoLoginPage.Name = "ssoLoginPage";
            this.ssoLoginPage.ScriptErrorsSuppressed = true;
            this.ssoLoginPage.Size = new System.Drawing.Size(334, 311);
            this.ssoLoginPage.TabIndex = 0;
            this.ssoLoginPage.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.ssoLoginPage_DocumentCompleted);
            // 
            // ssoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.ssoLoginPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ssoLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ssoLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser ssoLoginPage;
    }
}