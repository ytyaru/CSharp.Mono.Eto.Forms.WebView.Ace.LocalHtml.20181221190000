using System;
using Eto.Forms;
using Eto.Drawing;

namespace WebViewLocalHtml
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Title = "WebView LocalHtml";
            ClientSize = new Size(400, 350);
            //WebView webView = new WebView() { Url=new Uri("file:///res/index.html") };
            WebView webView = new WebView() { Url=new Uri("file:///tmp/work/Projects/WebViewLocalHtml/WebViewLocalHtml/WebViewLocalHtml/res/index.html") };
            //WebView webView = new WebView() { Url=new Uri("https://ace.c9.io/build/kitchen-sink.html") };

			DynamicLayout layout = new DynamicLayout();
			layout.Add(webView);
			Content = layout;
        }
    }
}
