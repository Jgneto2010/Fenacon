using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.User
{
    public class Employee : Entity
    {

        public Employee(string name, string cpf, string address, DateTime admissionDate)
        {
            Name = name;
            Cpf = cpf;
            Address = address;
            AdmissionDate = admissionDate;
            Id = Guid.NewGuid();
        }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Address { get; set; }
        public Office Office { get; set; }
        public DateTime workload { get; set; }
        public DateTime AdmissionDate { get; set; }
        public Supervisor? Supervisor { get; set; }
        public Situation Situation { get; set; }


        public bool CheckHolidays(DateTime admissionDate)
        {
           var dateSolicitation = DateTime.Now;
            

            if ( admissionDate.Month > 12 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    
}
