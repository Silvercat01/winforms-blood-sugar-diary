using BloodSugarClassLibrary.Models;
using BloodSugarClassLibrary.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BloodSugarClassLibrary.Repositories
{
    public class PatientRepository
    {
        private readonly UserContext _context;

        public PatientRepository(UserContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Patient GetPatientByUserId(int userId)
        {
            return _context.Patients.FirstOrDefault(p => p.UserId == userId);
        }

        public void UpdatePatient(Patient patient)
        {
            if (patient == null)
                throw new ArgumentNullException(nameof(patient));

            _context.SaveChanges();
        }

        public void AddPatient(Patient patient)
        {
            if (patient == null)
                throw new ArgumentNullException(nameof(patient));

            _context.Patients.Add(patient);
            _context.SaveChanges();
        }
    }
}
