using Notes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Business.Abstract
{
    public interface INoteService
    {
        List<Note> GetAllNotes();
        Note GetNoteById(int id);
        Note CreateNote(Note note);
        Note UpdateNote(Note note);
        void DeleteNote(int id);
    }
}
