using System;
using EcommerceAPI.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    public class BasketController : ControllerBase
    {
        readonly private IBasketReadRepository _basketReadRepository;

        public BasketController(IBasketReadRepository basketReadRepository)
        {
            _basketReadRepository = basketReadRepository;
        }
    }
}

