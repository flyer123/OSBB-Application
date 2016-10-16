using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Input;
using System.Windows;
using System.Reflection;
using System.ComponentModel;
using System.Globalization;
using OSBB.Windows;
using OSBB.Data;
using GenderEnumeration;
using ModeEnumeration;

namespace OSBB.DesktopClient.ViewModels
{
    public class SelectedOccupantViewModel : ViewModel
    {
        private readonly BusinessContext context;
        private ListAppartmentViewModel parentAppartmentViewModel;
        private Mode mode;
        public SelectedOccupantViewModel(ListAppartmentViewModel ocvm) : this (new BusinessContext())
        {
            parentAppartmentViewModel = ocvm;
            mode = ocvm.mode;
        }

        public SelectedOccupantViewModel(BusinessContext context)
        {
            this.context = context;
        }
        private int id;
        private string firstName, middleName, lastName;
        private DateTime birthDate; private bool owner;
        private int apaprtmentId; private Gender selectedGender;


        public int Id 
        { 
            get 
            { 
                return id;
            }
            set
            {
                id = value;
            }
        }

        public bool CanModify
        {
            get
            {
                return (FirstName == null || LastName == null) || !(FirstName.Trim().Length == 0) && !(LastName.Trim().Length == 0);
            }
        }

        public int AppartmentId
        {
            get
            {
                return apaprtmentId;
            }
            set
            {
                apaprtmentId = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }
        }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }
         public bool Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }

         #region enumeration code for gender property

         public Gender SelectedGender
         {
             get { return selectedGender; }
             set
             {
                 selectedGender = value;
             }
         }

         private List<KeyValuePair<string, Gender>> genderList;
         public List<KeyValuePair<string, Gender>> GenderList
         {
             get
             {
                 if (genderList == null)
                 {
                     genderList = new List<KeyValuePair<string, Gender>>();
                     foreach (Gender gender in Enum.GetValues(typeof(Gender)))
                     {
                         string Description;
                         FieldInfo fieldInfo = gender.GetType().GetField(gender.ToString());
                         DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                         if (attributes != null && attributes.Length > 0) { Description = attributes[0].Description; }
                         else { Description = string.Empty; }
                         KeyValuePair<string, Gender> TypeKeyValue =
                         new KeyValuePair<string, Gender>(Description, gender);
                         genderList.Add(TypeKeyValue);
                     }
                 }
                 return genderList;
             }
         }

         #endregion


         public ICommand UpdateOccupantCommand
         {
             get
             {
                 return new ActionCommand(x => UpdateOccupant());
             }
         }
         private void UpdateOccupant()
         {
             if (this.mode == Mode.Create)
             {
                 var ocp = new Occupant()
                 {
                     AppartmentId = this.AppartmentId,
                     BirthDate = this.BirthDate,
                     FirstName = this.FirstName,
                     LastName = this.LastName,
                     Gender = this.SelectedGender,
                     MiddleName = this.MiddleName,
                     Owner = this.Owner
                 };
                 ocp.OccupantId = context.AddNewOccupant(AppartmentId, FirstName, LastName, MiddleName, SelectedGender, BirthDate, Owner);
                 parentAppartmentViewModel.SelectedAppartment.Occupants.Add(ocp);
             }
             else
             {
                 var ocp = parentAppartmentViewModel.SelectedAppartment.Occupants.FirstOrDefault(x => x.OccupantId == Id);
                 context.UpdateOccupant(Id, AppartmentId, FirstName, LastName, MiddleName, SelectedGender, BirthDate, Owner);
                 int i = parentAppartmentViewModel.SelectedAppartment.Occupants.IndexOf(ocp);
                 parentAppartmentViewModel.SelectedAppartment.Occupants[i] = new Occupant()
                 {
                     AppartmentId = this.AppartmentId,
                     BirthDate = this.BirthDate,
                     FirstName = this.FirstName,
                     LastName = this.LastName,
                     Gender = this.SelectedGender,
                     MiddleName = this.MiddleName,
                     Owner = this.Owner,
                     OccupantId = Id
                 };
             }
         }
    }
}
