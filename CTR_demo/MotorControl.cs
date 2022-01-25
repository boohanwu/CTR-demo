using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTR_demo
{
    class MotorControl
    {
        byte[] data;
        string dataStr;
        byte[] crcResult;

        public byte[] RelativeRotation(int id, double angle)
        {
            string RotationID = id.ToString("X").PadLeft(2, '0');
            string RotationAngle = ((int)Math.Round((angle / 2.25) * 10)).ToString("X").PadLeft(8, '0');

            dataStr = RotationID + "100104000204" + RotationAngle;
            data = StringToByteArray(dataStr);
            crcResult = BitConverter.GetBytes(CRC16(data));
            data = data.Concat(crcResult).ToArray();
            return data;
        }
        public byte[] AbsoluteRotation(int id, double angle)
        {
            string RotationID = id.ToString("X").PadLeft(2, '0');
            string RotationAngle = ((int)Math.Round((angle / 2.25) * 10)).ToString("X").PadLeft(8, '0');

            dataStr = RotationID + "100100000204" + RotationAngle;
            data = StringToByteArray(dataStr);
            crcResult = BitConverter.GetBytes(CRC16(data));
            data = data.Concat(crcResult).ToArray();
            return data;
        }

        public byte[] Translation(int id, double angle)
        {
            string TranslationID = id.ToString("X").PadLeft(2, '0');
            string TranslationDistance = ((int)Math.Round(-angle * 800)).ToString("X").PadLeft(8, '0');

            dataStr = TranslationID + "100104000204" + TranslationDistance;
            data = StringToByteArray(dataStr);
            crcResult = BitConverter.GetBytes(CRC16(data));
            data = data.Concat(crcResult).ToArray();
            return data;
        }
        public byte[] Brake()
        {
            dataStr = "FF10010A0001020000";
            data = StringToByteArray(dataStr);
            crcResult = BitConverter.GetBytes(CRC16(data));
            data = data.Concat(crcResult).ToArray();
            return data;
        }
        public byte[] ReadPosition(int id)
        {
            string ReadID = id.ToString("X").PadLeft(2, '0');
            dataStr = ReadID + "0302010002";
            data = StringToByteArray(dataStr);
            crcResult = BitConverter.GetBytes(CRC16(data));
            data = data.Concat(crcResult).ToArray();
            return data;
        }

        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        private static ushort CRC16(byte[] pDataBytes)
        {
            ushort crc = 0xffff;
            ushort polynom = 0xA001;

            for (int i = 0; i < pDataBytes.Length; i++)
            {
                crc ^= pDataBytes[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x01) == 0x01)
                    {
                        crc >>= 1;
                        crc ^= polynom;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }
            return crc;
        }
    }
}
