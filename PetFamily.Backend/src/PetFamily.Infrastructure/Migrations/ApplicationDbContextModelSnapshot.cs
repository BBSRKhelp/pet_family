﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PetFamily.Infrastructure;

#nullable disable

namespace PetFamily.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.7.24405.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PetFamily.Domain.SpeciesAggregate.Entities.Breed", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("species_id")
                        .HasColumnType("uuid")
                        .HasColumnName("species_id");

                    b.ComplexProperty<Dictionary<string, object>>("Name", "PetFamily.Domain.SpeciesAggregate.Entities.Breed.Name#Name", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("name");
                        });

                    b.HasKey("Id")
                        .HasName("pk_breed");

                    b.HasIndex("species_id")
                        .HasDatabaseName("ix_breed_species_id");

                    b.ToTable("breed", (string)null);
                });

            modelBuilder.Entity("PetFamily.Domain.SpeciesAggregate.Species", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.ComplexProperty<Dictionary<string, object>>("Name", "PetFamily.Domain.SpeciesAggregate.Species.Name#Name", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("name");
                        });

                    b.HasKey("Id")
                        .HasName("pk_species");

                    b.ToTable("species", (string)null);
                });

            modelBuilder.Entity("PetFamily.Domain.VolunteerAggregate.Entities.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateOnly?>("Birthday")
                        .HasColumnType("date")
                        .HasColumnName("birthday");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0)
                        .HasColumnName("status");

                    b.Property<bool>("_isDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<Guid>("volunteer_id")
                        .HasColumnType("uuid")
                        .HasColumnName("volunteer_id");

                    b.ComplexProperty<Dictionary<string, object>>("Address", "PetFamily.Domain.VolunteerAggregate.Entities.Pet.Address#Address", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("city");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("country");

                            b1.Property<string>("Postalcode")
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("postalcode");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("street");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("AppearanceDetails", "PetFamily.Domain.VolunteerAggregate.Entities.Pet.AppearanceDetails#AppearanceDetails", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<int>("Coloration")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasDefaultValue(0)
                                .HasColumnName("coloration");

                            b1.Property<float>("Height")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("real")
                                .HasDefaultValue(0f)
                                .HasColumnName("height");

                            b1.Property<float>("Weight")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("real")
                                .HasDefaultValue(0f)
                                .HasColumnName("weight");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("BreedAndSpeciesId", "PetFamily.Domain.VolunteerAggregate.Entities.Pet.BreedAndSpeciesId#BreedAndSpeciesId", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<Guid>("BreedId")
                                .HasColumnType("uuid")
                                .HasColumnName("breed_id");

                            b1.Property<Guid>("SpeciesId")
                                .HasColumnType("uuid")
                                .HasColumnName("species_id");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("HealthDetails", "PetFamily.Domain.VolunteerAggregate.Entities.Pet.HealthDetails#HealthDetails", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("HealthInformation")
                                .IsRequired()
                                .HasMaxLength(1000)
                                .HasColumnType("character varying(1000)")
                                .HasColumnName("health_information");

                            b1.Property<bool>("IsCastrated")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("boolean")
                                .HasDefaultValue(false)
                                .HasColumnName("is_castrated");

                            b1.Property<bool>("IsVaccinated")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("boolean")
                                .HasDefaultValue(false)
                                .HasColumnName("is_vaccinated");
                        });

                    b.HasKey("Id")
                        .HasName("pk_pets");

                    b.HasIndex("volunteer_id")
                        .HasDatabaseName("ix_pets_volunteer_id");

                    b.ToTable("pets", (string)null);
                });

            modelBuilder.Entity("PetFamily.Domain.VolunteerAggregate.Volunteer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<bool>("_isDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.ComplexProperty<Dictionary<string, object>>("Email", "PetFamily.Domain.VolunteerAggregate.Volunteer.Email#Email", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("email");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("PhoneNumber", "PetFamily.Domain.VolunteerAggregate.Volunteer.PhoneNumber#PhoneNumber", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(11)
                                .HasColumnType("character varying(11)")
                                .HasColumnName("phone_number");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("WorkExperience", "PetFamily.Domain.VolunteerAggregate.Volunteer.WorkExperience#WorkExperience", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<byte>("Value")
                                .HasMaxLength(100)
                                .HasColumnType("smallint")
                                .HasColumnName("work_experience");
                        });

                    b.HasKey("Id")
                        .HasName("pk_volunteer");

                    b.ToTable("volunteer", (string)null);
                });

            modelBuilder.Entity("PetFamily.Domain.SpeciesAggregate.Entities.Breed", b =>
                {
                    b.HasOne("PetFamily.Domain.SpeciesAggregate.Species", null)
                        .WithMany("Breeds")
                        .HasForeignKey("species_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_breed_species_species_id");
                });

            modelBuilder.Entity("PetFamily.Domain.VolunteerAggregate.Entities.Pet", b =>
                {
                    b.HasOne("PetFamily.Domain.VolunteerAggregate.Volunteer", null)
                        .WithMany("Pets")
                        .HasForeignKey("volunteer_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_pets_volunteer_volunteer_id");

                    b.OwnsOne("PetFamily.Domain.Shared.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("PetId")
                                .HasColumnType("uuid")
                                .HasColumnName("id");

                            b1.Property<string>("Value")
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("name");

                            b1.HasKey("PetId");

                            b1.ToTable("pets");

                            b1.WithOwner()
                                .HasForeignKey("PetId")
                                .HasConstraintName("fk_pets_pets_id");
                        });

                    b.OwnsOne("PetFamily.Domain.Shared.ValueObjects.PhoneNumber", "PhoneNumber", b1 =>
                        {
                            b1.Property<Guid>("PetId")
                                .HasColumnType("uuid")
                                .HasColumnName("id");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(11)
                                .HasColumnType("character varying(11)")
                                .HasColumnName("phone_number");

                            b1.HasKey("PetId");

                            b1.ToTable("pets");

                            b1.WithOwner()
                                .HasForeignKey("PetId")
                                .HasConstraintName("fk_pets_pets_id");
                        });

                    b.OwnsOne("PetFamily.Domain.Shared.ValueObjects.Description", "Description", b1 =>
                        {
                            b1.Property<Guid>("PetId")
                                .HasColumnType("uuid")
                                .HasColumnName("id");

                            b1.Property<string>("Value")
                                .HasMaxLength(2000)
                                .HasColumnType("character varying(2000)")
                                .HasColumnName("description");

                            b1.HasKey("PetId");

                            b1.ToTable("pets");

                            b1.WithOwner()
                                .HasForeignKey("PetId")
                                .HasConstraintName("fk_pets_pets_id");
                        });

                    b.OwnsOne("PetFamily.Domain.VolunteerAggregate.ValueObjects.PetDetails", "Details", b1 =>
                        {
                            b1.Property<Guid>("PetId")
                                .HasColumnType("uuid");

                            b1.HasKey("PetId");

                            b1.ToTable("pets");

                            b1.ToJson("details");

                            b1.WithOwner()
                                .HasForeignKey("PetId")
                                .HasConstraintName("fk_pets_pets_id");

                            b1.OwnsMany("PetFamily.Domain.VolunteerAggregate.ValueObjects.Requisite", "Requisites", b2 =>
                                {
                                    b2.Property<Guid>("PetDetailsPetId")
                                        .HasColumnType("uuid");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("integer");

                                    b2.Property<string>("Description")
                                        .IsRequired()
                                        .HasMaxLength(1000)
                                        .HasColumnType("character varying(1000)");

                                    b2.Property<string>("Title")
                                        .IsRequired()
                                        .HasMaxLength(50)
                                        .HasColumnType("character varying(50)");

                                    b2.HasKey("PetDetailsPetId", "Id");

                                    b2.ToTable("pets");

                                    b2.ToJson("details");

                                    b2.WithOwner()
                                        .HasForeignKey("PetDetailsPetId")
                                        .HasConstraintName("fk_pets_pets_pet_details_pet_id");
                                });

                            b1.OwnsMany("PetFamily.Domain.VolunteerAggregate.ValueObjects.PetPhoto", "PetPhotos", b2 =>
                                {
                                    b2.Property<Guid>("PetDetailsPetId")
                                        .HasColumnType("uuid");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("integer");

                                    b2.Property<bool>("IsMainPhoto")
                                        .HasColumnType("boolean");

                                    b2.Property<string>("Path")
                                        .IsRequired()
                                        .HasMaxLength(5000)
                                        .HasColumnType("character varying(5000)");

                                    b2.HasKey("PetDetailsPetId", "Id");

                                    b2.ToTable("pets");

                                    b2.ToJson("details");

                                    b2.WithOwner()
                                        .HasForeignKey("PetDetailsPetId")
                                        .HasConstraintName("fk_pets_pets_pet_details_pet_id");
                                });

                            b1.Navigation("PetPhotos");

                            b1.Navigation("Requisites");
                        });

                    b.Navigation("Description");

                    b.Navigation("Details")
                        .IsRequired();

                    b.Navigation("Name");

                    b.Navigation("PhoneNumber")
                        .IsRequired();
                });

            modelBuilder.Entity("PetFamily.Domain.VolunteerAggregate.Volunteer", b =>
                {
                    b.OwnsOne("PetFamily.Domain.VolunteerAggregate.ValueObjects.FullName", "FullName", b1 =>
                        {
                            b1.Property<Guid>("VolunteerId")
                                .HasColumnType("uuid")
                                .HasColumnName("id");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("first_name");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("last_name");

                            b1.Property<string>("Patronymic")
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("patronymic");

                            b1.HasKey("VolunteerId");

                            b1.ToTable("volunteer");

                            b1.WithOwner()
                                .HasForeignKey("VolunteerId")
                                .HasConstraintName("fk_volunteer_volunteer_id");
                        });

                    b.OwnsOne("PetFamily.Domain.VolunteerAggregate.ValueObjects.Shell.RequisitesShell", "Requisite", b1 =>
                        {
                            b1.Property<Guid>("VolunteerId")
                                .HasColumnType("uuid");

                            b1.HasKey("VolunteerId");

                            b1.ToTable("volunteer");

                            b1.ToJson("requisite");

                            b1.WithOwner()
                                .HasForeignKey("VolunteerId")
                                .HasConstraintName("fk_volunteer_volunteer_id");

                            b1.OwnsMany("PetFamily.Domain.VolunteerAggregate.ValueObjects.Requisite", "Requisites", b2 =>
                                {
                                    b2.Property<Guid>("RequisitesShellVolunteerId")
                                        .HasColumnType("uuid");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("integer");

                                    b2.Property<string>("Description")
                                        .IsRequired()
                                        .HasMaxLength(1000)
                                        .HasColumnType("character varying(1000)");

                                    b2.Property<string>("Title")
                                        .IsRequired()
                                        .HasMaxLength(50)
                                        .HasColumnType("character varying(50)");

                                    b2.HasKey("RequisitesShellVolunteerId", "Id");

                                    b2.ToTable("volunteer");

                                    b2.ToJson("requisite");

                                    b2.WithOwner()
                                        .HasForeignKey("RequisitesShellVolunteerId")
                                        .HasConstraintName("fk_volunteer_volunteer_requisites_shell_volunteer_id");
                                });

                            b1.Navigation("Requisites");
                        });

                    b.OwnsOne("PetFamily.Domain.VolunteerAggregate.ValueObjects.Shell.SocialNetworkShell", "SocialNetwork", b1 =>
                        {
                            b1.Property<Guid>("VolunteerId")
                                .HasColumnType("uuid");

                            b1.HasKey("VolunteerId");

                            b1.ToTable("volunteer");

                            b1.ToJson("social_network");

                            b1.WithOwner()
                                .HasForeignKey("VolunteerId")
                                .HasConstraintName("fk_volunteer_volunteer_id");

                            b1.OwnsMany("PetFamily.Domain.VolunteerAggregate.ValueObjects.SocialNetwork", "SocialNetworks", b2 =>
                                {
                                    b2.Property<Guid>("SocialNetworkShellVolunteerId")
                                        .HasColumnType("uuid");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("integer");

                                    b2.Property<string>("Title")
                                        .IsRequired()
                                        .HasMaxLength(50)
                                        .HasColumnType("character varying(50)");

                                    b2.Property<string>("Url")
                                        .IsRequired()
                                        .HasMaxLength(100)
                                        .HasColumnType("character varying(100)");

                                    b2.HasKey("SocialNetworkShellVolunteerId", "Id");

                                    b2.ToTable("volunteer");

                                    b2.ToJson("social_network");

                                    b2.WithOwner()
                                        .HasForeignKey("SocialNetworkShellVolunteerId")
                                        .HasConstraintName("fk_volunteer_volunteer_social_network_shell_volunteer_id");
                                });

                            b1.Navigation("SocialNetworks");
                        });

                    b.OwnsOne("PetFamily.Domain.Shared.ValueObjects.Description", "Description", b1 =>
                        {
                            b1.Property<Guid>("VolunteerId")
                                .HasColumnType("uuid")
                                .HasColumnName("id");

                            b1.Property<string>("Value")
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("description");

                            b1.HasKey("VolunteerId");

                            b1.ToTable("volunteer");

                            b1.WithOwner()
                                .HasForeignKey("VolunteerId")
                                .HasConstraintName("fk_volunteer_volunteer_id");
                        });

                    b.Navigation("Description");

                    b.Navigation("FullName")
                        .IsRequired();

                    b.Navigation("Requisite");

                    b.Navigation("SocialNetwork");
                });

            modelBuilder.Entity("PetFamily.Domain.SpeciesAggregate.Species", b =>
                {
                    b.Navigation("Breeds");
                });

            modelBuilder.Entity("PetFamily.Domain.VolunteerAggregate.Volunteer", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
