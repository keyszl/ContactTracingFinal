using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactTracing.Data;
using ContactTracing.Models;

namespace ContactTracing.Data
{
    public class DBInfoRepository
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public DBInfoRepository(ContactTracing.Data.ContactTracingContext context)
        {
            _context = context;
        }

        public async Task<Account> GetAccountByEmail(string userEmail)
        {
            var account = await _context.Accounts.Where(a =>
              a.Email.ToLower().Equals(userEmail.ToLower())).FirstOrDefaultAsync();
            return account;
        }
    }
}
