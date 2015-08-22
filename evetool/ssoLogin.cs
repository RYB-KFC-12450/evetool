using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace evetool
{
    public partial class ssoLogin : Form
    {
        public ssoLogin()
        {
            InitializeComponent();
            ssoLoginPage.Navigate("https://auth.eve-online.com.cn/oauth/authorize?client_id=eveLauncherSerenity&lang=zh&response_type=token&redirect_uri=https://auth.eve-online.com.cn/launcher?client_id=eveLauncherSerenity&scope=eveClientToken%20user");
        }

        private void ssoLoginPage_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ssoLoginPage.Document.BackColor = Color.Black;
            Regex tokenRegex = new Regex("access_token=([A-Za-z0-9_-]+)&");
            if (tokenRegex.IsMatch(ssoLoginPage.Url.ToString()))
            {
                MatchCollection mc = tokenRegex.Matches(ssoLoginPage.Url.ToString());
                String bearerToken = mc[0].Groups[1].ToString();
                this.Dispose();
            }
        }
    }
}
