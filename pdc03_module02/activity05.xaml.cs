using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace pdc03_module02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity05 : ContentPage
    {

        ObservableCollection<employee> employees = new ObservableCollection<employee>();

        public ObservableCollection<employee> Employees { get { return employees; } }
        public activity05()
        {
            InitializeComponent();

            {
                lst.ItemSource = employees;

                employees.Add(new employee { DisplayName = "Juan Dela Cruz", Position = "President", profileimage = "image1.jpg" });
                employees.Add(new employee { DisplayName = "Peter", Position = "Vice President", profileimage = "image2.jpg" });
                employees.Add(new employee { DisplayName = "Mary", Position = "Secretary", profileimage = "image3.jpg" });
            }
        }
    }
}