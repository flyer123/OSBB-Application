using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace OSBB.Windows
{
    public abstract class ViewModel : ObservableObject, IDataErrorInfo
    {

        public string this[string columnName]
        {
            get { return OnValidate(columnName); }
        }

        public string Error
        {
            get
            {
                throw new NotSupportedException();
            }
        }
        protected virtual string OnValidate([CallerMemberName] string propertyName = "")
        {
            var context = new ValidationContext(this)
            {
                MemberName = propertyName
            };
            var results = new Collection<ValidationResult>();
            var isValid = Validator.TryValidateObject(this, context, results, true);
            if (!isValid)
            {
                ValidationResult result = results.SingleOrDefault(p => p.MemberNames.Any(memberName => memberName == propertyName));
                if (result == null)
                {
                    return null;
                }
                else
                {
                    return result.ErrorMessage; ;
                }
            }
            return null;
        }
    }
}
