using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace WindowsFormsApp15.Data
{
    public sealed class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> dbe = 
            new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        public static DatabaseConnection Instance { get { return dbe.Value; } }

        private string DatabaseFile;
        private string DatabaseSource;
        private SQLiteConnection connection;

        private DatabaseConnection()
        {
            string folder = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            DatabaseFile = Path.Combine(folder, @"Data\", "databaseFile.db");
            DatabaseSource = "data source=" + DatabaseFile;
            connection = new SQLiteConnection(DatabaseSource);
        }

        public void InitDatabase()
        {
            if (!File.Exists(DatabaseFile))
            {
                SQLiteConnection.CreateFile(DatabaseFile);
            }
            using (connection)
            {
                // Create a database command
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"CREATE TABLE IF NOT EXISTS [UniversityTable] (
                                            [UniversityID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                            [UniversityName] VARCHAR(200) NOT NULL)";
                    command.ExecuteNonQuery();

                    command.CommandText = @"CREATE TABLE IF NOT EXISTS [MajorTable] (
                                            [MajorID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                            [MajorName] VARCHAR(500) NOT NULL,
                                            [UniversityID] INTEGER REFERENCES UniversityTable)";
                    command.ExecuteNonQuery();

                    command.CommandText = @"CREATE TABLE IF NOT EXISTS [LecturerTable] (
                                            [LecturerID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                            [TitleAndName] VARCHAR(500) NOT NULL,
                                            [UniversityID] INTEGER REFERENCES UniversityTable,
                                            [MajorID] INTEGER REFERENCES MajorTable)";
                    command.ExecuteNonQuery();

                    command.CommandText = @"CREATE TABLE IF NOT EXISTS [CourseTable](
                                            [CourseID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                            [CourseName] VARCHAR(500) NOT NULL,
                                            [Semester] VARCHAR(10) NULL,
                                            [UniversityID] INTEGER REFERENCES UniversityTable,
                                            [MajorID] INTEGER REFERENCES MajorTable,
                                            [LecturerID] INTEGER REFERENCES LecturerTable)";
                    command.ExecuteNonQuery();

                    command.CommandText = @"CREATE TABLE IF NOT EXISTS [StudentTable](
                                            [StudentID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                            [UserName] VARCHAR(200) NOT NULL,
                                            [Password] VARCHAR(200) NOT NULL,
                                            [Semester] INTEGER NULL,
                                            [UniversityID] INTEGER REFERENCES UniversityTable,
                                            [MajorID] INTEGER REFERENCES MajorTable)";
                    command.ExecuteNonQuery();

                    command.CommandText = @"CREATE TABLE IF NOT EXISTS [RatingTable](
                                            [RatingID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                            [StudentID] INTEGER REFERENCES StudentTable,
                                            [CourseID] INREGER REFERENCES CourseTable,
                                            [Semester] VARCHAR(10) NULL,
                                            [OverallRating] INTEGER NOT NULL,
                                            [ContactHours] INTEGER NULL,
                                            [SelfStudyHours] INTEGER NULL,
                                            [OrganizedRating] INTEGER NOT NULL,
                                            [LearnedRating] INTEGER NOT NULL,
                                            [InterestingRating] INTEGER NOT NULL,
                                            [PresentationRating] INTEGER NOT NULL,
                                            [Comment] VARCHAR(2000) NULL,
                                            [DateTime] DATETIME NOT NULL)";
                    command.ExecuteNonQuery();

                    command.CommandText = @"INSERT INTO UniversityTable (Name) VALUES ('Vilnius University')";
                    command.ExecuteNonQuery();
                }
            }
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SQLiteConnection GetConnection()
        {
            return connection;
        }
    }
}
