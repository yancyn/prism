// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.UnityExtensions;

namespace HelloWorld
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return this.Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }     

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(HelloWorldModule.HelloWorldModule));
            moduleCatalog.AddModule(typeof(TouchstoneModule.TouchstoneModule));

            // FAIL
            // load module at start up time if found
            //Assembly assembly = Application.Current.GetType().Assembly;
            //string directory = System.IO.Directory.GetParent(assembly.Location).FullName;
            //List<AssemblyName> assemblies = new List<AssemblyName>();
            //System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(directory);
            //foreach (System.IO.FileInfo fileInfo in directoryInfo.GetFiles())
            //{
            //    switch (fileInfo.Name.ToLower())
            //    {
            //        case "helloworldmodule.dll":
            //            moduleCatalog.AddModule(typeof(HelloWorldModule.HelloWorldModule));
            //            break;
            //        case "touchstonemodule.dll":
            //            moduleCatalog.AddModule(typeof(TouchstoneModule.TouchstoneModule));
            //            break;
            //    }
            //}
        }


    }
}
