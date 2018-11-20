﻿using Etherama.Common;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Etherama.WebApplication.Core.Tokens;

namespace Etherama.WebApplication.Core.Policies {

	public class RequireJWTArea : IAuthorizationRequirement {

		private JwtArea _area;

		public RequireJWTArea(JwtArea area) {
			_area = area;
		}

		public class Handler : AuthorizationHandler<RequireJWTArea> {

			protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, RequireJWTArea requirement) {

				if (context.User.HasClaim(JWT.ErAreaField, requirement._area.ToString().ToLower())) {
					context.Succeed(requirement);
					return Task.CompletedTask;
				}

				context.Fail();
				return Task.CompletedTask;
			}
		}
	}
}
