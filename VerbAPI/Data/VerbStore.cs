using System;
using VerbAPI.Models.Dto;

namespace VerbAPI.Data
{
	public static class VerbStore
	{
		public static List<VerbDTO> getList = new List<VerbDTO> {
                new VerbDTO{Id = 1, Name = "Pool View", Sqft = 100, occupancy = 4},
                new VerbDTO{Id = 2, Name = "Beach View", Sqft = 300, occupancy = 3}
            };
    }
}

