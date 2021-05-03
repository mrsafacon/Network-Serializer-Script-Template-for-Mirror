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


public struct MamaSerial
{
    
}


public static class MamaSerialSerializer
{
    public static void WriteMamaSerial(this NetworkWriter writer, MamaSerial value)
    {
        //write data
    }

    public static MamaSerial ReadMamaSerial(this NetworkReader reader)
    {
        //read data
        return new MamaSerial(); //remove this
    }
}
