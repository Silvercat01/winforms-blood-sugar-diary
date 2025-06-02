using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodSugarClassLibrary.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int UserId { get; set; } // Külső kulcs a User táblára
        public User User { get; set; } // Navigációs tulajdonság visszafelé

        public Patient(string name, string address, string phonenumber, int userId)
        {
            Name = name;
            UserId = userId;
            Address = address;
            PhoneNumber = phonenumber;
        }

        public Patient()
        {
        }

    }
}
