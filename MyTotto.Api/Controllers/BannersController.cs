using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using MyTotto.Api.Abstract;
using MyTotto.Data.Abstract;
using MyTotto.Data.Models;

namespace MyTotto.Api.Controllers
{
    public class BannersController : BaseController
    {
        private IBannersRepository bannersRepository;

        public BannersController(IBannersRepository bannersRepository)
        {
            this.bannersRepository = bannersRepository;
        }

        [HttpGet("all")]
        public IEnumerable<Banner> GetAllBanners()
        {
            List<Banner> banners = bannersRepository.GetBanners();

            return banners;
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
