﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PsychologicalSupports.Models.ModelUI
{
    public class Interests_Card_145UI
    {
        public long StudentID { get; set; }
        public string Biology { get; set; }
        public string Geography { get; set; }
        public string Geology { get; set; }
        public string TheMedicine { get; set; }
        public string LightAndFoodIndustry { get; set; }
        public string Physics { get; set; }
        public string Chemistry { get; set; }
        public string EngineeringMechanics { get; set; }
        public string ElectricalEngineeringRadioEngineering { get; set; }
        public string MaterialHandling { get; set; }
        public string InformationTechnology { get; set; }
        public string Psychology { get; set; }
        public string Building { get; set; }
        public string Tranport { get; set; }
        public string MilitarySpecialties { get; set; }
        public string Story { get; set; }
        public string Literature { get; set; }
        public string Journalism { get; set; }
        public string Sociology { get; set; }
        public string Pedagogy { get; set; }
        public string Right { get; set; }
        public string ServiceSector { get; set; }
        public string Maths { get; set; }
        public string Economy { get; set; }
        public string ForeignLanguages { get; set; }
        public string Art { get; set; }
        public string Music { get; set; }
        public string Sport { get; set; }

        public virtual Student Student { get; set; }
    }
}