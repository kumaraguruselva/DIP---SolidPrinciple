using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class BusinessLogic
    {
        private readonly IRepository _dataaccess;
        public BusinessLogic(IRepository dataaccess) { _dataaccess = dataaccess; }

        public void EditDetails()
        {
            _dataaccess.Edit();
        }
        public void SaveDetails()
        {
            _dataaccess.Save();
        }
    }
}
