using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp09
{
    public class People : IDataErrorInfo
    {
        public string this[string columnName]
        {
            get
            {
                string errorInfo = null;
                switch (columnName)
                {
                    case "State":
                        if (State > 228)
                            errorInfo = "Введена не правильная статья XD XD " +
                                "Вы депортированные в КОРЕЮ";
                        else if (State < 0)
                            errorInfo = "Статья не может быть меньше нуля XD XD XD XD ";
                        break;
                    case "Name":
                        if (Name.Length < 4)
                            errorInfo = "Имя слишком короткое";
                        break;
                   
                }
                return errorInfo;
            }
        }

        public string Name { get; set; }
        public int State { get; set; }
        public string Error { get; set; }
    }
}
