using Microsoft.AspNetCore.Mvc;
using WorldServer.Application.DTOs;
using WorldServer.Application.Services;

namespace WorldServer.Api.Controllers
{
    [ApiController]
    [Route("api/objects")]
    public class ObjectController
    : ControllerBase
    {
        private readonly ObjectService service;

        public ObjectController(
            ObjectService service)
        {
            this.service = service;
        }

        [HttpGet("chunk")]
        public async Task<IActionResult>
            GetChunk(
                int chunkX,
                int chunkY)
        {
            var result =
                await service.GetChunkObjectsAsync(
                    chunkX,
                    chunkY);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult>
            Create(
                [FromBody]
            CreateObjectRequest request)
        {
            var result =
                await service.CreateAsync(
                    request);

            return Ok(result);
        }
    }
}