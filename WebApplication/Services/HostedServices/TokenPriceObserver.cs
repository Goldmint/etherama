﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Etherama.WebApplication.Services.HostedServices {

	public class TokenPriceObserver : BaseHostedService {

		protected override TimeSpan Period => TimeSpan.FromMinutes(5);

		public TokenPriceObserver(IServiceProvider services) : base(services) { }

		protected override async Task OnInit() {
			await base.OnInit();
		}

		protected override async Task DoWork() {

			DbContext.DetachEverything();
			var tokenList = await DbContext.Tokens.Where(x => x.IsEnabled && !x.IsDeleted).ToListAsync();

			foreach (var token in tokenList) {
				token.CurrentPriceEth = await EthereumObserver.GetTokenPrice(token.EtheramaContractAddress);
				token.TimeUpdated = DateTime.Now;
			}

			await DbContext.SaveChangesAsync();
		}
	}
}
