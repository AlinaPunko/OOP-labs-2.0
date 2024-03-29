﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._1
{

        class Channel // настройки канала
        {
            public int Id { get; set; }
            public string Title { get; set; } //название канала
            public string Description { get; set; } //описание канала
            public string Link { get; set; } //ссылка на канал
            public string Copyright { get; set; } //копирайт


            public virtual ICollection<Item> Items { get; set; }

            public Channel()
            {
                Items = new List<Item>();
            }
            public override string ToString()
            {
                return Title;
            }

        }
    

}
