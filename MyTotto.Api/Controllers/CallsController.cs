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
    /// Контроллер для заказа обратных звонков.
    /// </summary>
    [Consumes("application/json")]
    [Produces("application/json")]
    public class CallsController : BaseController
    {
        private ICallsRepository callsRepository;

        public CallsController(ICallsRepository callsRepository)
        {
            this.callsRepository = callsRepository;
        }

        /// <summary>
        /// Сохраняет заказ обратного звонка.
        /// </summary>
        /// <param name="call">Данные для звонка.</param>
        /// <response code="400">Not valid.</response>
        /// <response code="200">Success.</response>
        [HttpPost("order")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult SaveCall([FromBody] OrderCallBindingModel call)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            OrderCall callItem = new OrderCall(call.Name, call.Phone);
            callsRepository.SaveCall(callItem);

            return Ok();
        }
    }
}