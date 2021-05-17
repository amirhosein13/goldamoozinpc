using layedata;
using System;
using System.Collections.Generic;
using System.Text;

namespace datacore
{
   public interface Iinteruserpanel
    {
        List<dore> getalldorebyusername(string name);
        int getdorecountbyname(string name);
        List<payuserdore> getfactorbyname(string name);
        List<soal> getsoalbynameuser(string name);
        List<javab> getalljavabhayam(string name);
    }
}
