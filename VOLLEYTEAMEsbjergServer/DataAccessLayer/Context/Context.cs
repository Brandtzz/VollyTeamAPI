﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataAccessLayer.Context
{
    public class Context : DbContext

    {


        public Context() : base("VOLLEYTEAMEsbjerg")
        {
            Database.SetInitializer(new VOLLEYTEAMDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            var newsConfig = modelbuilder.Entity<DomainModelNews>();
            newsConfig.Property(domainModelNews => domainModelNews.News).HasColumnType("NVARCHAR").HasMaxLength(2100);
            newsConfig.ToTable("News");

            base.OnModelCreating(modelbuilder);
            var aboutConfig = modelbuilder.Entity<DomainModelAbout>();
            aboutConfig.Property(domainModelAbout => domainModelAbout.About).HasColumnType("NVARCHAR").HasMaxLength(2100);
            aboutConfig.ToTable("About");

            base.OnModelCreating(modelbuilder);
            var boardConfig = modelbuilder.Entity<DomainModelBoard>();
            boardConfig.Property(domainModelBoard => domainModelBoard.Board).HasColumnType("NVARCHAR").HasMaxLength(2100);
            boardConfig.ToTable("Board");

            base.OnModelCreating(modelbuilder);
            var contactsConfig = modelbuilder.Entity<DomainModelContacts>();
            contactsConfig.Property(domainModelContacts => domainModelContacts.Contacts).HasColumnType("NVARCHAR").HasMaxLength(2100);
            contactsConfig.ToTable("Contacts");

            base.OnModelCreating(modelbuilder);
            var sponsorConfig = modelbuilder.Entity<DomainModelSponsor>();
            sponsorConfig.Property(domainModelSponsor => domainModelSponsor.Sponsor).HasColumnType("NVARCHAR").HasMaxLength(2100);
            sponsorConfig.ToTable("Sponsor");

            base.OnModelCreating(modelbuilder);
            var tournamentConfig = modelbuilder.Entity<DomainModelTournament>();
            tournamentConfig.Property(domainModelTournament => domainModelTournament.Tournament)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(2100);
            tournamentConfig.ToTable("Tournament");

            base.OnModelCreating(modelbuilder);
            var teamConfig = modelbuilder.Entity<DomainModelTeam>();
            teamConfig.Property(domainModelTeam => domainModelTeam.Team).HasColumnType("NVARCHAR").HasMaxLength(2100);
            teamConfig.ToTable("Team");

            base.OnModelCreating(modelbuilder);
            var englishConfig = modelbuilder.Entity<DomainModelEnglish>();
            englishConfig.Property(DomainModelEnglish => DomainModelEnglish.English).HasColumnType("NVARCHAR").HasMaxLength(2100);
            englishConfig.ToTable("English");

            base.OnModelCreating(modelbuilder);
            var pictureConfig = modelbuilder.Entity<DomainModelPicture>();
            pictureConfig.Property(domainModelPicture => domainModelPicture.PictureName).HasColumnType("NVARCHAR").HasMaxLength(200).HasColumnType("image").IsRequired();
            teamConfig.ToTable("Picture");

        }

        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelTeam> Team { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelTournament> Tournament { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelAbout> About { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelBoard> Board { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelContacts> Contacts { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelNews> News { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelSponsor> Sponsor { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelEnglish> English { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelPicture> Picture { get; set; }
    }
}
