using layedata;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace datacore
{
    public interface Isoalinter
    {
        List<soal> getallsoal();
        List<soal> getsoalbyiddore(int dore);
        bool addsoal(soal soal);
        soal getsoalbyid(int id);
        bool addjavab(javab javab);
        int getidbynameuser(string name);
        bool modarsgsaya(int id);
        List<soal> getsoalbynamesoal(string name);
        bool javabsahihkon(string idusername,int idjavab);
    }
}
