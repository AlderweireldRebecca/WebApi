using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Afspraak
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        public string Voornaam { get; set; }
        [Required]
        public DateTime Geboortedatum { get; set; }
        [Required]
        public string Telefoonnummer { get; set; }
        public string EmailAdres { get; set; }
        [Required]
        public string GekendePatient { get; set; }
        public string ExtraInfo { get; set; }
        [Required]
        public DateTime AfspraakDatum { get; set; }

    }
}