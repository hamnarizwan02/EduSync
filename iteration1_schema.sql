/*
DROP TABLE IF EXISTS Bookmarks;
DROP TABLE IF EXISTS Enrollment;
DROP TABLE IF EXISTS Announcement;
DROP TABLE IF EXISTS LectureNote;
DROP TABLE IF EXISTS Quiz;
DROP TABLE IF EXISTS Assignment;
DROP TABLE IF EXISTS Courses;
DROP TABLE IF EXISTS Users;
*/

-- Users Table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
	uname VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    passwordd VARCHAR(255) NOT NULL,
    UserType VARCHAR(255) NOT NULL CHECK (UserType IN ('Instructor', 'Student', 'Administrator'))
);
select * from enrollment
select * from users

-- Insert the administrator
INSERT INTO Users (uname, Email, passwordd, UserType) VALUES 
('Kissa', 'admin@gmail.com', 'admin', 'Administrator');

-- Insert students and Instructors
INSERT INTO Users (uname, Email, passwordd, UserType) VALUES 
    ('Hamna','hamna@gmail.com', 'hamna', 'Student'),
    ('Kristy','kristy@hotmail.com', 'kissa', 'Student'),
    ('Arham','arham@yahoo.com', 'arham', 'Student'),
    ('Elijah','elijah@gmail.com', 'elijah', 'Instructor'),
    ('Sarah','sarah@outlook.com', 'sarah', 'Student'),
    ('John','john@outlook.com', 'john', 'Instructor'),
    ('Rory','rory@gmail.com', 'rory', 'Instructor'),
    ('Ted','ted@gmail.com', 'ted', 'Student'),
    ('Sam','sam@gmail.com', 'sam', 'Student');

select * from Users where UserType = 'Instructor';

-- Courses Table
CREATE TABLE Courses (
    CourseID INT PRIMARY KEY IDENTITY,
    CourseName VARCHAR(255) NOT NULL,
    InstructorID INT,
    FOREIGN KEY (InstructorID) REFERENCES Users(UserID)
);

INSERT INTO Courses (CourseName, InstructorID) VALUES
	('SE', 5),
	('Web Programming', 7),
	('AI', 8),
	('PDC', 5),
	('Web Programming', 7),
	('Numerical', 8),
	('CNet', 5),
	('DIP', 7);


-- Content Table
CREATE TABLE Assignment (
    AssignmentID INT PRIMARY KEY IDENTITY,
	CourseID INT,
	Section VARCHAR(255),
    Deadline VARCHAR(255),
	AssignmentFilePath VARCHAR(255),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);
select * from Assignment;

CREATE TABLE Quiz (
    QuizID INT PRIMARY KEY IDENTITY,
	StudentID INT,
	Section VARCHAR(255),
	CourseID INT,
	QuizFilePath VARCHAR(255),
	FOREIGN KEY (StudentID) REFERENCES Users(UserID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);
select * from Quiz

CREATE TABLE LectureNote (
    LectureNoteID INT PRIMARY KEY IDENTITY,
	Section VARCHAR(255),
	CourseID INT,
	NotesFilePath VARCHAR(255),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

select * from LectureNote

CREATE TABLE Announcement (
    AnnouncementID INT PRIMARY KEY IDENTITY,
	CourseID INT,
	Section VARCHAR(255),
	announcements VARCHAR(255),	--uploaded content
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);
select * from Announcement

-- Enrollment Table
CREATE TABLE Enrollment (
    EnrollmentID INT PRIMARY KEY IDENTITY,
	Section VARCHAR(255),
    UserID INT,
    CourseID INT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);
--multiple entries for a student according to course 
