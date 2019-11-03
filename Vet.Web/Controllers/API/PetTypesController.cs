using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Vet.Web.Data;
using Vet.Web.Data.Entities;

namespace Vet.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PetTypesController : ControllerBase
    {
        private readonly DataContext _context;

        public PetTypesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/PetTypes
        [HttpGet]
        public IEnumerable<PetType> GetPetTypes()
        {
            return _context.PetTypes;
        }
    }
}