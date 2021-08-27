using System;
using System.Collections.Generic;
using System.Linq;
using static WSAlmandTeknologi.ServiceModels;

namespace WSAlmandTeknologi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        dbAlmandTeknologiDataContext DB;

        public List<User> PostUser(string UserName, string Tipe)
        {
            DB = new dbAlmandTeknologiDataContext();

            List<User> Lmvh = new List<User>();
            
            try
            {
                var AllData = DB.GetUser(UserName, Tipe);
                foreach (var m in AllData)
                {
                    User ma = new User();
                    ma.ID = m.ID;
                    ma.UserName = m.UserName;
                    ma.Nama = m.Nama;
                    ma.Email = m.Email;
                    ma.bAktif = Convert.ToInt32(m.bAktif);
                    Lmvh.Add(ma);
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return Lmvh.ToList();
        }
        public List<User> GetUser(string UserName, string Tipe)
        {
            DB = new dbAlmandTeknologiDataContext();

            List<User> Lmvh = new List<User>();

            try
            {
                var AllData = DB.GetUser(UserName, Tipe);
                foreach (var m in AllData)
                {
                    User ma = new User();
                    ma.ID = m.ID;
                    ma.UserName = m.UserName;
                    ma.Nama = m.Nama;
                    ma.Email = m.Email;
                    ma.bAktif = Convert.ToInt32(m.bAktif);
                    Lmvh.Add(ma);
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return Lmvh.ToList();
        }
    }
}
