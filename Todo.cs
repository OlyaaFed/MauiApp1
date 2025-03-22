using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class Todo
    {
        public string Name { get; set; }
        public string Frequency { get; set; }
        public string Description { get; set; }
        public DateTime LastCompleted { get; set; }

    }
}
