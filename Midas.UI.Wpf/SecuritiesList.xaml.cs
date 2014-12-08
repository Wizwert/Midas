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

namespace Midas.UI.Wpf
{
    /// <summary>
    /// Interaction logic for SecuritiesList.xaml
    /// </summary>
    public partial class SecuritiesList : UserControl
    {
        private readonly SecuritiesListViewModel _viewModel = new SecuritiesListViewModel();

        public SecuritiesList()
        {
            InitializeComponent();

            DataContext = _viewModel;
        }
    }
}
