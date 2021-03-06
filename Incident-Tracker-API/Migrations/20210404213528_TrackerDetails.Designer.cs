// <auto-generated />
using System;
using Incident_Tracker_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Incident_Tracker_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210404213528_TrackerDetails")]
    partial class TrackerDetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Incident_Tracker_API.Entities.TrackerDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Severity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("tbTracker");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 4, 5, 3, 5, 27, 773, DateTimeKind.Local).AddTicks(3377),
                            Description = "Test1",
                            Severity = "High",
                            Status = "inprogress",
                            UpdateDate = new DateTime(2021, 4, 5, 3, 5, 27, 775, DateTimeKind.Local).AddTicks(2326)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
