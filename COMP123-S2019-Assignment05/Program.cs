﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// 
/// Course Name:    COMP123
/// Course Section: Section 002
/// Assignment:     #5-Dollar Computers
/// Student Name:   Harbin Ramo
/// Student Number: 301046044
/// 
/// </summary>
namespace COMP123_S2019_Assignment05
{
    static class Program
    {
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static AboutForm aboutForm;

        public static string FileName { get; set; }
        public static string BeginTag { get; set; }
        public static string NextTag { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new SplashForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();

            Application.Run(splashForm);
        }
    }
}
