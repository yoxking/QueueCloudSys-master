using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntFrm.RegistConsole
{
    public class RegisterInfo
    {
        private int id;
        private string encDogId;
        private string dogType;
        private string organizName;
        private string contact;
        private string telphone;
        private DateTime updateDate;
        private DateTime activeDate;
        private int activeCount;
        private string activeValCode;
        private string comment;

        public int ID { get => id; set => id = value; }
        public string EncDogId { get => encDogId; set => encDogId = value; }
        public string DogType { get => dogType; set => dogType = value; }
        public string OrganizName { get => organizName; set => organizName = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Telphone { get => telphone; set => telphone = value; }
        public DateTime UpdateDate { get => updateDate; set => updateDate = value; }
        public DateTime ActiveDate { get => activeDate; set => activeDate = value; }
        public int ActiveCount { get => activeCount; set => activeCount = value; }
        public string ActiveValCode { get => activeValCode; set => activeValCode = value; }
        public string Comment { get => comment; set => comment = value; }
    }
}
