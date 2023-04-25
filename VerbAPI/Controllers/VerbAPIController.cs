﻿using System;
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
		[ProducesResponseType(StatusCodes.Status200OK)]
		public ActionResult<VerbDTO> GetVerb()
		{ 
			return Ok(VerbStore.getList);
		}

		[HttpGet("{id:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult<VerbDTO> GetVerb(int id)
		{
			if (id == 0)
			{
				return BadRequest();
			}

			var verb = VerbStore.getList.FirstOrDefault(u => u.Id == id);

			if (verb == null)
			{
				return NotFound();
			}


            return Ok(verb);
		}

		[HttpPost]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<VerbDTO> CreateVerb([FromBody]VerbDTO verbDTO)
		{
			if (verbDTO == null)
			{
				return BadRequest(verbDTO);
			}
			if (verbDTO.Id > 0)
			{
				return StatusCode(StatusCodes.Status500InternalServerError);
			}
			verbDTO.Id = VerbStore.getList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
			VerbStore.getList.Add(verbDTO);

			return Ok(verbDTO);
		}
	}
}

