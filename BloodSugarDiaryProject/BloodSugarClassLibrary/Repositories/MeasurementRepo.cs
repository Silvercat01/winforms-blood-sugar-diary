using System.Diagnostics.Metrics;
using BloodSugarClassLibrary.Data;
using BloodSugarClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BloodSugarClassLibrary.Repositories
{
    public class MeasurementRepo
    {
        private readonly UserContext _context;

        public MeasurementRepo(UserContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<Measurements> GetMeasurements(int userId, string timeRange = "all")
        {
            var query = _context.Measurements.Where(m => m.UserId == userId);

            switch (timeRange)
            {
                case "today":
                    query = query.Where(m => m.MeasurementDate >= DateTime.Today);
                    break;
                case "week":
                    query = query.Where(m => m.MeasurementDate >= DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek));
                    break;
                case "month":
                    query = query.Where(m => m.MeasurementDate >= new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1));
                    break;
            }

            return query.OrderByDescending(m => m.MeasurementDate).ToList();
        }

        public Measurements? GetMeasurementById(int id)
        {
            return _context.Measurements.FirstOrDefault(m => m.Id == id);
        }

        public void AddMeasurement(Measurements measurement)
        {
            _context.Measurements.Add(measurement);
            _context.SaveChanges();
        }

        public void UpdateMeasurement(Measurements measurement)
        {
            _context.Measurements.Update(measurement);

            _context.SaveChanges();
        }

        public void DeleteMeasurement(int id)
        {
            var measurement = _context.Measurements.Find(id); //ef metódus
            _context.Measurements.Remove(measurement);
            _context.SaveChanges();
        }


    }
}
