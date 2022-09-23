﻿namespace ClientApp.View
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbHistory = new System.Windows.Forms.Label();
            this.DgvHistory = new System.Windows.Forms.DataGridView();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.CbbLanguages = new System.Windows.Forms.ComboBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.lbLanguages = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbConnecting = new System.Windows.Forms.Label();
            this.GbConnect = new System.Windows.Forms.GroupBox();
            this.GbInput = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistory)).BeginInit();
            this.GbConnect.SuspendLayout();
            this.GbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(131, 156);
            this.txtResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(231, 75);
            this.txtResult.TabIndex = 17;
            this.txtResult.Text = "";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResult.Location = new System.Drawing.Point(20, 187);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(56, 23);
            this.lbResult.TabIndex = 16;
            this.lbResult.Text = "Result";
            // 
            // lbHistory
            // 
            this.lbHistory.AutoSize = true;
            this.lbHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHistory.Location = new System.Drawing.Point(20, 365);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(75, 28);
            this.lbHistory.TabIndex = 15;
            this.lbHistory.Text = "History";
            this.lbHistory.Click += new System.EventHandler(this.lbHistory_Click);
            // 
            // DgvHistory
            // 
            this.DgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistory.Location = new System.Drawing.Point(20, 412);
            this.DgvHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvHistory.Name = "DgvHistory";
            this.DgvHistory.RowHeadersWidth = 51;
            this.DgvHistory.RowTemplate.Height = 29;
            this.DgvHistory.Size = new System.Drawing.Size(754, 281);
            this.DgvHistory.TabIndex = 14;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(259, 251);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(103, 37);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(131, 39);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(231, 27);
            this.txtInput.TabIndex = 12;
            // 
            // CbbLanguages
            // 
            this.CbbLanguages.FormattingEnabled = true;
            this.CbbLanguages.Location = new System.Drawing.Point(131, 107);
            this.CbbLanguages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbbLanguages.Name = "CbbLanguages";
            this.CbbLanguages.Size = new System.Drawing.Size(231, 28);
            this.CbbLanguages.TabIndex = 11;
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInput.Location = new System.Drawing.Point(20, 41);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(73, 23);
            this.lbInput.TabIndex = 10;
            this.lbInput.Text = "Number";
            this.lbInput.Click += new System.EventHandler(this.lbInput_Click);
            // 
            // lbLanguages
            // 
            this.lbLanguages.AutoSize = true;
            this.lbLanguages.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLanguages.Location = new System.Drawing.Point(20, 112);
            this.lbLanguages.Name = "lbLanguages";
            this.lbLanguages.Size = new System.Drawing.Size(85, 23);
            this.lbLanguages.TabIndex = 9;
            this.lbLanguages.Text = "Language";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "IP Address";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(134, 27);
            this.txtIpAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(220, 27);
            this.txtIpAddress.TabIndex = 19;
            this.txtIpAddress.Text = "127.0.0.1";
            this.txtIpAddress.TextChanged += new System.EventHandler(this.txtIpAddress_TextChanged);
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPort.Location = new System.Drawing.Point(6, 98);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(41, 23);
            this.lbPort.TabIndex = 20;
            this.lbPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(134, 94);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(220, 27);
            this.txtPort.TabIndex = 21;
            this.txtPort.Text = "8000";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(189, 179);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(165, 40);
            this.btnConnect.TabIndex = 22;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbConnecting
            // 
            this.lbConnecting.BackColor = System.Drawing.Color.IndianRed;
            this.lbConnecting.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbConnecting.ForeColor = System.Drawing.Color.White;
            this.lbConnecting.Location = new System.Drawing.Point(6, 179);
            this.lbConnecting.Name = "lbConnecting";
            this.lbConnecting.Size = new System.Drawing.Size(160, 40);
            this.lbConnecting.TabIndex = 23;
            this.lbConnecting.Text = "Idle";
            this.lbConnecting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbConnect
            // 
            this.GbConnect.Controls.Add(this.label1);
            this.GbConnect.Controls.Add(this.btnConnect);
            this.GbConnect.Controls.Add(this.lbConnecting);
            this.GbConnect.Controls.Add(this.txtIpAddress);
            this.GbConnect.Controls.Add(this.lbPort);
            this.GbConnect.Controls.Add(this.txtPort);
            this.GbConnect.Location = new System.Drawing.Point(405, 23);
            this.GbConnect.Name = "GbConnect";
            this.GbConnect.Size = new System.Drawing.Size(369, 250);
            this.GbConnect.TabIndex = 24;
            this.GbConnect.TabStop = false;
            this.GbConnect.Text = "Connect";
            // 
            // GbInput
            // 
            this.GbInput.Controls.Add(this.lbLanguages);
            this.GbInput.Controls.Add(this.CbbLanguages);
            this.GbInput.Controls.Add(this.txtResult);
            this.GbInput.Controls.Add(this.lbInput);
            this.GbInput.Controls.Add(this.btnSend);
            this.GbInput.Controls.Add(this.lbResult);
            this.GbInput.Controls.Add(this.txtInput);
            this.GbInput.Location = new System.Drawing.Point(20, 23);
            this.GbInput.Name = "GbInput";
            this.GbInput.Size = new System.Drawing.Size(372, 312);
            this.GbInput.TabIndex = 25;
            this.GbInput.TabStop = false;
            this.GbInput.Text = "Input";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 715);
            this.Controls.Add(this.GbInput);
            this.Controls.Add(this.GbConnect);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.DgvHistory);
            this.Name = "Main";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistory)).EndInit();
            this.GbConnect.ResumeLayout(false);
            this.GbConnect.PerformLayout();
            this.GbInput.ResumeLayout(false);
            this.GbInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbHistory;
        private System.Windows.Forms.DataGridView DgvHistory;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox CbbLanguages;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Label lbLanguages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lbConnecting;
        private System.Windows.Forms.GroupBox GbConnect;
        private System.Windows.Forms.GroupBox GbInput;
    }
}