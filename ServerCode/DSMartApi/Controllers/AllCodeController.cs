using AspNetCoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DSMartApi.Common;
using DSMartEntities.Entities;
using System.Data.Common;
using System.Data.Entity;
using System.Net.WebSockets;
using System.Threading;
using TanvirArjel.EFCore.GenericRepository;
using DSMartEntities.Enum;

namespace DSMartApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[IdentityBasicAuthentication]
    //[CustomAuthentication]
    public class ALLCODEController : ControllerBase
    {
        private readonly IRepository _repository;

        private readonly IQueryRepository _queryRepository;
        private readonly DSMartDbContext _context;
        private readonly IRepository<DSMartDbContext> _pharmacyRepository;

        private readonly ILogger<UserController> _logger;

        public ALLCODEController(ILogger<UserController> logger, IRepository repository, IQueryRepository queryRepository,DSMartDbContext context,IRepository<DSMartDbContext> pharmacyRepository)
        {
            _logger = logger;
            _repository = repository;
            _context = context;
            _queryRepository = queryRepository;
            _pharmacyRepository = pharmacyRepository;
        }

        [HttpGet]
        [Route("LoadALLCODEByType")]
        public async Task<List<ALLCODE>> LoadAllCodeByType(string type)
        {
            try
            {
                await _context.Database.OpenConnectionAsync(default);
                var ALLCODEs=_context.AllCode.Where(x => x.CODE_NAME == type);
                if(ALLCODEs!=null && ALLCODEs.Any())
                    return ALLCODEs.ToList();
            }
            catch (Exception e)
            {

            }
            finally
            {
                await _context.Database.CloseConnectionAsync();
            }
            return null;
        }
        [HttpGet]
        [Route("LoadAllallCode")]
        public async Task<List<ALLCODE>> LoadAllallCode()
        {
            try
            {
                var test = new List<ALLCODE>();
                test.Add(new ALLCODE { IDX = 1, CODE_NAME = "Hieu" });
                return test;
                await _context.Database.OpenConnectionAsync(default);
                //var allCodes = await _queryRepository.GetCountAsync<ALLCODE>(default);
                var allCodes = _context.AllCode;
                if (allCodes != null && allCodes.Any())
                    return allCodes.ToList();
                var a = 1;
            }
            catch (Exception e)
            {

            }
            finally
            {
                await _context.Database.CloseConnectionAsync();
            }
            return null;
        }
        [HttpGet]
        [Route("GetSystemDate")]
        public async Task<string> GetSystemDate()
        {
            return DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}