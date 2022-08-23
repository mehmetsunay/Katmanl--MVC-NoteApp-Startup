using Notes.DataAccess.Abstract;
using Notes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.DataAccess.Concrete
{
    public class NoteRepository : INoteRepository
    {
        public Note CreateNote(Note note)
        {
            using (var noteDbContext = new NotesDbContext())
            {
                noteDbContext.Notes.Add(note);
                noteDbContext.SaveChanges();
                return note;
            }
        }

        public void DeleteNote(int id)
        {
            using (var noteDbContext = new NotesDbContext())
            {
                var deletenote = GetNoteById(id);
                noteDbContext.Notes.Remove(deletenote);
                noteDbContext.SaveChanges();
            }
        }

        public List<Note> GetAllNotes()
        {
            using(var noteDbContext = new NotesDbContext())
            {
                return noteDbContext.Notes.ToList();
            }
        }

        public Note GetNoteById(int id)
        {
            using(var noteDbContext = new NotesDbContext())
            {
                return noteDbContext.Notes.Find(id);
            }
        }

        
    }
}
