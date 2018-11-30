using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemList
{
    public class DataG
    {
        private bool isConnected;

        public bool IsConnected
        {
            get { return isConnected; }
            set { isConnected = value; }
        }


        public DataG(bool _isconnected)
        {
            IsConnected = _isconnected;
        }
    }

 
}
