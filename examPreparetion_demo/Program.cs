namespace examPreparetion_demo
{
    using System;
    using System.Collections.Generic;

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //ÉzÅ[ÉÄâÊñ ÇçÏê¨
            ApplicationContext appContext = new ApplicationContext();
            appContext.MainForm = new Home();
            Application.Run(appContext);
        }
        public static ApplicationContext AppContext { get; private set; }

        public static void ApplicationExit()
        {
            Application.Exit();
        }
    }
}