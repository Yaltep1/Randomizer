using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    class Controller
    {
        private Connection con;
        public Controller()
        {
            con = new Connection();
        }
        public int loginUser(string log, string pass) {
            foreach (User user in con.Users)
            {
                if (user.login.TrimEnd().Equals(log.TrimEnd()) && user.password.TrimEnd().Equals(pass.TrimEnd()))return user.Id;
            }
            return -1;
        }
       public  ArrayList getRequests (int num) {
            ArrayList list = new ArrayList();
            
            foreach (Request req in con.Requests) {
                if (req.user_id == num) {
                    
                    list.Add("Nums: "+"("+req.start+") - ("+req.finish+"); Date: "+req.date+" ;"); }
            }
            return list;
        }
        public void incertReq(int start,int end,int id)
        {
            
            Request req = con.Requests.First();
            
            req.start = start;
            req.finish = end;
            req.user_id = id;
            req.date = DateTime.Now.ToShortDateString();
            con.Requests.Add(req);
            con.SaveChanges();
            
        }
    }
}
