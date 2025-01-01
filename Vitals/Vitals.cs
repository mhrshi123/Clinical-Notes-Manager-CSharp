namespace Vitals
{

    public interface IVital
    {
        string Type { get; }
        string Value { get; set; }
        string Status { get; }
        public string ToString();

    }

    public class BloodPressure : IVital
    {
        public string Type => "BP";

        public string Value { get; set; }

        public string Status
        {
            get
            {
                string[] values = Value.Split("/");
                var systolic = float.Parse(values[0]);
                var diastolic = float.Parse(values[1]);

                if (systolic < 90 && diastolic < 60) return "Low";
                if (systolic > 130 && systolic > 80) return "High";
                return "Normal";
            }
        }

        public string ToString()
        {
            return Type + ":" + Value + " mmHg (" + Status + ")";
        }
    }

    public class HeartRate : IVital
    {
        public string Type => "HR";

        public string Value { get; set; }

        public string Status
        {
            get
            {
                float hr = float.Parse(Value);

                if (hr < 60) return "Low";
                if (hr > 100) return "High";
                return "Normal";

            }
        }

        public string ToString()
        {
            return Type + ":" + Value + " bpm (" + Status + ")";
        }
    }

    public class Temperature : IVital
    {
        public string Type => "T";
        public string Value { get; set; }
        public string Status

        {
            get
            {
                float temp = float.Parse(Value);

                if (temp < 36.5 || temp > 37.2) return "Abnormal";

                return "Normal";

            }
        }

        public string ToString()
        {
            return Type + ":" + Value + " Celsius (" + Status + ")";
        }
    }
    public class RespiratoryRate : IVital
    {
        public string Type => "RR";

        public string Value { get; set; }

        public string Status
        {
            get
            {
                float respiratoryRate = float.Parse(Value);

                if (respiratoryRate < 12 || respiratoryRate > 16) return "Abnormal";

                return "Normal";

            }
        }

        public string ToString()
        {
            return Type + ":" + Value + "bpm (" + Status + ")";
        }
    }
}


