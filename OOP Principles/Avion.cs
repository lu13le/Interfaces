﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    internal class Avion:Vozilo
    {
        #region atributi
        private int visinaLetenja;
        private int domet;
        #endregion

        #region Konstruktori
        public Avion(int visinaLetenja, int domet, string boja, float brzina, float maxBrzina) : base(boja, brzina, maxBrzina)
        {
            this.visinaLetenja = visinaLetenja;
            this.domet = domet;
        }

        #endregion

        #region funkcije

        public override void ubrzaj()
        {
            if (moguceUbrzanje() > 500)
                getSetBrzina += 100;
            else if (getSetBrzina + 100 >= getSetMaxBrzina)
                getSetBrzina = getSetMaxBrzina;
            else
                getSetBrzina += 50;
        }
        public override void uspori()
        {
            if (visinaLetenja > 10000)
                getSetBrzina -= 50;
            else
                getSetBrzina -= 100;
        }

        public override void unos()
        {
            Console.WriteLine("Unesite visinu letenja aviona: ");
            visinaLetenja = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite domet aviona: ");
            domet = Convert.ToInt32(Console.ReadLine());
            base.unos();
        }
        public override string ToString()
        {
            return $"AVION\nVisina letenja aviona: {visinaLetenja}\nDomet letenja aviona: {domet}\n{base.ToString()}";
        }
        #endregion
    }
}
