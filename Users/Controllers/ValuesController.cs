using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TemplateProject.DAL;
using TemplateProject.DAL.UnitOfWork;
using TemplateProject.Model;

namespace Users.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase {
		private UnitOfWork _unitOfWork;
		public ValuesController(BaseDbContext context) {
			_unitOfWork = new UnitOfWork(context);
		}

		// GET api/values
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get() {
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<User> Get(int id) {
			return _unitOfWork.UserRepository.GetById(id);
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody] string value) {
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value) {
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id) {
		}
	}
}
