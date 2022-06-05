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

        // Sorting
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public string DateSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {


            /*** NEW CODE ***/

            // Sorting
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            Console.WriteLine(sortOrder);

            IQueryable<Scripture> scripturesIQ = from m in _context.Scripture
                                                 select m;

            scripturesIQ = scripturesIQ.OrderBy(s => s.EntryDate);

            switch (sortOrder)
            {
                case "Date":
                    scripturesIQ = scripturesIQ.OrderBy(s => s.EntryDate);
                    break;

                case "date_desc":
                    scripturesIQ = scripturesIQ.OrderByDescending(s => s.EntryDate);
                    break;

                default:
                    
                    break;
            }

            Scripture = await scripturesIQ.AsNoTracking().ToListAsync();




            // Filtering
            var scriptures = from m in _context.Scripture
                             select m;
            if (!string.IsNullOrEmpty(ReferenceSearch))
            {
                scriptures = scriptures.Where(s => s.Reference.Contains(ReferenceSearch));
                Scripture = await scriptures.ToListAsync();
            }
            else if (!string.IsNullOrEmpty(NoteSearch))
            {
                scriptures = scriptures.Where(s => s.Note.Contains(NoteSearch));
                Scripture = await scriptures.ToListAsync();
            }

            









            ///*** OLD CODE ****/

            //Console.WriteLine("Date Sort: " + DateSort);
            //Console.WriteLine("Reference Search: " + ReferenceSearch);


            //if (!string.IsNullOrEmpty(DateSort))
            //{
            //    Console.WriteLine("Sorting");
            //    Console.WriteLine(DateSort);

            //    // We are sorting
            //    DateSort = sortOrder == "Date" ? "date_desc" : "Date";


            //    IQueryable<Scripture> scripturesIQ = from m in _context.Scripture
            //                                         select m;

            //    scripturesIQ = scripturesIQ.OrderBy(s => s.EntryDate);

            //    //switch (sortOrder)
            //    //{
            //    //    case "Date":
            //    //        scripturesIQ = scripturesIQ.OrderBy(s => s.EntryDate);
            //    //        break;
            //    //}

            //    Scripture = await scripturesIQ.AsNoTracking().ToListAsync();

            //}
            //else
            //{
            //    Console.WriteLine("Filtering");
            //    // We are filtering
            //    var scriptures = from m in _context.Scripture
            //                     select m;
            //    if (!string.IsNullOrEmpty(ReferenceSearch))
            //    {
            //        scriptures = scriptures.Where(s => s.Reference.Contains(ReferenceSearch));
            //    }
            //    else if (!string.IsNullOrEmpty(NoteSearch))
            //    {
            //        scriptures = scriptures.Where(s => s.Note.Contains(NoteSearch));

            //    }

            //    Scripture = await scriptures.ToListAsync();
            //}

        }
    }
}
