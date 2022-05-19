using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiSample
{
    internal class StartupPageTabbed : TabbedPage
    {
        public StartupPageTabbed()
        {
            Children.Add(new AppShell() { Title = "Shell"});
            Children.Add(new CodeBehindMainPage() { Title = "NoShell" });
        }
    }
}
