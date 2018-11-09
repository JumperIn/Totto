﻿using System;
using MyTotto.Data.Models;

namespace MyTotto.Web.Models.Layout
{
    /// <summary>
    /// Модель представления для SEO-настроек.
    /// </summary>
    public class SeoViewModel
    {
        /// <summary>
        /// Название страницы.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Ключевые слова.
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public SeoViewModel()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        public SeoViewModel(SeoData seo)
        {
            Title = seo.Title;
            Description = seo.Description;
            Keywords = seo.Keywords;
        }
    }
}
