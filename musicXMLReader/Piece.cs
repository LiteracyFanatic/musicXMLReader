using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace musicXMLReader
{
    class Piece
    {
        public List<Part> PartList { get; set; } = new List<Part>();

        public Piece()
        {

        }

        public static Piece Create(XDocument doc)
        {
            Piece _piece = new Piece();

            foreach (var partElement in doc.Descendants("part"))
            {
                _piece.PartList.Add(Part.Create(doc, partElement));
            }

            return _piece;
        }
    }
}
