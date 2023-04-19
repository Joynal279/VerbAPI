using System;
using Microsoft.AspNetCore.Mvc;
using VerbAPI.Models;
using VerbAPI.Models.Dto;

namespace VerbAPI.Controllers
{

	[Route("api/[action]")]
	[ApiController]
	public class VerbAPIController : ControllerBase
	{
		[HttpGet]
		public IEnumerable<VerbDTO> GetVerb()
		{
			return new List<VerbDTO> {
				new VerbDTO{Id = 1, Name = "Pool View"},
				new VerbDTO{Id = 2, Name = "Beach View"}
			};
		}
	}
}

