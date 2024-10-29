using AutoMapper;
using Business.Core.DTO;
using Business.Entyties;
using Business.ViewModel;
using Data.DataContext;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_API.Controllers
{
    [ApiController]
    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserRepository _userRepository;

        public UserController(IMapper mapper, UserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        [HttpPost]
        [Route("api/v1/user/create")]
        public async Task<IActionResult> Create([FromBody] UserViewModel viewModel)
        {
            try
            {
                var userDTO = _mapper.Map<UserDTO>(viewModel);
                await _userRepository.AddAsync(userDTO);

                return Ok(new ResultViewModel
                {
                    Message = "user created",
                    Success = true,
                    Data = userDTO
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
