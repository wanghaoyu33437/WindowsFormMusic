using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMusic
{
    class Menu
    {
        public Menu()
        {
            this.Ano = "上下箭头选择 Enter键确认";
            this.CurrentItem = -1;
        }
        public Menu(string title)
        {
            this.Title = title;
            this.Ano = "上下箭头选择 Enter键确认";
            this.CurrentItem = -1;
        }
        public string Title
        {
            get;
            set;
        }

        public string Ano
        {
            set;
            get;
        }

        public int CurrentItem
        {
            get;
            set;
        }

        List<MenuItem> items = new List<MenuItem>();

        public int getItemSize()
        {
            return items.Count;
        }

        public MenuItem getItemByIndex(int i)
        {
            return items[i];
        }


        //新增菜单项
        public bool addItem(MenuItem newItem)
        {
            foreach (MenuItem item in items)
            {
                if (item.Id == newItem.Id)
                    return false;
            }
            if (this.items.Count == 0)
                this.CurrentItem = 0;
            this.items.Add(newItem);
            return true;
        }

        //打印
        public virtual int Show()
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine(Title);

            for (int i = 0; i < items.Count; i++)
            {

                if (CurrentItem == i)
                    Console.BackgroundColor = ConsoleColor.Blue;
                else
                    Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("{0}、{1}", items[i].Id, items[i].Name);
            }

            Console.ResetColor();
            Console.WriteLine(this.Ano);

            Console.CursorVisible = false;
            return Action(Console.ReadKey(true).Key);
        }
        //处理键盘动作
        public int Action(ConsoleKey inputKey)
        {
            if (inputKey == ConsoleKey.UpArrow)
            {

                this.CurrentItem = (this.CurrentItem + this.items.Count - 1) % this.items.Count;
                this.Show();
                return -1;
            }
            else if (inputKey == ConsoleKey.DownArrow)
            {
                this.CurrentItem = (this.CurrentItem + 1) % this.items.Count;
                this.Show();
                return -1;
            }
            else if (inputKey == ConsoleKey.Enter)
            {
                items[this.CurrentItem].Select();
                return items[this.CurrentItem].Id;
            }

            this.Show();
            return -1;
        }
        //删除所有项
        public void Clear()
        {
            this.items.Clear();
        }
    }
}
