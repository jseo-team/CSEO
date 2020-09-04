using System;

namespace dotNet {
    public static class Strings{

        public static string empty = "";

        public static string after(this string s, string a)
        {
            if (s.IndexOf(a)>-1) return s.Substring(s.IndexOf(a) + a.Length);
            else return Strings.empty;
        }

        public static string before(this string s, string b)
        {
            if (s.IndexOf(b)>-1) return s.Substring(0, s.IndexOf(b)); 
            else return Strings.empty;
        }

        public static string replace(this string s, string a, string b)
        {
            return String.Join(b, s.Split(a.ToCharArray()));
        }

    }
}
