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
        private readonly IPromosRepository promosRepository;

        public PromosController(IPromosRepository promosRepository)
        {
            this.promosRepository = promosRepository;
        }

        #region Promo Blocks

        /// <summary>
        /// Возвращает список всех промо-блоков.
        /// </summary>
        [HttpGet("blocks/all")]
        public IEnumerable<Promo> GetAllPromos()
        {
            List<Promo> promos = promosRepository.GetAllPromos();
            return promos;
        }

        /// <summary>
        /// Добавляет новый промо-блок в список.
        /// </summary>
        /// <param name="promo">Данные промо-блока.</param>
        [HttpPost("blocks/block")]
        public void AddPromo([FromBody] Promo promo)
        {
            promosRepository.AddPromo(promo);
        }

        /// <summary>
        /// Обновляет данные промо-блока в списке.
        /// </summary>
        /// <param name="promo">Данные промо-блока.</param>
        [HttpPost("blocks/block/update")]
        public void UpdatePromo([FromBody] Promo promo)
        {
            promosRepository.UpdatePromo(promo);
        }

        /// <summary>
        /// Удаляет промо-блок из списка.
        /// </summary>
        /// <param name="id">Идентификатор промо-блока.</param>
        [HttpPost("blocks/block/delete/{id}")]
        public void DeletePromo(int id)
        {
            promosRepository.DeletePromo(id);
        }

        #endregion

        #region Promo Products

        /// <summary>
        /// Возвращает список всех промо-продуктов.
        /// </summary>
        [HttpGet("products/all")]
        public IEnumerable<PromoProduct> GetAllPromoProducts()
        {
            List<PromoProduct> promos = promosRepository.GetAllPromoProducts();
            return promos;
        }

        /// <summary>
        /// Добавляет новый промо-продукт в список.
        /// </summary>
        /// <param name="promo">Данные промо-продукта.</param>
        [HttpPost("products/product")]
        public void AddPromoProduct([FromBody] PromoProduct promo)
        {
            promosRepository.AddPromoProduct(promo);
        }

        /// <summary>
        /// Обновляет данные промо-продукта в списке.
        /// </summary>
        /// <param name="promo">Данные промо-продукта.</param>
        [HttpPost("products/product/update")]
        public void UpdatePromoProduct([FromBody] PromoProduct promo)
        {
            promosRepository.UpdatePromoProduct(promo);
        }

        /// <summary>
        /// Удаляет промо-продукт из списка.
        /// </summary>
        /// <param name="id">Идентификатор промо-продукта.</param>
        [HttpPost("products/product/delete/{id}")]
        public void DeletePromoProduct(int id)
        {
            promosRepository.DeletePromoProduct(id);
        }

        #endregion
    }
}