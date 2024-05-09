using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.Comment;
using backend.Models;

namespace backend.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                StockId = commentModel.StockId,
                Title = commentModel.Title,
            };
        }

        public static Comment ToCommentFromCreateDTO(this CreateCommentRequestDto commentRequestDto, int stockId)
        {
            return new Comment
            {
                Title = commentRequestDto.Title,
                Content = commentRequestDto.Content,
                StockId = stockId
            };
        }
    }
}