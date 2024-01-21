using System;
using System.Text;

class StringCompress
{


    public static string compress(string input)
    {
        // validate before 
        char current = input[0];
        int count = 0;
        StringBuilder output = new StringBuilder();

        foreach (char dot in input)
        {

            if (dot == current)
            {
                count++;
            }
            else
            {

                output.Append(current);
                output.Append(count);
                //update current and count
                current = dot;
                count = 1;

            }

        }

        output.Append(current);
        output.Append(count);


        return output.ToString();

    }

}
