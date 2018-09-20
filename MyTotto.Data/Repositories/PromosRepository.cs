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
        /// Возвращает продукт по промо-блоку.
        /// </summary>
        /// <param name="id">Идентификатор промо-блока.</param>
        public Promo GetPromo(int id)
        {
            return context.Promos.FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Добавляет промо-блок в список.
        /// </summary>
        /// <param name="promo">Данные промо-блока.</param>
        public void AddPromo(Promo promo)
        {
            context.Promos.Add(promo);
            Save();
        }

        /// <summary>
        /// Обновляет промо-блок в списке.
        /// </summary>
        /// <param name="promo">Данные промо-блока.</param>
        public void UpdatePromo(Promo promo)
        {
            context.Promos.Update(promo);
            Save();
        }

        /// <summary>
        /// Удаляет промо-блок по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор промо-блока.</param>
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
    }
}