using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemo.Class
{
    public class SessionManager
    {
      
        //Private constructor
        SessionManager()
        {

        }
        //Static instance of SessionManager
        private static SessionManager sessionmanager;

        //Property To get sessionmanager object by creating new instance if sessionmanager object is null.
        public static SessionManager GetInstance
            {
            get
            {
                if (sessionmanager == null)
                {
                    sessionmanager = new SessionManager();
                }
                return sessionmanager;
            }
            
            }

        private string message;

        public string sMessage
        {
            get { return message; }
            set { message = value; }
        }
    }
}