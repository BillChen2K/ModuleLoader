﻿using System;
using System.Windows.Forms;
namespace ModuleLoader
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //var form = new RenderForm("Module Loader")
            //{
            //    Width = 1280,
            //    Height = 720
            //};

            //RenderLoop.Run(form, () =>
            //{

            //});
        }
    }
}
