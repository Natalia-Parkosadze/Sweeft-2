//1)

bool sPalindrome(string text) 
{
    text = text.ToLower().Replace(" ", "");

    StringBuilder reversedtext = new StringBuilder();

    for (int i = text.Length - 1; i >= 0; i--)
    {
        reversedtext.Append(text[i]);
    }

    
    if (text.Equals(reversedtext.ToString()))
    {
        return true;
    }
    else
    {
        return false;
    }
}


//2)
int MinSplit(int amount)
{
    int[] coins = new int[] { 50, 20, 10, 5, 1 };
    
    int numCoins = 0;
    
    int i = 0;
    
    while (amount > 0 && i < coins.Length)
    {
        if (amount >= coins[i])
        {
            amount -= coins[i];
            numCoins++;
        }
        {
            i++;
        }
    }
    
    return numCoins;
}

//3)
static int NotContains(int[] array)
{
    Array.Sort(array);

    int nextNumber = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= 0)
        {
            continue;
        }

        if (array[i] == nextNumber)
        {
            nextNumber++;
        }
        else if (array[i] > nextNumber)
        {
            break;
        }
    }

    return nextNumber;
}


//4)

static bool IsProperly(string sequence)
{
    int count = 0;
    for (int i = 0; i < sequence.Length; i++)
    {
        if (sequence[i] == '(')
        {
            count++;
        }
        else if (sequence[i] == ')')
        {
            count--;
        }

        if (count < 0)
        {
            return false;
        }
    }

    return count == 0;
}


//5)

static int CountVariants(int stairCount)
{
    if (stairCount <= 0)
    {
        return 0;
    }
    else if (stairCount == 1)
    {
        return 1;
    }

    int[] variants = new int[stairCount + 1];
    variants[1] = 1;
    variants[2] = 2;

    for (int i = 3; i <= stairCount; i++)
    {
        variants[i] = variants[i - 1] + variants[i - 2];
    }

    return variants[stairCount];
}
