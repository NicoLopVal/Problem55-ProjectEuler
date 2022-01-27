using System.Numerics;

double counter = 0;
for(BigInteger i = 1; i<= 10000; i++)
{
    int iterations = 0;
    BigInteger valor = i;
    while (true)
    {
        valor = valor + ReverseNumber(valor);
        if (IsPalindrome(valor))
            break;
        if (iterations >= 50)
        {
            counter++;
            break;
        }
        iterations++;
    }
}

Console.WriteLine("There are {0} Lychrel numbers below ten-thousand", counter);

bool IsPalindrome(BigInteger number)
{
    string strNumber = number.ToString();
    int j = strNumber.Length - 1;
    for(int i = 0; i <= j; i++)
    {
        if(strNumber[i] != strNumber[j])
            return false;
        j--;
    }
    return true;
}

BigInteger ReverseNumber(BigInteger number)
{
    char[] charNumber = number.ToString().ToCharArray();
    Array.Reverse(charNumber);
    return BigInteger.Parse(new String(charNumber));
}