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
using System.Windows.Threading;

namespace BeehiveManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer timer = new DispatcherTimer();
        private readonly Queen queen;

        public MainWindow()
        {
            InitializeComponent();
            queen = Resources["queen"] as Queen;
            // The WPF app uses data binding now, so we don't need to use the Text property to update the status report TextBox.
            // statusReport.Text = queen.StatusReport;
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(1.5);
            timer.Start();
        }

        /// <summary>
        /// Timer calls the Tick event handler every 1.5 seconds, which in turn calls the WorkShift button's event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            WorkShift_Click(this, new RoutedEventArgs());
        }

        /// <summary>
        /// Passes text from the selected ComboBox item directly to Queen.AssignBee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssignJob_Click(object sender, RoutedEventArgs e)
        {
            queen.AssignBee(jobSelector.Text);
            // statusReport.Text = queen.StatusReport;
        }

        private void WorkShift_Click(object sender, RoutedEventArgs e)
        {
            queen.WorkTheNextShift();
            // statusReport.Text = queen.StatusReport;
        }
    }
}
