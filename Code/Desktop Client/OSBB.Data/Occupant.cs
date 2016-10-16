using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GenderEnumeration;

namespace OSBB.Data
{
    public class Occupant
    {
        public Occupant()
        {

        }
        public int OccupantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate
        {
            get;
            set;
        }
        public bool Owner { get; set; }
        public int AppartmentId { get; set; }

        public string OwnerString
        {
            //get { return this.Owner == true ? "Владелец" : ""; }
            get { return this.Owner == true ? "Да" : ""; }
        }

        public string DisplayGender
        {
            get
            {
                if (Gender == GenderEnumeration.Gender.male)
                    return "мужской";
                else
                    return "женский";
            }
        }

        public virtual Appartment Appartment { get; set; }

    }
}
