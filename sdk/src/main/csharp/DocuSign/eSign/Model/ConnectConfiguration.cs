using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuSign.eSign.Model
{
    public class ConnectInformation
    {
        public List<ConnectConfiguration> configurations { get; set; }
        public string totalRecords { get; set; }
    }

    //https://www.docusign.com/p/RESTAPIGuide/Content/REST%20API%20References/Set%20Up%20a%20Connect%20Configuration.htm\

    public class ConnectConfiguration
    {
        public string connectId { get; set; }
        public string configurationType { get; set; }
        public string urlToPublishTo { get; set; }
        public string allowEnvelopePublish { get; set; }
        public string enableLog { get; set; }
        public string includeDocuments { get; set; }
        public string includeCertificateOfCompletion { get; set; }
        public string requiresAcknowledgement { get; set; }
        public string signMessageWithX509Certificate { get; set; }
        public string useSoapInterface { get; set; }
        public string includeTimeZoneInformation { get; set; }
        public string includeEnvelopeVoidReason { get; set; }
        public string includeSenderAccountasCustomField { get; set; }
        public string envelopeEvents { get; set; }
        public string recipientEvents { get; set; }
        public string userIds { get; set; }
        public string allUsers { get; set; }
        public string includeCertSoapHeader { get; set; }
        public string includeDocumentFields { get; set; }
        public string name { get; set; }
        public string soapNamespace { get; set; }

        public ConnectConfiguration(string name, string url,
            string envelopeevents = "Sent, Delivered, Completed, Declined, Voided",
            string recipientevents = "Sent, Delivered, Completed, Declined, AuthenticationFailed, AutoResponded")
        {
            this.name = name;
            this.urlToPublishTo = url;
            this.envelopeEvents = envelopeEvents;
            this.recipientEvents = recipientEvents;

            allowEnvelopePublish = "true";
            enableLog = "true";
            includeDocuments = "false";
            requiresAcknowledgement = "false";
            signMessageWithX509Certificate = "false";
            useSoapInterface = "false";
            includeTimeZoneInformation = "false";
            includeEnvelopeVoidReason = "true";
            includeSenderAccountasCustomField = "true";
            allUsers = "true";
            includeDocumentFields = "true";
        }
    }




}
