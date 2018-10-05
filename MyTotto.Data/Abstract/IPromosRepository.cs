using System;
using System.Collections.Generic;
using MyTotto.Data.Models;

namespace MyTotto.Data.Abstract
{
    /// <summary>
    /// Интерфейс для работы с промо-блоками.
    /// </summary>
    public interface IPromosRepository
    {
        /// <summary>
        /// Возвращает весь список промо-блоков.
        /// </summary>
        List<Promo> GetAllPromos();

        /// <summary>
        /// Возвращает продукт по промо-блоку.
        /// </summary>
        /// <param name="id">Идентификатор промо-блока.</param>
        Promo GetPromo(int id);

        /// <summary>
        /// Добавляет промо-блок в список.
        /// </summary>
        /// <param name="promo">Данные промо-блока.</param>
        void AddPromo(Promo promo);

        /// <summary>
        /// Обновляет промо-блок в списке.
        /// </summary>
        /// <param name="promo">Данные промо-блока.</param>
        void UpdatePromo(Promo promo);

        /// <summary>
        /// Удаляет промо-блок по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор промо-блока.</param>
        void DeletePromo(int id);
    }
}