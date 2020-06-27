using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSBank
{
    class WSUser
    {
        private string userid;
        private string imie;
        private string nazwisko;
        private int data_otwarcia;
        private int saldo;

        public WSUser(string userid,string imie,string nazwisko,int data_otwarcia,int saldo)
        {
            this.userid = userid;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.data_otwarcia = data_otwarcia;
            this.saldo = saldo;
        }
        public string getFullName()
        {
            return imie + " " + nazwisko;
        }
        public string getUserId()
        {
            return userid;
        }

    }
}
