using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadordeVendas.Models
{
    public class func
    {
        public bool isVogal(char v)
        {
            if (v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u')
            {
                return true;
            }
            return false;
                }
    }
}
