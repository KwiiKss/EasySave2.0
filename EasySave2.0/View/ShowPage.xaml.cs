﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;

namespace EasySave2._0
{
    /// <summary>
    /// Interaction logic for ShowPage.xaml
    /// </summary>
    public partial class ShowPage : Window
    {
        public ShowPage()
        {
            InitializeComponent();
        }

        private void ReturnButt(object sender, MouseButtonEventArgs e)
        {
            MenuEN window = new MenuEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void LoadSaves(object sender, MouseButtonEventArgs e)
        {
            listviewEN.Items.Clear();
            string Path = OptionsEN.Folder;

            DirectoryInfo dinfo = new DirectoryInfo(Path);

            FileInfo[] Files = dinfo.GetFiles();


            DirectoryInfo[] Dirs = dinfo.GetDirectories();

            foreach (FileInfo file in Files)
            {
                listviewEN.Items.Add(file.Name);
            }
            foreach (DirectoryInfo dir in Dirs)
            {
                listviewEN.Items.Add(dir.Name);
            }
            
        }
    }
}

