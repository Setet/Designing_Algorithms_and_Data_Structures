using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Boss_of_this_Gym
{
    class ClassAutomat
    {
        Dictionary<string, string[]> gramm = new Dictionary<string, string[]>();
        Regex osnova;
        bool stor;
        public ClassAutomat(string s)
        {
            Regex neter = new Regex(@"[A-Z]{1}");
            Regex prow = new Regex(@"^[A-Z]{1}$");
            Regex prowr = new Regex(@"^[A-Z]?[a-z]{1}$");
            Regex prowl = new Regex(@"^[a-z]{1}[A-Z]?$");

            string[] rez = s.Split('\n');
            string[][] rez1 = new string[rez.Length][];
            for (int i = 0; i < rez1.Length; i++)
            {
                rez1[i] = new string[rez[i].Length];
                rez1[i] = rez[i].Split('-');

            }

            string[] rez2 = new string[rez.Length];
            for (int i = 0; i < rez1.Length; i++)
            {
                rez2[i] = rez1[i][0];
            }

            for (int i = 0; i < rez1.Length; i++)
            {
                gramm.Add(rez1[i][0], rez1[i][1].Split('|'));
            }

            foreach (string i in gramm.Keys)
            {
                if (!prow.IsMatch(i))
                    throw new Exception();
            }

            bool l = true, r = true;
            foreach (string[] i in gramm.Values)
            {
                for (int j = 0; j < i.Length; j++)
                {
                    if (l)
                        l = prowl.IsMatch(i[j]);

                    if (r)
                        r = prowr.IsMatch(i[j]);

                    if (!l && !r)
                        break;

                    if (neter.IsMatch(i[j]))
                    {
                        Match Term = neter.Match(i[j]);

                        if (!gramm.ContainsKey(Term.Value))
                            throw new Exception();
                    }
                }

                if (!l && !r)
                    break;
            }

            if (!l && !r)
                throw new Exception();

            if (l)
            {
                osnova = prowl;
                stor = true;
            }
            else
            {
                osnova = prowr;
                stor = false;
            }

            if (!gramm.ContainsKey("S"))
                throw new Exception();
        }
        public bool check_word(string s)
        {
            Regex neter = new Regex(@"[A-Z]{1}");
            Regex ter = new Regex(@"[a-z]{1}");
            if (!stor)
            {

                char rez; StringBuilder s1 = new StringBuilder(s);
                for (int i = 0; i < s.Length / 2; i++)
                {
                    rez = s1[i];
                    s1[i] = s[s1.Length - i - 1];
                    s1[s1.Length - i - 1] = rez;
                }
                s = s1.ToString();

            }
            return check(0, "S");

            bool check(int n, string terminal, bool c = false)
            {

                string[] stroka;
                gramm.TryGetValue(terminal, out stroka);
                Match Term;

                for (int i = 0; i < stroka.Length && !c; i++)
                {
                    Term = ter.Match(stroka[i]);
                    if (Term.Value[0] == s[n])
                    {
                        if ((n != s.Length - 1) && (!c) && (neter.IsMatch(stroka[i])))
                        {
                            Term = neter.Match(stroka[i]);

                            c = check(n + 1, Term.Value);
                        }
                        else if ((n == s.Length - 1) && (!neter.IsMatch(stroka[i])))
                            return true;
                    }
                }
                return c;
            }
        }
    }
}
