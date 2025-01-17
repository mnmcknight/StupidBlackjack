﻿//ClassMaster: Jonah

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StupidBlackjackSln.Code
{
    /// <summary>
    /// A wrapper for client-side socket implementation
    /// for StupidBlackjack
    /// </summary>
    class StupidConnector
    {
        private static String ip = StupidServer.DEFAULT_DOMAIN;
        private static int port = StupidServer.DEFAULT_PORT;

        private TcpClient client;
        private int key = new Random().Next(Int32.MaxValue);
        private NetworkStream netstream;
        private readonly String serverDomain;
        private readonly int serverPort;

        /// <summary>
        /// Create a new connection to the default matchmaking server.
        /// </summary>
        public StupidConnector()
        {
            this.serverDomain = ip;
            this.serverPort = port;
            this.client = new TcpClient(serverDomain, serverPort);
            this.netstream = client.GetStream();
        }

        /// <summary>
        /// Create a new connection to a custom matchmaking server.
        /// </summary>
        /// <param name="domain">The domain name (or ip) of the server</param>
        /// <param name="port">The port to connect to</param>
        public StupidConnector(String domain, int port)
        {
            this.serverDomain = domain;
            this.serverPort = port;
            this.client = new TcpClient(serverDomain, serverPort);
            this.netstream = client.GetStream();
        }

        /// <summary>
        /// Check for an update from the connected server.
        /// </summary>
        /// <returns>The incoming string, or null if none available</returns>
        public String CheckForUpdate()
        {
            if (this.HasResponse())
            {
                return this.ReadLine();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Close the connection. Use before terminating application
        /// </summary>
        public void Close() {
            netstream.Close();
            client.Close();
        }

        /// <summary>
        /// Alias for Encoding.ASCII.GetString() to make code more readable.
        /// </summary>
        /// <param name="b">Byte array to convert</param>
        /// <returns>The string represented by the given byte array</return>
        private String GetStringFromBytes(byte[] b) {
            return Encoding.ASCII.GetString(b, 0, b.Length);
        }

        /// <summary>
        /// Check if StupidConnector has a line to read.
        /// </summary>
        /// <returns>true if pending, false otherwise</returns>
        public bool HasResponse()
        {
            return client.GetStream().DataAvailable;
        }

        /// <summary>
        /// Fetch a list of the games currently being hosted on the matchmaking server.
        /// </summary>
        /// <returns>An array of strings containing game names and id's</returns>
        public String[] FetchListOfGames()
        {
            String[] response = this.WriteLine(StupidServer.CMD_FETCH);
            if (!response[0].Equals(StupidServer.RESPONSE_SUCCESS))
            {
                return null;
            }
            else
            {
                // Don't return the empty string at the end
                String[] list = response[1].Split(';');
                return new List<string>(list).GetRange(0, list.Length - 1).ToArray();
            }
        }

        /// <summary>
        /// Get the number of players connected to a hosted game, including the host.
        /// </summary>
        /// <param name="id">The game id to query</param>
        /// <returns>population of a game, or null if failed</returns>
        public int? GetGamePopulationByID(int id)
        {
            String[] response = this.WriteLine(StupidServer.CMD_GET_GAME_POP_BY_ID + " " + id.ToString());
            if (!response[0].Equals(StupidServer.RESPONSE_SUCCESS))
            {
                return null;
            }
            else
            {
                try
                {
                    return Int32.Parse(response[1]);
                }
                catch
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Get the name of a hosted game.
        /// </summary>
        /// <param name="id">The game id to query</param>
        /// <returns>Name of a game, or null if failed</returns>
        public String GetGameNameByID(int id)
        {
            String[] response = this.WriteLine(StupidServer.CMD_GET_GAME_NAME_BY_ID + " " + id.ToString());
            if (!response[0].Equals(StupidServer.RESPONSE_SUCCESS))
            {
                return null;
            }
            else
            {
                return response[1];
            }
        }

        /// <summary>
        /// Get the "security" key associated with this connector object.
        /// </summary>
        public int GetKey()
        {
            return key;
        }

        /// <summary>
        /// Create a new game session on the matchmaking server.
        /// </summary>
        /// <param name="serverName">Display name for the game session.</param>
        /// <returns>The generated id number for the game, or 0 if failed.</returns>
        public int HostNewGame(String serverName)
        {
            String[] response = this.WriteLine(StupidServer.CMD_HOST_NEW_GAME + " " + serverName + " " + key.ToString());
            if (!response[0].Equals(StupidServer.RESPONSE_SUCCESS))
            {
                return 0;
            }
            else
            {
                return Int32.Parse(response[1]);
            }
        }

        /// <summary>
        /// Join a game using its identification number.
        /// </summary>
        /// <param name="id">id of game to join</param>
        /// <returns>true if join succeeded</returns>
        public String[] JoinGameByID(int id)
        {
            String[] response = this.WriteLine(StupidServer.CMD_JOIN_GAME_BY_ID + " " + id + " " + key);
            return response;
        }

        /// <summary>
        /// Remove the player from a particular hosted game.
        /// </summary>
        /// <param name="id">The id of the game to be removed from</param>
        /// <returns>True if the server responds with RESPONSE_SUCCESS, else false</returns>
        public String[] LeaveGameByID(int id)
        {
            String[] response = this.WriteLine(StupidServer.CMD_REMOVE_PLAYER_FROM_GAME + " " + id + " " + key);
            return response;
        }

        /// <summary>
        /// Notify other players of the card that you have drawn.
        /// </summary>
        /// <param name="c">The card object to notify</param>
        /// <param name="connected_game_id">The id of the game connection</param>
        /// <returns>true if the server responds with RESPONSE_SUCCESS, else false</returns>
        public String[] NotifyCardDrawn(Card c, int connected_game_id)
        {
            String[] response = this.WriteLine(StupidServer.NOTIFY_CARD_DRAW + " " + connected_game_id + " " + key.ToString() + " " + c.ToString());
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="connected_game_id"></param>
        /// <returns></returns>
        public String[] NotifyDealerDraw(Card c, int connected_game_id)
        {
            String[] response = this.WriteLine(StupidServer.NOTIFY_DEALER_DRAW + " " + connected_game_id + " " + c.ToString());
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connected_game_id"></param>
        /// <returns></returns>
        public String[] NotifyDealerSetupFinished(int connected_game_id)
        {
            String[] response = this.WriteLine(StupidServer.NOTIFY_DEALER_SETUP_FINISH + " " + connected_game_id + " " + key.ToString());
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connected_game_id"></param>
        /// <returns></returns>
        public String[] NotifyDealerStand(int connected_game_id)
        {
            String[] response = this.WriteLine(StupidServer.NOTIFY_DEALER_STAND + " " + connected_game_id + " " + key.ToString());
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connected_game_id"></param>
        /// <returns></returns>
        public String[] NotifyInitializationComplete(int connected_game_id)
        {
            String[] response = this.WriteLine(StupidServer.NOTIFY_INIT + " " + connected_game_id);
            return response;
        }

        /// <summary>
        /// Notify the server that the initial 2 cards have been drawn.
        /// </summary>
        /// <param name="connected_game_id">The id of the game connection</param>
        /// <returns>true if the server responds with RESPONSE_SUCCESS, else false</returns>
        public String[] NotifySetupFinished(int connected_game_id)
        {
            String[] response = this.WriteLine(StupidServer.NOTIFY_SETUP_FINISH + " " + connected_game_id);
            return response;
        }

        /// <summary>
        /// Notify other players that you have stood.
        /// </summary>
        /// <param name="connected_game_id">The id of the game connection</param>
        /// <returns>true if the server responds with RESPONSE_SUCCESS, else false</returns>
        public String[] NotifyStand(int connected_game_id)
        {
            String[] response = this.WriteLine(StupidServer.NOTIFY_STAND + " " + connected_game_id + " " + key.ToString());
            return response;
        }
        
        /// <summary>
        /// Read from StupidServer until a newline is reached
        /// </summary>
        /// <returns>Characters from the StupidServer</returns>
        private String ReadLine()
        {
            byte[] buffer = new byte[1];
            String reading = "";
            client.GetStream().Read(buffer, 0, 1); //Read 1 byte at a time
            while (!buffer[0].Equals(StupidServer.NEWLINE))
            {
                reading += Encoding.ASCII.GetString(buffer);
                client.GetStream().Read(buffer, 0, 1);
            }
            return reading;
        }

        /// <summary>
        /// Remove a previously hosted game from the matchmaking server.
        /// </summary>
        /// <param name="id">The id of the game to remove</param>
        public void RemoveHostedGame(int id)
        {
            this.WriteLine(StupidServer.CMD_REMOVE_GAME_BY_ID + " " + id + " " + key);
        }

        /// <summary>
        /// Set IP address of server.
        /// </summary>
        /// <param name="ip">ip address in parsable String format</param>
        public static void SetIP(String ip)
        {
            StupidConnector.ip = ip;
        }

        /// <summary>
        /// Set port of server.
        /// </summary>
        /// <param name="port">port for connection</param>
        public static void SetPort(int port)
        {
            StupidConnector.port = port;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="game_id"></param>
        public String[] StartHostedGame(int game_id)
        {
            String[] response = this.WriteLine(StupidServer.CMD_START_GAME_BY_ID + " " + game_id + " " + key);
            return response;
        }
        
        /// <summary>
        /// Write a String to the connection followed by a newline character, and get a response.
        /// </summary>
        /// <param name="toWrite">The String to send</param>
        /// <returns>The Server's response split by spaces</returns>
        private String[] WriteLine(String toWrite)
        {
            byte[] data = Encoding.ASCII.GetBytes(toWrite.Trim());
            client.GetStream().Write(data, 0, data.Length);
            client.GetStream().Write(new byte[] {StupidServer.NEWLINE}, 0, 1);
            return this.ReadLine().Trim().Split(' ');
        }
    }
}
