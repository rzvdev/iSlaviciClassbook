using iSlavici.Models;
using System.Collections.Generic;

namespace iSlavici.Controls
{
    public interface IFiltrableNotes
    {
        List<NoteListModel> GetNoteList();
        void SetNoteList(List<NoteListModel> notes);
    }
}