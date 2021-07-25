using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSAlmandTeknologi
{
    public class ServiceModels
    {
        public class User
        {
            public string UserName { get; set; }
            public string Nama { get; set; }
            public string Email { get; set; }
            public int ID { get; set; }
            public int bAktif { get; set; }
        }
    }
}