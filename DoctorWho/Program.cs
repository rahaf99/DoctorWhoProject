
using DoctorWho;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var _context = new DoctorWhoCoreDbContext();

/*
var Companions = _context.Companions.Select(x=>_context.fnCompanions ).ToList();
Console.WriteLine(Companions);*/

var episods = _context.ViewEpisodes.ToList();
foreach(var e in episods)
{
    Console.WriteLine(e.AuthorName + "/" + e.Title + "/" + e.DoctorName + "/" + e.Companions + "/" + e.Enemies);
}
