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

        /// <summary>
        /// Возвращает список баннеров.
        /// </summary>
        [HttpGet("all")]
        public IEnumerable<Banner> GetAllBanners()
        {
            List<Banner> banners = bannersRepository.GetBanners();

            return banners;
        }

        /// <summary>
        /// Добавляет новый баннер в список.
        /// </summary>
        /// <param name="banner">Данные баннера.</param>
        [HttpPost("banner")]
        public void AddBanner(Banner banner)
        {
            bannersRepository.AddBanner(banner);
        }

        /// <summary>
        /// Обновляет данные баннера в списке.
        /// </summary>
        /// <param name="banner">Данные баннера.</param>
        [HttpPost("banner/update")]
        public void UpdateBanner(Banner banner)
        {
            bannersRepository.UpdateBanner(banner);
        }

        /// <summary>
        /// Удаляет баннер из списка.
        /// </summary>
        /// <param name="id">Идентификатор баннера.</param>
        [HttpDelete("banner/{id}")]
        public void UpdateBanner(int id)
        {
            bannersRepository.DeleteBanner(id);
        }
    }
}
