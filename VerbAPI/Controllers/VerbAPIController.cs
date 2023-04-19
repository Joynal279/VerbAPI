using System;
using Microsoft.AspNetCore.Mvc;
using VerbAPI.Models;
using VerbAPI.Models.Dto;
using VerbAPI.Data;

namespace VerbAPI.Controllers
{

	[Route("api/[action]")]
	[ApiController]
	public class VerbAPIController : ControllerBase
	{
		[HttpGet]
		public IEnumerable<VerbDTO> GetVerb()
		{
			return VerbStore.getList;
		}

		[HttpGet("{id:int}")]
		public VerbDTO GetVerb(int id)
		{
			return VerbStore.getList.FirstOrDefault(u => u.Id == id);
		}
	}
}

