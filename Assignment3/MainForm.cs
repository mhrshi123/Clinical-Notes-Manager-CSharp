using FormUtilities;
using System.Text;

namespace Assignment3_Pandya_Maharshi;

public partial class MainForm : Form
{

    private ClinicalNotesManager noteManager = new ClinicalNotesManager();
    StringBuilder errors = new StringBuilder();
    public MainForm()
    {

        InitializeComponent();

        noteManager.LoadNotesFromFile();

        AwaitingNoteMode();
        UpdateListBoxes();
    }
    private void UpdateListBoxes()
    {

        listBoxNotes.Items.Clear();
        foreach (ClinicalNotes note in noteManager.ClinicalNotes)
        {
            listBoxNotes.Items.Add($"{note.PatientName}(Note: {note.NoteId})");
        }
    }

    private void buttonAddNote_Click(object sender, EventArgs e)
    {
        Validations();
        if (errors.Length > 0)
        {
            labelMessage.Text = errors.ToString();
            return;
        }

        AddNoteMode();

        var note = new ClinicalNotes
        {
            NoteId = int.Parse(textBoxNoteID.Text),
            PatientName = textBoxPatientName.Text,
            DateOfBirth = dateTimePickerDateOfBirth.Value,
            Note = richTextBoxNotes.Text,
            Problems = listBoxProblems.Items.Cast<string>().ToList(),
            Vitals = noteManager.ExtractVitals(richTextBoxNotes.Text)
        };

        noteManager.AddClinicalNotes(note);
        noteManager.SaveNotesToFile();
        UpdateListBoxes();
        labelMessage.Text = $"{textBoxPatientName.Text} has been added successfully.";
        ClearFormFields();

    }

    private void buttonUpdateNote_Click(object sender, EventArgs e)
    {
        Validations();
        if (errors.Length > 0)
        {
            labelMessage.Text = errors.ToString();
            return;
        }
        EditNoteMode();
       
        noteManager.UpdateClinicalNotes(int.Parse(textBoxNoteID.Text), new ClinicalNotes
        {
            NoteId = int.Parse(textBoxNoteID.Text),
            PatientName = textBoxPatientName.Text,
            DateOfBirth = dateTimePickerDateOfBirth.Value,
            Note = richTextBoxNotes.Text,
            Problems = listBoxProblems.Items.Cast<string>().ToList(),
            Vitals = noteManager.ExtractVitals(richTextBoxNotes.Text)
        });
        noteManager.SaveNotesToFile();
        UpdateListBoxes();


        var updateNotes = noteManager.ClinicalNotes.FirstOrDefault(note => note.NoteId == int.Parse(textBoxNoteID.Text));

        if (updateNotes != null)
        {
            foreach (var vital in updateNotes.Vitals)
            {
                listBoxVitals.Items.Add(vital.ToString());
            }
        }

        ClearFormFields();
        AwaitingNoteMode();

        labelMessage.Text = "Updates made successfully";
    }

    private void buttonDeleteNote_Click(object sender, EventArgs e)
    {

        Validations();
        if (errors.Length > 0)
        {
            labelMessage.Text = errors.ToString();
            return;
        }
        noteManager.DeleteClinicalNotes(int.Parse(textBoxNoteID.Text));
        noteManager.SaveNotesToFile();
        UpdateListBoxes();
        ClearFormFields();
        AwaitingNoteMode();

        labelMessage.Text = "Record has been deleted successfully";


    }

