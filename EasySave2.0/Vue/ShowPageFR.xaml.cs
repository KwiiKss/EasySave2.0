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

namespace EasySave
{
    public partial class ShowPageFR : Window
    {
        public ShowPageFR()
        {
            InitializeComponent(); // Initialisation des composants de la page
        }

        private void ReturnButt(object sender, MouseButtonEventArgs e) // Event bouton qui permets de revenir à la page précédente
        {
            MenuFR window = new MenuFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void LoadSavesFR(object sender, RoutedEventArgs e) // Méthode qui permets de récupérer les différents fichiers et dossiers du chemin par défaut
        {
            listviewFR.Items.Clear();
            string Chemin = Data.Instance.DefaultPath;

            DirectoryInfo dinfo = new DirectoryInfo(Chemin);

            FileInfo[] Fichier = dinfo.GetFiles();


            DirectoryInfo[] Dirs = dinfo.GetDirectories();

            foreach (FileInfo fichier in Fichier)
            {
                listviewFR.Items.Add(fichier.Name);
            }
            foreach (DirectoryInfo dir in Dirs)
            {
                listviewFR.Items.Add(dir.Name);
            }
            
        }
    }
}

