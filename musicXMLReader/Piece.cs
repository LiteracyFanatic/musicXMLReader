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
        public List<Part> PartList {get; set;}

        public Piece(string file)
        { 
            List<Part> partList = new List<Part>();

            XDocument doc = XDocument.Load(file);
            foreach (var partElement in doc.Descendants("part"))
            {
                partList.Add(new Part(file, partElement));
            }

            PartList = partList;
        }
    }
}
