using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using BloodSugarClassLibrary.Models;

namespace BloodSugarDiary.Services
{
    public static class XmlExportService
    {
        public static bool TryExportMeasurementsToXml(List<Measurements> measurements, string filePath, out string errorMessage)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(List<Measurements>));
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    serializer.Serialize(stream, measurements);
                }
                errorMessage = null;
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}