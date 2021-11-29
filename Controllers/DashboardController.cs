using DashboardApi.Model;
using DashboardApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        IService iserv;

        public DashboardController(IService _iserv)
        {
            iserv = _iserv;
        }


        [HttpGet]
        [Route("GetAllAccelerators")]
        public ActionResult<Accelerator> GetAllAccelerators()
        {
            try
            {
                iserv = new ServiceClass();

                return Ok(iserv.getAllAccelerators());

            }

            catch
            {
                return BadRequest();
            }

        }


    }
}
