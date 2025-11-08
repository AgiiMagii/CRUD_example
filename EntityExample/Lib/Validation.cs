using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace EntityExample.Lib
{
    public class Validation
    {   static readonly DateTime minDate = new DateTime(1960, 1, 1);
        public List<string> StudentValidation(Student student)
        {
            List<string> errors = new List<string>();
            if (!IsNameSurnameValid(student.Name))
            {
                errors.Add("Name must be between 2 and 30 characters and cannot contain digits.");
            }
            if (!IsNameSurnameValid(student.Surname))
            {
                errors.Add("Surname must be between 2 and 30 characters and cannot contain digits.");
            }
            if (!IsBirthYearValid(student.BirthYear ?? DateTime.MinValue))
            {
                errors.Add("Birth year must be between 1900 and at least 18 years ago.");
            }
            return errors;
        }
        public bool IsNameSurnameValid(string input)
        {
            if (input.Length < 2 || input.Length > 30 || input.Any(char.IsDigit))
            {
                return false;
            }
            return true;
        }
        public bool IsBirthYearValid(DateTime birthYear)
        {
            int currentYear = DateTime.Now.Year;
            int year = birthYear.Year;
            if (year < 1900 || year > currentYear - 18)
            {
                return false;
            }
            return true;
        }
        public bool IsPhoneValid(string phone)
        {
            if (phone.Length < 7 || phone.Length > 15 || !phone.All(c => char.IsDigit(c) || c == '+' || c == '-' || c == ' '))
            {
                return false;
            }
            return true;
        }
        public bool IsHireDateValid(DateTime hireDate)
        {
            if (hireDate > DateTime.Now && hireDate < minDate)
            {
                return false;
            }
            return true;
        }
        public bool IsEstablishedYearValid(int year)
        {
            int currentYear = DateTime.Now.Year;
            if (year < 1700 || year > currentYear)
            {
                return false;
            }
            return true;
        }
        public bool IsFacultyNameValid(string name)
        {
            if (name.Length < 2 || name.Length > 100)
            {
                return false;
            }
            return true;
        }
        public bool IsCourseNameUnique(string name, List<Course> existingCourses)
        {
            if (existingCourses.Any(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }
            return true;
        }
        public List<string> LectorValidation(Lector lector)
        {
            List<string> errors = new List<string>();
            if (!IsNameSurnameValid(lector.Name))
            {
                errors.Add("Name must be between 2 and 30 characters and cannot contain digits.");
            }
            if (!IsNameSurnameValid(lector.Surname))
            {
                errors.Add("Surname must be between 2 and 30 characters and cannot contain digits.");
            }
            if (!IsPhoneValid(lector.Phone))
            {
                errors.Add("Phone number must be between 7 and 15 characters and can only contain digits, '+', '-' and spaces.");
            }
            if (!IsHireDateValid(lector.HireDate ?? DateTime.MinValue))
            {
                errors.Add($"Hire date must be between {minDate.ToShortDateString()} and today.");
            }
            return errors;
        }
        public List<string> AddressValidation(Address address)
        {
            List<string> errors = new List<string>();
            if (address.Region.Length > 50)
            {
                errors.Add("Region must be less than 50 characters.");
            }
            if (address.City.Length > 50)
            {
                errors.Add("City must be less than 50 characters.");
            }
            if (address.Street.Length > 100)
            {
                errors.Add("Street must be less than 100 characters.");
            }
            if (address.Number.Length > 10)
            {
                errors.Add("Number must be less than 10 characters.");
            }
            return errors;
        }
        public List<string> FacultyValidation(Faculty faculty)
        {
            List<string> errors = new List<string>();
            if (!IsFacultyNameValid(faculty.Name))
            {
                errors.Add("Faculty name must be between 2 and 100 characters.");
            }
            if (faculty.ANNO != null && !IsEstablishedYearValid(faculty.ANNO.Value.Year))
            {
                errors.Add("Established year must be between 1700 and the current year.");
            }
            return errors;
        }
        public List<string> CourseValidation(Course course, List<Course> existingCourses)
        {
            List<string> errors = new List<string>();
            if (course.Name.Length < 2 || course.Name.Length > 100)
            {
                errors.Add("Course name must be between 2 and 100 characters.");
            }
            else if (string.IsNullOrWhiteSpace(course.Name))
            {
                errors.Add("Course name is required.");
            }
            else if (!IsCourseNameUnique(course.Name, existingCourses))
            {
                errors.Add("Course name must be unique within the faculty.");
            }
            return errors;
        }
    }
}
