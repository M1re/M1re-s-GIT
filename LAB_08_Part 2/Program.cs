using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_08_2
{
    class DiskPhone
    {
        public string TelephoneNumber;
        public static readonly string AllowdSymbols = "0123456789";

        public void AnswerCall(string PhoneNumber) { }

        public void MakeCall(string PhoneNumber) { }

    }

    class ButtonPhone : DiskPhone
    {
        new public static readonly string AllowdSymbols = "0123456789*#";

        public void DisplayPhoneNumber(string PhoneNumber) { }
        new public void AnswerCall(string PhoneNumber)
        {
            DisplayPhoneNumber(PhoneNumber);
        }
    }

    class MobilePhone : ButtonPhone
    {
        new public static readonly string AllowdSymbols = "0123456789*#abcdefghijklmnopqrstuvwxyz+=-_()?:%;\"![]}{";
        public string Resolution;
        public string Size;
        public string Color;

        public void SendSMS(string PhoneNumber) { }

        public void ReceiveSMS(string PhoneNumber) { }

    }

    class ColoredMobile : MobilePhone
    {
        public int DisplayColors;
        public bool HasSecondSIM;
        public string SecondNumber;
        public void MakeCall(string PhoneNumber, bool UseSecondSIM) { }

        public void SendSMS(string PhoneNumber, bool UseSecondSIM) { }

        public void SendMMS(string PhoneNumber, bool UseSecondSIM) { }

        public void ReceiveMMS(string PhoneNumber) { }
    }

    class SmartPhone : ColoredMobile
    {
        public bool HasSensor;
        public int MaxTouches;
        public int NumberOfCamers;

        void MakePhoto(int CameraToUse) { }

        void MakeVideo(int CameraToUse) { }
    }
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
