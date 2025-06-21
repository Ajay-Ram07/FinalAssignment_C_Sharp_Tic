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
                Console.WriteLine("Database file created successfully.");
            }

            // 🔧 Step 1: Create all tables
            using (var connection = DataBase.GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();

                // USERS TABLE
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

                // COURSES TABLE
                command.CommandText = @"
                CREATE TABLE IF NOT EXISTS courses (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    course_name TEXT NOT NULL UNIQUE,
                    created_at TEXT,
                    updated_at TEXT
                );";
                command.ExecuteNonQuery();

                // SUBJECTS TABLE
                command.CommandText = @"
                CREATE TABLE IF NOT EXISTS subjects (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    subject_name TEXT NOT NULL,
                    course_id INTEGER,
                    FOREIGN KEY(course_id) REFERENCES courses(id)
                );";
                command.ExecuteNonQuery();

                // STUDENTS TABLE
                command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS students (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        user_id INTEGER,
                        student_number TEXT,
                        name TEXT,
                        course TEXT,
                        lecturer TEXT,
                        FOREIGN KEY(user_id) REFERENCES users(id)
                        );";
                command.ExecuteNonQuery();

                // MARKS TABLE
                command.CommandText = @"
                CREATE TABLE IF NOT EXISTS marks (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    student_id TEXT,
                    student_name TEXT,
                    course TEXT,
                    subject TEXT,
                    mark INTEGER
                );";
                command.ExecuteNonQuery();


                // All other table creation code...
                // [students, lecturers, staffs, courses, etc...]

                Console.WriteLine("All tables created successfully.");
                connection.Close();
            }

            // 👑 Step 2: Insert Base Admin
            using (var connection = DataBase.GetConnection())
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM users WHERE email = 'ajay'";
                SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, connection);
                long exists = (long)checkCmd.ExecuteScalar();

                if (exists == 0)
                {
                    string insertQuery = @"
                INSERT INTO users (name, email, password, role, created_at, updated_at)
                VALUES ('Ajay Admin', 'ajay', '123456', 'admin', @createdAt, @updatedAt)";
                    SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, connection);
                    insertCmd.Parameters.AddWithValue("@createdAt", DateTime.Now.ToString());
                    insertCmd.Parameters.AddWithValue("@updatedAt", DateTime.Now.ToString());
                    insertCmd.ExecuteNonQuery();

                    Console.WriteLine("Base admin inserted.");
                }

                connection.Close();
            }
        }


    }
}
