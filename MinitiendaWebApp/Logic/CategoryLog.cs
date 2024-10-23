using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class CategoryLog
    {
        CategoryDat objCat = new CategoryDat();
        public DataSet showCategories() {
            return objCat.showCategories();
        }

    }
}