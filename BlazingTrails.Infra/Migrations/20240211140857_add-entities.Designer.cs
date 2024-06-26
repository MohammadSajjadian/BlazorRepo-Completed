﻿// <auto-generated />
using BlazingTrails.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazingTrails.Infra.Migrations
{
    [DbContext(typeof(BlazingTrailsContext))]
    [Migration("20240211140857_add-entities")]
    partial class addentities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazingTrails.Domain.Entities.Trail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TimeInMinutes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("trails");
                });

            modelBuilder.Entity("BlazingTrails.Domain.Entities.Waypoint", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("trailId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("trailId");

                    b.ToTable("waypoints");
                });

            modelBuilder.Entity("BlazingTrails.Domain.Entities.Waypoint", b =>
                {
                    b.HasOne("BlazingTrails.Domain.Entities.Trail", "trail")
                        .WithMany("waypoints")
                        .HasForeignKey("trailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("trail");
                });

            modelBuilder.Entity("BlazingTrails.Domain.Entities.Trail", b =>
                {
                    b.Navigation("waypoints");
                });
#pragma warning restore 612, 618
        }
    }
}
