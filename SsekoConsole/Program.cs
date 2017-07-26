using Microsoft.EntityFrameworkCore;
using Sseko.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SsekoConsole
{
    class Program
    {
        static SsekoContext context;

        static void Main(string[] args)
        {
            //context = new SsekoContext();

            //Task.Run(() => Run()).Wait();

            //Debugger.Break();
        }

        private static async Task<bool> Run()
        {
            try
            {
                var data = await context.AffiliateplusAccount.ToListAsync().ConfigureAwait(false);

                Debugger.Break();

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}