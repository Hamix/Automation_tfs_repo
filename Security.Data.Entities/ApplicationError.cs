using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Entities.Abstractions;

namespace Security.Data.Entities
{
    public class ApplicationError : IEntity, IUniqueEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime DateCreated { get; set; }

        public string AssignedDeveloper { get; set; }
        public DateTime DateAssigned { get; set; }
        public byte Priority { get; set; }

        public byte Severity { get; set; }
        
        //bug or somthing
        public byte ErrorType { get; set; }

        public string IntegratedBuild { get; set; }
    }
}
