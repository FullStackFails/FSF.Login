﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace FSF.Login.Data.Migrations
{
  public partial class CustomUserData : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropColumn(
          name: "DOB",
          table: "AspNetUsers");

      migrationBuilder.DropColumn(
          name: "Name",
          table: "AspNetUsers");

      migrationBuilder.AddColumn<string>(
          name: "FirstName",
          table: "AspNetUsers",
          nullable: true);

      migrationBuilder.AddColumn<string>(
          name: "LastName",
          table: "AspNetUsers",
          nullable: true);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropColumn(
          name: "FirstName",
          table: "AspNetUsers");

      migrationBuilder.DropColumn(
          name: "LastName",
          table: "AspNetUsers");

      migrationBuilder.AddColumn<DateTime>(
          name: "DOB",
          table: "AspNetUsers",
          type: "datetime2",
          nullable: false,
          defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

      migrationBuilder.AddColumn<string>(
          name: "Name",
          table: "AspNetUsers",
          type: "nvarchar(max)",
          nullable: true);
    }
  }
}
