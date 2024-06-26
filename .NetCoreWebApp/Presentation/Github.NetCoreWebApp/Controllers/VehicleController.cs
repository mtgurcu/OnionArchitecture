﻿using Application.CQRS.Commands;
using Application.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Github.NetCoreWebApp.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class VehicleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VehicleController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            var result = await this._mediator.Send(new VehicleGetQueryRequest { Id = id });

            return Ok(result);
        }
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(VehicleCreateCommandRequest model)
        {
            var result = await this._mediator.Send(model);

            return Ok(result);
        }
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(VehicleUpdateCommandRequest model)
        {
            var result = await this._mediator.Send(model);

            return Ok(result);
        }
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(VehicleDeleteCommandRequest model)
        {
            var result = await this._mediator.Send(model);

            return Ok(result);
        }
    }
}
