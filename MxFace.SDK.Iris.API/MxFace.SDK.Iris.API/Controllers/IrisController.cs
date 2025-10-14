using Microsoft.AspNetCore.Mvc;
using MxFace.Iris.Shared.Models;
using MxFace.SDK.Iris.Interfaces;

namespace MxFace.SDK.Iris.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IrisController : ControllerBase
    {
        private readonly IIrisProcessor _irisService;

        public IrisController(IIrisProcessor irisService)
        {
            _irisService = irisService;
        }

        [HttpPost("enroll")]
        public async Task<IActionResult> Enroll([FromBody] EnrollRequest request)
        {
            var result = await _irisService.EnrollIris(
                request.TemplateData,
                request.PersonId,
                request.Group
            );
            return Ok(result);
        }

        [HttpPost("search")]
        public async Task<IActionResult> Search([FromBody] SearchRequest request)
        {
            var result = await _irisService.SearchIris(request.TemplateData, request.Group);
            return Ok(result);
        }

        [HttpPost("verify")]
        public async Task<IActionResult> Verify([FromBody] MatchRequest request)
        {
            var result = await _irisService.VerifyIris(request.SourceTemplate, request.TargetTemplate);
            return Ok(result);
        }
    }
}
