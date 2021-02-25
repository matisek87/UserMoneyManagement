using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMoneyManagement.Interfaces;

namespace UserMoneyManagement.Controllers
{
    public class CustomerController : Controller

    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
