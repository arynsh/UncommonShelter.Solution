﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UncommonShelter.Models;

namespace UncommonShelter.Migrations
{
    [DbContext(typeof(UncommonShelterContext))]
    [Migration("20200131183452_Inital")]
    partial class Inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UncommonShelter.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("Species");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 5,
                            Gender = "Male",
                            Name = "Stephen",
                            Species = "Sheep"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 6,
                            Gender = "Male",
                            Name = "Roo",
                            Species = "Donkey"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 8,
                            Gender = "Female",
                            Name = "Molly",
                            Species = "Donkey"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 9,
                            Gender = "Male",
                            Name = "Walter",
                            Species = "Camel"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 4,
                            Gender = "Female",
                            Name = "Beatrice",
                            Species = "Sheep"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}