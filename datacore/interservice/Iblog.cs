using System;
using System.Collections.Generic;
using System.Text;
using layedata;

namespace datacore
{
    public interface Iblog
    {
        blogmaghale getblogbyid(int id);
        List<blogmaghale> getallmaghale();
    }
}
