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
    public class PromosController : BaseController
    {
        private IPromosRepository promosRepository;

        public PromosController(IPromosRepository promosRepository)
        {
            this.promosRepository = promosRepository;
        }

        /// <summary>
        /// Возвращает список всех промо-блоков.
        /// </summary>
        [HttpGet("all")]
        public IEnumerable<Promo> GetAllPromos()
        {
            List<Promo> promos = promosRepository.GetAllPromos();
            return promos;
        }

        /// <summary>
        /// Добавляет новый промо в список.
        /// </summary>
        /// <param name="promo">Данные промо.</param>
        [HttpPost("promo")]
        public void AddPromo([FromBody] Promo promo)
        {
            promosRepository.AddPromo(promo);
        }

        /// <summary>
        /// Обновляет данные промо в списке.
        /// </summary>
        /// <param name="promo">Данные промо.</param>
        [HttpPost("promo/update")]
        public void UpdatePromo([FromBody] Promo promo)
        {
            promosRepository.UpdatePromo(promo);
        }

        /// <summary>
        /// Удаляет промо из списка.
        /// </summary>
        /// <param name="id">Идентификатор промо.</param>
        [HttpPost("promo/delete/{id}")]
        public void DeletePromo(int id)
        {
            promosRepository.DeletePromo(id);
        }
    }
}