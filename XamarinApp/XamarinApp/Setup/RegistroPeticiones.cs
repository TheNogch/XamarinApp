using System;
using System.Collections.Generic;
using System.Text;
using Waher.Networking.XMPP;
using Waher.Persistence.Attributes;

namespace XamarinApp.Setup
{
    [CollectionName("Peticiones")]
    [Index("Timestamp")]
    [Index("ContractId", "Timestamp")]
    [Index("PetitorLegalId", "Timestamp")]
    public class RegistroPeticiones
    {
        private string objectId = null;
        private DateTime timestamp = DateTime.MinValue;
        private string contracid = string.Empty;
        private string petitorlegalid = string.Empty;
        private string status = string.Empty;

        [ObjectId]
        public string ObjectId
        {
            get { return objectId; }
            set { objectId = value; }
        }

        public DateTime Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }

        public string ContractId
        {
            get { return contracid; }
            set { contracid = value; }
        }

        public string PetitorLegalId
        {
            get { return petitorlegalid; }
            set { petitorlegalid = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
