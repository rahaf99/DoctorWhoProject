using Dapper;
using DoctorWho;
using DoctorWho.Db.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

internal class Program
{
    public static DoctorWhoCoreDbContext _context;
    private static void Main(string[] args)
    {
        _context = new DoctorWhoCoreDbContext();
        //SummariseEpisodes();

        /*
        var Companions = _context.Companions.Select(x=>_context.fnCompanions ).ToList();
        Console.WriteLine(Companions);*/


        //func
        //string getCompanions(int EpisodeId)
        //  => throw new NotSupportedException();

        //var query1 = _context.Database.ExecuteSqlRaw(" select [dbo].[fnCompanions](1);");
        //Console.WriteLine(query1);

        //createAuthor("Author6");
        //updateAuthor(6, "6*");
        //deleteAuthor(6);
        GetAllDoctors();
        GetEnemyById(2);
        GetCompanionById(2);
    }
    string getEnemies(int EpisodeId)
    {
        string Enemies = null;

        return Enemies;
    }
    //view
    void getEpisodes()
    {
        var episods = _context.ViewEpisodes.ToList();
        foreach (var e in episods)
        {
            Console.WriteLine(e.AuthorName + "/" + e.Title + "/" + e.DoctorName + "/" + e.Companions + "/" + e.Enemies);
        }
    }
    //proc
    void SummariseEpisodes()
    {
        /*
        var output = _context.ComEpoFav.FromSql($"[dbo].[spSummariseEpisodes]").ToList();
        var output1 = _context.Database.GetDbConnection().QueryMultiple($"[dbo].[spSummariseEpisodes]", new DynamicParameters(), commandType : CommandType.StoredProcedure);

        var yy = output1.Read<string>().ToList();
        var zz = output1.Read<string>().ToList();

        var output3 = _context.Database.executesql($"[dbo].[spSummariseEpisodes]").ToList();
        */
        object output1 = _context.Database.ExecuteSqlRaw("exec spSummariseEpisodes;");

        Console.WriteLine(output1.ToString());
        /*
        //var tt = _context.Set<string>().FromSqlInterpolated($"EXEC spSummariseEpisodes;");

        //var dbTransaction = _context.Database.CurrentTransaction.GetDbTransaction();

        //using (SqlMapper.)
            //Console.WriteLine(tt.ToString());
            /* var rowsModified = _context.Database.ExecuteSql($"exec dbo.spSummariseEpisodes");
            foreach (var row in rowsModified)
            {
                Console.WriteLine(row);
            }

        */


    }




}






