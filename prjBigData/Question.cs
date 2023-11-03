using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjBigData
{
    public class Question
    { public Question(String ch, int nr,String r ,int np,Boolean utilise, String diff,string mod)
        {   souel = ch;
            Nr = nr;
            reponse = r;
            Np = np;
            this.utilise = utilise;
            this.diff = diff;
            this.module = mod;
            

        }
        public Boolean utilise;
        public  String souel { get; set; }
        public String reponse;
        public String diff;
        public String module;

        public List<String> reponses = new List<string>()
        {
        };
        public int Nr { get; set; }
        public int Np { get; set; }

        public void saisir(String ch ,int n)
        {
            souel = ch;
            Np = n;
        }
    }
}
