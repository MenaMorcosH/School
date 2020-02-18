using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.Queries.contracts;
using School.Queries.ViewModels;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
     
        private readonly IBranchQueries _BranchQueries;
        private readonly IMapper _mapper;


        public BranchController(IBranchQueries BranchQueries, IMapper mapper)
        {

            _BranchQueries = BranchQueries ?? throw new ArgumentNullException(nameof(BranchQueries));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<BranchViewModel>>> GetBranches()
        {
           

            IEnumerable <Branch> data = await _BranchQueries.GetAllAsync();
            IEnumerable<BranchViewModel> Branches = _mapper.Map<IEnumerable<Branch>, IEnumerable<BranchViewModel>>(data);
            return Ok(Branches);
        }
        [HttpGet("{id}")]
        public async Task <BranchViewModel>GetBranchById( int id )
        {
            Branch data =  await _BranchQueries.GetByIdAsync(id, "Code");
           BranchViewModel Branch = _mapper.Map<Branch,BranchViewModel>(data);
            return Branch;
        }

    }
}