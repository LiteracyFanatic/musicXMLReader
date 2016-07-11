using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace musicXMLReader
{
    class Part
    {
        public List<string> Notes { get; set; }
        public List<int> Durations { get; set; }
        public int Division { get; set; }
        public int Tempo { get; set; }

        public string ID { get; set; }
        public string Name { get; set; }

        public string Raw { get; set; }

        public override string ToString()
        {
            return "const unsigned int " + Name.ToLower().Split(' ')[0] + "Notes[] PROGMEM = \n{\n" + String.Join(", ", Notes) + "\n};\n\nconst unsigned int " + Name.ToLower().Split(' ')[0] + "Times[] PROGMEM = \n{\n" + String.Join(", ", Times) + "\n};";
        }

        public List<int> Times
        {
            get { return Durations.Select(i => (int)(60000 * (float)i / Division / Tempo)).ToList(); }
        }

        public Part(string file, XElement partElement)
        {
            List<string> notes = new List<string>();
            List<int> durations = new List<int>();
            int division;
            int tempo;
            string id;
            string name;

            XDocument doc = XDocument.Load(file);

            //XElement selectedPart = partElement.Descendants("part").ElementAt(partNumber);

            bool result = int.TryParse(partElement.Descendants("divisions").FirstOrDefault()?.Value, out division);
            if (!result)
            {
                division = 4;
            }

            result = int.TryParse(doc.Descendants("sound").Attributes("tempo").FirstOrDefault()?.Value, out tempo);
            if (!result)
            {
                tempo = 100;
            }

            id = partElement.Attributes("id").FirstOrDefault()?.Value;
            if (id == null)
            {
                id = "NO ID";
            }

            name = doc.Descendants("score-part").Where(p => String.Equals(p.Attribute("id").Value.ToString(), id)).FirstOrDefault()?.Descendants("part-name")?.FirstOrDefault().Value;
            if (name == null)
            {
                name = "NO NAME";
            }

            var pitches = from pitch in partElement.Descendants("note")
                          select new
                          {
                              rest = pitch.Descendants("rest").FirstOrDefault(),
                              step = pitch.Descendants("step").FirstOrDefault(),
                              alter = pitch.Descendants("alter").FirstOrDefault(),
                              octave = pitch.Descendants("octave").FirstOrDefault(),
                              duration = pitch.Descendants("duration").FirstOrDefault()
                          };

            foreach (var pitch in pitches)
            {
                string rest = "";
                if (pitch.rest != null)
                {
                    rest = "REST";
                }

                string step = "";
                if (pitch.step != null)
                {
                    step = pitch.step.Value;
                }

                string accidental = "";
                if (pitch.alter != null)
                {
                    switch (int.Parse(pitch.alter.Value))
                    {
                        case 1:
                            accidental = "S";
                            break;
                        case -1:
                            accidental = "F";
                            break;
                        default:
                            break;
                    }
                }

                string octave = "";
                if (pitch.octave != null)
                {
                    octave = pitch.octave.Value;
                }

                int duration = 1;
                if (pitch.duration != null)
                {
                    duration = int.Parse(pitch.duration.Value);
                }

                notes.Add("NOTE_" + rest + step + accidental + octave);

                durations.Add(duration);
            }
            Notes = notes;
            Durations = durations;
            Division = division;
            Tempo = tempo;
            ID = id;
            Name = name;
            Raw = partElement.ToString();
        }
    }
}
