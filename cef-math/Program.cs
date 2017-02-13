using System;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            //For Windows 7 and above, best to include relevant app.manifest entries as well
            Cef.EnableHighDPISupport();

            //Perform dependency check to make sure all relevant resources are in our output directory.
            Cef.Initialize(new CefSettings(), performDependencyCheck: true, browserProcessHandler: null);

            var browser = new BrowserForm();
            Application.Run(browser);
        }
    }
}
