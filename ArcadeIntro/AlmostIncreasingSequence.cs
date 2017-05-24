//NOT MY SOLUTION
//Had trouble with this one, had to click the "hint"
/*
Given a sequence of integers as an array, determine whether 
it is possible to obtain a strictly increasing sequence by 
removing no more than one element from the array.

Example

For sequence = [1, 3, 2, 1], the output should be
almostIncreasingSequence(sequence) = false;

There is no one element in this array that can be removed in order to get a strictly increasing sequence.

For sequence = [1, 3, 2], the output should be
almostIncreasingSequence(sequence) = true.

You can remove 3 from the array to get the strictly increasing sequence [1, 2]. Alternately, you can remove 2 to get the strictly increasing sequence [1, 3].
*/
private static bool almostIncreasingSequence(int[] sequence)
{
	if (sequence.Length == 1) {return true;}
    int countOne = 0;
    int countTwo = 0;
    for (int i = 0; i < sequence.Length - 1; i++) 
	{
      if (sequence[i] >= sequence[i+1]) 
      {
        countOne++;
      }
       if(i != 0) 
	   {
           if (sequence[i - 1] >= sequence[i + 1]) 
		   {
               countTwo++;
           }
       }
    }
    
    if (countOne == 1 && countTwo <= 1) 
	{
        return true;
    } else 
	{
        return false;
    }
}