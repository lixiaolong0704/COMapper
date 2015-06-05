using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace COMapper
{
    public  interface  IEnumPanel
    {
        bool HasChildren { get; }

        void EnumAllChildrens(Action<object> child);

    }

    //public interface ICOMapperControl
    //{
    //    string Name { get; set; }
    //}
   
}
