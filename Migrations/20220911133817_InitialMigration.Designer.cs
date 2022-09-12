﻿// <auto-generated />
using BloodDonationManagement.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BloodDonationManagement.Migrations
{
    [DbContext(typeof(DonarContext))]
    [Migration("20220911133817_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BloodDonationManagement.Models.SchoolModel", b =>
                {
                    b.Property<int>("DonarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DonarAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DonarCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DonarName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DonarId");

                    b.ToTable("schoolModels");
                });
#pragma warning restore 612, 618
        }
    }
}