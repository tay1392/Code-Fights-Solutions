bool checkPalindrome(string inputString)
{
        int min = 0;
        int max = 0;
        foreach(char c in inputString)
        {
            max++;
        }
        
        max--;
        while (true)
        {
            if (min > max)
            {
                return true;
            }
            char a = inputString[min];
            char b = inputString[max];
            if (char.ToLower(a) != char.ToLower(b))
            {
                return false;
            }
            min++;
            max--;
        }
		
	//My actual solution below wasn't efficent/fast enough... But it worked 100%		
		
    /*
    int len = 0;
    string reversed = "";
    
    //finding the length of the input string
    //is there no .length function!?
    
    foreach(char c in inputString)
    {
        len++;
    }
    
    //start at char before null
    for(int i = len-1; i >= 0; i--)
    {
        reversed += inputString[i];
    }
    
    if(inputString == reversed)
    {
        return true;
    }
    else
    {
        return false;
    }*/
}
