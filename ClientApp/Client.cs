﻿using Models.DTO;
using Models.Entities;
using Models.Mapper;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    public class Client
    {
        private Socket socket;
        
        public Repository Repository { get; set; }
        public Action<ResponseDTO> OnReceivedMessage { get; set; }
        public Action OnConnectionStateChanged { get; set; }
        public Client()
        {
            Repository = new Repository();  
        }

        public void Connect(string ipAddress, int port)
        {
            if (!IsConnected())
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(new IPEndPoint(IPAddress.Parse(ipAddress), port));
                new Task(async () =>
                {
                    while (IsConnected())
                    {
                        await Task.Delay(1000);
                    };
                    Disconnect();
                    OnConnectionStateChanged?.Invoke();
                }).Start();
            }
        }

        public void Send(RequestDTO request)
        {
            if (socket != null)
            {
                new Task(() =>
                {
                    try
                    {
                        socket.Send(Encoding.UTF8.GetBytes(request.Serialize()));
                        ResponseDTO res = ProcessReceiveMessage();
                        Repository.Requests.Add(Mapper.MapRequest(res));
                        OnReceivedMessage?.Invoke(res);
                    }
                    catch (SocketException)
                    {
                        OnConnectionStateChanged?.Invoke();
                        Disconnect();
                    }
                }).Start();
            }
        }

        public ResponseDTO ProcessReceiveMessage()
        {
            byte[] buffer = new byte[16384];
            socket.Receive(buffer);
            ResponseDTO res = ResponseDTO.Deserialize(Encoding.UTF8.GetString(buffer).Replace("\0", ""));
            return res;
        }
        
        public bool IsConnected()
        {
            try
            {
                return (socket != null && !((socket.Poll(1000, SelectMode.SelectRead) && (socket.Available == 0)) || !socket.Connected));
            }
            catch (ObjectDisposedException)
            {
                return false;
            }
        }

        public void Disconnect()
        {
            if (socket != null)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                socket = null;
            }
        }
    }
}
