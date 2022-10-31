using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class ExpectionService:Exception
    {
        public ExpectionService(String Msg):base(Msg)
        {

        }

    }
}
