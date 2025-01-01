using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormUtilities
{
    public class ClinicalNotesManager
    {
        public List<ClinicalNotes> ClinicalNotes { get; set; }

        string filePath = "encounter-notes.txt";

        const char DELIMITER = '|';

        public ClinicalNotesManager()
        {
            ClinicalNotes = new List<ClinicalNotes>();
        }

        public void AddClinicalNotes(ClinicalNotes clinicalNotes)
        {
            ClinicalNotes.Add(clinicalNotes);
        }

        public void LoadNotesFromFile()
        {

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length == 0)
                {
                    return;
                }
                string checkString = "";
                foreach (string line in lines)
                {
                    checkString += line;
                }

                if (checkString == null || checkString == string.Empty)
                {
                    return;
                }

                foreach (string line in lines)
                {
                    string[] fields = line.Split(DELIMITER);

                    if (fields.Length < 5)
                    {
                        Array.Resize(ref fields, 5);
                        fields[4] = "-";
                    }

                    ClinicalNotes note = new ClinicalNotes
                    {

                        NoteId = string.IsNullOrEmpty(fields[0]) ? 0 : int.Parse(fields[0]),
                        PatientName = fields[1],
                        DateOfBirth = !string.IsNullOrEmpty(fields[2]) ? DateTime.ParseExact(fields[2], "dddd, MMMM d, yyyy h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None) : DateTime.Now,
                        Problems = fields[3].Split(';').ToList(),
                        Note = fields[4].Replace(";;", "\n"),
                        Vitals = ExtractVitals(fields[4]) 
                    };



                    ClinicalNotes.Add(note);
                }
            }
            else
            {
                throw new FileNotFoundException($"The file {filePath} does not exist.");
            }
        }
        public void SaveNotesToFile()
        {
            List<string> lines = new List<string>();
            foreach (ClinicalNotes note in ClinicalNotes)
            {
                string line = $"{note.NoteId}|{note.PatientName}|{note.DateOfBirth.ToString("dddd, MMMM d, yyyy h:mm tt")}|{string.Join(";", note.Problems)}|{note.Note.Replace("\n", ";;")}";
                lines.Add(line);
            }
            File.WriteAllLines(filePath, lines);

        }

        public void UpdateClinicalNotes(int noteId, ClinicalNotes updatedClinicalNotes)
        {
            ClinicalNotes existingNote = ClinicalNotes.FirstOrDefault(n => n.NoteId == updatedClinicalNotes.NoteId);
            if (existingNote != null)
            {
                existingNote.PatientName = updatedClinicalNotes.PatientName;
                existingNote.DateOfBirth = updatedClinicalNotes.DateOfBirth;
                existingNote.Note = updatedClinicalNotes.Note;
                existingNote.Problems = updatedClinicalNotes.Problems;
                existingNote.Vitals = ExtractVitals(updatedClinicalNotes.Note);
            }
        }

        public void DeleteClinicalNotes(int noteId)
        {
            ClinicalNotes note = ClinicalNotes.FirstOrDefault(n => n.NoteId == noteId);
            if (note != null)
            {
                ClinicalNotes.Remove(note);
            }
        }

        public List<IVital> ExtractVitals(string noteContent)
        {
            List<IVital> vitals = new List<IVital>();

            var bpMatches = Regex.Matches(noteContent, @"BP:?\s(\d{2,3})/(\d{2,3})");
            foreach (Match match in bpMatches)
            {
                BloodPressure bp = new BloodPressure
                {
                    Value = $"{match.Groups[1].Value}/{match.Groups[2].Value}"
                };
                vitals.Add(bp);
            }

            var hrMatches = Regex.Matches(noteContent, @"HR:?\s(\d{2,3})");
            foreach (Match match in hrMatches)
            {
                HeartRate hr = new HeartRate
                {
                    Value = match.Groups[1].Value
                };
                vitals.Add(hr);
            }

            var tMatches = Regex.Matches(noteContent, @"T:?\s(\d{2,3}(?:\.\d+)?)");

            foreach (Match match in tMatches)
            {
                Temperature temp = new Temperature
                {
                    Value = match.Groups[1].Value
                };
                vitals.Add(temp);
            }

            var rrMatches = Regex.Matches(noteContent, @"RR:?\s(\d{2,3})");
            foreach (Match match in rrMatches)
            {
                var rr = new RespiratoryRate
                {
                    Value = match.Groups[1].Value
                };
                vitals.Add(rr);
            }

            return vitals;
        }
    }
}
