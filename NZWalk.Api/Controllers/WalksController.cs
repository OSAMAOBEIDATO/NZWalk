using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalk.Api.Models.Domain;
using NZWalk.Api.Models.DTOs;
using NZWalk.Api.Repository;

namespace NZWalk.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IWalkRepository walkRepository;

        public WalksController(IMapper mapper, IWalkRepository walkRepository)
        {
            this.mapper = mapper;
            this.walkRepository = walkRepository;
        }



        [HttpPost]
        public async Task<IActionResult> create([FromBody] AddWalkrequestTdo addWalkrequestTdo)
        {
            //from TDO TO DOMAIN
            var WalkDomain = mapper.Map<Walk>(addWalkrequestTdo);
            await walkRepository.create(WalkDomain);
            return Ok();
        }
    }
}
