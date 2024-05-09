using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.Stock;
using backend.Models;

namespace backend.Mappers
{
    public static class StockMapper
    {
        public static StockDto ToStockDto(this Stock stockModel)
        {
            return new StockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Industry = stockModel.Industry,
                LastDiv = stockModel.LastDiv,
                MarketCap = stockModel.MarketCap,
                Purchase = stockModel.Purchase,
                Comments = stockModel.Comments.Select(c => c.ToCommentDto()).ToList()
            };
        }

        public static Stock ToStockFromCreateDTO(this CreateStockRequestDto stockRequestDto)
        {
            return new Stock
            {
                Symbol = stockRequestDto.Symbol,
                CompanyName = stockRequestDto.CompanyName,
                Industry = stockRequestDto.Industry,
                LastDiv = stockRequestDto.LastDiv,
                MarketCap = stockRequestDto.MarketCap,
                Purchase = stockRequestDto.Purchase,
            };
        }
    }
}