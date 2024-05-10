using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be of 5 characters")]
        [MaxLength(200, ErrorMessage = "Title cannot be over 200 characters")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(5, ErrorMessage = "Content must be of 5 characters")]
        [MaxLength(200, ErrorMessage = "Content cannot be over 200 characters")]
        public string Content { get; set; } = string.Empty;
    }
}