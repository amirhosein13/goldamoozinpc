using System;
using System.Collections.Generic;
using System.Text;

namespace datacore
{
   public interface Iuser
    {
        public int getroleiduser(string id);
        public bool getbooldastresuser(string id,int idrole);
    }
}
