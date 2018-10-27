using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using MyTotto.Data.Abstract;
using MyTotto.Data.Models;

namespace MyTotto.Data.Repositories
{
    /// <summary>
    /// Репозиторий для промо-блоков.
    /// </summary>
    public class PromosRepository : BaseRepository, IPromosRepository
    {
        public PromosRepository(TottoContext context)
        {
            this.context = context;
        }

        #region Promo

        /// <summary>
        /// Возвращает весь список промо-блоков.
        /// </summary>
        public List<Promo> GetAllPromos()
        {
            List<Promo> promos = context.Promos
                .Where(p => p.IsActive)
                .OrderBy(p => p.Order)
                .ToList();

            return promos;
        }

        /// <summary>
        /// Возвращает промо-блок по ID.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        public Promo GetPromo(int id)
        {
            return context.Promos.FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Добавляет промо-блок в список.
        /// </summary>
        /// <param name="promo">Данные промо.</param>
        public void AddPromo(Promo promo)
        {
            context.Promos.Add(promo);
            Save();
        }

        /// <summary>
        /// Обновляет промо-блок в списке.
        /// </summary>
        /// <param name="promo">Данные промо.</param>
        public void UpdatePromo(Promo promo)
        {
            context.Promos.Update(promo);
            Save();
        }

        /// <summary>
        /// Удаляет промо-блок по ID.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        public void DeletePromo(int id)
        {
            Promo promo = GetPromo(id);
            if (promo == null)
            {
                return;
            }
            context.Promos.Remove(promo);
            Save();
        }

        #endregion

        #region PromoProduct

        /// <summary>
        /// Возвращает весь список промо товаров.
        /// </summary>
        public List<PromoProduct> GetAllPromoProducts()
        {
            List<PromoProduct> promoProducts = context.PromoProducts
                .Where(p => p.IsActive)
                .OrderBy(p => p.Order)
                .ToList();

            return promoProducts;
        }

        /// <summary>
        /// Возвращает промо товара по ID.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        public PromoProduct GetPromoProduct(int id)
        {
            return context.PromoProducts.FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Добавляет промо товара в список.
        /// </summary>
        /// <param name="promoProduct">Данные промо.</param>
        public void AddPromoProduct(PromoProduct promoProduct)
        {
            context.PromoProducts.Add(promoProduct);
            Save();
        }

        /// <summary>
        /// Обновляет промо товар в списке.
        /// </summary>
        /// <param name="promoProduct">Данные промо.</param>
        public void UpdatePromoProduct(PromoProduct promoProduct)
        {
            context.PromoProducts.Update(promoProduct);
            Save();
        }

        /// <summary>
        /// Удаляет промо товара по ID.
        /// </summary>
        /// <param name="id">Идентификатор промо.</param>
        public void DeletePromoProduct(int id)
        {
            PromoProduct promoProduct = GetPromoProduct(id);
            if (promoProduct == null)
            {
                return;
            }
            context.PromoProducts.Remove(promoProduct);
            Save();
        }

        #endregion
    }
}