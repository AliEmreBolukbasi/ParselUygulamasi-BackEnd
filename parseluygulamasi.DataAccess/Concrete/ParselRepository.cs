using Microsoft.EntityFrameworkCore;
using parseluygulamasi.DataAccess;
using parseluygulamasi.Entities;
using parseluygulamasiDataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parseluygulamasiDataAccess.Concrete
{
    
    public class ParselRepository : IParselRepository
    {

        public Parsel CreateParsel(Parsel parsel)
        {
            using (var ctx = new ParselDbContext())
            {
                ctx.Parsels.Add(parsel);
                ctx.SaveChanges();
                return parsel;
            }
        }

        public void DeleteParsel(int id)
        {
            using (var ctx = new ParselDbContext())
            {
                var deletedParsel = GetParselById(id);
                ctx.Parsels.Remove(deletedParsel);
                ctx.SaveChanges();
            }
        }

        public  Task<List<Parsel>> GetAllParsels()
        {
            // usingle beraber task kullanılmıyor.Context disoble hatası veriyor
                var ctx = new ParselDbContext();
                return ctx.Parsels.ToListAsync();
        }




        public Parsel GetParselById(int id)
        {
            using (var ctx = new ParselDbContext())
            {
                return ctx.Parsels.Find(id);
            }
        }

        public Parsel UpdateParsel(Parsel parsel)
        {
            using (var ctx = new ParselDbContext())
            {
                ctx.Parsels.Update(parsel);
                ctx.SaveChanges();
                return parsel;
            }
        }
    }
}
