﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    public enum Operation
    {
        Login,
        DodajProdavca,
        VratiSveProdavce,
        PretraziKorisnike,
        ObrisiKorisnika,
        NadjiKorisnikaPoId,
        UpdateKorisnika,
        PromeniSifru,
        DodajProizvod,
        VratiSveProizvode,
        ObrisiProizvod,
        PretraziProizvodePoNazivu,
        UpdateProizvod,
        NadjiProizvodPoId,
        DodajRacun,
        VratiSveRacune,
        StornirajRacun,
        PretraziRacunePoDatumu,
        NadjiRacunPoId,
        UpdateRacun,
        ProveriUsername
    }
}
