using Notes.Business.Abstract;
using Notes.DataAccess.Abstract;
using Notes.DataAccess.Concrete;
using Notes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Business.Concrete
{
    public class NoteManager : INoteService
    {
        private INoteRepository _noterepository;

        public NoteManager()
        {
            _noterepository = new NoteRepository();
        }

        public Note CreateNote(Note note)
        {
            return _noterepository.CreateNote(note);
        }

        public void DeleteNote(int id)
        {
            _noterepository.DeleteNote(id);
        }

        public List<Note> GetAllNotes()
        {
            return _noterepository.GetAllNotes();
        }

        public Note GetNoteById(int id)
        {
            return _noterepository.GetNoteById(id);
        }

        public Note UpdateNote(Note note)
        {
            throw new NotImplementedException();
        }
    }
}
