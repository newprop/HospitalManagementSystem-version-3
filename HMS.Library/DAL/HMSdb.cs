using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Library.Models;
using HMS.Library.Types;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace HMS.Library.DAL
{
	public class HMSdb : IdentityDbContext
	{
		public DbSet<Admission> Admissions { get; set; }
		public DbSet<Appointment> Appointments { get; set; }
		public DbSet<Billing> Billings { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Discharge> Discharges { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Emergency> Emergencies { get; set; }
		public DbSet<InventoryItem> InventoryItems { get; set; }
		public DbSet<Nurse> Nurses { get; set; }
		public DbSet<Patient> Patients { get; set; }
		public DbSet<AppointmentPrescribe> AppointmentPrescribes { get; set; }
		public DbSet<EmergencyPrescribe> EmergencyPrescribes { get; set; }
		public DbSet<Report> Reports { get; set; }
		public DbSet<Room> Rooms { get; set; }
		public DbSet<Staff> Staffs { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }
		public DbSet<Transaction> Transactions { get; set; }
		public DbSet<Ward> Wards { get; set; }
		public DbSet<ReportType> ReportTypes { get; set; }
		public DbSet<BloodType> BloodTypes { get; set; }
		public DbSet<AppointmentType> AppointmentTypes { get; set; }


		public HMSdb(DbContextOptions opt) : base(opt)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<IdentityUserLogin<string>>()
			.HasKey(u => new { u.UserId, u.LoginProvider, u.ProviderKey });

			modelBuilder.Entity<IdentityUserRole<string>>()
			.HasKey(r => new { r.UserId, r.RoleId });


			modelBuilder.Entity<BloodType>().HasData(new BloodType[]
			{
				new BloodType
				{
					BloodTypeId = 1,
					Name = "A+"
				},
				new BloodType
				{
					BloodTypeId = 2,
					Name = "A-"
				},
				new BloodType
				{
					BloodTypeId = 3,
					Name = "AB+"
				},
				new BloodType
				{
					BloodTypeId = 4,
					Name = "AB-"
				},
				new BloodType
				{
					BloodTypeId = 5,
					Name = "B+"
				},
				new BloodType
				{
					BloodTypeId = 6,
					Name = "B-"
				},
				new BloodType
				{
					BloodTypeId = 7,
					Name = "O+"
				},
				new BloodType
				{
					BloodTypeId = 8,
					Name = "O-"
				}
			});

			modelBuilder.Entity<ReportType>().HasData(new ReportType[]
			{
				new ReportType
				{
					ReportTypeId = 1,
					Name = "Discharge Summary"
				},
				new ReportType
				{
					ReportTypeId = 2,
					Name = "Pathology Report"
				},
				new ReportType
				{
					ReportTypeId = 3,
					Name = "Laboratory Report"
				},
				new ReportType
				{
					ReportTypeId = 4,
					Name = "Consultation Report"
				},
				new ReportType
				{
					ReportTypeId = 5,
					Name = "Anesthesia Report"
				}

			});


			modelBuilder.Entity<AppointmentType>().HasData(new AppointmentType[]
			{
				new AppointmentType
				{
					AppointmentTypeId = 1,
					Name = "General Consultation"
				},
				new AppointmentType
				{
					AppointmentTypeId = 2,
					Name = "Specialist Consultation"
				},
				new AppointmentType
				{
					AppointmentTypeId = 3,
					Name = "Follow-up Appointment"
				},
				new AppointmentType
				{
					AppointmentTypeId = 4,
					Name = "Maternity Appointment"
				},
				new AppointmentType
				{
					AppointmentTypeId = 5,
					Name = "Vaccination/Immunization"
				},
				new AppointmentType
				{
					AppointmentTypeId = 6,
					Name = "Surgical Consultation"
				},
				new AppointmentType
				{
					AppointmentTypeId = 7,
					Name = "Emergency Consultation"
				},
				new AppointmentType
				{
					AppointmentTypeId = 8,
					Name = "Nutritional Counseling"
				},
				new AppointmentType
				{
					AppointmentTypeId = 9,
					Name = "Lab Work or Blood Tests"
				}

			});


			modelBuilder.Entity<Department>().HasData(new Department[]
			{
				new Department
				{
					DepartmentId = 1,
					Name = "MEDICINE"
				},
				new Department
				{
					DepartmentId = 2,
					Name = "ENT"
				},


                new Department
          {
              DepartmentId = 3,
               Name = "CHILD CARE"
                },
                new Department
                   {
                    DepartmentId = 4,
    Name = "CARDIOLOGY"
},
                    new Department
    {
        DepartmentId = 5,
        Name = "Psychology"
    },
                        new Department
    {
        DepartmentId = 6,
        Name = "Gynecology"
    },
                        new Department
{
    DepartmentId = 7,
    Name = "Neurology"
},
                        new Department
{
    DepartmentId = 8,
    Name = "Ophthalmology"
},
                                        new Department
                {
                    DepartmentId = 9,
                    Name = "Physiotherapy"
                },



            });
			modelBuilder.Entity<Doctor>().HasData(new Doctor[]
			{
                 new Doctor
    {
        DoctorId = 1,
        Name = "Dr. Farhana Rahman",
        Specialization = "Gynecologist",
        ContactNo = "+880-181-2225587",
        Email = "farhana@example.com",
        Schedule = "Sat-Thu 10-1",
        Shift = ShiftType.Morning_6am_To_2pm,
        Image = "doctor_farhana.jpg",
        DepartmentID = 1
    },
    new Doctor
    {
        DoctorId = 2,
        Name = "Dr. Rahman Chowdhury",
        Specialization = "Orthopedic Surgeon",
        ContactNo = "+880-191-2225587",
        Email = "rahman@example.com",
        Schedule = "Sat-Thu 2-5",
        Shift = ShiftType.Afternoon_2pm_To_10pm,
        Image = "doctor_rahman.jpg",
        DepartmentID = 2
    },
    new Doctor
    {
        DoctorId = 3,
        Name = "Dr. Ayesha Khan",
        Specialization = "Pediatrician",
        ContactNo = "+880-181-2225587",
        Email = "ayesha@example.com",
        Schedule = "Sat-Wed 9-12, Thu 9-1",
        Shift = ShiftType.Morning_6am_To_2pm,
        Image = "doctor_ayesha.jpg",
        DepartmentID = 3
    },
    new Doctor
    {
        DoctorId = 4,
        Name = "Dr. Mohammad Ali",
        Specialization = "General Physician",
        ContactNo = "+880-171-2225587",
        Email = "mohammad@example.com",
        Schedule = "Sat-Thu 3-6",
        Shift = ShiftType.Afternoon_2pm_To_10pm,
        Image = "doctor_mohammad.jpg",
        DepartmentID = 4
    },
    new Doctor
    {
        DoctorId = 5,
        Name = "Dr. Fatima Ahmed",
        Specialization = "Dermatologist",
        ContactNo = "+880-181-2225587",
        Email = "fatima@example.com",
        Schedule = "Sat-Tue 10-1, Thu 11-2",
        Shift = ShiftType.Morning_6am_To_2pm,
        Image = "doctor_fatima.jpg",
        DepartmentID = 5
    },
    new Doctor
    {
        DoctorId = 6,
        Name = "Dr. Hasan Mahmud",
        Specialization = "Neurologist",
        ContactNo = "+880-191-2225587",
        Email = "hasan@example.com",
        Schedule = "Sat-Wed 9-12, Thu 9-1",
        Shift = ShiftType.Morning_6am_To_2pm,
        Image = "doctor_hasan.jpg",
        DepartmentID = 6
    },
    new Doctor
    {
        DoctorId = 7,
        Name = "Dr. Aisha Rahman",
        Specialization = "Psychiatrist",
        ContactNo = "+880-181-2225587",
        Email = "aisha@example.com",
        Schedule = "Sat-Thu 2-5",
        Shift = ShiftType.Afternoon_2pm_To_10pm,
        Image = "doctor_aisha.jpg",
        DepartmentID = 7
    },
    new Doctor
    {
        DoctorId = 8,
        Name = "Dr. Ali Khan",
        Specialization = "Ophthalmologist",
        ContactNo = "+880-171-2225587",
        Email = "ali@example.com",
        Schedule = "Sat-Wed 9-12, Thu 9-1",
        Shift = ShiftType.Morning_6am_To_2pm,
        Image = "doctor_ali.jpg",
        DepartmentID = 8
    },
    new Doctor
    {
        DoctorId = 9,
        Name = "Dr. Nazia Islam",
        Specialization = "ENT Specialist",
        ContactNo = "+880-181-2225587",
        Email = "nazia@example.com",
        Schedule = "Sat-Tue 10-1, Thu 11-2",
        Shift = ShiftType.Morning_6am_To_2pm,
        Image = "doctor_nazia.jpg",
        DepartmentID = 9
    },
    new Doctor
    {
        DoctorId = 10,
        Name = "Dr. Kabir Khan",
        Specialization = "Urologist",
        ContactNo = "+880-191-2225587",
        Email = "kabir@example.com",
        Schedule = "Sat-Thu 2-5",
        Shift = ShiftType.Afternoon_2pm_To_10pm,
        Image = "doctor_kabir.jpg",
        DepartmentID = 10
    }

            });

			modelBuilder.Entity<Patient>().HasData(new Patient[]
			{
                new Patient
            {
                PatientId = 1,
                Name = "David Rahman",
                Dob = new DateOnly(1995,05,23),
                Gender = Genders.Male,
                Age = 31,
                ContactNo = "+880-181-2225587",
                Email = "david@example.com",
                Address = "123 River Road, Dhaka, Bangladesh",
                BloodTypeID = 2,
                InsuranceInformation = "Coverage Inc."
            },
            new Patient
            {
                PatientId = 2,
                Name = "Sarah Khan",
                Dob = new DateOnly(1995,05,23),
                Gender = Genders.Female,
                Age = 35,
                ContactNo = "+880-191-2225587",
                Email = "sarah@example.com",
                Address = "456 Garden Street, Chittagong, Bangladesh",
                BloodTypeID = 1,
                InsuranceInformation = "Protective Insurance Co."
            },
            new Patient
            {
                PatientId = 3,
                Name = "Mark Wilson",
                Dob = new DateOnly(1995,05,23),
                Gender = Genders.Male,
                Age = 46,
                ContactNo = "+880-171-2225587",
                Email = "mark@example.com",
                Address = "789 Mountain View, Sylhet, Bangladesh",
                BloodTypeID = 3,
                InsuranceInformation = "AssureNow Insurance"
            },
            new Patient
            {
                PatientId = 4,
                Name = "Jennifer Lee",
                Dob = new DateOnly(1995,05,23),
                Gender = Genders.Female,
                Age = 29,
                ContactNo = "+880-181-2225587",
                Email = "jennifer@example.com",
                Address = "890 Park Avenue, Dhaka, Bangladesh",
                BloodTypeID = 2,
                InsuranceInformation = "SafetyNet Insurance Services"
            },
            new Patient
            {
                PatientId = 5,
                Name = "Robert Islam",
                Dob = new DateOnly(1996,05,23),
                Gender = Genders.Male,
                Age = 33,
                ContactNo = "+880-191-2225587",
                Email = "robert@example.com",
                Address = "234 Lakeview Road, Sylhet, Bangladesh",
                BloodTypeID = 1,
                InsuranceInformation = "SecureLife Insurance"
            },
            new Patient
            {
                PatientId = 6,
                Name = "Megan Ahmed",
                Dob = new DateOnly(1997,05,23),
                Gender = Genders.Female,
                Age = 26,
                ContactNo = "+880-171-2225587",
                Email = "megan@example.com",
                Address = "345 Forest Avenue, Chittagong, Bangladesh",
                BloodTypeID = 2,
                InsuranceInformation = "Guardian Insurance Co."
            },
            new Patient
            {
                PatientId = 7,
                Name = "Daniel Chowdhury",
                Dob = new DateOnly (1992, 05, 23),
                Gender = Genders.Male,
                Age = 39,
                ContactNo = "+880-181-2225587",
                Email = "daniel@example.com",
                Address = "456 Maple Street, Dhaka, Bangladesh",
                BloodTypeID = 3,
                InsuranceInformation = "Shield Insurance Group"
            },
            new Patient
            {
                PatientId = 8,
                Name = "Ava Rahman",
                Dob = new DateOnly (1999, 05, 23),
                Gender = Genders.Female,
                Age = 23,
                ContactNo = "+880-191-2225587",
                Email = "ava@example.com",
                Address = "567 Oak Lane, Sylhet, Bangladesh",
                BloodTypeID = 1,
                InsuranceInformation = "SafeGuard Insurance"
            },
            new Patient
            {
                PatientId = 9,
                Name = "James Ali",
                Dob = new DateOnly (1980, 05, 23),
                Gender = Genders.Male,
                Age = 51,
                ContactNo = "+880-171-2225587",
                Email = "james@example.com",
                Address = "678 Pine Street, Chittagong, Bangladesh",
                BloodTypeID = 2,
                InsuranceInformation = "FirstChoice Insurance"
            },
             new Patient
            {
                PatientId = 4,
                Name = "David Miller",
                Dob = new   DateOnly(1991,05,23),
                Gender = Genders.Male,
                Age = 31,
                ContactNo = "+880-181-2225587",
                Email = "david@example.com",
                Address = "123 River Road, Dhaka, Bangladesh",
                BloodTypeID = 2,
                InsuranceInformation = "Coverage Inc."
            }

            });






        }

	}
}
