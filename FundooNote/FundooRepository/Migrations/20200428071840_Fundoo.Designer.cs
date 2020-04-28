﻿// <auto-generated />
using System;
using FundooRepository.FundooContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FundooRepository.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200428071840_Fundoo")]
    partial class Fundoo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FundooModel.Account.RegisterModel", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Firstname");

                    b.Property<string>("Lastname");

                    b.Property<string>("Password");

                    b.HasKey("Email");

                    b.ToTable("Accountregister");
                });

            modelBuilder.Entity("FundooModel.Collaborators.CollaboratorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NoteId");

                    b.Property<string>("ReceiverEmail");

                    b.Property<string>("SenderEmail");

                    b.HasKey("Id");

                    b.ToTable("Collaborators");
                });

            modelBuilder.Entity("FundooModel.Label.Labelmodel", b =>
                {
                    b.Property<int>("LabelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("LabelName");

                    b.Property<int>("NoteId");

                    b.HasKey("LabelId");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("FundooModel.Notes.NotesModel", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddImg");

                    b.Property<bool>("Archeive");

                    b.Property<string>("ChangeColor");

                    b.Property<DateTime?>("Createdate1");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<DateTime?>("Modifieddate");

                    b.Property<bool>("Pin");

                    b.Property<string>("Reminder");

                    b.Property<string>("Title");

                    b.Property<bool>("Trash");

                    b.HasKey("NoteId");

                    b.ToTable("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}
