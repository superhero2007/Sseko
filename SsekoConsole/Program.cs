using Microsoft.EntityFrameworkCore;
using Sseko.Data;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SsekoConsole
{
    class Program
    {
        static SsekoContext _context;

        static void Main(string[] args)
        {
            _context = new SsekoContext();

            Task.Run(Run).Wait();

            Debugger.Break();
        }

        private static async Task<bool> Run()
        {
            try
            {
                var data = await _context.AffiliateplusAccount.ToListAsync().ConfigureAwait(false);

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