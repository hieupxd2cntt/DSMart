using AspNetCoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DSMartEntities.Entities;
using System.Text.Json.Serialization;
using TanvirArjel.EFCore.GenericRepository;
using DSMartEntities;
using DSMartEntities.CommonFunction;
using System.Diagnostics;

namespace DSMartApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[IdentityBasicAuthentication]
    //[CustomAuthentication]
    public class UserController : ControllerBase
    {
        private readonly IRepository _repository;

        private readonly IQueryRepository _queryRepository;
        private readonly DSMartDbContext _context;
        private readonly IRepository<DSMartDbContext> _DSMartRepository;

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, IRepository repository, IQueryRepository queryRepository,DSMartDbContext context, IRepository<DSMartDbContext>DSMartRepository)
        {
            _logger = logger;
            _repository = repository;
            _context = context;
            _queryRepository = queryRepository;
            _DSMartRepository =DSMartRepository;
        }

        
    }
}