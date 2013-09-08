﻿// FFXIVAPP.Client
// TabItemHelper.cs
// 
// © 2013 Ryan Wilson

#region Usings

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

#endregion

namespace FFXIVAPP.Client.Helpers
{
    internal static class TabItemHelper
    {
        /// <summary>
        /// </summary>
        /// <param name="image"> </param>
        /// <param name="name"> </param>
        /// <returns> </returns>
        public static DataTemplate ImageHeader(BitmapImage image, string name)
        {
            var dataTemplate = new DataTemplate();
            var stackPanelFactory = new FrameworkElementFactory(typeof (StackPanel));
            var imageFactory = new FrameworkElementFactory(typeof (Image));
            var labelFactory = new FrameworkElementFactory(typeof (Label));
            imageFactory.SetValue(FrameworkElement.HeightProperty, (double) 24);
            imageFactory.SetValue(FrameworkElement.WidthProperty, (double) 24);
            imageFactory.SetValue(FrameworkElement.ToolTipProperty, name);
            imageFactory.SetValue(Image.SourceProperty, image);
            labelFactory.SetValue(ContentControl.ContentProperty, name);
            labelFactory.SetValue(UIElement.VisibilityProperty, Visibility.Collapsed);
            labelFactory.SetValue(FrameworkElement.NameProperty, "FriendlyName");
            stackPanelFactory.AppendChild(imageFactory);
            stackPanelFactory.AppendChild(labelFactory);
            dataTemplate.VisualTree = stackPanelFactory;
            return dataTemplate;
        }
    }
}