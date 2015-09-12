using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;
namespace demo
{
    public class sms
    {
        public static bool open = false;
        public static SerialPort portc = new SerialPort();

        public static bool sendMsg(SerialPort port, string PhoneNo, string Message)
        {
            bool isSend = false;


            string recievedData = ExecCommand(port, "AT", 300, "No phone connected");
            recievedData = ExecCommand(port, "AT+CMGF=1", 300, "Failed to set message format.");
            String command = "AT+CMGS=\"" + PhoneNo + "\"";
            recievedData = ExecCommand(port, command, 300, "Failed to accept phoneNo");
            command = Message + char.ConvertFromUtf32(26) + "\r";
            recievedData = ExecCommand(port, command, 3000, "Failed to send message"); //3 seconds
            if (recievedData.EndsWith("\r\nOK\r\n"))
            {
                isSend = true;
            }
            else if (recievedData.Contains("ERROR"))
            {
                isSend = false;
            }
            return isSend;


        }
        public static string ExecCommand(SerialPort port, string command, int responseTimeout, string errorMessage)
        {


            port.DiscardOutBuffer();
            port.DiscardInBuffer();
            receiveNow.Reset();
            port.Write(command + "\r");

            string input = ReadResponse(port, responseTimeout);
            if ((input.Length == 0) || ((!input.EndsWith("\r\n> ")) && (!input.EndsWith("\r\nOK\r\n"))))
                throw new ApplicationException("No success message was received.");
            return input;


        }
        public static string ReadResponse(SerialPort port, int timeout)
        {
            string buffer = string.Empty;

            do
            {
                if (receiveNow.WaitOne(timeout, false))
                {
                    string t = port.ReadExisting();
                    buffer += t;
                }
                else
                {
                    if (buffer.Length > 0)
                        throw new ApplicationException("Response received is incomplete.");
                    else
                        throw new ApplicationException("No data received from phone.");
                }
            }
            while (!buffer.EndsWith("\r\nOK\r\n") && !buffer.EndsWith("\r\n> ") && !buffer.EndsWith("\r\nERROR\r\n"));

            return buffer;
        }
        public static SerialPort OpenPort(string p_strPortName, int p_uBaudRate, int p_uDataBits, int p_uReadTimeout, int p_uWriteTimeout)
        {
            receiveNow = new AutoResetEvent(false);
            SerialPort port = new SerialPort();

            port.PortName = p_strPortName;                 //COM5
            port.BaudRate = p_uBaudRate;                   //9600
            port.DataBits = p_uDataBits;                   //8
            port.StopBits = StopBits.One;                  //1
            port.Parity = Parity.None;                     //None
            port.ReadTimeout = p_uReadTimeout;             //300
            port.WriteTimeout = p_uWriteTimeout;           //300
            port.Encoding = Encoding.GetEncoding("iso-8859-1");
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            port.Open();
            port.DtrEnable = true;
            port.RtsEnable = true;
            portc = port;

            return port;
        }
        public static void ClosePort(SerialPort port)
        {
            try
            {
                port.Close();
                port.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);
                port = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (e.EventType == SerialData.Chars)
            {
                receiveNow.Set();
            }


        }
        public static AutoResetEvent receiveNow;
    
    }
}