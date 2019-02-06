﻿using OSharp.Beatmap.Configurable;
using System.Drawing;

namespace OSharp.Beatmap.Sections
{
    /// <summary>
    /// Not implemented
    /// </summary>
    [SectionProperty("Colours")]
    public class Colours : KeyValueSection
    {
        [SectionConverter(typeof(ColorConverter))]
        public Color Combo1 { get; set; }

        [SectionConverter(typeof(ColorConverter))]
        public Color Combo2 { get; set; }

        [SectionConverter(typeof(ColorConverter))]
        public Color Combo3 { get; set; }

        [SectionConverter(typeof(ColorConverter))]
        public Color Combo4 { get; set; }

        [SectionConverter(typeof(ColorConverter))]
        public Color Combo5 { get; set; }

        [SectionConverter(typeof(ColorConverter))]
        public Color Combo6 { get; set; }

        [SectionConverter(typeof(ColorConverter))]
        public Color Combo7 { get; set; }

        [SectionConverter(typeof(ColorConverter))]
        public Color Combo8 { get; set; }
    }
}
