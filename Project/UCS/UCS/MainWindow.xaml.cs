using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UCS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Domain.Workspace> WorkspaceList = new List<Domain.Workspace>();

        public MainWindow()
        {
            InitializeComponent();

            WorkspaceList.Add(new Domain.Workspace { Name = "Item1", EngineDir = "Engine1", ProjectDir = "Project1" });
            WorkspaceList.Add(new Domain.Workspace { Name = "Item2", EngineDir = "Engine2", ProjectDir = "Project2" });

            WorkspaceView.ItemsSource = WorkspaceList;
            CommandView.ItemsSource = WorkspaceList;
        }
    }
}
