using System.Diagnostics;

namespace webview2_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            webView2.Dock = DockStyle.Fill;

            //webView2.Source = new Uri($"file:///{Path.GetFullPath("./sample.pdf")}#page=2");
            //webView2.Source = new Uri($"file:///{Path.GetFullPath("./sample.pdf")}#toolbar=0&page=2");
            webView2.Source = new Uri($"file:///{Path.GetFullPath("./sample.pdf")}#toolbar=0&page=1&view=FitV");
        }
    }
}