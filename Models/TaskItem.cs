using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSKhromushinV2.Models
{
    public class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; } // 1 — высокий, 2 — средний, 3 — низкий
        public bool IsCompleted { get; set; }
    }
}
