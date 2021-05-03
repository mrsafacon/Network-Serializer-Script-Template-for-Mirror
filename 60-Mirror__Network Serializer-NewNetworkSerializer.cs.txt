using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

/*
	Serialization Guide: https://mirror-networking.gitbook.io/docs/guides/serialization
	API Reference:  
        	Network Writer: https://mirror-networking.com/docs/api/Mirror.NetworkWriter.html
        	Network Reader: https://mirror-networking.com/docs/api/Mirror.NetworkReader.html
*/


public struct #SCRIPTNAME#
{
    
}


public static class #SCRIPTNAME#Serializer
{
    public static void Write#SCRIPTNAME#(this NetworkWriter writer, #SCRIPTNAME# value)
    {
        //write data
    }

    public static #SCRIPTNAME# Read#SCRIPTNAME#(this NetworkReader reader)
    {
        //read data
        return new #SCRIPTNAME#(); //remove this
    }
}
