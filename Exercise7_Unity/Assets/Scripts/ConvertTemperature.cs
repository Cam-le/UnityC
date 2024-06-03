using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Converting temperature from F to C and back to F
/// </summary>
public class ConvertTemperature : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Three original temperature, don't know why but I have to use integer
        int fahren1, fahren2, celsius;
        //First F value
        fahren1 = 0;
        print("Original F:" + fahren1);
        //Calculate and print the converted celsius value
        celsius = (fahren1 - 32) / 9 * 5;
        print("Original F (In Celsius):" + celsius);
        //Convert C back to F and print value
        fahren2 = celsius * 9 / 5 + 32;
        print("Original F (After converted from C):" + fahren2);

        print("-----------------------");

        //Modify the original F value, keeping the same structure
        fahren1 = 32;
        print("Original F:" + fahren1);
        celsius = (fahren1 - 32) / 9 * 5;
        print("Original F (In Celsius):" + celsius);
        fahren2 = celsius * 9 / 5 + 32;
        print("Original F (After converted from C):" + fahren2);

        print("-----------------------");

        //Modify the original F value, keeping the same structure
        fahren1 = 212;
        print("Original F:" + fahren1);
        celsius = (fahren1 - 32) / 9 * 5;
        print("Original F (In Celsius):" + celsius);
        fahren2 = celsius * 9 / 5 + 32;
        print("Original F (After converted from C):" + fahren2);


    }

   
}
