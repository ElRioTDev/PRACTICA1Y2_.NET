using Microsoft.AspNetCore.Mvc;
using Proyecto1.Services;


namespace Proyecto1.Controllers
{
    public class GpuController : Controller
    {
        private readonly GpuService _gpuService;

        public GpuController(GpuService gpuService)
        {
            _gpuService = gpuService;
        }

        public async Task<IActionResult> Index()
        {
            var gpus = await _gpuService.GetGpusAsync();
            return View(gpus);
        }
    }
}
