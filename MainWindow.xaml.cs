using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using ПШ.Utils;

namespace ПШ
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            var Agents = DatabaseContext.db.Agent.ToList();
            InitializeComponent();
            LViewAgents.ItemsSource = Agents;
        }
    }
}