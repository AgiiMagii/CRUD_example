using EntityExample.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Z.EntityFramework.Plus;

namespace EntityExample.Lib
{
    public class Factory
    {
        Repository repository = new Repository(new UniversityExampleEntities());
        public List<StudentView> GetStudents()
        {
            return repository.GetEntities<Student>().Select(s => new StudentView
            {
                ID_student = s.ID_student,
                Name = s.Name,
                Surname = s.Surname,
                Gender = s.Gender,
                BirthYear = s.BirthYear,
                CourseName = s.Course != null ? s.Course.Name : string.Empty,
                Scholarship = s.Scholarship != null ? s.Scholarship.Value.ToString("C") : "N/A"

            }).ToList();
        }
        public List<LectorView> GetLectors()
        {
            return repository.GetEntities<Lector>().Select(l => new LectorView
            {
                ID_lector = l.ID_lector,
                Name = l.Name,
                Surname = l.Surname,
                Phone = l.Phone,
                HireDate = l.HireDate,
                FacultyName = l.Faculty != null ? l.Faculty.Name : string.Empty

            }).ToList();
        }
        public List<Address> GetAddresses()
        {
            return repository.GetEntities<Address>().Select(a => new Address
            {
                ID_address = a.ID_address,
                Region = a.Region,
                City = a.City,
                Street = a.Street,
                Number = a.Number

            }).ToList();
        }
        public List<Faculty> GetFaculties()
        {
            return repository.GetEntities<Faculty>();
        }
        public List<Course> GetCourses()
        {
            return repository.GetEntities<Course>();
        }
        public List<Course> GetCoursesByFacultyId(long facultyId)
        {
            return repository.GetEntities<Course>().Where(c => c.ID_faculty == facultyId).ToList();
        }
        public List<LectorView> GetLectorsByFaculty(long facultyId)
        {
            return repository.GetEntities<Lector>().Where(l => l.ID_faculty == facultyId).Select(l => new LectorView
            {
                ID_lector = l.ID_lector,
                Name = l.Name,
                Surname = l.Surname,
                Phone = l.Phone,
                HireDate = l.HireDate,
                FacultyName = l.Faculty != null ? l.Faculty.Name : string.Empty
            }).ToList();
        }
        public List<Student> GetStudentsByCourseID(long courseId)
        {
            return repository.GetEntities<Student>().Where(s => s.ID_course == courseId).ToList();
        }
        public List<GetStudentsByFaculty_Result> GetStudentsByFaculty(string faculty)
        {
            try
            {
                SqlParameter facultyParam = new SqlParameter("@Faculty", faculty);
                return repository.ExecuteStoredProcedure<GetStudentsByFaculty_Result>("GetStudentsByFaculty", facultyParam);

            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving students by faculty.", ex);
            }
        }
        //public List<StudentView> GetStudentsByFilter(string searchText)
        //{
        //    try
        //    {
        //        SqlParameter parameters = new System.Data.SqlClient.SqlParameter("@filterValue", searchText ?? (object)DBNull.Value);
        //        return repository.ExecuteStoredProcedure<StudentView>("GetStudentsByFilter", parameters);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("An error occurred while retrieving students by filter.", ex);
        //    }
        //}
        public Student RegStudent(Student student)
        {
            return repository.AddEntity(student);
        }
        public Lector RegLector(Lector lector)
        {
            return repository.AddEntity(lector);
        }
        public Address RegAddress(Address address)
        {
            return repository.AddEntity(address);
        }
        public Faculty RegFaculty(Faculty faculty)
        {
            return repository.AddEntity(faculty);
        }
        public Course RegCourse(Course course)
        {
            return repository.AddEntity(course);
        }
        public Student GetStudentById(long id)
        {
            return repository.GetEntities<Student>().FirstOrDefault(s => s.ID_student == id);
        }
        public Lector GetLectorById(long id)
        {
            Lector lector = repository.GetEntities<Lector>().FirstOrDefault(l => l.ID_lector == id);
            return lector;
        }
        public Address GetAddressById(long id)
        {
            return repository.GetEntities<Address>().FirstOrDefault(a => a.ID_address == id);
        }
        public Faculty GetFacultyById(long id)
        {
            return repository.GetEntities<Faculty>().FirstOrDefault(f => f.ID_faculty == id);
        }
        public Course GetCourseById(long id)
        {
            return repository.GetEntities<Course>().FirstOrDefault(c => c.ID_course == id);
        }
        public long GetLastInsertedAddressId()
        {
            return repository.GetEntities<Address>().OrderByDescending(a => a.ID_address).FirstOrDefault().ID_address;
        }
        public bool UpdateStudent(Student student)
        {
            if (student == null)
            {
                return false;
            }
            Student studentEntity = repository.GetEntities<Student>().FirstOrDefault(s => s.ID_student == student.ID_student); //find the existing entity
            if (studentEntity == null)
            {
                return false;
            }
            studentEntity.Name = student.Name;      //update properties from the provided student
            studentEntity.Surname = student.Surname;
            studentEntity.BirthYear = student.BirthYear;
            studentEntity.Gender = student.Gender;
            studentEntity.ID_course = student.ID_course;
            repository.UpdateEntity(studentEntity); //save changes
            return true;
        }
        public bool UpdateAddress(Address address)
        {
            if (address == null)
            {
                return false;
            }
            Address addressEntity = repository.GetEntities<Address>().FirstOrDefault(a => a.ID_address == address.ID_address); //find the existing entity
            if (addressEntity == null)
            {
                return false;
            }
            addressEntity.Region = address.Region;      //update properties from the provided address
            addressEntity.City = address.City;
            addressEntity.Street = address.Street;
            addressEntity.Number = address.Number;
            repository.UpdateEntity(addressEntity); //save changes
            return true;
        }
        public bool UpdateLector(Lector lector)
        {
            if (lector == null)
            {
                return false;
            }
            Lector lectorEntity = repository.GetEntities<Lector>().FirstOrDefault(l => l.ID_lector == lector.ID_lector); //find the existing entity
            if (lectorEntity == null)
            {
                return false;
            }
            lectorEntity.Name = lector.Name;      //update properties from the provided lector
            lectorEntity.Surname = lector.Surname;
            lectorEntity.Phone = lector.Phone;
            lectorEntity.ID_faculty = lector.ID_faculty;
            lectorEntity.HireDate = lector.HireDate;
            repository.UpdateEntity(lectorEntity); //save changes
            return true;
        }
        public bool UpdateFaculty(Faculty faculty)
        {
            if (faculty == null)
            {
                return false;
            }
            Faculty facultyEntity = repository.GetEntities<Faculty>().FirstOrDefault(f => f.ID_faculty == faculty.ID_faculty);
            if (facultyEntity == null)
            {
                return false;
            }
            facultyEntity.Name = faculty.Name;
            facultyEntity.ID_address = faculty.ID_address;
            facultyEntity.ANNO = faculty.ANNO;
            repository.UpdateEntity(facultyEntity);
            return true;
        }
        public bool UpdateCourse(Course course)
        {
            if (course == null)
            {
                return false;
            }
            Course courseEntity = repository.GetEntities<Course>().FirstOrDefault(c => c.ID_course == course.ID_course);
            if (courseEntity == null)
            {
                return false;
            }
            courseEntity.Name = course.Name;
            courseEntity.ID_faculty = course.ID_faculty;
            repository.UpdateEntity(courseEntity);
            return true;
        }
        public bool DeleteStudent(long id)
        {
            Student studentEntity = repository.GetEntities<Student>().FirstOrDefault(s => s.ID_student == id);
            if (studentEntity == null)
            {
                return false;
            }
            repository.DeleteEntity(studentEntity);
            return true;
        }
        public bool DeleteLector(long id)
        {
            Lector lectorEntity = repository.GetEntities<Lector>().FirstOrDefault(l => l.ID_lector == id);
            if (lectorEntity == null)
            {
                return false;
            }
            repository.DeleteEntity(lectorEntity);
            return true;
        }
        public bool DeleteAddress(long id)
        {
            Address addressEntity = repository.GetEntities<Address>().FirstOrDefault(a => a.ID_address == id);
            if (addressEntity == null)
            {
                return false;
            }
            repository.DeleteEntity(addressEntity);
            return true;
        }
        public bool DeleteCourse(long id)
        {
            Course courseEntity = repository.GetEntities<Course>().FirstOrDefault(c => c.ID_course == id);
            if (courseEntity == null)
            {
                return false;
            }
            repository.DeleteEntity(courseEntity);
            return true;
        }
        public bool AddScholarship(long courseID, decimal amount)
        {
            try
            {
                using (var context = new UniversityExampleEntities())
                {
                    // 1️⃣ Atjauno course default
                    context.Course
                        .Where(c => c.ID_course == courseID)
                        .Update(c => new Course { DefaultScholarship = amount });

                    // 2️⃣ Atjauno studentiem, kuriem nav īpašā procenta
                    context.Student
                        .Where(s => s.ID_course == courseID)
                        .Update(s => new Student { Scholarship = amount });
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

