using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cetho.Module.BusinessObjects
{
    public class GPSyncCreateria
    {

        public GPSyncCreateria()
        {
            //LastSync = System.DateTime.Now.ToString("yyMMddhhmmssfff");
           // Sync();
        }
        public void Sync()
        {
            LastSync = System.DateTime.Now.ToString("yyMMddhhmmssfff");
        }
        private DateTime  _FromDate; // field
        public DateTime FromDate   // property
        {
            get { 
                if ( _FromDate ==null)
                {
                    _FromDate = System.DateTime.Now;
                }
                return _FromDate; }
            set { _FromDate = value; }
        }
        private DateTime _ToDate; // field
        public DateTime ToDate   // property
        {
            get {
                if (_ToDate == null)
                {
                    _ToDate = System.DateTime.Now;
                }
                return _ToDate; }
            set { _ToDate = value; }
        }
       

       

        private string _LastSync; // field
        public string  LastSync   // property
        {
            get
            {
               return _LastSync;
            }
            set { _LastSync = value; }
        }
    }
}
