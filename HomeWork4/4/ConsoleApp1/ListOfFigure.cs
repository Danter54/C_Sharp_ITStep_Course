using ConsoleApp1.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ListOfFigure
    {

        private List<Figure> _list;

        public ListOfFigure()
        {
            _list = new List<Figure>();
        }

        public ListOfFigure(Figure[] figures)
        {
            _list = new List<Figure>();

            foreach (var figure in figures)
            {
                _list.Add(figure);
            }
        }

        public ListOfFigure(Figure figure)
        {
            _list = new List<Figure> { figure };
        }

        public int GetLength() => _list.Count();
        public Figure GetObject(int i) => _list[i];


        public void AddFigure(Figure figure)
        {
            if (_list == null)
            {
                _list = new List<Figure>();
                _list.Add(figure);
            }
            else _list.Add(figure);
        }

        public void RemoveFigure(Figure figure)
        {
            if (_list == null)
            {
                Console.WriteLine("List is null!!!");
            }
            else _list.Remove(figure);
        }
    }

}
