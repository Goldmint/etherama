﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Etherama.Common;
using Etherama.DAL.Models.Base;

namespace Etherama.DAL.Models {

	[Table("er_user_activity")]
	public class UserActivity : DbBaseUserEntity {

		[Column("type"), MaxLength(32), Required]
		public string Type { get; set; }

		[Column("comment"), MaxLength(512), Required]
		public string Comment { get; set; }

		[Column("ip"), MaxLength(15), Required]
		public string Ip { get; set; }

		[Column("agent"), MaxLength(128), Required]
		public string Agent { get; set; }

		[Column("time_created"), Required]
		public DateTime TimeCreated { get; set; }

		[Column("locale")]
		public Locale? Locale { get; set; }
	}
}
