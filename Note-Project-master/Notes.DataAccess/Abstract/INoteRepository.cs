using Notes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.DataAccess.Abstract
{
    public interface INoteRepository
    {
        List<Note> GetAllNotes();
        Note GetNoteById(int id);
        Note CreateNote(Note note);

        void DeleteNote(int id);
    }
}
