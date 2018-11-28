﻿using System;

namespace Etherama.WebApplication.Models.API.v1.ViewModels
{
    public class TokenFullInfoResponseViewModel
    {
        public long Id { get; set; }

        public string TokenContractAddress { get; set; }

        public string EtheramaContractAddress { get; set; }

        public string FullName { get; set; }

        public string Ticker { get; set; }

        public string LogoUrl { get; set; }

        public string Description { get; set; }

        public decimal StartPriceEth { get; set; }

        public DateTime TimeCreated { get; set; }
    }
}
