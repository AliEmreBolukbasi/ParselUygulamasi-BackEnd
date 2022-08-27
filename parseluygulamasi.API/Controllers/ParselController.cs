using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using parseluygulamasi.Entities;
using parseluygulamasiBusiness.Abstract;
using parseluygulamasiBusiness.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parseluygulamasi.API.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class ParselController : ControllerBase
    {
        private IParselService _parselService;

        public ParselController(IParselService parselService) {

            _parselService = parselService;
        }

        [HttpGet]
        public async Task<List<Parsel>> Get() {

            return await _parselService.GetAllParsels(); 
        }

        [HttpGet("{id}")]
        public Parsel Get(int id)
        {
            return _parselService.GetParselById(id);
        }

        [HttpPost]
        public Parsel Post([FromBody]Parsel parsel)
        {
            return _parselService.CreateParsel(parsel);
        }

        [HttpPut]
        public Parsel Put([FromBody] Parsel parsel)
        {
            return _parselService.UpdateParsel(parsel);
        }

        [HttpDelete("{id}")]
        public void  Delete(int id)
        {
            _parselService.DeleteParsel(id);
        }

    }

}
