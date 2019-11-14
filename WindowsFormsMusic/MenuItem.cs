using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMusic
{
    delegate void ItemSelect(MenuItem item);

    class MenuItem
    {
        public MenuItem(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public MenuItem(int id, string name, ItemSelect select)
        {
            this.Id = id;
            this.Name = name;
            this.SelectEvent += select;
        }

        public event ItemSelect SelectEvent;

        public int Id
        {
            set;
            get;
        }
        public string Name
        {
            get;
            set;
        }

        public void Select()
        {
            if (null != SelectEvent)
                SelectEvent(this);
        }
    }
}
