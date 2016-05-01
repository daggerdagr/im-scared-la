using UnityEngine;
using System.Collections;
using System;
using SharpOSC;

namespace muse_osc_server
{
    public class muse_osc_server : MonoBehaviour
    {


        // Use this for initialization
        void Start()
        {
            Debug.Log("It's running!");
            // Callback function for received OSC messages. 
            // Prints EEG and Relative Alpha data only.
            HandleOscPacket callback = delegate (OscPacket packet)
            {
                var messageReceived = (OscMessage)packet;
                var addr = messageReceived.Address;
                if (addr == "/muse/eeg")
                {
                    Debug.Log("EEG values: ");
                    foreach (var arg in messageReceived.Arguments)
                    {
                        Debug.Log(arg + " ");
                    }
                }
                if (addr == "/muse/elements/alpha_relative")
                {
                    Debug.Log("Relative Alpha power values: ");
                    foreach (var arg in messageReceived.Arguments)
                    {
                        Debug.Log(arg + " ");
                    }
                }
            };

            // Create an OSC server.
            var listener = new UDPListener(5000, callback);

            Debug.Log("Press enter to stop");
            Console.ReadLine();
            listener.Close();

        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log("It's running!");
            // Callback function for received OSC messages. 
            // Prints EEG and Relative Alpha data only.
            HandleOscPacket callback = delegate (OscPacket packet)
            {
                var messageReceived = (OscMessage)packet;
                var addr = messageReceived.Address;
                if (addr == "/muse/eeg")
                {
                    Debug.Log("EEG values: ");
                    foreach (var arg in messageReceived.Arguments)
                    {
                        Debug.Log(arg + " ");
                    }
                }
                if (addr == "/muse/elements/alpha_relative")
                {
                    Debug.Log("Relative Alpha power values: ");
                    foreach (var arg in messageReceived.Arguments)
                    {
                        Debug.Log(arg + " ");
                    }
                }
            };

            // Create an OSC server.
            var listener = new UDPListener(5000, callback);

            Debug.Log("Press enter to stop");
            Console.ReadLine();
            listener.Close();
        }
    }
}
