﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace musicXMLReader
{
    class Part
    {
        public List<Measure> Measures { get; set; } = new List<Measure>();

        public List<string> Notes
        {
            get
            {
                List<string> notes = new List<string>();
                Measures.ForEach(m => notes.AddRange(m.Notes));
                return notes;
            }
        }

        public List<int> Durations
        {
            get
            {
                List<int> durations = new List<int>();
                Measures.ForEach(m => durations.AddRange(m.Durations));
                return durations;
            }
        }

        public int Division { get; set; }
        public Dictionary<int, int> Tempos { get; set; } // key = measure, value = tempo

        public string ID { get; set; }
        public string Name { get; set; }

        public string Raw { get; set; }

        public Part()
        {

        }

        public class Measure
        {
            public List<string> Notes { get; set; } = new List<string>();
            public List<int> Durations { get; set; } = new List<int>();
            public int Tempo { get; set; } // key = measure, value = tempo
            public int Number { get; set; }

        }

        public List<int> Times
        {
            get
            {
                List<int> times = new List<int>();

                Measures.ForEach(m => times.AddRange(m.Durations
                   .Select(d => (int)(60000 * (float)d / Division / m.Tempo))));

                return times;
            }
        }

        public static Part Create(XDocument doc, XElement partElement)
        {
            Part _part = new Part();

            bool result;

            //int division;
            //bool result = int.TryParse(partElement.Descendants("divisions").FirstOrDefault()?.Value, out division);
            //if (!result)
            //{
            //    division = 4;
            //}
            //_part.Division = division;

            _part.Division = (int?)partElement.Descendants("divisions").FirstOrDefault() ?? 4;

            //int tempo;
            //result = int.TryParse(doc.Descendants("sound").Attributes("tempo").FirstOrDefault()?.Value, out tempo);
            //if (!result)
            //{
            //    tempo = 100;
            //}
            //_part.Tempos = tempo;

            int tempo = 100;

            foreach (var measureElement in partElement.Descendants("measure"))
            {
                Measure curMeasure = new Measure();

                curMeasure.Number = int.Parse(measureElement.Attribute("number").Value);

                //int curTempo;
                //result = int.TryParse(doc.Descendants("measure")
                //    .Where(m => int.Parse(m.Attribute("number").Value) == curMeasure.Number)
                //    .Descendants("sound")
                //    ?.FirstOrDefault(s => s.Attribute("tempo") != null)
                //    ?.Attribute("tempo").Value, out curTempo);
                //if (result)
                //{
                //    tempo = curTempo;
                //}
                //else
                //{
                //    curTempo = tempo;
                //} 
                //curMeasure.Tempo = curTempo;

                int curTempo = (int?)doc.Descendants("measure")
                    .Where(m => int.Parse(m.Attribute("number").Value) == curMeasure.Number)
                    .Descendants("sound")
                    ?.FirstOrDefault(s => s.Attribute("tempo") != null)
                    ?.Attribute("tempo") ?? tempo;
                tempo = curTempo;
                curMeasure.Tempo = curTempo;


                //var pitches = from pitch in measureElement.Descendants("note")
                //              select new
                //              {
                //                  rest = pitch.Descendants("rest").FirstOrDefault(),
                //                  step = pitch.Descendants("step").FirstOrDefault(),
                //                  alter = pitch.Descendants("alter").FirstOrDefault(),
                //                  octave = pitch.Descendants("octave").FirstOrDefault(),
                //                  duration = pitch.Descendants("duration").FirstOrDefault()
                //              };

                var pitches = measureElement.Descendants("note")
                              .Select(n => new
                              {
                                  rest = n.Descendants("rest").FirstOrDefault(),
                                  step = n.Descendants("step").FirstOrDefault(),
                                  alter = n.Descendants("alter").FirstOrDefault(),
                                  octave = n.Descendants("octave").FirstOrDefault(),
                                  duration = n.Descendants("duration").FirstOrDefault()
                              });

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

                    curMeasure.Notes.Add("NOTE_" + rest + step + accidental + octave);

                    curMeasure.Durations.Add(duration);
                }

                _part.Measures.Add(curMeasure);
            }



            string id = partElement.Attributes("id").FirstOrDefault()?.Value;
            if (id == null)
            {
                id = "NO ID";
            }
            _part.ID = id;

            string name = doc.Descendants("score-part").Where(p => String.Equals(p.Attribute("id").Value.ToString(), id)).FirstOrDefault()?.Descendants("part-name")?.FirstOrDefault().Value;
            if (name == null)
            {
                name = "NO NAME";
            }
            _part.Name = name;

            //var pitches = from pitch in partElement.Descendants("note")
            //              select new
            //              {
            //                  rest = pitch.Descendants("rest").FirstOrDefault(),
            //                  step = pitch.Descendants("step").FirstOrDefault(),
            //                  alter = pitch.Descendants("alter").FirstOrDefault(),
            //                  octave = pitch.Descendants("octave").FirstOrDefault(),
            //                  duration = pitch.Descendants("duration").FirstOrDefault()
            //              };

            //foreach (var pitch in pitches)
            //{
            //    string rest = "";
            //    if (pitch.rest != null)
            //    {
            //        rest = "REST";
            //    }

            //    string step = "";
            //    if (pitch.step != null)
            //    {
            //        step = pitch.step.Value;
            //    }

            //    string accidental = "";
            //    if (pitch.alter != null)
            //    {
            //        switch (int.Parse(pitch.alter.Value))
            //        {
            //            case 1:
            //                accidental = "S";
            //                break;
            //            case -1:
            //                accidental = "F";
            //                break;
            //            default:
            //                break;
            //        }
            //    }

            //    string octave = "";
            //    if (pitch.octave != null)
            //    {
            //        octave = pitch.octave.Value;
            //    }

            //    int duration = 1;
            //    if (pitch.duration != null)
            //    {
            //        duration = int.Parse(pitch.duration.Value);
            //    }

            //    _part.Notes.Add("NOTE_" + rest + step + accidental + octave);

            //    _part.Durations.Add(duration);
            //}

            _part.Raw = partElement.ToString();

            return _part;
        }

    }
}
