using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainActivity.ViewModels {
    public class Lvl1_ViewModel {
    
        [DataType(DataType.Text)]
        public string Input { set; get; }

     
        public int CurrentProgress { set; get; }
    }
}
