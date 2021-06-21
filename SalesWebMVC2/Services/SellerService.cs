﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC2.Data;
using SalesWebMVC2.Models;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC2.Services.Exceptions;

namespace SalesWebMVC2.Services
{
    public class SellerService
    {
        private readonly SalesWebMVC2Context _context;

        public SellerService(SalesWebMVC2Context context)
        {
            _context = context;
        }
        public async Task<List<Seller>> FindAll()
        {
            return await _context.Seller.ToListAsync();
        }
        public async Task InsertAsync(Seller obj)
        {
            
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department)
                .FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task removeAsync(int id)
        {
            var obj = await _context.Seller.FindAsync(id);
            _context.Seller.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Seller obj)
        {
            if (!await _context.Seller.AnyAsync(x => x.Id == obj.Id))
            {
                throw new NotFoundException("ID Not Found");
            }
            try
            {
            _context.Update(obj);
            await _context.SaveChangesAsync();

            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

    }
}
