namespace Assignment3_Pandya_Maharshi;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }


    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        buttonStartNewNote = new Button();
        listBoxNotes = new ListBox();
        groupBoxEncounterNote = new GroupBox();
        listBoxVitals = new ListBox();
        buttonDeleteNote = new Button();
        buttonUpdateNote = new Button();
        buttonAddNote = new Button();
        label7 = new Label();
        richTextBoxNotes = new RichTextBox();
        label6 = new Label();
        label5 = new Label();
        buttonRemoveProblem = new Button();
        listBoxProblems = new ListBox();
        buttonAddNewProblem = new Button();
        textBoxNewProblem = new TextBox();
        dateTimePickerDateOfBirth = new DateTimePicker();
        textBoxPatientName = new TextBox();
        textBoxNoteID = new TextBox();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        labelMessage = new Label();
        groupBoxEncounterNote.SuspendLayout();
        SuspendLayout();
        // 
        // buttonStartNewNote
        // 
        buttonStartNewNote.BackColor = Color.CornflowerBlue;
        buttonStartNewNote.Location = new Point(51, 35);
        buttonStartNewNote.Margin = new Padding(4, 5, 4, 5);
        buttonStartNewNote.Name = "buttonStartNewNote";
        buttonStartNewNote.Size = new Size(165, 36);
        buttonStartNewNote.TabIndex = 0;
        buttonStartNewNote.Text = "Start new note";
        buttonStartNewNote.UseVisualStyleBackColor = false;
        buttonStartNewNote.Click += buttonStartNewNode_Click;
        // 
        // listBoxNotes
        // 
        listBoxNotes.BackColor = Color.Snow;
        listBoxNotes.FormattingEnabled = true;
        listBoxNotes.ItemHeight = 25;
        listBoxNotes.Location = new Point(51, 99);
        listBoxNotes.Margin = new Padding(4, 5, 4, 5);
        listBoxNotes.Name = "listBoxNotes";
        listBoxNotes.Size = new Size(238, 529);
        listBoxNotes.TabIndex = 1;
        listBoxNotes.SelectedIndexChanged += listBoxNotes_SelectedIndexChanged;
        // 
        // groupBoxEncounterNote
        // 
        groupBoxEncounterNote.BackColor = Color.LightGray;
        groupBoxEncounterNote.Controls.Add(listBoxVitals);
        groupBoxEncounterNote.Controls.Add(buttonDeleteNote);
        groupBoxEncounterNote.Controls.Add(buttonUpdateNote);
        groupBoxEncounterNote.Controls.Add(buttonAddNote);
        groupBoxEncounterNote.Controls.Add(label7);
        groupBoxEncounterNote.Controls.Add(richTextBoxNotes);
        groupBoxEncounterNote.Controls.Add(label6);
        groupBoxEncounterNote.Controls.Add(label5);
        groupBoxEncounterNote.Controls.Add(buttonRemoveProblem);
        groupBoxEncounterNote.Controls.Add(listBoxProblems);
        groupBoxEncounterNote.Controls.Add(buttonAddNewProblem);
        groupBoxEncounterNote.Controls.Add(textBoxNewProblem);
        groupBoxEncounterNote.Controls.Add(dateTimePickerDateOfBirth);
        groupBoxEncounterNote.Controls.Add(textBoxPatientName);
        groupBoxEncounterNote.Controls.Add(textBoxNoteID);
        groupBoxEncounterNote.Controls.Add(label4);
        groupBoxEncounterNote.Controls.Add(label3);
        groupBoxEncounterNote.Controls.Add(label2);
        groupBoxEncounterNote.Controls.Add(label1);
        groupBoxEncounterNote.Location = new Point(342, 15);
        groupBoxEncounterNote.Margin = new Padding(4, 5, 4, 5);
        groupBoxEncounterNote.Name = "groupBoxEncounterNote";
        groupBoxEncounterNote.Padding = new Padding(4, 5, 4, 5);
        groupBoxEncounterNote.Size = new Size(1082, 664);
        groupBoxEncounterNote.TabIndex = 2;
        groupBoxEncounterNote.TabStop = false;
        groupBoxEncounterNote.Text = "Add/Edit/Delet Encounter Note:";
        // 
        // listBoxVitals
        // 
        listBoxVitals.BackColor = Color.Snow;
        listBoxVitals.FormattingEnabled = true;
        listBoxVitals.ItemHeight = 25;
        listBoxVitals.Location = new Point(794, 80);
        listBoxVitals.Margin = new Padding(4, 5, 4, 5);
        listBoxVitals.Name = "listBoxVitals";
        listBoxVitals.Size = new Size(258, 254);
        listBoxVitals.TabIndex = 19;
        // 
        // buttonDeleteNote
        // 
        buttonDeleteNote.BackColor = Color.Salmon;
        buttonDeleteNote.Location = new Point(371, 611);
        buttonDeleteNote.Margin = new Padding(4, 5, 4, 5);
        buttonDeleteNote.Name = "buttonDeleteNote";
        buttonDeleteNote.Size = new Size(149, 36);
        buttonDeleteNote.TabIndex = 18;
        buttonDeleteNote.Text = "Delete Note";
        buttonDeleteNote.UseVisualStyleBackColor = false;
        buttonDeleteNote.Click += buttonDeleteNote_Click;
        // 
        // buttonUpdateNote
        // 
        buttonUpdateNote.BackColor = Color.YellowGreen;
        buttonUpdateNote.Location = new Point(206, 611);
        buttonUpdateNote.Margin = new Padding(4, 5, 4, 5);
        buttonUpdateNote.Name = "buttonUpdateNote";
        buttonUpdateNote.Size = new Size(149, 36);
        buttonUpdateNote.TabIndex = 17;
        buttonUpdateNote.Text = "Update note";
        buttonUpdateNote.UseVisualStyleBackColor = false;
        buttonUpdateNote.UseWaitCursor = true;
        buttonUpdateNote.Click += buttonUpdateNote_Click;
        // 
        // buttonAddNote
        // 
        buttonAddNote.BackColor = Color.YellowGreen;
        buttonAddNote.Location = new Point(41, 611);
        buttonAddNote.Margin = new Padding(4, 5, 4, 5);
        buttonAddNote.Name = "buttonAddNote";
        buttonAddNote.Size = new Size(149, 36);
        buttonAddNote.TabIndex = 16;
        buttonAddNote.Text = "Add note";
        buttonAddNote.UseVisualStyleBackColor = false;
        buttonAddNote.Click += buttonAddNote_Click;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(41, 340);
        label7.Margin = new Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new Size(63, 25);
        label7.TabIndex = 15;
        label7.Text = "Notes:";
        // 
        // richTextBoxNotes
        // 
        richTextBoxNotes.BackColor = Color.Snow;
        richTextBoxNotes.Location = new Point(41, 369);
        richTextBoxNotes.Margin = new Padding(4, 5, 4, 5);
        richTextBoxNotes.Name = "richTextBoxNotes";
        richTextBoxNotes.Size = new Size(1010, 206);
        richTextBoxNotes.TabIndex = 14;
        richTextBoxNotes.Text = "";
        richTextBoxNotes.TextChanged += richTextBoxNotes_TextChanged;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(784, 44);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(54, 25);
        label6.TabIndex = 13;
        label6.Text = "Vitals";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(588, 45);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(87, 25);
        label5.TabIndex = 12;
        label5.Text = "Problems";
        // 
        // buttonRemoveProblem
        // 
        buttonRemoveProblem.BackColor = Color.Salmon;
        buttonRemoveProblem.Location = new Point(588, 308);
        buttonRemoveProblem.Margin = new Padding(4, 5, 4, 5);
        buttonRemoveProblem.Name = "buttonRemoveProblem";
        buttonRemoveProblem.Size = new Size(168, 36);
        buttonRemoveProblem.TabIndex = 10;
        buttonRemoveProblem.Text = "Remove Problem";
        buttonRemoveProblem.UseVisualStyleBackColor = false;
        buttonRemoveProblem.Click += buttonRemoveProblem_Click;
        // 
        // listBoxProblems
        // 
        listBoxProblems.BackColor = Color.Snow;
        listBoxProblems.FormattingEnabled = true;
        listBoxProblems.ItemHeight = 25;
        listBoxProblems.Location = new Point(589, 80);
        listBoxProblems.Margin = new Padding(4, 5, 4, 5);
        listBoxProblems.Name = "listBoxProblems";
        listBoxProblems.Size = new Size(175, 204);
        listBoxProblems.TabIndex = 9;
        // 
        // buttonAddNewProblem
        // 
        buttonAddNewProblem.BackColor = Color.YellowGreen;
        buttonAddNewProblem.Location = new Point(450, 228);
        buttonAddNewProblem.Margin = new Padding(4, 5, 4, 5);
        buttonAddNewProblem.Name = "buttonAddNewProblem";
        buttonAddNewProblem.Size = new Size(74, 36);
        buttonAddNewProblem.TabIndex = 8;
        buttonAddNewProblem.Text = "Add";
        buttonAddNewProblem.UseVisualStyleBackColor = false;
        buttonAddNewProblem.Click += buttonAddNewProblem_Click;
        // 
        // textBoxNewProblem
        // 
        textBoxNewProblem.Location = new Point(161, 228);
        textBoxNewProblem.Margin = new Padding(4, 5, 4, 5);
        textBoxNewProblem.Name = "textBoxNewProblem";
        textBoxNewProblem.Size = new Size(264, 31);
        textBoxNewProblem.TabIndex = 7;
        // 
        // dateTimePickerDateOfBirth
        // 
        dateTimePickerDateOfBirth.Format = DateTimePickerFormat.Short;
        dateTimePickerDateOfBirth.Location = new Point(161, 169);
        dateTimePickerDateOfBirth.Margin = new Padding(4, 5, 4, 5);
        dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
        dateTimePickerDateOfBirth.Size = new Size(145, 31);
        dateTimePickerDateOfBirth.TabIndex = 6;
        // 
        // textBoxPatientName
        // 
        textBoxPatientName.Location = new Point(161, 110);
        textBoxPatientName.Margin = new Padding(4, 5, 4, 5);
        textBoxPatientName.Name = "textBoxPatientName";
        textBoxPatientName.Size = new Size(344, 31);
        textBoxPatientName.TabIndex = 5;
        // 
        // textBoxNoteID
        // 
        textBoxNoteID.Location = new Point(161, 51);
        textBoxNoteID.Margin = new Padding(4, 5, 4, 5);
        textBoxNoteID.Name = "textBoxNoteID";
        textBoxNoteID.ReadOnly = true;
        textBoxNoteID.Size = new Size(155, 31);
        textBoxNoteID.TabIndex = 4;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(20, 239);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(124, 25);
        label4.TabIndex = 3;
        label4.Text = "New problem:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(28, 178);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(116, 25);
        label3.TabIndex = 2;
        label3.Text = "Date of Birth:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(26, 114);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(119, 25);
        label2.TabIndex = 1;
        label2.Text = "Patient name:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(69, 60);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(78, 25);
        label1.TabIndex = 0;
        label1.Text = "Note ID:";
        // 
        // labelMessage
        // 
        labelMessage.AutoSize = true;
        labelMessage.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        labelMessage.ForeColor = Color.Red;
        labelMessage.Location = new Point(64, 714);
        labelMessage.Margin = new Padding(4, 0, 4, 0);
        labelMessage.MinimumSize = new Size(225, 62);
        labelMessage.Name = "labelMessage";
        labelMessage.Size = new Size(225, 62);
        labelMessage.TabIndex = 3;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(224, 224, 224);
        ClientSize = new Size(1440, 838);
        Controls.Add(labelMessage);
        Controls.Add(groupBoxEncounterNote);
        Controls.Add(listBoxNotes);
        Controls.Add(buttonStartNewNote);
        Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4, 5, 4, 5);
        Name = "MainForm";
        Text = "Assignment 3: ";
        groupBoxEncounterNote.ResumeLayout(false);
        groupBoxEncounterNote.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonStartNewNote;
    private ListBox listBoxNotes;
    private GroupBox groupBoxEncounterNote;
    private DateTimePicker dateTimePickerDateOfBirth;
    private TextBox textBoxPatientName;
    private TextBox textBoxNoteID;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private Button buttonAddNewProblem;
    private TextBox textBoxNewProblem;
    private Button buttonRemoveProblem;
    private ListBox listBoxProblems;
    private Label label7;
    private RichTextBox richTextBoxNotes;
    private Label label6;
    private Label label5;
    private Label labelMessage;
    private Button buttonDeleteNote;
    private Button buttonUpdateNote;
    private Button buttonAddNote;
    private ListBox listBoxVitals;
}
