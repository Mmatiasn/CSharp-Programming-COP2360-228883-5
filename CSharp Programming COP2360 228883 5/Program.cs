using System;
using System.Windows.Forms;

#pragma warning disable 1587
///------------------------------------------------------------------------------
///   Namespace:      <Class CSharp_Programming_COP2360_228883_5>                              
///   Class:          <Class Program>                                   
///   Description:    <Description Assignment 5>                                  
///   Author:         <Author Matias Miranda Noriega> Date: <DateTime 04/17/2017>   
///   Notes:          <Notes>                                        
///   Revision History:                                               
///   Name:Initial  Date:04/17/2017 Description:Last Modification Date                  
///------------------------------------------------------------------------------
#pragma warning restore 1587

namespace CSharp_Programming_COP2360_228883_5
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
            Application.Run(new MainForm());
        }
    }
}
