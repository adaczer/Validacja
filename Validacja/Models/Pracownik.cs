using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Validacja.Models
{
    public class Pracownik
    {
        [ScaffoldColumn(false)] // oznacza ignorowanie przez htm helpery
        public int PracownikId { get; set; }

        [Display(Name ="Imie Pracownika")]
        [Required(ErrorMessage ="Musisz wprowadzic imie")]
        [StringLength(30)]
        public string Imie { get; set; }

        [Display(Name = "Wiek Pracownika")]
        [Required(ErrorMessage = "Musisz wprowadzic wiek pracownika")]
        [Range(18,70)]
        public int Wiek { get; set; }

        [Display(Name = "Adres email Pracownika")]
        [Required(ErrorMessage = "Musisz wprowadzic adres e-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [RegularExpression(@"\(?\d{3}\)?[-\.]? *\d{3}[-\.]? *[-\.]?\d{4}", ErrorMessage = "Numer musi byc zapisany w formacie: 123-123-1234")]
        public string  NrTelefonu { get; set; }

        [Display(Name ="Pytanie do szefa:")]
        [DataType(DataType.MultilineText)]
        public string  Pytanie { get; set; }

    }
}