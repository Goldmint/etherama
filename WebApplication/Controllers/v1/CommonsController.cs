﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Etherama.WebApplication.Core.Policies;
using Etherama.WebApplication.Core.Response;

namespace Etherama.WebApplication.Controllers.v1 {

	[Route("api/v1/commons")]
	public class CommonsController : BaseController {

		/// <summary>
		/// Countries blacklist
		/// </summary>
		[AnonymousAccess]
		[HttpGet, Route("bannedCountries")]
		[ProducesResponseType(typeof(string[]), 200)]
		public async Task<APIResponse> BannedCountries() {
			var list = await (
				from a in DbContext.BannedCountry
				select a.Code.ToUpper()
			).AsNoTracking().ToArrayAsync();
			return APIResponse.Success(list);
		}
	}
}