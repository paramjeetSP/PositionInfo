//using Microsoft.AspNetCore.Http;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;

//namespace LeaveManagement.utilities
//{
//    public class SessionIndexer
//    {
//        private ISession Session;
//        public SessionIndexer(ISession Session)
//        {
//            this.Session = Session;
//        }
//        public object this[string key]
//        {
          
//            set
//            {
//                Session.SetObject(key, value);
//            }
//            get
//            {
//                return Session.GetObject(key);
//            }
//        }
//    }   
//}
