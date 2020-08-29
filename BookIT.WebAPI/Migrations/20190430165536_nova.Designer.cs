﻿// <auto-generated />
using System;
using BookIT.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookIT.WebAPI.Migrations
{
    [DbContext(typeof(BookITContext))]
    [Migration("20190430165536_nova")]
    partial class nova
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookIT.WebAPI.Database.DodatnaUsluga", b =>
                {
                    b.Property<int>("DodatnaUslugaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("DodatnaUslugaId");

                    b.ToTable("DodatneUsluge");
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.DodatnaUslugaRezervacija", b =>
                {
                    b.Property<int>("DodatnaUslugaRezervacijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena");

                    b.Property<int>("DodatnaUslugaId");

                    b.Property<int>("RezervacijaId");

                    b.HasKey("DodatnaUslugaRezervacijaId");

                    b.HasIndex("DodatnaUslugaId");

                    b.HasIndex("RezervacijaId");

                    b.ToTable("DodatneUslugeRezervacije");
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.DodatnaUslugaSmjestaj", b =>
                {
                    b.Property<int>("DodatnaUslugaSmjestajId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DodatnaUslugId");

                    b.Property<int?>("DodatnaUslugaId");

                    b.Property<int>("SmjestajId");

                    b.HasKey("DodatnaUslugaSmjestajId");

                    b.HasIndex("DodatnaUslugaId");

                    b.HasIndex("SmjestajId");

                    b.ToTable("DodatneUslugeSmjestaji");
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Drzava", b =>
                {
                    b.Property<int>("DrzavaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("DrzavaId");

                    b.ToTable("Drzave");
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Faktura", b =>
                {
                    b.Property<int>("FakturaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumFakture");

                    b.Property<double>("Iznos");

                    b.Property<int>("RezervacijaId");

                    b.HasKey("FakturaId");

                    b.HasIndex("RezervacijaId");

                    b.ToTable("Fakture");
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Grad", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaId");

                    b.Property<string>("Naziv");

                    b.HasKey("GradId");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Klijent", b =>
                {
                    b.Property<int>("Id");

                    b.HasKey("Id");

                    b.ToTable("Klijenti");
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<string>("BrojMobitela");

                    b.Property<string>("Email");

                    b.Property<int>("GradId");

                    b.Property<string>("Ime");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PasswordSalt");

                    b.Property<string>("Prezime");

                    b.HasKey("KorisnikId");

                    b.HasIndex("GradId");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.KorisnikUloga", b =>
                {
                    b.Property<int>("KorisnikUlogaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnikId");

                    b.Property<int>("UlogaId");

                    b.HasKey("KorisnikUlogaId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("UlogaId");

                    b.ToTable("KorisniciUloge");
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Rezervacija", b =>
                {
                    b.Property<int>("RezervacijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojGostiju");

                    b.Property<DateTime>("CheckInDate");

                    b.Property<DateTime>("CheckOutDate");

                    b.Property<DateTime>("DatumRezervacije");

                    b.Property<int>("KlijentId");

                    b.Property<int>("SmjestajId");

                    b.Property<int>("Status");

                    b.HasKey("RezervacijaId");

                    b.HasIndex("KlijentId");

                    b.HasIndex("SmjestajId");

                    b.ToTable("Rezervacije");
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Smjestaj", b =>
                {
                    b.Property<int>("SmjestajId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<int>("GradId");

                    b.Property<string>("Naziv");

                    b.Property<int>("TipSmjestaja");

                    b.Property<int>("VlasnikSmjestajaId");

                    b.HasKey("SmjestajId");

                    b.HasIndex("GradId");

                    b.HasIndex("VlasnikSmjestajaId");

                    b.ToTable("Smjestaji");
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Soba", b =>
                {
                    b.Property<int>("SobaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojMalihKreveta");

                    b.Property<int>("BrojVelikihKreveta");

                    b.Property<double>("Cijena");

                    b.Property<string>("Naziv");

                    b.Property<int>("SmjestajId");

                    b.Property<int>("VelicinaSobe");

                    b.HasKey("SobaId");

                    b.HasIndex("SmjestajId");

                    b.ToTable("Sobe");
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.SobaRezervacija", b =>
                {
                    b.Property<int>("SobaRezervacijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RezervacijaId");

                    b.Property<int>("SobaId");

                    b.HasKey("SobaRezervacijaId");

                    b.HasIndex("RezervacijaId");

                    b.HasIndex("SobaId");

                    b.ToTable("SobeRezervacije");
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Uloga", b =>
                {
                    b.Property<int>("UlogaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.HasKey("UlogaId");

                    b.ToTable("Uloge");
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.VlasnikSmjestaja", b =>
                {
                    b.Property<int>("Id");

                    b.HasKey("Id");

                    b.ToTable("VlasniciSmjestaja");
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.DodatnaUslugaRezervacija", b =>
                {
                    b.HasOne("BookIT.WebAPI.Database.DodatnaUsluga", "DodatnaUsluga")
                        .WithMany()
                        .HasForeignKey("DodatnaUslugaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookIT.WebAPI.Database.Rezervacija", "Rezervacija")
                        .WithMany("DodatnaUslugaRezervacija")
                        .HasForeignKey("RezervacijaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.DodatnaUslugaSmjestaj", b =>
                {
                    b.HasOne("BookIT.WebAPI.Database.DodatnaUsluga", "DodatnaUsluga")
                        .WithMany()
                        .HasForeignKey("DodatnaUslugaId");

                    b.HasOne("BookIT.WebAPI.Database.Smjestaj", "Smjestaj")
                        .WithMany()
                        .HasForeignKey("SmjestajId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Faktura", b =>
                {
                    b.HasOne("BookIT.WebAPI.Database.Rezervacija", "Rezervacija")
                        .WithMany()
                        .HasForeignKey("RezervacijaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Grad", b =>
                {
                    b.HasOne("BookIT.WebAPI.Database.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Klijent", b =>
                {
                    b.HasOne("BookIT.WebAPI.Database.Korisnik", "Korisnik")
                        .WithOne("Klijent")
                        .HasForeignKey("BookIT.WebAPI.Database.Klijent", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Korisnik", b =>
                {
                    b.HasOne("BookIT.WebAPI.Database.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.KorisnikUloga", b =>
                {
                    b.HasOne("BookIT.WebAPI.Database.Korisnik", "Korisnik")
                        .WithMany("KorisnikUloga")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookIT.WebAPI.Database.Uloga", "Uloga")
                        .WithMany()
                        .HasForeignKey("UlogaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Rezervacija", b =>
                {
                    b.HasOne("BookIT.WebAPI.Database.Klijent", "Klijent")
                        .WithMany("Rezervacija")
                        .HasForeignKey("KlijentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookIT.WebAPI.Database.Smjestaj", "Smjestaj")
                        .WithMany()
                        .HasForeignKey("SmjestajId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Smjestaj", b =>
                {
                    b.HasOne("BookIT.WebAPI.Database.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookIT.WebAPI.Database.VlasnikSmjestaja", "VlasnikSmjestaja")
                        .WithMany("Smjestaj")
                        .HasForeignKey("VlasnikSmjestajaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.Soba", b =>
                {
                    b.HasOne("BookIT.WebAPI.Database.Smjestaj", "Smjestaj")
                        .WithMany()
                        .HasForeignKey("SmjestajId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.SobaRezervacija", b =>
                {
                    b.HasOne("BookIT.WebAPI.Database.Rezervacija", "Rezervacija")
                        .WithMany("SobaRezervacija")
                        .HasForeignKey("RezervacijaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookIT.WebAPI.Database.Soba", "Soba")
                        .WithMany()
                        .HasForeignKey("SobaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookIT.WebAPI.Database.VlasnikSmjestaja", b =>
                {
                    b.HasOne("BookIT.WebAPI.Database.Korisnik", "Korisnik")
                        .WithOne("VlasnikSmjestaja")
                        .HasForeignKey("BookIT.WebAPI.Database.VlasnikSmjestaja", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
