﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteControlSlave
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Directory.SetCurrentDirectory(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

            using (NotifyIcon icon = new NotifyIcon())
            {
                SlaveWindow f1 = new SlaveWindow(icon);
                f1.Hide();

                icon.Icon = f1.Icon;
                icon.Visible = true;

                Application.Run();
                icon.Visible = false;
            }
        }
    }
}
