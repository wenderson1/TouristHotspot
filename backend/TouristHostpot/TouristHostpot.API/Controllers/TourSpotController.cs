using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouristHotspot.Application.Commands.CreateTourSpot;
using TouristHotspot.Application.Queries.GetAllTourSpot;
using TouristHotspot.Application.Queries.GetTourSpot;
using TouristHotspot.Core.Repositories;

namespace TouristHostpot.API.Controllers
{
    [Route("api/tourSpot")]
    public class TourSpotController:ControllerBase
    {
        private readonly ITourSpotRepository _tourSpotRepository;
        private readonly IMediator _mediator;

        public TourSpotController(ITourSpotRepository tourSpotRepository,IMediator mediator)
        {
            _tourSpotRepository = tourSpotRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {
            var getAllTourSpotQuery = new GetAllTourSpotQuery(query);
            var tourSpots = await _mediator.Send(getAllTourSpotQuery);

            return Ok(tourSpots);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>GetById(int id)
        {
            var getTourSpotByIdQuery = new GetTourSpotByIdQuery(id);
            var tourSpot = await _mediator.Send(getTourSpotByIdQuery);

            if (tourSpot == null)
                return NotFound();

            return Ok(tourSpot);
        }

        [HttpPost]
        public async Task<IActionResult>  Post([FromBody] CreateTourSpotCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }
    }
}
