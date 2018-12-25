using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using MyTotto.Api.Abstract;
using MyTotto.Api.Models;
using MyTotto.Data;
using MyTotto.Data.Abstract;
using MyTotto.Data.Models;

namespace MyTotto.Api.Controllers
{
    /// <summary>
    /// Контроллер для подписчиков.
    /// </summary>
    [Consumes("application/json")]
    [Produces("application/json")]
    public class SubscribersController : BaseController
    {
        private readonly ISubscribersRepository subscribersRepository;

        public SubscribersController(ISubscribersRepository subscribersRepository)
        {
            this.subscribersRepository = subscribersRepository;
        }

        /// <summary>
        /// Сохраняет почту подписчика.
        /// </summary>
        /// <param name="subscriber">Данные подписчика.</param>
        /// <response code="400">Not valid.</response>
        /// <response code="200">Success.</response>
        [HttpPost("subscriber")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult SaveCall([FromBody] SubscriberBindingModel subscriber)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            Subscriber subscriberItem = new Subscriber(subscriber.Email);
            subscribersRepository.SaveSubscriber(subscriberItem);

            return Ok();
        }
    }
}