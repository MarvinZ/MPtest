using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using TestManagePath.ManagePathWebRef;

namespace TestManagePath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly VendorTicketService _svc = new VendorTicketService();

        private void btn_CallService_Click(object sender, EventArgs e)
        {
            try
            {
                btnCustomWay.Enabled = false;
                richTextBox1.Text = "";

                var myXml = txtRequest.Text;
                var xdoc = new XmlDocument();
                xdoc.LoadXml(myXml);

                var info = _svc.MPTicketService(xdoc);

                richTextBox1.Text = info.ToString();
                btnCustomWay.Enabled = true;

            }
            catch (Exception ex)
            {

                richTextBox1.Text = ex.Message;
                btnCustomWay.Enabled = true;
            }
        }

        private static string SendRequestToMPAPI(string requestParams, string serviceURL)
        {
            XmlDocument xmlDoc = new XmlDocument();

            try
            {

                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;// | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                var request = WebRequest.Create(serviceURL);
                request.Headers.Add(@"SOAP:Action");
                request.ContentType = "text/xml";
                request.Method = "POST";
                //custom envelope
                var envelope = @"<?xml version=""1.0"" encoding=""utf-8"" ?><soap12:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap12=""http://www.w3.org/2003/05/soap-envelope"">  <soap12:Body>    <MPTicketService xmlns=""http://managepath8.com/"">      <Request>        REQUESTBODY      </Request>    </MPTicketService>  </soap12:Body></soap12:Envelope>";

                var soapXml = envelope.Replace("REQUESTBODY", requestParams);

                using (var writer = new StreamWriter(request.GetRequestStream()))
                {
                    writer.WriteLine(soapXml);
                }

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var readStream = new StreamReader(response.GetResponseStream()))
                    {
                        var resultXml = readStream.ReadToEnd();

                        if (!String.IsNullOrEmpty(resultXml))
                        {
                            xmlDoc.LoadXml(resultXml);
                        }
                    }
                    response.Close();
                }
            }
            catch (Exception ex)
            {
                //GlobalLog.Log.Write("Exception received: Message: " + ex.Message + "InnerException Message: " + ex.InnerException.Message);
            }
            return xmlDoc.OuterXml;
        }

        private void btnCustomWay_Click(object sender, EventArgs e)
        {
       
            btn_CallService.Enabled = false;
            richTextBox1.Text = "";
           var a =  SendRequestToMPAPI(txtRequest.Text,
                "https://managepath8.com/Services/Implementations/DollarGeneral/VendorTicketService.asmx");


            System.Xml.Linq.XDocument xDocument = System.Xml.Linq.XDocument.Parse(a);


            richTextBox1.Text = xDocument.ToString();

            btn_CallService.Enabled = true;
        }


    }
}
