using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalk.Api.Data;
using NZWalk.Api.Models.Domain;
using NZWalk.Api.Models.DTOs;
using NZWalk.Api.Repository;



namespace NZWalk.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        public readonly NZWalkDBContext _dBContext;
        public IRegionRepostory regionRepostory;
        private readonly IMapper mapper;

        public RegionController(NZWalkDBContext dBContext, IRegionRepostory regionRepostory,
            IMapper mapper)
        {
            this._dBContext = dBContext;
            this.regionRepostory = regionRepostory;
            this.mapper = mapper;
        }

        //GET:get all region in database
        //GET:http://localhost:7072/api/region
        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
            // Fetch data from the database asynchronously
            var regionDomain = await regionRepostory.GetAllRegionsAsync();

            /* Map domain models to DTOs
            var regionDTOs = new List<RegionDTO>();
            foreach (var region in regionDomain)
            {
                regionDTOs.Add(new RegionDTO
                {
                    id = region.id,
                    name = region.name,
                    code = region.code,
                    regionImageUrl = region.regionImageUrl,
                });
            }*/




            return Ok(mapper.Map<List<RegionDTO>>(regionDomain));
        }



        //GET:to get single recorde in database
        //GET:http://localhost:7072/api/region/id
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> getSingleRegion([FromRoute] Guid id)
        {
            //from database to domain models 
            // var regions = _dBContext.regions.Find(id); 
            var regionsDomain = await regionRepostory.getSingleRegionAsync(id);

            if (regionsDomain == null)
                return NotFound();
            //From  domain to tdo 
            /* var regionTDO = new RegionDTO()
             {
                 id = regionsDomain.id,
                 name = regionsDomain.name,
                 code = regionsDomain.code,
                 regionImageUrl = regionsDomain.regionImageUrl,
             };*/

            //from tdo to cleint
            return Ok(mapper.Map<RegionDTO>(regionsDomain));
        }


        //Post to create new recorde
        //POST:http://localhost:7072/api/region
        [HttpPost]
        public async Task<IActionResult> create([FromBody] AddRegionRequstDto addRegionRequstTdo)
        {
            //from TDO to domine

            var regionDomain = mapper.Map<Region>(addRegionRequstTdo);
            //from domain to database
            await regionRepostory.create(regionDomain);

            //back from region domain to TDO
            /*var regionDto = new RegionDTO
            {
                id = regionDomain.id,
                name = regionDomain.name,
                code = regionDomain.code,
                regionImageUrl = regionDomain.regionImageUrl,
            };*/

            return CreatedAtAction(nameof(getSingleRegion), new { id = regionDomain.id }, mapper.Map<RegionDTO>(regionDomain));
        }


        //PUT:to update database
        //GET:http://localhost:7072/api/region/id
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionRequstDto updateRegionRequstTdo)
        {
            //check if Exit
            /* var RegionDomenModels = new Region()
             {
                 id = id,
                 name = updateRegionRequstTdo.name,
                 code = updateRegionRequstTdo.code,
                 regionImageUrl = updateRegionRequstTdo.regionImageUrl
             };*/
            var RegionDomenModels = mapper.Map<Region>(updateRegionRequstTdo);
            var checkifound = await regionRepostory.update(id, RegionDomenModels);

            if (checkifound == null)
            {
                return NotFound();
            }

            //convart from domain to Tdo
            /*
            var updateRegionDto = new RegionDTO
            {
                id = RegionDomenModels.id,
                name = RegionDomenModels.name,
                code = RegionDomenModels.code,
                regionImageUrl = RegionDomenModels.regionImageUrl,

            };*/
            return Ok(mapper.Map<RegionDTO>(RegionDomenModels));

        }

        //Delete Region
        //DELETE:http://localhost:7072/api/region/id
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var regionsDomainModels = await regionRepostory.Delete(id);
            if (regionsDomainModels == null)
            {
                return NotFound();
            }

            /* var RegionDto = new RegionDTO
             {
                 id = regionsDomainModels.id,
                 name = regionsDomainModels.name,
                 code = regionsDomainModels.code,
                 regionImageUrl = regionsDomainModels.regionImageUrl,

             };*/
            var RegionDto = mapper.Map<RegionDTO>(regionsDomainModels);

            return Ok(RegionDto);

        }


    }
}
