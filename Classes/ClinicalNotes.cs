namespace Classes
{
    public class ClinicalNotes
    {
        public ClinicalNotes() { }//default constructor
       
        public int NoteId { get; set; } 
        public string PatientName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Note { get; set; }

        public List<string> Problems { get; set; }

        public List<IVital> Vitals { get; set; }


        public override string ToString()
        {
            return PatientName + "(" + NoteId +")";
        }
    }
}
