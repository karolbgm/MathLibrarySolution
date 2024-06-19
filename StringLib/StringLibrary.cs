namespace StringLib;

public static class StringLibrary
{
    public static string Concat(string str1, string str2)
    {
        return str1 + " " + str2;
    }

    public static string Upper(string str)
    {
        return str.ToUpper();
    }

    //BETTER WAY
    public static string ToUpperEveryOther(string str)
        //char can be a letter, number or symbol
    {
        var toUpper = true;
        var converted = string.Empty; //string variable
        foreach (var ch in str.ToCharArray())
        {
            if (!char.IsLetter(ch)) //true if letter // false if number or symbol
            {
                converted += ch;
                continue; //it will restart the if, with the next ch
            }
            if (toUpper)
            {
                converted += ch.ToString().ToUpper();
                
            } else
            {
                converted += ch.ToString().ToLower();
            }
            toUpper = !toUpper; //if true, change to false / if false, change to true -- TOGGLE

        }
        return converted;
    }

    public static string UpperAndLower(string str)
    {
        char[] myArr = str.ToCharArray();
        string finalString = ""; 


        for (int i = 0; i < myArr.Length; i++)

        {
            if (i % 2 == 0)
            {
              finalString += char.ToUpper(myArr[i]);

            } else
            {
                finalString += char.ToLower(myArr[i]);
            }
      

        }
        return finalString;
    }
}
