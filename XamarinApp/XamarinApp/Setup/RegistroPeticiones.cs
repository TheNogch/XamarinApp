using System;
using System.Collections.Generic;
using System.Text;
using Waher.Persistence.Attributes;

namespace XamarinApp.Setup
{
    public class RegistroPeticiones
    {
        private string contracid = string.Empty;
        private string petitorlegalid = string.Empty;

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
    }
}
