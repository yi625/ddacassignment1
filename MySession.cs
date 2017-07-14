using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDAC
{
    public class MySession
    {
        // private constructor
        private MySession()
        {
            AgentID = -1;
            StaffID = -1;
            Username = "";
            UserEmail = "";
            UserRole = "";
        }
        // Gets the current session.
        public static MySession Current
        {
            get
            {
                MySession session =
                  (MySession)HttpContext.Current.Session["__MySession__"];
                if (session == null)
                {
                    session = new MySession();
                    HttpContext.Current.Session["__MySession__"] = session;
                }
                return session;
            }
        }
        public int AgentID { get; set; }
        public int StaffID { get; set; }
        public string Username { get; set; }
        public string UserEmail { get; set; }
        public string UserRole { get; set; }
    }

}