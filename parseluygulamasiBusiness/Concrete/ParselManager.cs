using parseluygulamasi.Entities;
using parseluygulamasiBusiness.Abstract;
using parseluygulamasiDataAccess.Abstract;
using parseluygulamasiDataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parseluygulamasiBusiness.Concrete
{
    public class ParselManager : IParselService
    {
        private IParselRepository _parselRepository ;

        public ParselManager(IParselRepository parselRepository) {
            _parselRepository = parselRepository;
        }

        public Parsel CreateParsel(Parsel parsel)
        {
            return _parselRepository.CreateParsel(parsel);
        }

        public void DeleteParsel(int id)
        {
            _parselRepository.DeleteParsel(id);
        }

        public async Task<List<Parsel>> GetAllParsels()
        {
            return await _parselRepository.GetAllParsels();
        }

        public Parsel GetParselById(int id)
        {

            if (id>0) {
                return _parselRepository.GetParselById(id);
            }
            throw new Exception("İd , 0 dan büyük olmalıdır.");
        }

        public Parsel UpdateParsel(Parsel parsel)
        {
            return _parselRepository.UpdateParsel(parsel);
        }

        async Task<List<Parsel>> IParselService.GetAllParsels()
        {
            return await _parselRepository.GetAllParsels();
        }
    }
}
