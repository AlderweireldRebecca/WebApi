using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.EF
{
    public class AfspraakInitializer : DropCreateDatabaseIfModelChanges<AfspraakContext>
    {
        protected override void Seed(AfspraakContext context)
        {
            var afspraak = new Afspraak
            {
                AfspraakDatum = new DateTime(2018, 1, 22, 10, 0, 0),
                EmailAdres = "test@gmail.com",
                ExtraInfo = "Initial seed data",
                Geboortedatum = new DateTime(1990, 3, 22),
                GekendePatient = "Nieuw",
                Naam = "Test",
                Telefoonnummer = "4556651232",
                Voornaam = "Seed"
            };

            context.Afspraken.Add(afspraak);
            context.SaveChanges();
        }
    }
}