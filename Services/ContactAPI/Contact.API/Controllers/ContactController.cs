using Contact.API.Infrastructure;
using Contact.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _service;

        public ContactController(IContactService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public ContactDto Get(int id)
        {
            var contact = _service.GetContactById(id);
            return contact;
        }
    }
}
