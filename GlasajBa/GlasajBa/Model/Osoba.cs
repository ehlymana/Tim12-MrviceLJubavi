﻿using GlasajBa.Helper;
using Prism.Windows.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBa.Model
{
    class Osoba : ValidatableBindableBase
    {
        string ime;
        [Required(ErrorMessage = "Niste unijeli ime")]
        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                SetProperty(ref ime, value);
            }
        }

        public Osoba() { }

        string prezime;
        [Required(ErrorMessage = "Niste unijeli prezime")]
        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                SetProperty(ref prezime, value);
            }
        }
        DateTime datRodjenja;
        [PunoljetstvoPropertyAttribute(ErrorMessage = "Morate biti punoljetni")]
        public DateTime DatRodjenja
        {
            get
            {
                return datRodjenja;
            }

            set
            {
                SetProperty(ref datRodjenja, value);
            }
        }
        string licnaKarta; //\d\d\d[A-Z]\d\d\d\d\d
        [Required(ErrorMessage = "Niste unijeli broj lične karte"), RegularExpression(@"\d\d\d[A-Z]\d\d\d\d\d", ErrorMessage = "Neispravan format licne karte!")]
        public string LicnaKarta
        {
            get
            {
                return licnaKarta;
            }

            set
            {
                SetProperty(ref licnaKarta, value);
            }
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        string JMBG;
        [Required(ErrorMessage = "Niste unijeli matični broj"), RegularExpression(@"\d{13}", ErrorMessage = "JMBG je 13 cifara!")]
        public string JMBG1
        {
            get
            {
                return JMBG;
            }

            set
            {
                SetProperty(ref JMBG, value);
            }
        }
        string drzavaBoravka;
        [Required(ErrorMessage = "Niste unijeli državu boravka")]
        public string DrzavaBoravka
        {
            get
            {
                return drzavaBoravka;
            }

            set
            {
                SetProperty(ref drzavaBoravka, value);
            }
        }
        public Osoba(string im, string prez, DateTime datR, string LK, string maticni, string drzava)
        {
            Ime = im;
            Prezime = prez;
            DatRodjenja = datR;
            LicnaKarta = LK;
            JMBG1 = maticni;
            DrzavaBoravka = drzava;
        }
    }
}
