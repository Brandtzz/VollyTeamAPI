﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;
using DataAccessLayer.Properties;
using System.ComponentModel;
using DataAccessLayer.Helpers;

namespace DataAccessLayer.Context
{
    public class VOLLEYTEAMDbInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            var about = new DomainModelAbout
            {
                About = "I dette felt kan du fortælle lidt om klubben, og om volleyball teamet."
            };

            var board = new DomainModelBoard
            {
                Board = "Bestyrelsen består af: Judith, Kenneth, Tina og Per"
            };

            var contacts = new DomainModelContacts
            {
                Contacts = "Kontakt Judith for nærmere information på 99999999"
            };

            var news = new DomainModelNews
            {
                News = "Senior Mixhold stadig ubesejret!"
            };

            var sponsor = new DomainModelSponsor
            {
                Sponsor =
                    "Sponsorerne i år er: Skræddergården, Jyske Bank, Skjern Bank, Valse Møllen, Aarsland, Slagter Kaj Madsen"
            };

            var team = new DomainModelTeam
            {
                Team = "1 division senior damer, C-Række senior mixhold + DGI-rækken senior mixhold, Kids/teen volley"
            };

            var tournament = new DomainModelTournament
            {
                Tournament = "Turneringsplan for 1 div:  " +
                             "Turneringsplan for C-rækken senior mixhold:  " +
                             "Turneringsplan for DGI turneringen senior mixhold:  " +
                             "Turneringsplan for Kids/teen volley: "
            };

<<<<<<< HEAD
            var picture = new DomainModelPicture
            {
                Id = 1,
                PictureName = "VOLLEYTEAM Esbjerg Logo",
                Picture = HelpPictureConverter.CopyImageToByteArray(Resources.logo)
=======
            var english = new DomainModelEnglish
            {
                English = "Welcome to VOLLEYTEAMESBJERG........GOOGLE TRANSLATE FTW!!!!!!!"
>>>>>>> 824385cd0c3b87466afba8a2b8951c6f92d38b90
            };

            //Bitmap bitmapLogo = new Bitmap(Resources.logo);

            //var picture = new DomainModelPicture
            //{
            //    PictureName = "VOLLEYTEAM Esbjerg Logo",
            //    Picture = bitmapLogo
            //};

            context.About.Add(about);
            context.Board.Add(board);
            context.Contacts.Add(contacts);
            context.News.Add(news);
            context.Sponsor.Add(sponsor);
            context.Team.Add(team);
            context.Tournament.Add(tournament);
            context.English.Add(english);
            //context.Picture.Add(picture);
            base.Seed(context);
        }
    }
}
