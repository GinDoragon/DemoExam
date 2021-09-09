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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DemoExam
{
    /// <summary>
    /// Логика взаимодействия для AllAgents.xaml
    /// </summary>
    public partial class AllAgents : Page
    {
        public AllAgents()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
            timer.Start();
            cbFilter.Items.Add("По типу");
            cbSort.Items.Add("от А до Я");
        }

        public void UpdateData(object sender, object e)
        {
            var HistoryAgents = DB.agentsEntities.Agent.ToList();
            ListAgents.ItemsSource = HistoryAgents;
            ListAgents.ItemsSource = DB.agentsEntities.Agent.Where(x => x.Title.StartsWith(txtSearch.Text)).ToList();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
