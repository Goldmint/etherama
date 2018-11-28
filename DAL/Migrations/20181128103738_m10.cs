﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Etherama.DAL.Migrations
{
    public partial class m10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "erc20_contract_address",
                table: "er_token");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "erc20_contract_address",
                table: "er_token",
                maxLength: 43,
                nullable: false,
                defaultValue: "");
        }
    }
}
