using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesScriptureJournal.Data;
using RazorPagesScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPagesScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesScriptureJournal.Data.RazorPagesScriptureJournalContext _context;

        public IndexModel(RazorPagesScriptureJournal.Data.RazorPagesScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }
        [BindProperty(SupportsGet = true)]
        public string ReferenceSearch { get; set; }
        [BindProperty(SupportsGet = true)]
        public string NoteSearch { get; set; }

        public async Task OnGetAsync()
        {

            var scriptures = from m in _context.Scripture
                         select m;
            if (!string.IsNullOrEmpty(ReferenceSearch))
            {
                scriptures = scriptures.Where(s => s.Reference.Contains(ReferenceSearch));
            }
            else if (!string.IsNullOrEmpty(NoteSearch))
            {
                scriptures = scriptures.Where(s => s.Note.Contains(NoteSearch));

            }

            Scripture = await scriptures.ToListAsync();
        }
    }
}
