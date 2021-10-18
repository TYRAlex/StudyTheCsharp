namespace LeecodeStudy
{
    public class RegexSolve
    {
        public static bool IsMatch(string s, string pattern)
        {
            int m = s.Length;
            int n = pattern.Length;

            bool[,] f = new bool[m + 1, n + 1];
            f[0, 0] = true;
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (pattern[j - 1] == '*')
                    {
                        f[i, j] = f[i, j - 2];
                        if (Match(s, pattern, i, j))
                        {
                            f[i, j] = f[i - 1, j - 1];
                        }
                    }
                }
            }

            return f[m, n];
        }

        public static bool Match(string s, string p, int i, int j)
        {
            if (i == 0)
            {
                return false;
            }

            if (p[j - 1] == '.')
            {
                return true;
            }

            return s[i - 1] == p[j - 1];
        }
    }
}