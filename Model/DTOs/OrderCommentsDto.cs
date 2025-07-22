using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adarec_ui.Model.DTOs
{
    public class OrderCommentsDto
    {
        public int? OrderId { get; set; }
        public string? OrderDescription { get; set; }
        public List<CommentDetailDto> Comments { get; set; } = [];
    }
}
