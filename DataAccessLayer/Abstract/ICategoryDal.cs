using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {                                       /*CRUD İşlemleri burada tanımlandı.*/
        List<Category> List();

        void Insert(Category p);

        void Update(Category p);

        void Delete(Category p);


    }
}
