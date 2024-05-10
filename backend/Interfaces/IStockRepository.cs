using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.Stock;
using backend.Helpers;
using backend.Models;

namespace backend.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync(QueryObject query);
        Task<Stock> GetByIdAsync(int id);
        Task<Stock> CreateAsync(Stock stockModel);
        Task<Stock> UpdateAsync(int id, UpdateStockRequestDto stockRequestDto);
        Task<Stock> DeleteAsync(int id);
        Task<bool> StockExists(int id);
    }
}