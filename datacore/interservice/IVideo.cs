using System;
using System.Collections.Generic;
using System.Text;
using layedata;

namespace datacore
{
   public interface IVideo
    {
        bool addvideo(videodore videodore);
        videodore getvideobyid(int id);
        List<videodore> getallvideo();
        List<videodore> getallvideobyid(int id);
        bool uodatevideo(videodore videodore);
        bool deletebyid(int id);
        bool videodoreExists(int id);
        vmvideopage getvmvideopagebyidvideo(int idvideo);
        bool createnazarvideo(string matnnazara, string videoida, string nameuser);
        bool isteacher(string username);
        bool deletenazar(int id);
        int getidvideobynazar(int id);
    }
}
