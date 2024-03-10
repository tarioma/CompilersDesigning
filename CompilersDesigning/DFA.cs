namespace CompilersDesigning;

public static class DFA
{
    public static bool ConstainsPhone(string text)
    {
        int i = -1;

        switch (0)
        {
            case 0:
                if (++i >= text.Length) goto default;
                if (text[i] == '+') goto case 1;
                if (text[i] == '0') goto case 4;
                if (char.IsDigit(text[i])) goto case 10;
                goto case 0;
            case 1:
                if (++i >= text.Length) goto default;
                if (text[i] == '3') goto case 2;
                goto case 0;
            case 2:
                if (++i >= text.Length) goto default;
                if (text[i] == '7') goto case 3;
                goto case 0;
            case 3:
                if (++i >= text.Length) goto default;
                if (text[i] == '3') goto case 4;
                goto case 0;
            case 4:
                if (++i >= text.Length) goto default;
                if (text[i] == ' ') goto case 4;
                if (text[i] == '(') goto case 5;
                if (char.IsDigit(text[i])) goto case 11;
                goto case 0;
            case 5:
                if (++i >= text.Length) goto default;
                if (char.IsDigit(text[i])) goto case 6;
                goto case 0;
            case 6:
                if (++i >= text.Length) goto default;
                if (char.IsDigit(text[i])) goto case 7;
                goto case 0;
            case 7:
                if (++i >= text.Length) goto default;
                if (char.IsDigit(text[i])) goto case 8;
                goto case 0;
            case 8:
                if (++i >= text.Length) goto default;
                if (text[i] == ')') goto case 9;
                goto case 0;
            case 9:
                if (++i >= text.Length) goto default;
                if (text[i] == ' ') goto case 9;
                if (char.IsDigit(text[i])) goto case 10;
                goto case 0;
            case 10:
                if (++i >= text.Length) goto default;
                if (text[i] == ' ') goto case 10;
                if (char.IsDigit(text[i])) goto case 11;
                goto case 0;
            case 11:
                if (++i >= text.Length) goto default;
                if (text[i] == ' ') goto case 11;
                if (char.IsDigit(text[i])) goto case 12;
                goto case 0;
            case 12:
                if (++i >= text.Length) goto default;
                if (text[i] == ' ') goto case 12;
                if (char.IsDigit(text[i])) goto case 13;
                goto case 0;
            case 13:
                if (++i >= text.Length) goto default;
                if (text[i] == ' ') goto case 13;
                if (char.IsDigit(text[i])) goto case 14;
                goto case 0;
            case 14:
                i++;
                if (i >= text.Length || text[i] == ' ') return true;
                goto case 0;
            default:
                return false;
        }
    }
}