public class Solution {
    public char FindKthBit(int n, int k) {
        var strings ="0";
        while(n-1>0)
        {
            var begin=strings;
            strings=strings+'1'+Reverse(Invert(begin));
            n--;
        }
        return strings[k-1];
    }
    public string Invert(string invertString){
        var newString = new StringBuilder(invertString.Length);
        foreach(var chars in invertString){
           
           newString.Append(chars =='0'?'1':'0');
        }
        return newString.ToString();
    }
    public static string Reverse( string s )
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}