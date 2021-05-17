using layedata;
using System;
using System.Collections.Generic;
using System.Text;

namespace datacore
{
   public interface Idoreinter
    {
        bool adddore(dore dore);
        bool updatedore(dore dore);
        bool doreExists(int id);
        List<dore> getalldore();
        List<dore> getalldorebymodarsname(string name);
        doreindexpage getdorekamelbyid(int id);
        dore getdorebyid(int id);
        dore getdorebyname(string ids);
        bool deletdorebyid(int id);
        bool postftp(string fullnamea, string filenamea);
        List<dore> getdorebynamesearch(string name);

        bool isteacher(string name);
        bool addnazar(nazarat nazarat);

        bool addnazarostad(nazarostad nazarostad);
        int getintiduser(string username);
        bool deletenazar(int idnazar);
    }
}
