using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyTotto.Data.Abstract;
using MyTotto.Data.Models;
using MyTotto.Web.Models;
using MyTotto.Web.Abstract;
using MyTotto.Data;
using MyTotto.Data.Models.Layout;

namespace MyTotto.Web.Controllers
{
    public class HeaderController : BaseController
    {
        private ICommonRepository commonRepository;

        public HeaderController(ICommonRepository commonRepository)
        {
            this.commonRepository = commonRepository;
        }

        /// <summary>
        /// Отображает хэдер с навигационным меню.
        /// </summary>
        public PartialViewResult Index()
        {

            //https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-2.1
            // ViewComponent вероятно
            Navigation navigation = commonRepository.GetNavigation();

            return PartialView("_Header", navigation);
        }
    }
}
