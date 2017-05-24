int adjacentElementsProduct(int[] inputArray)
{
    //input array nputArray = [3, 6, -2, -5, 7, 3]
    //Should result in 21
    
    //first solution idea
    /*
        iterate through with two index variables
        multiply every adjacent elemt together
        find the largest product 
        return it
    */
    
    //Second solution idea
    /*
       
    */
    int largest = -1500;
    int product = 0;
    int length = 0;
    int x =0;
    int y = 1;
    
    //finding the size of array, because I don't see any type of .length property...
    foreach(int a in inputArray)
    {
        length++;
    }
    
    while(y < length)
    {
        product = (inputArray[x] * inputArray[y]);
        //doesn't work for negatives like this
        if(product > largest)
        {
            largest = product;
        }
        x++;
        y++;
    }
    
    return largest;
}
