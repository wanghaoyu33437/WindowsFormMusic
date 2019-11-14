using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMusic
{
    class MusicMenu : Menu
    {
        public MusicMenu() { }
        public MusicMenu(string title, int playingIndex) : base(title)
        {
            this.playingIndex = playingIndex;
        }
        public int playingIndex
        {
            get;
            set;
        }
        public override int Show()
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine(Title);
            for (int i = 0; i < getItemSize(); i++)
            {

                if (CurrentItem == i)
                    Console.BackgroundColor = ConsoleColor.Blue;
                else
                    Console.BackgroundColor = ConsoleColor.Black;
                if (playingIndex == i)
                    Console.WriteLine("{0}、{1} --------------------正在播放中", getItemByIndex(i).Id, getItemByIndex(i).Name);
                else
                    Console.WriteLine("{0}、{1}", getItemByIndex(i).Id, getItemByIndex(i).Name);
            }

            Console.ResetColor();
            Console.WriteLine(this.Ano);

            Console.CursorVisible = false;
            return Action(Console.ReadKey(true).Key);

        }
    }
}
