using parseluygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parseluygulamasiBusiness.Abstract
{
    public interface IParselService
    {
        Task<List<Parsel>> GetAllParsels();
        Parsel GetParselById(int id);
        Parsel CreateParsel(Parsel parsel);
        Parsel UpdateParsel(Parsel parsel);
        void DeleteParsel(int id);
    }
}
