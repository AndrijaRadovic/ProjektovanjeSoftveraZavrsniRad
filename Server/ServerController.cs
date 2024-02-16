﻿using Common.Domain;
using Server.SystemOperations.SOLogin;
using Server.SystemOperations.SORacun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServerController
    {
        private static ServerController instance;
        public static ServerController Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServerController();
                return instance;
            }
        }

        internal void DodajProdavca(Korisnik korisnik)
        {
            KreirajProdavcaSO so = new KreirajProdavcaSO(korisnik);
            so.ExecuteTemplate();
        }

        //Login
        internal object Login(Korisnik korisnik)
        {
            LoginSO loginSO = new LoginSO(korisnik);
            loginSO.ExecuteTemplate();
            return (Korisnik)loginSO.result;
        }

    }
}