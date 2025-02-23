﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Petzold.EncloseElementInEllipse
{
    class EncloseElementInEllipse : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new EncloseElementInEllipse());
        }

        public EncloseElementInEllipse()
        {
            Title = "Enclose Element in Ellipse";
            EllipseWithChild elips = new EllipseWithChild();
            elips.Fill = Brushes.ForestGreen;
            elips.Stroke = new Pen(Brushes.Magenta, 24);
            Content = elips;

            TextBlock text = new TextBlock();
            text.FontFamily = new FontFamily("Pretendard");
            text.FontSize = 48;
            text.Text = "Text inside ellipse";

            elips.Child = text;
        }
    }
}
