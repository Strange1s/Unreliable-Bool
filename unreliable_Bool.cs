using System;
using System.Collections;
using System.Runtime;

//I genuinely have no idea why you would want to use this but okay
public class unreliable_Bool
{
    Random random = new Random();

    public bool unreliabool()
    {
        //create 2 random doubles
        Double rand_1 = random.NextDouble();
        Double rand_2 = random.NextDouble();

        //compare the random doubles
        if (rand_2 > rand_1)
            return true;
        else return false;

        //This is simple but completely pointless. I don't know why you'd want this...
    }
    
}
