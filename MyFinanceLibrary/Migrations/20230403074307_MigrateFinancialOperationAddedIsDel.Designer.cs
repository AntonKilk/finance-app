﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFinanceLibrary.Data;

#nullable disable

namespace MyFinanceLibrary.Migrations
{
    [DbContext(typeof(MyFinanceContext))]
    [Migration("20230403074307_MigrateFinancialOperationAddedIsDel")]
    partial class MigrateFinancialOperationAddedIsDel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyFinanceLibrary.Models.FinancialOperation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDel")
                        .HasColumnType("bit");

                    b.Property<int>("OperationTypeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("FinancialOperations");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Amount = 10000m,
                            Comment = "Salary March",
                            Date = new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 1
                        },
                        new
                        {
                            ID = 2,
                            Amount = 1000m,
                            Comment = "Birthday gift",
                            Date = new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 2
                        },
                        new
                        {
                            ID = 3,
                            Amount = 100m,
                            Comment = "Tesla shares",
                            Date = new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 3
                        },
                        new
                        {
                            ID = 4,
                            Amount = 10m,
                            Comment = "bonus1",
                            Date = new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 4
                        },
                        new
                        {
                            ID = 5,
                            Amount = 1m,
                            Comment = "Rental income",
                            Date = new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 5
                        },
                        new
                        {
                            ID = 6,
                            Amount = 10000m,
                            Comment = "Another gift",
                            Date = new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 1
                        },
                        new
                        {
                            ID = 7,
                            Amount = 1000m,
                            Comment = "Microsoft shares",
                            Date = new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 2
                        },
                        new
                        {
                            ID = 8,
                            Amount = 100m,
                            Comment = "more money",
                            Date = new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 3
                        },
                        new
                        {
                            ID = 9,
                            Amount = 10m,
                            Comment = "bonus2",
                            Date = new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 4
                        },
                        new
                        {
                            ID = 10,
                            Amount = 1m,
                            Comment = "additional income",
                            Date = new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 5
                        },
                        new
                        {
                            ID = 11,
                            Amount = -1000m,
                            Comment = "grocery1",
                            Date = new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 6
                        },
                        new
                        {
                            ID = 12,
                            Amount = -100m,
                            Comment = "gasoline1",
                            Date = new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 7
                        },
                        new
                        {
                            ID = 13,
                            Amount = -10m,
                            Comment = "rental1",
                            Date = new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 8
                        },
                        new
                        {
                            ID = 14,
                            Amount = -1m,
                            Comment = "kids clothing",
                            Date = new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 9
                        },
                        new
                        {
                            ID = 15,
                            Amount = -1000m,
                            Comment = "shopping1",
                            Date = new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 10
                        },
                        new
                        {
                            ID = 16,
                            Amount = -100m,
                            Comment = "grocery1",
                            Date = new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 6
                        },
                        new
                        {
                            ID = 17,
                            Amount = -10m,
                            Comment = "bus",
                            Date = new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 7
                        },
                        new
                        {
                            ID = 18,
                            Amount = -1m,
                            Comment = "rental1",
                            Date = new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 8
                        },
                        new
                        {
                            ID = 19,
                            Amount = -1000m,
                            Comment = "H&M",
                            Date = new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 9
                        },
                        new
                        {
                            ID = 20,
                            Amount = -100m,
                            Comment = "shopping2",
                            Date = new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDel = false,
                            OperationTypeID = 10
                        });
                });

            modelBuilder.Entity("MyFinanceLibrary.Models.OperationType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isIncome")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("OperationTypes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Salary",
                            isIncome = true
                        },
                        new
                        {
                            ID = 2,
                            Name = "Gift",
                            isIncome = true
                        },
                        new
                        {
                            ID = 3,
                            Name = "Interest",
                            isIncome = true
                        },
                        new
                        {
                            ID = 4,
                            Name = "Bonus",
                            isIncome = true
                        },
                        new
                        {
                            ID = 5,
                            Name = "Other",
                            isIncome = true
                        },
                        new
                        {
                            ID = 6,
                            Name = "Food",
                            isIncome = false
                        },
                        new
                        {
                            ID = 7,
                            Name = "Transport",
                            isIncome = false
                        },
                        new
                        {
                            ID = 8,
                            Name = "Housing",
                            isIncome = false
                        },
                        new
                        {
                            ID = 9,
                            Name = "Clothing",
                            isIncome = false
                        },
                        new
                        {
                            ID = 10,
                            Name = "Other",
                            isIncome = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
