using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using MyTotto.Api.Abstract;
using MyTotto.Data;
using MyTotto.Data.Abstract;
using MyTotto.Data.Models;

namespace MyTotto.Api.Controllers
{
    public class BannersController : BaseController
    {
        private readonly IBannersRepository bannersRepository;

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
        public void AddBanner([FromBody] Banner banner)
        {
            bannersRepository.AddBanner(banner);
        }

        /// <summary>
        /// Обновляет данные баннера в списке.
        /// </summary>
        /// <param name="banner">Данные баннера.</param>
        [HttpPost("banner/update")]
        public void UpdateBanner([FromBody] Banner banner)
        {
            bannersRepository.UpdateBanner(banner);
        }

        /// <summary>
        /// Удаляет баннер из списка.
        /// </summary>
        /// <param name="id">Идентификатор баннера.</param>
        [HttpPost("banner/delete/{id}")]
        public void DeleteBanner(int id)
        {
            bannersRepository.DeleteBanner(id);
        }
    }
}