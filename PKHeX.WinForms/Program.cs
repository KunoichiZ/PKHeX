﻿using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace PKHeX.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
#if !DEBUG
            // Add the event handler for handling UI thread exceptions to the event.
            Application.ThreadException += UIThreadException;

            // Set the unhandled exception mode to force all Windows Forms errors to go through our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event. 
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
#endif

            try
            {
                StartPKHeX();
            }
            catch (FileNotFoundException ex)
            {
                // Check whether or not the exception was from missing PKHeX.Core, rather than something else in the constructor of Main
                if (ex.TargetSite == typeof(Program).GetMethod(nameof(StartPKHeX), BindingFlags.Static | BindingFlags.NonPublic))
                {
                    // Exception came from StartPKHeX and (probably) corresponds to missing PKHeX.Core
                    MessageBox.Show("Could not locate PKHeX.Core.dll. Make sure you're running PKHeX together with its code library. Usually caused when all files are not extracted.", "PKHeX Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    // Exception came from Main
                    throw;
                }
            }
        }

        private static void StartPKHeX()
        {
            // Run the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        // Handle the UI exceptions by showing a dialog box, and asking the user whether or not they wish to abort execution.
        private static void UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            DialogResult result = DialogResult.Cancel;
            try
            {
                // Todo: make this translatable
                ErrorWindow.ShowErrorDialog("An unhandled exception has occurred.\nYou can continue running PKHeX, but please report this error.", t.Exception, true);
            }
            catch
            {
                try
                {
                    // Todo: make this translatable
                    MessageBox.Show("A fatal error has occurred in PKHeX, and the details could not be displayed.  Please report this to the author.", "PKHeX Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }

            // Exits the program when the user clicks Abort.
            if (result == DialogResult.Abort)
                Application.Exit();
        }

        // Handle the UI exceptions by showing a dialog box, and asking the user whether
        // or not they wish to abort execution.
        // NOTE: This exception cannot be kept from terminating the application - it can only 
        // log the event, and inform the user about it. 
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                var ex = (Exception)e.ExceptionObject;
                // Todo: make this translatable
                ErrorWindow.ShowErrorDialog("An unhandled exception has occurred.\nPKHeX must now close.", ex, false);
            }
            catch
            {
                try
                {
                    // Todo: make this translatable
                    MessageBox.Show("A fatal non-UI error has occurred in PKHeX, and the details could not be displayed.  Please report this to the author.", "PKHeX Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }
        }
    }
}
