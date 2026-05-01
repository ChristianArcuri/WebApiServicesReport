using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WebAPIBusiness.Utilities
{
    public class FaxSender
    {
        public delegate void SendFaxFx(string FaxSrvIp, string AgencyCode, string UserName, string Station, string FaxFilePath);
        public delegate void SendFaxInvoice(string FaxSrvIp, string AgencyCode, int InvDeliveryHour, int InvDeliveryMin,
                                            string UserName, string Station, string FaxFilePath);

        public static readonly SendFaxFx SendFaxFxDelegate;
        public static readonly SendFaxInvoice SendFaxInvoiceDelegate;
        static FaxSender()
        {
            SendFaxFxDelegate = new SendFaxFx(SendMarketingFax);
            SendFaxInvoiceDelegate = new SendFaxInvoice(SendFaxAccAgencyInvoice);
        }

        [DllImport(@"SendFaxes64Bit.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern void SendFaxAccAgencyInvoice(string FaxSrvIp, string AgencyCode, int InvDeliveryHour, int InvDeliveryMin,
                                                 string UserName, string Station, string FaxFilePath);

        public static void SendFaxAccAgencyInvoiceInt(string FaxSrvIp, string AgencyCode, int InvDeliveryHour, int InvDeliveryMin,
                                                 string UserName, string Station, string FaxFilePath)
        {
            SendFaxAccAgencyInvoice(FaxSrvIp, AgencyCode, InvDeliveryHour, InvDeliveryMin, UserName, Station, FaxFilePath);
        }
 
        [DllImport(@"SendFaxes64Bit.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern void SendFaxToAgency(string FaxSrvIp, string AgencyCode, string UserName, string Station, string FaxFilePath,
                                               int UseWireFax, int Queue);   // Generic

        public static void SendFaxToAgencyInt(string FaxSrvIp, string AgencyCode, string UserName, string Station, string FaxFilePath, int UseWireFax, int Queue)
        {
            SendFaxToAgency(FaxSrvIp, AgencyCode, UserName, Station, FaxFilePath, UseWireFax, Queue);

        }

        [DllImport(@"SendFaxes64Bit.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern void SendMarketingFax(string FaxSrvIp, string AgencyCode, string UserName, string Station, string FaxFilePath);

        public static void SendMarketingFaxInt(string FaxSrvIp, string AgencyCode, string UserName, string Station, string FaxFilePath)
        {
            SendMarketingFax(FaxSrvIp, AgencyCode, UserName, Station, FaxFilePath);
        }
    }
}
