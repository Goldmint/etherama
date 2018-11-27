﻿using System.Numerics;
using System.Threading.Tasks;
using Etherama.CoreLogic.Services.Blockchain.Ethereum.Models;

namespace Etherama.CoreLogic.Services.Blockchain.Ethereum {

	public interface IEthereumReader {

		/// <summary>
		/// Get latest block number on the logs provider side
		/// </summary>
		Task<long> GetLogsLatestBlockNumber();

		/// <summary>
		/// Check chain transaction by it's ID
		/// </summary>
		Task<TransactionInfo> CheckTransaction(string txid, int confirmationsRequired);

		/// <summary>
		/// Get current gas price in wei
		/// </summary>
		Task<BigInteger> GetCurrentGasPrice();



	    Task<decimal> GetTokenPrice(string contactAddress);
	    Task<long> GetBuyCount(string contactAddress);
	    Task<long> GetSellCount(string contactAddress);
	    Task<decimal> GetBonusPerShare(string contactAddress);


    }
}
