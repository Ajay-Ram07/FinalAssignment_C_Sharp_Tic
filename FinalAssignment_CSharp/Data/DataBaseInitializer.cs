using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace FinalAssignment_CSharp.Data
{
    internal class DataBaseInitializer
    {
        private static string dbFile = "uniComTic.db";

        public static void InitializeDatabase()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
                Console.WriteLine("DataBase File Created Successfully!");
            }

            using (var connection = DataBase.GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();


                //USER TABLE
                command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS users (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            name TEXT,
                            email TEXT UNIQUE,
                            password TEXT,
                            role TEXT,
                            created_at TEXT,
                            updated_at TEXT);";
                command.ExecuteNonQuery();

                //STUDENTS TABLE
                command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS students (
                            id INTIGER PRIMARY KEY AUTOINCREMENT,
                            user_id INTEGER,
                            student_number TEXT,
                            department TEXT,
                            FOREIGN KEY(user_id) REFRENCES users(id));";
                command.ExecuteNonQuery();

                //LECTURERS TABLE
                command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS lecturers (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            user_id INTEGER,
                            employee_number TEXT,
                            subjects_taught TEXT,
                            FOREIGN KEY(user_id) REFERENCES users(id)
                        );";
                command.ExecuteNonQuery();

                // 4. Staffs Table
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS staffs (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        user_id INTEGER,
                        designation TEXT,
                        FOREIGN KEY(user_id) REFERENCES users(id)
                    );";
                command.ExecuteNonQuery();

                // 5. Admins Table
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS admins (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        user_id INTEGER,
                        access_level TEXT,
                        FOREIGN KEY(user_id) REFERENCES users(id)
                    );";
                command.ExecuteNonQuery();

                // 6. Courses Table
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS courses (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        course_name TEXT,
                        department TEXT
                    );";
                command.ExecuteNonQuery();

                // 7. Subjects Table
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS subjects (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        subject_name TEXT,
                        course_id INTEGER,
                        FOREIGN KEY(course_id) REFERENCES courses(id)
                    );";
                command.ExecuteNonQuery();

                // 8. Exams Table
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS exams (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        subject_id INTEGER,
                        exam_date TEXT,
                        type TEXT,
                        FOREIGN KEY(subject_id) REFERENCES subjects(id)
                    );";
                command.ExecuteNonQuery();

                // 9. Marks Table
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS marks (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        student_id INTEGER,
                        subject_id INTEGER,
                        mark INTEGER,
                        FOREIGN KEY(student_id) REFERENCES students(id),
                        FOREIGN KEY(subject_id) REFERENCES subjects(id)
                    );";
                command.ExecuteNonQuery();

                // 10. Departments Table
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS departments (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        name TEXT,
                        description TEXT
                    );";
                command.ExecuteNonQuery();

                // 11. Timetables Table
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS timetables (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        department TEXT,
                        subject TEXT,
                        day TEXT,
                        time TEXT
                    );";
                command.ExecuteNonQuery();

                Console.WriteLine("ALL Tables Created Successfully.!");
            }
        }
    }
}
