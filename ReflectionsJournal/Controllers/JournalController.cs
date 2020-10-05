using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReflectionsJournal.Models;
using ReflectionsJournal.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;

namespace ReflectionsJournal.Controllers
{
    public class JournalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JournalController(ApplicationDbContext context)
        {
            _context = context;
        }
        
 // action to view all journal entries
        [Authorize(Roles = "admin, user")]
        public IActionResult viewAll()
        {
            return View(_context);

        }
        
        // action to view entry details from list
        [Authorize(Roles = "admin, user")]
         public IActionResult entryDetails(int entryID)
        {
            EntryModel matchingEntry = _context.entries.FirstOrDefault(e => e.id == entryID);

            if(matchingEntry != null)
            {
                return View(matchingEntry);
            }
                else
                {
                    return Content("No Matching Entry Found!");
                }
        }

        // action to create a new journal entry
        [HttpPost]
        [Authorize(Roles = "admin, user")]
        public IActionResult addEntry(EntryModel newEntry)
        {
            if(ModelState.IsValid)
            {
                _context.entries.Add(newEntry);
                _context.SaveChanges();
                return RedirectToAction("viewAll", "Journal");
            }
                else
                {
                    return View("addEntryForm", newEntry);
                }

        }

        // acction that pulls up the form to create a new entry
        [Authorize(Roles = "admin, user")]
        public IActionResult addEntryForm()
        {
            return View();
        }

        // action to edit an entry
        [HttpPost]
        [Authorize(Roles = "admin, user")]
         public IActionResult editEntry(EntryModel editEntry)
        {
            EntryModel matchingEntry = _context.entries.FirstOrDefault(e => e.id == editEntry.id);

            if(matchingEntry != null)
            {
                if(ModelState.IsValid)
                {
                    matchingEntry.entryDate = editEntry.entryDate;
                    matchingEntry.entryText = editEntry.entryText;
                    matchingEntry.confidenceLevel = editEntry.confidenceLevel;
                    
                    _context.SaveChanges();

                    return RedirectToAction("viewAll", "Journal");

                }
                    else
                    {
                        return View("editEntryForm", matchingEntry);
                    }
            }
                else
                {
                    return Content("No Matching Entry Found");
                }
        }

        // edit form  
        [Authorize(Roles = "admin, user")]
         public IActionResult editEntryForm(int entryID)
        {
            EntryModel matchingEntry = _context.entries.FirstOrDefault(e => e.id == entryID);

            if(matchingEntry != null)
            {
                return View(matchingEntry);
            }
                else
                {
                    return Content("No Match Found");
                }
        }

         [Authorize(Roles = "admin, user")]
        public IActionResult deleteEntry(int entryID)
        {
            EntryModel thisEntry = _context.entries.FirstOrDefault(e => e.id == entryID);

            if(thisEntry != null)
            {
                _context.Remove(thisEntry);
                _context.SaveChanges();

                return RedirectToAction("viewAll", "Journal");
            }
                else
                {
                    return Content("No Mathcing Entry Found");
                }
        }
        [Authorize(Roles = "admin, user")]
        public IActionResult deleteConf(int entryID)
        {            
            // find entry by id
            EntryModel matchingEntry = _context.entries.FirstOrDefault(e => e.id == entryID);
            // if GameModel is found
            if(matchingEntry != null)
            {
                return View(matchingEntry);
            } 
                else 
                {
                    return Content($"No entry found for entry id {entryID}");
                }
        }
    }

}