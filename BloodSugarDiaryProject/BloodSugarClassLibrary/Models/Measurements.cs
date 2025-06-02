namespace BloodSugarClassLibrary.Models
{
    public class Measurements
    {
        public enum Time
        {
            BeforeBreakfast,
            AfterBreakfast,
            BeforeLunch,
            AfterLunch,
            BeforeDinner,
            AfterDinner,
            Night
        }

        public enum Unit
        {
            mmol_l,
            mg_dl
        }

        public int Id { get; set; }
        public DateTime MeasurementDate { get; set; }
        public Time MeasurementTime { get; set; }
        public double BloodSugarLevel { get; set; }
        public Unit MeasurementUnit { get; set; }
        public string? Notes { get; set; } // Nullázható string
        public int UserId { get; set; } // Külső kulcs
        public virtual User? User { get; set; } // Navigációs tulajdonság

        public Measurements(DateTime date, Time time, double value, int userid)
        {
            MeasurementDate = date;
            MeasurementTime = time;
            BloodSugarLevel = value;
            UserId = userid;
        }

        public Measurements()
        {
        }

    }
}