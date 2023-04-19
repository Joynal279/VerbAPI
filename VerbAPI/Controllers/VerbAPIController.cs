using System;
using Microsoft.AspNetCore.Mvc;
using VerbAPI.Models;

namespace VerbAPI.Controllers
{

	[Route("api/VerbAPI")]
	[ApiController]
	public class VerbAPIController : ControllerBase
	{
		[HttpGet]
		public IEnumerable<VerbModel> GetVerb()
		{
			return new List<VerbModel> {
				new VerbModel{Id = 1, Name = "Pool View"},
				new VerbModel{Id = 2, Name = "Beach View"}
			};
		}
	}
}

