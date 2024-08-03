using MVVM_Proyecto.DAL;
using MVVM_Proyecto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Proyecto.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private List<Customer> _ListCustomers;
        public List<Customer> ListCustomers
        {
            get { return _ListCustomers; }
            set
            {
                if (_ListCustomers != value)
                {
                    _ListCustomers = value;
                    OnPropertyChanged("ListCustomers");
                }
            }
        }

        private ICommand _customerCommand;
        public ICommand CustomerCommand
        {
            get 
            { 
                if(_customerCommand == null)
                {
                    _customerCommand = new RelayCommand(param  => CustomerCommandExecute(), null);
                }
                return _customerCommand;
            }
        }

        private void CustomerCommandExecute() { 
            var customerService = new CustomerService();
            var result = customerService.GetCustomers();
            ListCustomers = new List<Customer>(result);
        }
    }
}
