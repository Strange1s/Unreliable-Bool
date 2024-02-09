using System;
using System.Collections;
using System.Runtime;

//I genuinely have no idea why you would want to use this but okay
public class unreliable_Bool
{
    Random random = new Random();

    public bool unreliabool()
    {
        //create random double
        Double rand_1 = random.NextDouble();

        return (0.5 > rand_1);//just compares, duh, and then returns the result

        //This is simple but completely pointless. I don't know why you'd want this...
    }

}
