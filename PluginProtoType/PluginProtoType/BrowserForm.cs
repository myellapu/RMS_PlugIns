using System;
using System.Windows.Forms;
namespace PluginProtoType
{
    public partial class BrowserForm : Form
    {
        public BrowserForm(string url)
        {
            InitializeComponent();
            webBrowser.Url = new Uri(url,UriKind.Absolute);
        }
    }
}
