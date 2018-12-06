using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Entities
{
    public class User
    {
        public string DisplayName { get; set; }
        public UserStatus Status { get; set; }
        public string IPAddress { get; set; }

        public User()
        {
        }

        public User(string displayName, UserStatus status, string ipAddress)
        {
            DisplayName = displayName;
            Status = status;
            IPAddress = ipAddress;
        }
    }
    public class TextMessage
    {
        public User User { get; set; }
        public TextMessageType Type { get; set; }
        public string Msg { get; set; }
        public DateTime DateTime { get; set; }

        public static byte[] EncodeMessage(TextMessage msg)
        {
            int displayNameLength = 0, MsgLength = 0, ipAddressLength = 0;

            displayNameLength = msg.User.DisplayName.Length;
            MsgLength = msg.Msg.Length;
            ipAddressLength = msg.User.IPAddress.Length;

            byte[] displayName = Encoding.Default.GetBytes(msg.User.DisplayName);
            byte[] textMessage = Encoding.Default.GetBytes(msg.Msg);
            byte[] ipAddress = Encoding.Default.GetBytes(msg.User.IPAddress);
            byte[] preamble = Encoding.Default.GetBytes("AA");

            List<byte> frame = new List<byte>();

            foreach (byte pr in preamble){frame.Add(pr);}
            frame.Add((byte)msg.Type);
            frame.Add((byte)msg.User.Status);
            frame.Add((byte)displayNameLength);
            frame.Add((byte)MsgLength);
            frame.Add((byte)ipAddressLength);
            foreach (byte dN in displayName){frame.Add(dN);}
            foreach (byte txt in textMessage){frame.Add(txt);}
            foreach (byte ip in ipAddress){frame.Add(ip);}
            return frame.ToArray();
        }

        public static TextMessage DecodeMessage(byte[] frame)
        {
            TextMessage message = new TextMessage() { User = new User() };
            if (true) //Preamble check will be evaluated here
            {
                int displayNameLength = 0, messageLength = 0, ipAddressLength = 0;

                message.Type = (TextMessageType)frame[2];
                message.User.Status = (UserStatus)frame[3];

                displayNameLength = frame[4];
                messageLength = frame[5];
                ipAddressLength = frame[6];

                byte[] displayName = new byte[displayNameLength];
                Array.Copy(frame, 7, displayName, 0, displayNameLength);

                message.User.DisplayName = Encoding.Default.GetString(displayName);

                byte[] textMessage = new byte[messageLength];
                Array.Copy(frame, 7 + displayNameLength, textMessage, 0, messageLength);

                byte[] ipAddress = new byte[ipAddressLength];
                Array.Copy(frame, 7 + displayNameLength + messageLength, ipAddress, 0, ipAddressLength);

                message.Msg = Encoding.Default.GetString(textMessage);
                message.User.DisplayName = Encoding.Default.GetString(displayName);
                message.User.IPAddress = Encoding.Default.GetString(ipAddress);
            }
            return message;
        }
    }
    public class FileMessage
    {
        public string Preamble { get; set; }
        public int DataLength { get; set; }
        public int Index { get; set; }
        public FileMessageType FileMessageType { get; set; }
        public FileStatus FileStatus { get; set; }
        public int IPLength { get; set; }
        public int FileNameLength { get; set; }
        public string IpAddress { get; set; }
        public string FileName { get; set; }

        public byte[] Data;

        public static byte[] EncodeMessage(FileMessage msg)
        {
            byte[] preamble = Encoding.Default.GetBytes("BB");
            byte[] index = BitConverter.GetBytes(msg.Index);
            byte[] ipLength = BitConverter.GetBytes(msg.IPLength);
            byte[] fileNameLength = BitConverter.GetBytes(msg.FileNameLength);
            byte[] ipAddress = Encoding.Default.GetBytes(msg.IpAddress);
            byte[] fileName = Encoding.Default.GetBytes(msg.FileName);

            List<byte> frame = new List<byte>();
            foreach (byte b in preamble)
            {
                frame.Add(b);
            }
            foreach (byte b in index)
            {
                frame.Add(b);
            }
            if (msg.FileMessageType == FileMessageType.Request)
                frame.Add(0);
            else
                frame.Add(1);
            frame.Add((byte)msg.FileStatus);
            foreach (byte b in ipLength)
            {
                frame.Add(b);
            }
            foreach (byte b in fileNameLength)
            {
                frame.Add(b);
            }
            foreach (byte b in ipAddress)
            {
                frame.Add(b);
            }
            foreach (byte b in fileName)
            {
                frame.Add(b);
            }
            foreach (byte b in msg.Data)
            {
                frame.Add(b);
            }
            int length = msg.Data.Length;
            byte[] frameLength = BitConverter.GetBytes(length);
            for (int i = 0; i < frameLength.Length; i++)
            {
                frame.Insert(i + 2, frameLength[i]);
            }
            return frame.ToArray();
        }

        public static FileMessage DecodeMessage(byte[] frame)
        {
            FileMessage msg = new Entities.FileMessage();

            msg.Preamble = Encoding.Default.GetString(frame, 0, 2);
            msg.DataLength = BitConverter.ToInt32(frame, 2);
            msg.Index = BitConverter.ToInt32(frame, 6);
            msg.FileMessageType = frame[10] == 0 ? FileMessageType.Request : FileMessageType.Responese;
            msg.FileStatus = (FileStatus)frame[11];
            msg.IPLength = BitConverter.ToInt32(frame, 12);
            msg.FileNameLength = BitConverter.ToInt32(frame, 16);
            msg.IpAddress = Encoding.Default.GetString(frame, 20, msg.IPLength);
            msg.FileName = Encoding.Default.GetString(frame, 20 + msg.IPLength, msg.FileNameLength);

            //int dataLength = msg.DataLength - (8 + msg.IPLength + msg.FileNameLength);
            msg.Data = new byte[msg.DataLength];
            Array.Copy(frame, frame.Length - msg.DataLength, msg.Data, 0, msg.DataLength);

            return msg;
        }
    }
    public class FileManager
    {
        FileMessage msg;
        string fileName;

        public FileManager(FileMessage _msg)
        {
            msg = _msg;
            fileName = _msg.FileName;
        }
        public FileManager(string _fileName, FileMessage _msg)
        {
            msg = _msg;
            fileName = _fileName;
        }
        public void Save()
        {
            FileStream fs;
            if (msg.FileStatus == FileStatus.NotStarted)
            {
                fs = new FileStream(fileName, FileMode.Create);
                fs.Close();
            }
            else if (msg.FileStatus == FileStatus.Started)
            {
                fs = new FileStream(fileName, FileMode.Append);
                fs.Write(msg.Data, 0, msg.DataLength);
                fs.Close();
            }
        }
        public byte[] GetBytes(int index)
        {
            return null;
        }

        public FileMessage GetMessage()
        {
            int length = 700;
            //FileMessage msg = new FileMessage();
            byte[] fileData = System.IO.File.ReadAllBytes(fileName);
            if (fileData.Length - msg.Index * length > length)
            {
                msg.Data = new byte[length];
                msg.FileStatus = FileStatus.Started;
                Array.Copy(fileData, msg.Index * length, msg.Data, 0, length);
            }
            else
            {
                length = fileData.Length - msg.Index * length;
                msg.Data = new byte[length];
                msg.FileStatus = FileStatus.Finished;
                Array.Copy(fileData, msg.Index * length, msg.Data, 0, length);
            }
            msg.DataLength = msg.Data.Length;
            return msg;
        }
    }
    public enum UserStatus
    {
        Available,
        UnAvailable,
        Bussy,
        Offline
    }
    public enum TextMessageType
    {
        TextMessage,
        StatusMessage,
        None
    }
    public enum FileMessageType
    {
        Request,
        Responese
    }
    public enum FileStatus
    {
        NotStarted,
        Started,
        Finished
    }
}
