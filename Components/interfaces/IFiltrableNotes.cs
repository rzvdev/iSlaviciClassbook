using iSlavici.Models;
using System.Collections.Generic;

namespace iSlavici.Controls
{
    public interface IFiltrableNotes
    {
        List<NoteListModel> GetNoteList();

        List<NoteOneStudentListModel> GetOneStudentNoteList();
        void SetNoteList(List<NoteListModel> notes);

        void SetOneStudentNoteList(List<NoteOneStudentListModel> notes);


    }
}