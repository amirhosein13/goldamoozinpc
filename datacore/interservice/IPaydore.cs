using System;
using System.Collections.Generic;
using System.Text;
using layedata;

namespace datacore
{
   public interface IPaydore
    {
        int returniduserbyname(string name);
        payuserdore returniduserdorepay(int id);
        int adduserpay(int iduser,int iddore);
        int getghaymatdore(int id);
        bool updatepardakht(int id);
        bool getkhariddore(string username,int id);
    }
}
