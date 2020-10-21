using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationTestApp.ViewModels {

    public class DataGridItemViewModel {
        public Dictionary<string, string> Properties { 
            set; 
            get;
        }
    }


    public class DataGridViewModel {
        public ObservableCollection<Dictionary<string, string>> DataStore { set; get; } = new ObservableCollection<Dictionary<string, string>>();

        public DataGridViewModel() {
            DataStore.Add(new Dictionary<string, string>() { { "column1", "korte" }, { "column2", "nyuszi" } });
            DataStore.Add(new Dictionary<string, string>() { { "column1", "nyamm" }, { "puding3", "boci" } });
            DataStore.Add(new Dictionary<string, string>() { { "column2", "hohoho" }, { "puding3", "trololo" } });
        }
    }
}