    private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBoxNotes.SelectedIndex != -1)
        {
            EditNoteMode();
            ClinicalNotes noteItem = noteManager.ClinicalNotes[listBoxNotes.SelectedIndex];
            textBoxNoteID.Text = noteItem.NoteId.ToString();
            textBoxPatientName.Text = noteItem.PatientName;
            dateTimePickerDateOfBirth.Text = noteItem.DateOfBirth.ToString("dd MMM yyyy");
            richTextBoxNotes.Text = noteItem.Note;

            listBoxProblems.Items.Clear();

            if (noteItem.Problems.Any())
            {
                if (!string.IsNullOrEmpty(noteItem.Problems[0]))
                {
                    foreach (var problem in noteItem.Problems)
                    {
                        listBoxProblems.Items.Add(problem);
                    }

                }


            }

            textBoxNewProblem.Clear();

            listBoxVitals.Items.Clear();

            foreach (var vital in noteItem.Vitals)
            {
                listBoxVitals.Items.Add(vital.ToString());
            }
        }

    }

    private void buttonStartNewNode_Click(object sender, EventArgs e)
    {
        AddNoteMode();

        int noteId;

        if (noteManager.ClinicalNotes.Count > 0)
        {
            noteId = noteManager.ClinicalNotes.Max(n => n.NoteId) + 1;
        }
        else
        {
            noteId = 1;
        }

        textBoxNoteID.Text = noteId.ToString();

        textBoxPatientName.Text = "";
        dateTimePickerDateOfBirth.Value = DateTime.Now;
        richTextBoxNotes.Text = "";
        textBoxNewProblem.Text = "";
        listBoxProblems.Items.Clear();
        listBoxVitals.Items.Clear();
        listBoxNotes.SelectedIndex = -1;

    }

    public void ClearFormFields()
    {
        textBoxNoteID.Clear();
        textBoxPatientName.Clear();
        dateTimePickerDateOfBirth.Value = DateTime.Now;
        textBoxNewProblem.Clear();
        richTextBoxNotes.Clear();
        listBoxNotes.SelectedIndex = -1;
        listBoxVitals.Items.Clear();
        listBoxProblems.Items.Clear();

    }

    public void AwaitingNoteMode()
    {
        buttonDeleteNote.Enabled = false;
        buttonAddNote.Enabled = false;
        buttonUpdateNote.Enabled = false;
        groupBoxEncounterNote.Enabled = false;
    }

    public void AddNoteMode()
    {
        groupBoxEncounterNote.Enabled = true;
        buttonAddNote.Enabled = true;
        buttonUpdateNote.Enabled = false;
        buttonDeleteNote.Enabled = false;
    }

    public void EditNoteMode()
    {
        groupBoxEncounterNote.Enabled = true;
        buttonAddNote.Enabled = false;
        buttonUpdateNote.Enabled = true;
        buttonDeleteNote.Enabled = true;
    }

    public void Validations()
    {
        errors.Clear();

        if (string.IsNullOrEmpty(textBoxPatientName.Text))
        {
            errors.AppendLine("Patient Name is required.");
        }

        if (dateTimePickerDateOfBirth.Value == DateTime.MinValue)
        {
            errors.AppendLine("Date of Birth is required.");
        }
        if (dateTimePickerDateOfBirth.Value > DateTime.Now)
        {
            errors.AppendLine("Date of Birth cannot be in the future.");
        }

        if (string.IsNullOrEmpty(richTextBoxNotes.Text))
        {
            errors.AppendLine("Clinical note content is required.");
        }
    }

    private void buttonAddNewProblem_Click(object sender, EventArgs e)
    {
        errors.Clear();
        if (string.IsNullOrEmpty(textBoxNewProblem.Text))
        {
            errors.AppendLine("Please enter a problem to add first!");
            labelMessage.Text = errors.ToString();
            return;
        }
     

        listBoxProblems.Items.Add(textBoxNewProblem.Text);

      
        textBoxNewProblem.Clear();
        
    }

    private void buttonRemoveProblem_Click(object sender, EventArgs e)
    {
        errors.Clear();
        if (listBoxProblems.SelectedIndex == -1)
        {
            errors.AppendLine("Please select a problem in the listbox to remove.");
            labelMessage.Text = errors.ToString();
            return;
        }
      
        listBoxProblems.Items.Remove(listBoxProblems.SelectedItem);

    }

    private void richTextBoxNotes_TextChanged(object sender, EventArgs e)
    {
        listBoxVitals.Items.Clear();
        
        foreach (var vital in noteManager.ExtractVitals(richTextBoxNotes.Text))
        {
            listBoxVitals.Items.Add(vital.ToString());
        }
    }
}
