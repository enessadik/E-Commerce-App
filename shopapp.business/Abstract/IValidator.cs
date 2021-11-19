using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Abstract
{
    public interface IValidator<T>
    {
        //Dictionary<string, string> ErrorMessage;  //daha detaylı bir bilgi vermek için Dictionary kullanabilriiz...
        string ErrorMessage { get; set; }
        bool Validation(T entity);
    }
}
