﻿using Models.DTO;
using Models.Entities;
using Models.Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ClientApp.View
{
    public partial class Main : Form
    {
        private Client client;
        public bool IsConnected { get; set; }
        public Main()
        {
            InitializeComponent();
            InitLanguageSelector();
            client = new Client()
            {
                OnReceivedMessage = ReceiveDataHandler,
                OnConnectionStateChanged = DisconnectedHandler
            };
            DgvHistory.DataSource = new List<RequestLog>();
        }
        private void InitLanguageSelector()
        {
            CbbLanguages.Items.AddRange(new CbbItem[]
            {
               new CbbItem { Key = "vi", Text = "Tiếng Việt" },
               new CbbItem { Key = "en", Text = "Tiếng Anh" },
               new CbbItem { Key = "sp", Text = "Tiếng Tây Ban Nha" },
               new CbbItem { Key = "fr", Text = "Tiếng Pháp"},
            });
            CbbLanguages.SelectedIndex = 0;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected())
            {
                string data = txtInput.Text;
                string lang = (CbbLanguages.SelectedItem as CbbItem).Key;
                client.Send(new RequestDTO
                {
                    Number = data,
                    Lang = lang
                });
            }
            else
            {
                MessageBox.Show("You haven't connected to server yet", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConnectionStateChanged(false);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            if(client.IsConnected())
            {
                client.Disconnect();
                ConnectionStateChanged(false);
            }
            else
            {
                string ipAddress = txtIpAddress.Text;
                int port = Convert.ToInt32(txtPort.Text);
                try
                {
                    client.Connect(ipAddress, port);
                    ConnectionStateChanged(true);
                }
                catch (SocketException)
                {
                    MessageBox.Show("Can't connect to server", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }        
            }
        }

        private void ConnectionStateChanged(bool state)
        {
            txtIpAddress.Enabled = !state;
            txtPort.Enabled = !state;
            lbConnecting.Text = state ? "Connecting" : "Idle";
            lbConnecting.BackColor = state ? Color.Green : Color.IndianRed;
            btnConnect.Text = state ? "Disconnect" : "Connect";
            IsConnected = state;
        }

        private void ReceiveDataHandler(ResponseDTO response) 
        {
            Invoke(new MethodInvoker(() =>
            {
                txtResult.Text = response.Text;
                DgvHistory.DataSource = null;
                DgvHistory.DataSource = client.Repository.Requests;
                DgvHistory.AutoResizeColumns();
            }));
        }

        private void DisconnectedHandler()
        {
            if (IsConnected)
            {
                // Server shutdown
                Invoke(new MethodInvoker(() =>
                {
                    MessageBox.Show("You has been disconnected to server or server has been shutdown", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConnectionStateChanged(false);
                }));
            }
        }

        private void DgvHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvHistory.SelectedRows.Count == 1)
            {
                txtInput.Text = DgvHistory.SelectedRows[0].Cells["Number"]?.Value.ToString().Replace(".", "");
                for (int i = 0;i < CbbLanguages.Items.Count; i++)
                {
                    if ((CbbLanguages.Items[i] as CbbItem).Text == DgvHistory.SelectedRows[0].Cells["Lang"].Value.ToString())
                    {
                        CbbLanguages.SelectedIndex = i;
                        break;
                    }
                }
                txtResult.Text = DgvHistory.SelectedRows[0].Cells["Text"]?.Value.ToString();
            }
        }
    }
}
